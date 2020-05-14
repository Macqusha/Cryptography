using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        byte[][] Key = new byte[8][];
        //16*8     4 бита = 2^4 = 16 значений, строк 8, как и шагов в цикле
        int[,] S_Box = { { 12, 4, 6, 2, 10, 5, 11, 9, 14, 8, 13, 7, 0, 3, 15, 1 },
                         { 6, 8, 2, 3, 9, 10, 5, 12, 1, 14, 4, 7, 11, 13, 0, 15 },
                         { 11, 3, 5, 8, 2, 15, 10, 13, 14, 1, 7, 4, 12, 9, 6, 0 },
                         { 12, 8, 2, 1, 13, 4, 15, 6, 7, 0, 10, 5, 3, 14, 9, 11 },
                         { 7, 15, 5, 10, 8, 1, 6, 13, 0, 9, 3, 14, 11, 4, 2, 12 },
                         { 5, 13, 15, 6, 9, 2, 12, 10, 11, 7, 8, 1, 4, 3, 14, 0 },
                         { 8, 14, 2, 5, 6, 9, 1, 12, 15, 4, 11, 0, 13, 10, 3, 7 },
                         { 1, 7, 14, 13, 0, 5, 8, 3, 4, 15, 10, 6, 9, 12, 11, 2 } };
        
        private void f17_ButtonReadKeyword_Click(object sender, EventArgs e)
        {
            Key = new byte[8][];
            for (int i = 0; i < 8; i++)
            {
                Key[i] = new byte[4];
            }
            int byteNumber = 0;
            int code;
            OpenFileDialog Load = new OpenFileDialog();
            if (Load.ShowDialog() == DialogResult.OK)
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.Open(Load.FileName, System.IO.FileMode.Open), Encoding.Default);
                int i = 0, j = 0; 
                while ((code = reader.PeekChar()) > -1 && (byteNumber = i*4+j) < 32)
                {
                    Key[i][j] = reader.ReadByte();
                    j++;
                    if (j == 4) { j = 0; i++; }
                }
                reader.Close();
                if (code == -1 && byteNumber == 31)
                {
                    f17_fieldKeyword.Text = "Source: " + Load.FileName;
                }
                else
                {
                    if (code == -1) MessageBox.Show("Слишком короткий ключ в файле", "Ошибка");
                    if (byteNumber == 31) MessageBox.Show("Слишком длинный ключ в файле", "Ошибка");
                    f17_fieldKeyword.Text = null;
                    Key = new byte[0][];
                }
            }
        }
        private void f17_ButtonGenKeyword_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTimeOffset.Now.Millisecond);
            Key = new byte[8][];

            for (int i = 0; i < 8; i++)
            {
                Key[i] = new byte[4];
                rand.NextBytes(Key[i]);
            }

            string KeyText = null;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    KeyText += (char)Key[i][j];
                }
            }

            f17_fieldKeyword.Text = KeyText;
        }
        private void f17_ButtonSaveKeyword_Click(object sender, EventArgs e)
        {
            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.Open(Save.FileName, System.IO.FileMode.OpenOrCreate), Encoding.Default);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        writer.Write(Key[i][j]);
                    }
                }   
                writer.Close();
            }
        }

        private void f17_ButtonEncryptFile_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            LinkedList<byte> ResultFile = new LinkedList<byte>();

            f17_labelPB.Text = "Выбор файла...";
            f17_labelPB.Update();
            OpenFileDialog Load = new OpenFileDialog();
            if (Load.ShowDialog() == DialogResult.OK)
            {
                f17_labelPB.Text = "Считываем из файла...";
                f17_labelPB.Update();
                System.IO.FileInfo Inform = new System.IO.FileInfo(Load.FileName);
                progressBar.Maximum = Convert.ToInt32(Inform.Length / 8) + 1;
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.Open(Load.FileName, System.IO.FileMode.Open), Encoding.Default);
                f17_labelPB.Text = "Зашифровываем...";
                f17_labelPB.Update();
                byte[] SourceL = new byte[4];
                byte[] SourceR = new byte[4];
                byte[] Result = new byte[8];
                for (long block = 0; block < (Inform.Length / 8); block++) //Блоки по 64 бит
                {
                    SourceL = reader.ReadBytes(4); //4*8=32
                    SourceR = reader.ReadBytes(4);
                    Result = FeistelNetwork(SourceL, SourceR);
                    for (int i = 0; i < 8; i++)
                    {
                        ResultFile.AddLast(Result[i]);
                    }
                    progressBar.Value++;
                    if (((progressBar.Maximum > 100 && progressBar.Value % (progressBar.Maximum / 100) == 0) ||
                    (progressBar.Value == progressBar.Maximum)))  //Составляет ровно n% или 100%
                        f17_labelPB.Text = "Зашифровываем... Выполнено " + Convert.ToString(progressBar.Value) + " из " + Convert.ToString(progressBar.Maximum);
                    f17_labelPB.Update();
                }

                LinkedList<byte> Tail = new LinkedList<byte>();
                while (reader.PeekChar() > -1)
                {
                    Tail.AddLast(reader.ReadByte());
                }
                Tail.AddLast(0x80);
                while (Tail.Count != 8)
                {
                    Tail.AddLast(0x00);
                }
                for (int i = 0; i < 4; i++)
                {
                    SourceL[i] = Tail.ElementAt(i);
                }
                for (int i = 4; i < 8; i++)
                {
                    SourceR[i - 4] = Tail.ElementAt(i);
                }
                Tail.Clear();
                Result = FeistelNetwork(SourceL, SourceR);
                for (int i = 0; i < 8; i++)
                {
                    ResultFile.AddLast(Result[i]);
                }
                progressBar.Value++;
                if (((progressBar.Maximum > 100 && progressBar.Value % (progressBar.Maximum / 100) == 0) ||
                   (progressBar.Value == progressBar.Maximum)))  //Составляет ровно n% или 100%
                    f17_labelPB.Text = "Зашифровываем... Выполнено " + Convert.ToString(progressBar.Value) + " из " + Convert.ToString(progressBar.Maximum);
                f17_labelPB.Update();
                reader.Close();
            }
            else
            {
                f17_labelPB.Text = "Готов к работе";
                f17_labelPB.Update();
                return;
            }

            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.Open(Save.FileName, System.IO.FileMode.OpenOrCreate), Encoding.Default);
                f17_labelPB.Text = "Сохраняем результат в файл...";
                f17_labelPB.Update();
                foreach (var Byte in ResultFile)
                {
                    writer.Write(Byte);
                }
                writer.Close();
            }
            else
            {
                f17_labelPB.Text = "Готов к работе";
                f17_labelPB.Update();
                return;
            }
            f17_labelPB.Text = "Готово.";
            f17_labelPB.Update();
        }
        private void f17_ButtonDecryptFile_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;

            LinkedList<byte> ResultFile = new LinkedList<byte>();

            f17_labelPB.Text = "Выбор файла...";
            f17_labelPB.Update();
            OpenFileDialog Load = new OpenFileDialog();
            if (Load.ShowDialog() == DialogResult.OK)
            {
                f17_labelPB.Text = "Считываем из файла...";
                f17_labelPB.Update();
                System.IO.FileInfo Inform = new System.IO.FileInfo(Load.FileName);
                progressBar.Maximum = Convert.ToInt32(Inform.Length / 8);
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.Open(Load.FileName, System.IO.FileMode.Open), Encoding.Default);
                f17_labelPB.Text = "Расшифровываем...";
                f17_labelPB.Update();
                byte[] SourceL = new byte[4];
                byte[] SourceR = new byte[4];
                byte[] Result = new byte[8];
                for (long block = 0; block < (Inform.Length / 8); block++) //Блоки по 64 бита
                {
                    SourceL = reader.ReadBytes(4); //4*8=32
                    SourceR = reader.ReadBytes(4);
                    Result = FeistelNetwork_Reverse(SourceL, SourceR);
                    for (int i = 0; i < 8; i++)
                    {
                        ResultFile.AddLast(Result[i]);
                    }
                    progressBar.Value++;
                    if (((progressBar.Maximum > 100 && progressBar.Value % (progressBar.Maximum / 100) == 0) ||
                        (progressBar.Value == progressBar.Maximum))) //Составляет ровно n% или 100%
                        f17_labelPB.Text = "Расшифровываем... Выполнено " + Convert.ToString(progressBar.Value) + " из " + Convert.ToString(progressBar.Maximum);
                    f17_labelPB.Update();
                }
                reader.Close();
            }
            else
            {
                f17_labelPB.Text = "Готов к работе";
                f17_labelPB.Update();
                return;
            }

            for (int i = 0; i < 8; i++)
            {
                if (ResultFile.Last() == 0x80)
                {
                    ResultFile.RemoveLast();
                    break;
                }
                if (ResultFile.Last() == 0x00)
                {
                    ResultFile.RemoveLast();
                    continue;
                }
            }

            SaveFileDialog Save = new SaveFileDialog();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.Open(Save.FileName, System.IO.FileMode.OpenOrCreate), Encoding.Default);
                f17_labelPB.Text = "Сохраняем результат в файл...";
                f17_labelPB.Update();
                foreach (var Byte in ResultFile)
                {
                    writer.Write(Byte);
                }
                writer.Close();
            }
            else
            {
                f17_labelPB.Text = "Готов к работе";
                f17_labelPB.Update();
                return;
            }
            f17_labelPB.Text = "Готово.";
            f17_labelPB.Update();
        }

        private byte[] FeistelNetwork(byte[] L0, byte[] R0)
        {
            byte[] Li = new byte[4];    
            byte[] Ri = new byte[4];
            byte[] tmp;
            
            for (int iteration = 0; iteration < 24; iteration++)
            {
                tmp = f(R0, (iteration % 8));  
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L0[i] ^ tmp[i]);
                }//Ri = L0.Xor(f(ref R0, (iteration % 8)));
                R0.CopyTo(Li, 0);
                Li.CopyTo(L0, 0);
                Ri.CopyTo(R0, 0);
            }

            for (int iteration = 24; iteration < 31; iteration++)
            {
                tmp = f(R0, (31 - iteration));
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L0[i] ^ tmp[i]);
                }//Ri = L0.Xor(f(ref R0, (31 - iteration)));
                R0.CopyTo(Li, 0);
                Li.CopyTo(L0, 0);
                Ri.CopyTo(R0, 0);
            }

            R0.CopyTo(Ri, 0);
            tmp = f(R0, 0);
            for (int i = 0; i < 4; i++)
            {
                Li[i] = Convert.ToByte(L0[i] ^ tmp[i]);
            }//Li = L0.Xor(f(ref R0, 0));

            byte[] Result = new byte[8];
            for (int i = 0; i < 4; i++)
            {
                Result[i] = Li[i];
                Result[i + 4] = Ri[i];
            }
            return Result;
        }
        private byte[] FeistelNetwork_Reverse(byte[] L32, byte[] R32)
        {
            byte[] Li = new byte[4];
            byte[] Ri = new byte[4];
            byte[] tmp;

            for (int iteration = 0; iteration < 8; iteration++)
            {
                tmp = f(R32, iteration);
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L32[i] ^ tmp[i]);
                }//Ri = L32.Xor(f(ref R32, iteration));
                R32.CopyTo(Li, 0);
                Li.CopyTo(L32, 0);
                Ri.CopyTo(R32, 0);
            }

            for (int iteration = 8; iteration < 31; iteration++)
            {
                tmp = f(R32, ((31 - iteration) % 8));
                for (int i = 0; i < 4; i++)
                {
                    Ri[i] = Convert.ToByte(L32[i] ^ tmp[i]);
                }//Ri = L32.Xor(f(ref R32, ((31 - iteration) % 8)));
                R32.CopyTo(Li, 0);
                Li.CopyTo(L32, 0);
                Ri.CopyTo(R32, 0);
            }

            R32.CopyTo(Ri, 0);
            tmp = f(R32, 0);
            for (int i = 0; i < 4; i++)
            {
                Li[i] = Convert.ToByte(L32[i] ^ tmp[i]);
            }//Li = L32.Xor(f(ref R32, 0));

            byte[] Result = new byte[8];
            for (int i = 0; i < 4; i++)
            {
                Result[i] = Li[i];
                Result[i + 4] = Ri[i];
            }
            return Result;
        }
        private byte[] f(byte[] R0, int number)
        {
            //Складываем по модулю 2^32 блок и ключ
            uint A = BitConverter.ToUInt32(R0.Reverse().ToArray(), 0);
            A += BitConverter.ToUInt32(Key[number].Reverse().ToArray(), 0);
            R0 = BitConverter.GetBytes(A);
            R0 = R0.Reverse().ToArray();

            BitArray Block_Bits = new BitArray(R0);
            BitArray NewBlock_Bits = new BitArray(32);
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    NewBlock_Bits[index] = Block_Bits[i * 8 + j];
                    index++;
                }
            }
            Block_Bits.SetAll(false);

            for (int cycle = 0; cycle < 8; cycle++)
            {
                string temp = null;
                for (int i = 0; i < 4; i++)
                {
                    temp += Convert.ToInt32(NewBlock_Bits[cycle * 4 + i]);
                }
                int column = Convert_BitString_To_Bytes(temp);
                byte[] Binary_S_Box = Convert_Int_To_Bits(S_Box[cycle, column]);
                for (int i = 0; i < 4; i++)
                {
                    if (Binary_S_Box[i] == 1)
                    {
                        Block_Bits[cycle * 4 + i] = true;
                    }
                }
            }

            for (int cycle = 0; cycle < 11; cycle++)
            {
                bool temp = Block_Bits[0];
                for (int i = 0; i < 31; i++)
                {
                    Block_Bits[i] = Block_Bits[i + 1];
                }
                Block_Bits[31] = temp;
            }

            byte[] Out = Convert_BitArray_To_Bytes(Block_Bits);
            return Out;
        }

        private static int Convert_BitString_To_Bytes(string bits)
        {
            int degree = bits.Length - 1;
            int result = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '1')
                {
                    result += Convert.ToInt32(Math.Pow(2, degree));
                }
                degree--;
            }

            return result;
        }
        private static byte[] Convert_Int_To_Bits(int A)
        {
            byte[] binary = new byte[4];
            int index = 3;
            while (A > 0)
            {
                binary[index] = Convert.ToByte(A % 2);
                A /= 2;
                index--;
            }
            return binary;
        }
        private static byte[] Convert_BitArray_To_Bytes(BitArray bits)
        {
            byte[] Result = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                int degree = 7;
                int sum = 0;
                for (int j = 0; j < 8; j++)
                {
                    if (bits[i * 4 + j] == true)
                    {
                        sum += Convert.ToInt32(Math.Pow(2, degree));
                    }
                    degree--;
                }
                Result[i] = Convert.ToByte(sum);
            }
            return Result;
        }
    }
}
