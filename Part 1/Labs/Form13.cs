using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        public string alf = "abcdefghijklmnopqrstuvwxyz" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "0123456789" + " .,?!~`@#№$;%^:&*()-_+=[]{}|/<>" + "„…†‡€‰‘’“”•—" +
            "™¤¦§©Є«»¬®°±µ¶·£¥≠≤≥÷×∞αβπΩ∑←↑→↓↔↕↨∆∏√∟∩∫≡⌂⌠⌡◊♀♂♠♣♥♦♪♫ⱰⱭⱲⱳⱴꞈ¼½¾²³¿ˇ˅ˣˢΞΘΛΨλζεδγϕϞϬϼѡ⅓"; // Length = 256
        int bitsForOneSymbol = 8;
        bool isFromFileOrig = false;
        bool isFromFileCipher = false;

        private void f13_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f13_fieldCiphertext.Text = null;
        }

        private void f13_ButtonClearKeyword_Click(object sender, EventArgs e)
        {
            f13_fieldKeyword.Text = null;
        }

        private void f13_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f13_fieldOriginal.Text = null;
        }

        private void f13_fieldKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (alf.IndexOf(symb) == -1 && symb != '\b' && symb != (char)8) e.Handled = true;
        }

        private void f13_fieldOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (alf.IndexOf(symb) == -1 && symb != '\b' && symb != (char)8) e.Handled = true;
            isFromFileOrig = false;
        }

        private void f13_fieldCiphertext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (alf.IndexOf(symb) == -1 && symb != '\b' && symb != (char)8) e.Handled = true;
            isFromFileCipher = false;
        }

        private void f13_ButtonReadOriginal_Click(object sender, EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "OriginalIn.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        textFromFile = new StreamReader(myStream, Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            f13_fieldOriginal.Text = textFromFile;
            isFromFileOrig = true;
        }

        private void f13_ButtonSaveOriginal_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "OriginalOut.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f13_fieldOriginal.Text));
                    myStream.Close();
                }
            }
        }

        private void f13_ButtonReadKeyword_Click(object sender, EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "KeywordIn.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        textFromFile = new StreamReader(myStream, Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            f13_fieldKeyword.Text = textFromFile;
        }

        private void f13_ButtonSaveKeyword_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "KeywordOut.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f13_fieldKeyword.Text));
                    myStream.Close();
                }
            }
        }

        private void f13_ButtonReadCiphertext_Click(object sender, EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "CiphertextIn.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        textFromFile = new StreamReader(myStream, Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            f13_fieldCiphertext.Text = textFromFile;
            isFromFileCipher = true;
        }

        private void f13_ButtonSaveCiphertext_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "CiphertextOut.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f13_fieldCiphertext.Text));
                    myStream.Close();
                }
            }
        }

        private void f13_ButtonGenKeyword_Click(object sender, EventArgs e)
        {
            int previous = Convert.ToInt32(f13_paramX0.Value);
            int A = Convert.ToInt32(f13_paramA.Value);
            int B = Convert.ToInt32(f13_paramB.Value);

            string generated_key = "";
            int sourceLen = f13_fieldOriginal.TextLength;
            if (sourceLen < f13_fieldCiphertext.TextLength) sourceLen = f13_fieldCiphertext.TextLength;
            if (sourceLen == 0)
            {
                MessageBox.Show("Сначала введите текст", "Предупреждение");
                f13_fieldOriginal.Text = null;
                goto exitkey;
            }

            for (int i = 0; i < sourceLen; i++)
            {
                generated_key = generated_key + alf[(A * previous + B) % alf.Length];
                previous = (A * previous + B) % alf.Length;
            }
            f13_fieldKeyword.Text = generated_key;
        exitkey:;
        }

        private byte[,] TextToBits(string text)
        {
            byte[] decimal_code = new byte[text.Length];
            for (int i = 0; i < decimal_code.Length; i++)
                decimal_code[i] = (byte)alf.IndexOf(text[i]); //от буквенной строки перейдем к десятичным числам - номеру символа в алфавите
            byte[,] bin_code = new byte[text.Length, bitsForOneSymbol]; //создадим ячейки под двоичный код - по 8 бит на букву     bitsForOneSymbol = 8
            for (int i = 0; i < text.Length; i++)
            {
                double curCode = decimal_code[i];
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                    if (curCode - Math.Pow(2, j) >= 0)
                    {
                        curCode -= Math.Pow(2, j);
                        bin_code[i, j] = 1;
                    }
                    else
                    {
                        bin_code[i, j] = 0;
                    }
            }
            return bin_code;
        }

        private string BitsToText(byte[,] bytes)
        {
            byte[] decimal_code = new byte[bytes.Length / bitsForOneSymbol];
            Array.Clear(decimal_code, 0, decimal_code.Length);
            for (int i = 0; i < decimal_code.Length; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    decimal_code[i] += (byte)(bytes[i, j] * Math.Pow(2, j));
                }

            string result = "";
            for (int i = 0; i < decimal_code.Length; i++)
                result += alf[decimal_code[i]];
            return result;
        }

        private void f13_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string Source = f13_fieldOriginal.Text;
            string entered_key = f13_fieldKeyword.Text;

            //Для удаления запрещенных символов составим строку из символов текста и ключа, отсутствующих в алфавите
            //Символ для теста - ✆
            string prohibited_symbs = "";
            for (int i = Source.Length - 1; i >= 0; i--)
                if (alf.IndexOf(Source[i]) < 0)
                    prohibited_symbs += Source[i];
            for (int i = entered_key.Length - 1; i >= 0; i--)
                if (alf.IndexOf(entered_key[i]) < 0)
                    prohibited_symbs += entered_key[i];
            //Удалим все встретившиеся запрещенные символы
            for (int i = 0; i < prohibited_symbs.Length; i++)
            {
                Source = Regex.Replace(Source, Convert.ToString(prohibited_symbs[i]), "");
                entered_key = Regex.Replace(entered_key, Convert.ToString(prohibited_symbs[i]), "");
            }

            //Убедимся, что размер ключа не меньше длины исходного текста
            if (entered_key.Length < Source.Length)
            {
                MessageBox.Show("Слишком короткий ключ", "Ошибка");
                goto metka_exit;
            }

            //Отразим очищенные от запрещенных символов данные в полях 
            f13_fieldOriginal.Text = Source;
            f13_fieldKeyword.Text = entered_key;

            //Переведем данные в последовательность битов
            byte[,] mes_bin = TextToBits(Source);
            byte[,] key_bin = TextToBits(entered_key);

            //Соберем битовые строки просто посмотреть на них
            string key_bin_str = "";
            string mes_bin_str = "";
            for (int i = 0; i < key_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    key_bin_str += Convert.ToString(key_bin[i, j]);
                }
            for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    mes_bin_str += Convert.ToString(mes_bin[i, j]);
                }

            //Побитовое сложение по модулю 2 
            byte[,] result = new byte[mes_bin.Length / bitsForOneSymbol, bitsForOneSymbol];
            if (isFromFileOrig) // Блоком
            {
                int i = 0;
                for (int k = 0; k < (mes_bin.Length / bitsForOneSymbol) / 64; k++) //Каждый блок
                    for (i = k * 64; (i < mes_bin.Length / bitsForOneSymbol) && (i < (k + 1) * 64); i++) // Каждую букву в пределах блока
                        for (int j = bitsForOneSymbol - 1; j >= 0; j--) //Каждый бит
                            result[i, j] = (byte)((mes_bin[i, j] + key_bin[i, j]) % 2);

                // Если есть последний неполный блок - шифруем хвост
                for (int letter = i; letter < mes_bin.Length / bitsForOneSymbol; letter++) // Каждую букву
                    for (int j = bitsForOneSymbol - 1; j >= 0; j--) // Каждый бит
                        result[letter, j] = (byte)((mes_bin[letter, j] + key_bin[letter, j]) % 2);
            }
            else // Потоком
            {
                for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++) // Каждую букву
                    for (int j = bitsForOneSymbol - 1; j >= 0; j--) // Каждый бит
                        result[i, j] = (byte)((mes_bin[i, j] + key_bin[i, j]) % 2);
            }

            f13_fieldCiphertext.Text = BitsToText(result);
            isFromFileCipher = false;

        metka_exit:;
        }

        private void f13_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f13_fieldCiphertext.Text;
            string entered_key = f13_fieldKeyword.Text;

            //Для удаления запрещенных символов составим строку из символов текста и ключа, отсутствующих в алфавите
            //Символ для теста - ✆
            string prohibited_symbs = "";
            for (int i = Source.Length - 1; i >= 0; i--)
                if (alf.IndexOf(Source[i]) < 0)
                    prohibited_symbs += Source[i];
            for (int i = entered_key.Length - 1; i >= 0; i--)
                if (alf.IndexOf(entered_key[i]) < 0)
                    prohibited_symbs += entered_key[i];
            //Удалим все встретившиеся запрещенные символы
            for (int i = 0; i < prohibited_symbs.Length; i++)
            {
                Source = Regex.Replace(Source, Convert.ToString(prohibited_symbs[i]), "");
                entered_key = Regex.Replace(entered_key, Convert.ToString(prohibited_symbs[i]), "");
            }

            //Убедимся, что размер ключа не меньше длины исходного текста
            if (entered_key.Length < Source.Length)
            {
                MessageBox.Show("Слишком короткий ключ", "Ошибка");
                goto metka_exit;
            }

            //Отразим очищенные от запрещенных символов данные в полях 
            f13_fieldCiphertext.Text = Source;
            f13_fieldKeyword.Text = entered_key;

            //Переведем данные в последовательность битов
            byte[,] mes_bin = TextToBits(Source);
            byte[,] key_bin = TextToBits(entered_key);

            //Соберем битовые строки просто посмотреть на них
            string key_bin_str = "";
            string mes_bin_str = "";
            for (int i = 0; i < key_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    key_bin_str += Convert.ToString(key_bin[i, j]);
                }
            for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    mes_bin_str += Convert.ToString(mes_bin[i, j]);
                }

            //Побитовое сложение по модулю 2
            byte[,] result = new byte[mes_bin.Length / bitsForOneSymbol, bitsForOneSymbol];
            if (isFromFileCipher) // Блоком
            {
                int i = 0;
                for (int k = 0; k < (mes_bin.Length / bitsForOneSymbol) / 64; k++) //Каждый блок
                    for (i = k * 64; (i < mes_bin.Length / bitsForOneSymbol) && (i < (k + 1) * 64); i++) // Каждую букву в пределах блока
                        for (int j = bitsForOneSymbol - 1; j >= 0; j--) //Каждый бит
                            result[i, j] = (byte)(((mes_bin[i, j] - key_bin[i, j]) + 2) % 2);

                // Если есть последний неполный блок - шифруем хвост
                for (int letter = i; letter < mes_bin.Length / bitsForOneSymbol; letter++) // Каждую букву
                    for (int j = bitsForOneSymbol - 1; j >= 0; j--) // Каждый бит
                        result[letter, j] = (byte)(((mes_bin[letter, j] - key_bin[letter, j]) + 2) % 2);
            }
            else // Потоком
            {
                for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++) // Каждую букву
                    for (int j = bitsForOneSymbol - 1; j >= 0; j--) // Каждый бит
                        result[i, j] = (byte)(((mes_bin[i, j] - key_bin[i, j]) + 2) % 2);
            }


            f13_fieldOriginal.Text = BitsToText(result);

        metka_exit:;
        }
    }
}
