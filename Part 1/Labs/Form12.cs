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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        public string alf = "abcdefghijklmnopqrstuvwxyz" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
            "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" + "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +
            "0123456789" + " .,?!~`@#№$;%^:&*()-_+=[]{}|/<>" + "„…†‡€‰‘’“”•—" +
            "™¤¦§©Є«»¬®°±µ¶·£¥≠≤≥÷×∞αβπΩ∑←↑→↓↔↕↨∆∏√∟∩∫≡⌂⌠⌡◊♀♂♠♣♥♦♪♫ⱰⱭⱲⱳⱴꞈ¼½¾²³¿ˇ˅ˣˢΞΘΛΨλζεδγϕϞϬϼѡ⅓";
        int bitsForOneSymbol = 8;

        private void f12_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f12_fieldCiphertext.Text = null;
        }

        private void f12_ButtonClearKeyword_Click(object sender, EventArgs e)
        {
            f12_fieldKeyword.Text = null;
        }

        private void f12_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f12_fieldOriginal.Text = null;
        }

        private void f12_ButtonGenKeyword_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(f12_ButtonGenKeyword, "Для введенного исходного текста");
        }

        private void f12_fieldKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (alf.IndexOf(symb) == -1 && symb != '\b' && symb != (char)8) e.Handled = true;
        }

        private void f12_Messages_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (alf.IndexOf(symb) == -1 && symb != '\b' && symb != (char)8) e.Handled = true;
        }

        private void f12_ButtonGenKeyword_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string generated_key = "";
            for (int i = 0; i < f12_fieldOriginal.TextLength; i++)
                generated_key = generated_key + alf[rnd.Next(alf.Length)];
            f12_fieldKeyword.Text = generated_key;
            if (f12_fieldOriginal.TextLength == 0)
            {
                MessageBox.Show("Сначала введите исходный текст", "Предупреждение");
                f12_fieldOriginal.Text = null;
            }
        }

        private void f12_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string Source = f12_fieldOriginal.Text;
            string entered_key = f12_fieldKeyword.Text;

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
                Source = Regex.Replace(Source,Convert.ToString(prohibited_symbs[i]),"");
                entered_key = Regex.Replace(entered_key, Convert.ToString(prohibited_symbs[i]), "");
            }

            //Убедимся, что размер ключа не меньше длины исходного текста
            if (entered_key.Length < Source.Length)
            {
                MessageBox.Show("Слишком короткий ключ", "Ошибка");
                goto metka_exit;
            }

            //Отразим очищенные от запрещенных символов данные в полях 
            f12_fieldOriginal.Text = Source;
            f12_fieldKeyword.Text = entered_key;

            //Переведем данные в последовательность битов
            byte[,] mes_bin = TextToBits(Source);
            byte[,] key_bin = TextToBits(entered_key);
            
            //Соберем битовые строки просто посмотреть на них
            string key_bin_str = "";
            string mes_bin_str = "";
            for (int i = 0; i < key_bin.Length/bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    key_bin_str += Convert.ToString(key_bin[i,j]);
                }
            for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    mes_bin_str += Convert.ToString(mes_bin[i, j]);
                }
 
            //Побитовое сложение по модулю 2
            byte[,] result = new byte[mes_bin.Length / bitsForOneSymbol, bitsForOneSymbol];
            for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                    result[i, j] = (byte)((mes_bin[i, j] + key_bin[i, j]) % 2);

            f12_fieldCiphertext.Text = BitsToText(result); 

        metka_exit:;
        }

        private void f12_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f12_fieldCiphertext.Text;
            string entered_key = f12_fieldKeyword.Text;

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
            f12_fieldCiphertext.Text = Source;
            f12_fieldKeyword.Text = entered_key;

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
            for (int i = 0; i < mes_bin.Length / bitsForOneSymbol; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                    result[i, j] = (byte)(((mes_bin[i, j] - key_bin[i, j]) + 2) % 2);

            f12_fieldOriginal.Text = BitsToText(result);

        metka_exit:;
        }

        private byte [,] TextToBits (string text)
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
                        bin_code[i,j] = 1;
                    }
                    else
                    {
                        bin_code[i, j] = 0;
                    }
            }
            return bin_code;
        }

        private string BitsToText (byte[,] bytes)
        {
            byte [] decimal_code = new byte [bytes.Length / bitsForOneSymbol];
            Array.Clear(decimal_code, 0, decimal_code.Length);
            for (int i = 0; i < decimal_code.Length; i++)
                for (int j = bitsForOneSymbol - 1; j >= 0; j--)
                {
                    decimal_code[i] += (byte)(bytes[i,j] * Math.Pow(2, j));
                }

            string result = "";
            for (int i = 0; i < decimal_code.Length; i++)
                result += alf[decimal_code[i]];
            return result;
        }
    }
}
