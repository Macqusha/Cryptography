using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Labs
{
    public partial class Form06 : Form
    {
        public Form06()
        {
            InitializeComponent();
        }

        private void f6_buttonCountHashFromTextbox_Click(object sender, EventArgs e)
        {
            byte[] tb = Encoding.Default.GetBytes(f6_textBox_original.Text);

            f6_TextBox_Hash.Text = GetHashMD5(tb);


        }

        private void f6_buttonCountHashFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.InitialDirectory = "D:\\Учеба\\Крипта 2\\Labs\\Labs\\bin\\Debug\\TextFiles";
            Load.DefaultExt = "txt";
            Load.FileName = "in.txt";
            Load.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Load.FilterIndex = 2;
            Load.RestoreDirectory = true;
            Load.Multiselect = false;
            string sFileName;
            if (Load.ShowDialog() == DialogResult.OK)
            {
                sFileName = Load.FileName;
                byte[] file = File.ReadAllBytes(Load.FileName);

                f6_TextBox_Hash.Text = GetHashMD5(file);
            }
        }

        private string GetHashMD5(byte[] arr)
        {
            //Step 1
            int bytesToAddAmount = (arr.Length + 1) % 64 > 56 ? (arr.Length + 1) % 64 - 56 : -(arr.Length + 1) % 64 + 56;            

            byte[] arrEx = new byte[arr.Length + bytesToAddAmount + 1];
            arr.CopyTo(arrEx, 0);
            arrEx[arr.Length] = 0x80;                                       //Добавляем единицу

            //Step 2
            byte[] arrExtended = new byte[arrEx.Length + 8];                //Добавляем слоты для длины файла
            arrEx.CopyTo(arrExtended, 0);
            byte [] len = BitConverter.GetBytes(arr.Length * 8);
            len.CopyTo(arrExtended, arrEx.Length);

            //Step 3
            uint[] buf = new uint[4];
            buf[0] = 0x67452301;
            buf[1] = 0xEFCDAB89;
            buf[2] = 0x98BADCFE;
            buf[3] = 0x10325476;
            
            //Step 4
            //Функции funF, funG, funH, funI определены
            uint[] T = new uint[64];
            for (int i = 1; i <= 64; i++)
            {
                T[i - 1] = (uint)(0x100000000 * Math.Abs(Math.Sin(i))); 
            }

            int[] shiftValues = { 7, 12, 17, 22, 5, 9, 14, 20, 4, 11, 16, 23, 6, 10, 15, 21 }; //константы для сдвигов
            for (int circle = 0; circle < arrExtended.Length / 64; circle++)
            {
                //HMD5
                
                uint[] tmp = new uint[4];
                buf.CopyTo(tmp, 0);

                byte[] piece = new byte[64];
                Array.Copy(arrExtended, 64 * circle, piece, 0, 64);

                for (int i = 0; i < 16; i++)
                {
                    var ff = piece.Skip(4 * i).Take(4).ToArray();
                    tmp[0] += funF(tmp[1], tmp[2], tmp[3]) + T[i] + BitConverter.ToUInt32(piece.Skip(4 * i).Take(4).ToArray(), 0);
                    tmp[0] = BitShift(tmp[0], shiftValues[i % 4]);
                    tmp[0] += tmp[1];
                    tmp = Shift(tmp);
                }
                for (int i = 0; i < 16; i++)
                {
                    int g = (5 * i + 1) % 16;
                    tmp[0] += funG(tmp[1], tmp[2], tmp[3]) + T[16 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                    tmp[0] = BitShift(tmp[0], shiftValues[4 + (i % 4)]);
                    tmp[0] += tmp[1];
                    tmp = Shift(tmp);
                }
                for (int i = 0; i < 16; i++)
                {
                    int g = (3 * i + 5) % 16;
                    tmp[0] += funH(tmp[1], tmp[2], tmp[3]) + T[32 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                    tmp[0] = BitShift(tmp[0], shiftValues[8 + (i % 4)]);
                    tmp[0] += tmp[1];
                    tmp = Shift(tmp);
                }
                for (int i = 0; i < 16; i++)
                {
                    int g = (7 * i) % 16;
                    tmp[0] += funI(tmp[1], tmp[2], tmp[3]) + T[48 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                    tmp[0] = BitShift(tmp[0], shiftValues[12 + (i % 4)]);
                    tmp[0] += tmp[1];
                    tmp = Shift(tmp);
                }
                buf[0] += tmp[0];
                buf[1] += tmp[1];
                buf[2] += tmp[2];
                buf[3] += tmp[3];
            }

            //Step 5
            return OutHash(buf[0]) + OutHash(buf[1]) + OutHash(buf[2]) + OutHash(buf[3]);
        }

        private uint funF(uint x, uint y, uint z)
        {
            return (x & y) | (~x & z);
        }
        private uint funG(uint x, uint y, uint z)
        {
            return (x & z) | (~z & y);
        }
        private uint funH(uint x, uint y, uint z)
        {
            return x ^ y ^ z;
        }
        private uint funI(uint x, uint y, uint z)
        {
            return y ^ (~z | x);
        }

        private uint[] Shift(uint[] arr)
        {
            var tmp = arr[0];
            arr[0] = arr[3];
            arr[3] = arr[2];
            arr[2] = arr[1];
            arr[1] = tmp;
            return arr;
        }

        private uint BitShift(uint numb, int pos)
        {
            uint hi = (uint)(numb >> (32 - pos));
            return (numb << pos) | hi;
        }

        private string OutHash(uint reg)
        {
            var bytes = BitConverter.GetBytes(reg);

            var tmp = reg.ToString("x");
            if (tmp.Length != 8)
            {
                var k = 8 - tmp.Length;
                for (int i = 0; i < k; i++)
                {
                    tmp = "0" + tmp;
                }
            }

            return new string(new char[] { tmp[6], tmp[7], tmp[4], tmp[5], tmp[2], tmp[3], tmp[0], tmp[1] });
        }
    }
}
