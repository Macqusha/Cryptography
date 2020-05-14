using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form08 : Form
    {
        public Form08()
        {
            InitializeComponent();
            f8_fieldKey.Text = "2019"; //Пример ключа для пользователей, не желающих придумывать свой
            f8_fieldKey.ForeColor = Color.Gray;
        }

        private void f8_fieldKey_Enter(object sender, EventArgs e)
        {
            //f8_fieldKey.Text = null;
            f8_fieldKey.ForeColor = Color.Black;
        }

        private void f8_ButtonClearKey_Click(object sender, EventArgs e)
        {
            f8_fieldKey.Text = null;
        }

        private void f8_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f8_fieldCiphertext.Text = null;
        }

        private void f8_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f8_fieldOriginal.Text = null;
        }

        private void f8_fieldKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string ALF = "0123456789"; //Допустимые символы в ключе
            if (ALF.IndexOf(number) == -1 && number != (char)8) e.Handled = true;
        }

        string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string ALF_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alf_en = "abcdefghijklmnopqrstuvwxyz";

        private void f8_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string Source = f8_fieldOriginal.Text.Replace("\r\n", "\r");
            char[] message = Source.ToCharArray();
            var entered_key = Regex.Replace(f8_fieldKey.Text, "[^0-9]", "");
            f8_fieldKey.Text = entered_key;
            if (entered_key.Length == 0)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }

            int keyPos = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (ALF_RU.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_RU[(ALF_RU.IndexOf(message[i]) + (entered_key[keyPos] - '0')) % ALF_RU.Length];
                    keyPos++;
                }
                if (alf_ru.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_ru[(alf_ru.IndexOf(message[i]) + (entered_key[keyPos] - '0')) % alf_ru.Length];
                    keyPos++;
                }
                if (ALF_EN.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_EN[(ALF_EN.IndexOf(message[i]) + (entered_key[keyPos] - '0')) % ALF_EN.Length];
                    keyPos++;
                }
                if (alf_en.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_en[(alf_en.IndexOf(message[i]) + (entered_key[keyPos] - '0')) % alf_en.Length];
                    keyPos++;
                }
                if (keyPos == entered_key.Length) keyPos = 0;
            }
            string result = new string(message);
            f8_fieldCiphertext.Text = result.Replace("\r", "\r\n"); ;
        metka_exit:;
        }

        private void f8_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f8_fieldCiphertext.Text.Replace("\r\n", "\r");
            char[] message = Source.ToCharArray();
            var entered_key = Regex.Replace(f8_fieldKey.Text, "[^0-9]", "");
            f8_fieldKey.Text = entered_key;
            if (entered_key.Length < 1)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }

            int keyPos = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (ALF_RU.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_RU[(ALF_RU.IndexOf(message[i]) - (int)(entered_key[keyPos] - '0') + ALF_RU.Length) % ALF_RU.Length];
                    keyPos++;
                }
                if (alf_ru.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_ru[(alf_ru.IndexOf(message[i]) - (int)(entered_key[keyPos] - '0') + alf_ru.Length) % alf_ru.Length];
                    keyPos++;
                }
                if (ALF_EN.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_EN[(ALF_EN.IndexOf(message[i]) - (int)(entered_key[keyPos] - '0') + ALF_EN.Length) % ALF_EN.Length];
                    keyPos++;
                }
                if (alf_en.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_en[(alf_en.IndexOf(message[i]) - (int)(entered_key[keyPos] - '0') + alf_en.Length) % alf_en.Length];
                    keyPos++;
                }
                if (keyPos == entered_key.Length) keyPos = 0;
            }
            string result = new string(message);
            f8_fieldOriginal.Text = result.Replace("\r", "\r\n"); ;
        metka_exit:;
        }
    }
}
