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

namespace Labs
{
    public partial class Form03 : Form
    {
        public Form03()
        {
            InitializeComponent();
            f3_fieldRotate.Text = "3"; //Пример ключа для пользователей, не желающих придумывать свой
            f3_fieldRotate.ForeColor = Color.Gray;
        }

        private void f3_fieldRotate_Enter(object sender, EventArgs e)
        {
            f3_fieldRotate.Text = null;
            f3_fieldRotate.ForeColor = Color.Black;
        }

        private void f3_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f3_fieldOriginal.Text = null;
        }

        private void f3_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f3_fieldCiphertext.Text = null;
        }

        private void f3_fieldRotate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != (char)8)
            {
                e.Handled = true;
            }
        }

        private void f3_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            int rot, tmpout;
            if (f3_fieldRotate.TextLength <1 || !int.TryParse(f3_fieldRotate.Text, out tmpout) || (rot = Convert.ToInt16(f3_fieldRotate.Text)) < 0)
            {
                MessageBox.Show("Поле \"сдвиг\" должно содержать целое неотрицательное число.");
            }
            else
            {
                string Source = f3_fieldOriginal.Text;
                char[] Code = Source.ToCharArray();

                for (int i = 0; i < Code.Length; i++)
                {
                    int tmp = Convert.ToInt16(Code[i]); //Код текущего символа
                    if ((tmp >= 65 && tmp <= 90) || (tmp >= 97 && tmp <= 122))//Английские заглавные и строчные
                    {
                        int rot_en = rot % 26;
                        tmp = tmp + rot_en;
                        if (tmp > 122 || (tmp>90 && (tmp-rot_en< 91))) tmp = tmp - 26;

                        Code[i] = Convert.ToChar(tmp);
                    }
                    else if ((tmp >= 1040 && tmp <= 1071) || tmp == 1025)//Русские заглавные
                    {
                        string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (ALF.IndexOf(tmp2) + rot) % 33;
                        tmp2 = ALF[tmp];
                        Code[i] = tmp2;
                    }
                    else if ((tmp >= 1072 && tmp <= 1103) || tmp == 1105)//Русские строчные
                    {
                        string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (alf.IndexOf(tmp2) + rot) % 33;
                        tmp2 = alf[tmp];
                        Code[i] = tmp2;
                    }
                }
                string txt = new string(Code);
                f3_fieldCiphertext.Text = txt;
            }
        }

        private void f3_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            int rot, tmpout;
            if (f3_fieldRotate.TextLength < 1 || !int.TryParse(f3_fieldRotate.Text, out tmpout) || (rot = Convert.ToInt16(f3_fieldRotate.Text)) < 0)
            {
                MessageBox.Show("Поле \"сдвиг\" должно содержать целое неотрицательное число.");
            }
            else
            {
                string Source = f3_fieldCiphertext.Text;
                char[] Code = Source.ToCharArray();
                int rotRU = (33 - rot) % 33;
                int rotEN = (26 - (rot % 26)) % 26;

                for (int i = 0; i < Code.Length; i++)
                {
                    int tmp = Convert.ToInt16(Code[i]); // Код текущего символа 
                    if ((tmp >= 65 && tmp <= 90) || (tmp >= 97 && tmp <= 122)) //Английские заглавные и строчные
                    {
                        tmp = tmp + rotEN;
                        if (tmp > 122 || (tmp > 90 && (tmp - rotEN < 91))) tmp = tmp - 26;

                        Code[i] = Convert.ToChar(tmp);
                    }
                    else if ((tmp >= 1040 && tmp <= 1071) || tmp == 1025) //Русские заглавные 
                    {
                        string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (ALF.IndexOf(tmp2) + rotRU) % 33;
                        tmp2 = ALF[tmp];
                        Code[i] = tmp2;
                    }
                    else if ((tmp >= 1072 && tmp <= 1103) || tmp == 1105) //Русские строчные
                    {
                        string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (alf.IndexOf(tmp2) + rotRU) % 33;
                        tmp2 = alf[tmp];
                        Code[i] = tmp2;
                    }
                }
                string txt = new string(Code);
                f3_fieldOriginal.Text = txt;
            }
        }

        private void f14_ButtonReadCiphertext_Click(object sender, EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "3_cezar_in.txt";
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
            f3_fieldOriginal.Text = textFromFile;
        }

        private void f14_ButtonSaveOriginal_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "3_cezar_out.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f3_fieldCiphertext.Text));
                    myStream.Close();
                }
            }
        }
    }
}
