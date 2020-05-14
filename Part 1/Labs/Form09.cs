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
    public partial class Form09 : Form
    {
        public Form09()
        {
            InitializeComponent();
            f9_fieldKeyword.Text = "example"; //Пример ключа для пользователей, не желающих придумывать свой
            f9_fieldKeyword.ForeColor = Color.Gray;
        }
        
        string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string ALF_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string alf_en = "abcdefghijklmnopqrstuvwxyz";

        private void f9_fieldKeyword_Enter(object sender, EventArgs e)
        {
            //f9_fieldKeyword.Text = null;
            f9_fieldKeyword.ForeColor = Color.Black;
        }

        private void f9_ButtonClearKeyword_Click(object sender, EventArgs e)
        {
            f9_fieldKeyword.Text = null;
        }

        private void f9_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f9_fieldOriginal.Text = null;
        }

        private void f9_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f9_fieldCiphertext.Text = null;
        }

        private void f9_fieldKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(char.IsLetter(number)) && number != (char)8) e.Handled = true;
        }

        private int Keyword_symb_to_Int_Rotate(char symb)
        {
            int num = -1;
            bool rus = false;
            if (alf_ru.IndexOf(symb) > num) { num = alf_ru.IndexOf(symb); rus = true; }
            if (ALF_RU.IndexOf(symb) > num) { num = ALF_RU.IndexOf(symb); rus = true; }
            if (alf_en.IndexOf(symb) > num) num = alf_en.IndexOf(symb);
            if (ALF_EN.IndexOf(symb) > num) num = ALF_EN.IndexOf(symb);

            if (rus)
                num = num % 33;
            else if (num != -1)
                num = num % 26;
            return num;
        }
        
        private void f9_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string Source = f9_fieldOriginal.Text.Replace("\r\n", "\r");
            char[] message = Source.ToCharArray();
            var entered_key = Regex.Replace(f9_fieldKeyword.Text, "[^a-zA-Zа-яА-ЯёЁ]", "");
            f9_fieldKeyword.Text = entered_key;
            if (entered_key.Length == 0)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }
            
            int keyPos = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int one_time_shift = Keyword_symb_to_Int_Rotate(entered_key[keyPos]); //Сдвиг для текущей буквы
                if (ALF_RU.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_RU[(ALF_RU.IndexOf(message[i]) + one_time_shift) % ALF_RU.Length];
                    keyPos++;
                }
                if (alf_ru.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_ru[(alf_ru.IndexOf(message[i]) + one_time_shift) % alf_ru.Length];
                    keyPos++;
                }
                if (ALF_EN.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_EN[(ALF_EN.IndexOf(message[i]) + one_time_shift) % ALF_EN.Length];
                    keyPos++;
                }
                if (alf_en.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_en[(alf_en.IndexOf(message[i]) + one_time_shift) % alf_en.Length];
                    keyPos++;
                }
                if (keyPos == entered_key.Length) keyPos = 0;
            }
            string result = new string(message);
            f9_fieldCiphertext.Text = result.Replace("\r", "\r\n"); ; ;
        metka_exit:;
        }

        private void f9_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f9_fieldCiphertext.Text.Replace("\r\n", "\r");
            char[] message = Source.ToCharArray();
            var entered_key = Regex.Replace(f9_fieldKeyword.Text, "[^a-zA-Zа-яА-ЯёЁ]", "");
            f9_fieldKeyword.Text = entered_key;
            if (entered_key.Length == 0)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }

            int keyPos = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int one_time_shift = Keyword_symb_to_Int_Rotate(entered_key[keyPos]); //Сдвиг для текущей буквы
                if (ALF_RU.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_RU[(ALF_RU.IndexOf(message[i]) - one_time_shift + ALF_RU.Length) % ALF_RU.Length];
                    keyPos++;
                }
                if (alf_ru.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_ru[(alf_ru.IndexOf(message[i]) - one_time_shift + alf_ru.Length) % alf_ru.Length];
                    keyPos++;
                }
                if (ALF_EN.IndexOf(message[i]) >= 0)
                {
                    message[i] = ALF_EN[(ALF_EN.IndexOf(message[i]) - one_time_shift + 2*ALF_EN.Length) % ALF_EN.Length];
                    keyPos++;
                }
                if (alf_en.IndexOf(message[i]) >= 0)
                {
                    message[i] = alf_en[(alf_en.IndexOf(message[i]) - one_time_shift + 2*alf_en.Length) % alf_en.Length];
                    keyPos++;
                }
                if (keyPos == entered_key.Length) keyPos = 0;
            }
            string result = new string(message);
            f9_fieldOriginal.Text = result.Replace("\r", "\r\n"); ; ;
        metka_exit:;
        }
    }
}
