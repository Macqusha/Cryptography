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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
            f15_comboBoxMethods.SelectedIndex = 0;
        }

        public string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string alf_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public string alf_en = "abcdefghijklmnopqrstuvwxyz";
        public string alf_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public double[] freqs_ru = { 0.062,0.014,0.038,0.013,0.025,0.072,0.0001,0.007,0.016,0.062,0.01,0.028,0.035,0.026,0.053,
            0.09,0.023,0.04,0.045,0.053,0.021,0.002,0.009,0.004,0.012,0.006,0.003,0.0004,0.016,0.014,0.003,0.006,0.018};
        public double[] freqs_en = {0.081,0.016,0.032,0.036,0.123,0.023,0.016,0.051,0.071,0.001,0.005,0.04,0.022,0.072,
            0.079,0.023,0.002,0.06,0.066,0.096,0.031,0.009,0.02,0.002,0.019,0.001};
        
        public string alf = "", ALF = "";

        private void f15_ButtonReadCiphertext_Click(object sender, EventArgs e)
        {
            f15_fieldOriginal.Text = null;
            f15_foundedKey.Text = null;
            f15_fieldKey.Text = null;
            f15_keyLengthUpDown.Value = 0;

            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "15_rus.txt";
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
            
            //Подсчитаем количество русских и английских букв, количество их вхождений
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < textFromFile.Length; i++)
            {
                if (alf_ru.IndexOf(textFromFile[i]) >= 0)
                {
                    amount_ru++;
                }
                if (alf_en.IndexOf(textFromFile[i]) >= 0)
                {
                    amount_en++;
                }
            }
            if (amount_ru > 0) { alf = alf_ru; ALF = alf_RU; }
            if (amount_en > 0) { alf = alf_en; ALF = alf_EN; }
            f15_alf.Text = alf;
            f15_alfExtended.Text = "";
            f15_fieldCiphertext.Text = textFromFile;
            if (amount_en * amount_ru > 0)
            {
                f15_fieldCiphertext.Text = null;
                MessageBox.Show("Пожалуйста, используйте только один язык.", "Ошибка");
            }
        }

        private void f15_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f15_fieldCiphertext.Text = null;
        }

        private void f15_ButtonSaveOriginal_Click(object sender, EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "15_out.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f15_fieldOriginal.Text));
                    myStream.Close();
                }
            }
        }

        private void f15_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f15_fieldOriginal.Text = null;
        }

        private void f15_fieldKey_TextChanged(object sender, EventArgs e)
        {
            if (f15_fieldKey.TextLength > 0)
            {
                string res = "";
                int j = 0;
                for (int i = 0; i < f15_fieldCiphertext.TextLength; i++)
                {
                    int curSymbNum = alf.IndexOf(f15_fieldCiphertext.Text[i]);
                    int rotSymbNum = alf.IndexOf(f15_fieldKey.Text[j]);
                    if (curSymbNum != -1)
                    {//строчная буква
                        res += alf[((curSymbNum - rotSymbNum) + alf.Length) % alf.Length];
                        j++;
                        j = j % f15_fieldKey.TextLength;
                    }
                    else
                    {
                        curSymbNum = ALF.IndexOf(f15_fieldCiphertext.Text[i]);
                        if (curSymbNum != -1)//заглавная буква
                        {
                           res += ALF[((curSymbNum - rotSymbNum) + ALF.Length) % ALF.Length];
                            j++;
                            j = j % f15_fieldKey.TextLength;
                        }
                        else
                        {
                            //Символы, которых нет в алфавите, просто переносятся \
                            //и не меняют позицию в ключе
                            res += f15_fieldCiphertext.Text[i];
                            /*j++;
                            j = j % f15_fieldKey.TextLength; */
                        }                            
                    }                        
                }
                f15_fieldOriginal.Text = res;
            }
            else f15_fieldOriginal.Text = null;
        }

        private void f15_fieldOriginal_TextChanged(object sender, EventArgs e)
        {
            f15_Table_Chart_func();
        }

        private void f15_fieldCiphertext_TextChanged(object sender, EventArgs e)
        {
            f15_fieldOriginal.Text = null;
            f15_foundedKey.Text = null;
            f15_keyLengthUpDown.Value = 0;

            //Подсчитаем количество русских и английских букв, количество их вхождений
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < f15_fieldCiphertext.TextLength; i++)
            {
                if (alf_ru.IndexOf(f15_fieldCiphertext.Text[i]) >= 0 || alf_RU.IndexOf(f15_fieldCiphertext.Text[i]) >= 0)
                {
                    amount_ru++;
                }
                if (alf_en.IndexOf(f15_fieldCiphertext.Text[i]) >= 0 || alf_EN.IndexOf(f15_fieldCiphertext.Text[i]) >= 0)
                {
                    amount_en++;
                }
            }
            if (amount_ru > 0) { alf = alf_ru; ALF = alf_RU; }
            if (amount_en > 0) { alf = alf_en; ALF = alf_EN; }
            f15_alf.Text = alf;
            f15_alfExtended.Text = "";
            if (amount_en * amount_ru > 0)
            {
                f15_fieldCiphertext.Text = null;
                MessageBox.Show("Пожалуйста, используйте только один язык.", "Ошибка");
            }
            
            string tmp = f15_fieldKey.Text;
            f15_fieldKey.Text = null;
            f15_fieldKey.Text = tmp;
        }

        private void f15_fieldKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (f15_fieldCiphertext.TextLength > 0 && 
                (alf.IndexOf(symb) == -1 && ALF.IndexOf(symb) == -1 && symb != (char)8)) e.Handled = true;
        }
        
        private void f15_buttonFindKeyLength_Click(object sender, EventArgs e)
        {
            f15_keyLengthUpDown.Value = 0;  //Сброс предыдущего результата
            if (f15_comboBoxMethods.Text == "Метод индекса совпадений" && f15_fieldCiphertext.TextLength > 0)
            {
                int possibleLength = 1;
                while (possibleLength  < 50)
                {
                    string Source = (f15_fieldCiphertext.Text).ToLower();
                    string everyXsymb = ""; // Формируем строку БЕЗ УЧЕТА РАЗДЕЛИТЕЛЕЙ из каждого х-того символа, где х = possibleLength
                    int j = 0;
                    for (int i = 0; i < Source.Length; i++)
                    {
                        if (j % possibleLength == 0 && (alf.IndexOf(Source[i]) != -1 || ALF.IndexOf(Source[i]) != -1)) //буква, нужная по номеру
                        {
                            everyXsymb += Source[i];
                            j++;
                        }
                        else if (j % possibleLength != 0 && (alf.IndexOf(Source[i]) != -1 || ALF.IndexOf(Source[i]) != -1)) //буква, не нужная по номеру 
                        {
                            j++;
                        }        
                    }

                    //Подсчитаем индекс 
                    double index = 0;
                    int[] times = new int[alf.Length];    
                    Array.Clear(times, 0, alf.Length);
                    //Вычислим количество вхождений каждой буквы
                    int amount = 0;
                    for (int i = 0; i < everyXsymb.Length; i++)
                    {
                        if (alf.IndexOf(everyXsymb[i]) >= 0)
                        {
                            amount++;
                            times[alf.IndexOf(everyXsymb[i])]++;
                        }                       
                    }
                    for (int i = 0; i < times.Length; i++)
                    {
                        index += (times[i]) * (times[i] - 1);
                    }
                    index = index / (double)(amount * (amount - 1));
                    if (index > 0.0553)
                    {
                        f15_keyLengthUpDown.Value = possibleLength;
                        goto metka_exit;
                    }
                    
                    possibleLength++;
                }
            metka_exit:;
            }
            if (f15_comboBoxMethods.Text == "Автокорреляционный метод" && f15_fieldCiphertext.TextLength > 0)
            {
                string Source = (f15_fieldCiphertext.Text).ToLower();
                for (int i = 0; i < Source.Length; i++) //Удаляем разделители
                {
                    if (alf.IndexOf(Source[i]) < 0)
                    {
                        string tmpDel = "";
                        tmpDel += Source[i];
                        Source = Source.Replace(tmpDel, "");
                    }
                }
                for (int possibleLength = 1; possibleLength < 50; possibleLength++)
                {
                    string copySource = Source.Substring(possibleLength) + Source.Substring(0, possibleLength);
                    int coincidences = 0;
                    for (int i = 0; i < Source.Length; i++)
                    {
                        if (Source[i] == copySource[i]) coincidences++;
                    }
                    double index = coincidences / (double) Source.Length;
                    if (index > 0.0553)
                    {
                        f15_keyLengthUpDown.Value = possibleLength;
                        break;
                    }
                }
            }
            if (f15_comboBoxMethods.Text == "Тест Казиски" && f15_fieldCiphertext.TextLength > 0)
            {
                string Source = (f15_fieldCiphertext.Text).ToLower();
                for (int i = 0; i < Source.Length; i++) //Удаляем разделители
                {
                    if (alf.IndexOf(Source[i]) < 0)
                    {
                        string tmpDel = "";
                        tmpDel += Source[i];
                        Source = Source.Replace(tmpDel, "");
                    }
                }
                if (Source.Length < 10) goto metka_exit; //Для работы нужен достаточно длинный текст
                string checked_sublines = ""; //В эту строку через пробел будем записывать проверенные строки
                List<int> possibleLengths = new List<int>();
                //если индекс в ней -1 то можно проверять, иначе - не надо
                for (int i = 0; i < Source.Length/3 - 1; i++)
                {
                    string subline = Source.Substring(i, 3);
                    if (checked_sublines.IndexOf(subline) == -1)
                    { 
                        //Считаем количество вхождений подстроки
                        int times = 0;
                        int j = 0;
                        while (Source.IndexOf(subline, j) != -1)
                        {
                            j = Source.IndexOf(subline, j) + 1; //Следующий поиск начнем после текущего вхождения
                            times++;
                        };
                        if (times >= 3)
                        {
                            checked_sublines += subline + " ";
                            List<int> positionsDifference = new List<int>();
                            int prev = Source.IndexOf(subline); //первое вхождение
                            j = prev + 1; //начнем поиск со второго
                            while (Source.IndexOf(subline, j) != -1)
                            {
                                int curIndex = Source.IndexOf(subline, j);
                                positionsDifference.Add(curIndex - 1);
                                prev = curIndex;
                                j = curIndex + 1;
                            };
                            int curGCD = positionsDifference[0];
                            for (int k = 1; k < positionsDifference.Count; k++)
                            {
                                curGCD = GCD(curGCD, positionsDifference[k]);
                            }
                            if (curGCD > 1) possibleLengths.Add(curGCD);
                        }
                    }
                }
                if (possibleLengths.Count > 0)
                {
                    possibleLengths.Sort();
                    int[] possibility = new int[50];
                    int i = 0;
                    while (i < possibleLengths.Count() && possibleLengths[i] < 50)
                    {
                        possibility[possibleLengths[i]]++;
                        i++;
                    }
                    for (i = 0; i < 50; i++)
                        possibility[i] = possibility[i] * i;    //Уменьшим значимость ложных срабатываний 
                    for (i = 0; i < 50; i++)
                        if (possibility[i] == possibility.Max())
                            f15_keyLengthUpDown.Value = i;
                }
            metka_exit:;
            }
        }

        private void f15_Table_Chart_func()
        {
            int[] times_ru = new int[alf_ru.Length];    //Массив подсчета вхождений каждой буквы 
            int[] times_en = new int[alf_en.Length];
            Array.Clear(times_ru, 0, alf_ru.Length);
            Array.Clear(times_en, 0, alf_en.Length);

            string analyzedText = f15_fieldOriginal.Text.ToLower();

            //Подсчитаем количество русских и английских букв, количество их вхождений
            int amount_ru = 0, amount_en = 0;
            for (int i = 0; i < analyzedText.Length; i++)
            {
                if (alf_ru.IndexOf(analyzedText[i]) >= 0)
                {
                    amount_ru++;
                    times_ru[alf_ru.IndexOf(analyzedText[i])]++;
                }
                if (alf_en.IndexOf(analyzedText[i]) >= 0)
                {
                    amount_en++;
                    times_en[alf_en.IndexOf(analyzedText[i])]++;
                }
            }

            f15_dataGridView.ColumnCount = 4;
            f15_dataGridView.RowCount = 1;
            int real_index = 0;
            for (int i = 0; i < times_ru.Length; i++)
            {
                if (times_ru[i] > 0)
                {
                    f15_dataGridView.RowCount++;
                    f15_dataGridView.Rows[real_index].Cells[0].Value = alf_ru[i];
                    f15_dataGridView.Rows[real_index].Cells[1].Value = times_ru[i];
                    f15_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_ru[i] / amount_ru, 6); //округлим до 6 знаков после ,
                    f15_dataGridView.Rows[real_index].Cells[3].Value = freqs_ru[i];
                    real_index++;
                }
            }
            for (int i = 0; i < times_en.Length; i++)
            {
                if (times_en[i] > 0)
                {
                    f15_dataGridView.RowCount++;
                    f15_dataGridView.Rows[real_index].Cells[0].Value = alf_en[i];
                    f15_dataGridView.Rows[real_index].Cells[1].Value = times_en[i];
                    f15_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_en[i] / amount_en, 6); //округлим до 6 знаков после ,
                    f15_dataGridView.Rows[real_index].Cells[3].Value = freqs_en[i];
                    real_index++;
                }
            }

            //Заполнение гистограммы
            f15_chart.Series[0].Points.Clear(); //Очистка старых точек
            if (amount_ru > 0)
            {
                for (int i = 0; i < times_ru.Length; i++)
                {
                    f15_chart.Series[0].Points.Add(times_ru[i]);
                }
            }
            if (amount_en > 0)
            {
                for (int i = 0; i < times_en.Length; i++)
                {
                    f15_chart.Series[0].Points.Add(times_en[i]);
                }
            }

        }

        private void f15_buttonFindKeys_Click(object sender, EventArgs e)
        {
            int keyLen = (int) f15_keyLengthUpDown.Value;
            string Source = (f15_fieldCiphertext.Text).ToLower();
            for (int i = 0; i < Source.Length; i++) //Удаляем разделители
            {
                if (alf.IndexOf(Source[i]) < 0)
                {
                    string tmpDel = "";
                    tmpDel += Source[i];
                    Source = Source.Replace(tmpDel, "");
                }
            }
            if (keyLen < 1 || Source.Length < f15_keyLengthUpDown.Value)
                goto metka_exit;

            //Разобьем текст на keyLen шифров цезаря
            string[] everyXsymb = new string[keyLen];
            for (int k = 0; k < keyLen; k++)
            {
                string tmp = "";
                int j = k;
                while (j < Source.Length)
                {
                    tmp += Source[j];
                    j += keyLen;
                }
                everyXsymb[k] = tmp;
            }

            string result = "";
            //Найдем ключ для каждого цезаря отдельно
            for (int k = 0; k < keyLen; k++)
            {
                //Подсчитаем количество вхождений каждой буквы
                int[] times = new int[alf.Length];
                Array.Clear(times, 0, times.Length);
                for (int i = 0; i < everyXsymb[k].Length; i++)
                {
                    if (alf.IndexOf(everyXsymb[k][i]) >= 0)
                    {
                        times[alf.IndexOf(everyXsymb[k][i])]++;
                    }
                }

                //Найдем самый часто встречающийся элемент, запишем его индекс
                int index = -1;
                for (int i = 0; i < times.Length; i++)
                {
                    if (times[i] == times.Max()) index = i;
                }

                //Запишем номер самой встречающейся статистичеки буквы в переменную standard
                int standard = alf.IndexOf('e'); //английская 
                if (alf.IndexOf('о') >= 0) standard = alf.IndexOf('о'); //русская
                if (alf.IndexOf('_') >= 0) standard = alf.IndexOf('_'); //пробел в виде подчеркивания
                if (alf.IndexOf(' ') >= 0) standard = alf.IndexOf(' '); //пробел

                result += alf[((index - standard) + alf.Length) % alf.Length];               
            }
            f15_foundedKey.Text = result;
        metka_exit:;
        }

        private void f15_useFoundedKey_Click(object sender, EventArgs e)
        {
            f15_fieldKey.Text = f15_foundedKey.Text;
        }

        private void f15_alfExtended_TextChanged(object sender, EventArgs e)
        {
            if (f15_checkBox_alfEx.Checked)
                alf = f15_alfExtended.Text + f15_alf.Text;
            else 
                alf = f15_alf.Text + f15_alfExtended.Text;

            ALF = alf.ToUpper();
            string tmp = f15_fieldKey.Text;
            f15_fieldKey.Text = null;
            f15_fieldKey.Text = tmp;
        }

        private void f15_checkBox_alfEx_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = f15_alfExtended.Text;
            f15_alfExtended.Text = null;
            f15_alfExtended.Text = tmp;
        }

        public static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            return GCD(b % a, a);
        }  
    }
}
