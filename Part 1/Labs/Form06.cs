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
    public partial class Form06 : Form
    {
        public Form06()
        {
            InitializeComponent();
            f6_fieldKey.Text = "(2,1,3)(5,1,3,2,4)(9,1,8,2,7,3,6,4,5)(1,3,2)(2,1,3,4,5)(3,2,1)(4,1,3,2)(3,1,4,2)";//Пример ключа для пользователей, не желающих придумывать свой
            f6_fieldKey.ForeColor = Color.Gray;
        }

        private void f6_fieldKey_Enter(object sender, EventArgs e)
        {
            //f6_fieldKey.Text = null;
            f6_fieldKey.ForeColor = Color.Black;
        }

        private void f6_ButtonClearKey_Click(object sender, EventArgs e)
        {
            f6_fieldKey.Text = null;
        }

        private void f6_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f6_fieldOriginal.Text = null;
        }

        private void f6_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f6_fieldCiphertext.Text = null;
        }

        private void f6_ButtonExampleKey_Click(object sender, EventArgs e)
        {
            f6_fieldKey.Text = "(2,1,3)(5,1,3,2,4)(9,1,8,2,7,3,6,4,5)(1,3,2)(2,1,3,4,5)(3,2,1)(4,1,3,2)(3,1,4,2)";//Пример ключа для пользователей, не желающих придумывать свой
            f6_fieldKey.ForeColor = Color.Gray;
        }
        
        private void f6_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            var Source = f6_fieldOriginal.Text.Replace("\r\n","\r");
            if (Check_key_func(f6_fieldKey.Text) == -1)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }
            string result = "";
            var swaps = (f6_fieldKey.Text).Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int curPos = 0;
            int brackets = 0; //Номер скобок в ключе
            while (curPos < Source.Length)
            {
                var local_swaps = swaps[brackets].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); 
                if (curPos + local_swaps.Length > Source.Length)
                {
                    var tail = Source.Skip(curPos).Take(Source.Length - curPos).ToArray();
                    result += new string (tail);
                    break;
                }
                var text = Source.Skip(curPos).Take(local_swaps.Length).ToArray();
                char[] Encrypted = new char[text.Length];
                for (int i = 0; i < local_swaps.Length; i++)
                    Encrypted[Convert.ToInt32(local_swaps[i]) - 1] = text[i];
                result += new string(Encrypted); 
                curPos += local_swaps.Length;
                if (++brackets == swaps.Length)  //brackets = 0;
                {
                    var tail = Source.Skip(curPos).Take(Source.Length - curPos).ToArray();
                    result += new string(tail);
                    break;
                }
            }
            f6_fieldCiphertext.Text = result.Replace("\r", "\r\n");
        metka_exit:;
        }

        private void f6_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            var Source = f6_fieldCiphertext.Text.Replace("\r\n", "\r");
            if (Check_key_func(f6_fieldKey.Text) == -1)
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка");
                goto metka_exit;
            }
            string result = "";
            var swaps = (f6_fieldKey.Text).Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int curPos = 0;
            int brackets = 0; //Номер скобок в ключе
            while (curPos < Source.Length)
            {
                var local_swaps = swaps[brackets].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries); 
                if (curPos + local_swaps.Length > Source.Length)
                {
                    var tail = Source.Skip(curPos).Take(Source.Length - curPos).ToArray();
                    result += new string(tail);
                    break;
                }
                var text = Source.Skip(curPos).Take(local_swaps.Length).ToArray();
                char[] Encrypted = new char[text.Length];
                for (int i = 0; i < local_swaps.Length; i++)
                    Encrypted[i] = text[Convert.ToInt32(local_swaps[i]) - 1];
                result += new string(Encrypted);
                curPos += local_swaps.Length;
                if (++brackets == swaps.Length)  //brackets = 0;
                {
                    var tail = Source.Skip(curPos).Take(Source.Length - curPos).ToArray();
                    result += new string(tail);
                    break;
                }
            }
            f6_fieldOriginal.Text = result.Replace("\r", "\r\n");
        metka_exit:;
        }

        private int Check_key_func(string entered_key)
        { 
            string alf = "0123456789(),"; //Допустимые символы в ключе
            if (entered_key[0] != '(') return -1;
            int opened_breaks = 1;
            for (int i = 1; i < entered_key.Length; i++)
            {
                if (alf.IndexOf(entered_key[i]) == -1) return -1;
                if (entered_key[i] == ')') opened_breaks--;
                if (entered_key[i] == '(') opened_breaks++;
                if (opened_breaks>1 || opened_breaks<0) return -1;
            }
            if (opened_breaks > 0) return -1;
            
            var swaps = (entered_key).Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < swaps.Length; i++)
            {
                var local_swaps = (swaps[i]).Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
                int[] times = new int[local_swaps.Length + 1];//Подсчет вхождений каждой цифры в каждой отдельной перестановке ключа
                Array.Clear(times, 0, local_swaps.Length + 1);
                for (int j = 0; j < local_swaps.Length; j++)
                {
                    if ((Convert.ToInt32(local_swaps[j]) > local_swaps.Length)) return -1;
                    times[Convert.ToInt32(local_swaps[j])]++;
                }
                if (times[0] != 0) return -1;
                for (int j = 1; j <= local_swaps.Length; j++)
                    if (times[j] != 1) return -1;
            }
            
            return 0;
        }

        private void f6_fieldKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string ALF = "1234567890(),"; //Допустимые символы в ключе
            if (ALF.IndexOf(number) == -1 && number != (char)8) e.Handled = true;
        }
    }
}