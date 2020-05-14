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
    public partial class Form05 : Form
    {
        public Form05()
        {
            InitializeComponent();
        }

        int[,] Key_Matrix = null;
        int[] x_seq = null;
        int[] y_seq = null;
        
        private void f5_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяABCDEFGHIJKLMNOPQRSTUVWXYZabcdefjhigklmnopqrstuvwxyz";   //разрешить на вход только буквы
            //if (ALF.IndexOf(number) == -1 && number != (char)8) e.Handled = true;
        }

        private void f5_fieldKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (!(char.IsNumber(symb)) && symb != ' ' && symb != (char)8) e.Handled = true;
        }

        private void f5_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f5_fieldOriginal.Text = null;
        }

        private void f5_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f5_fieldCiphertext.Text = null;
        }

        private void f5_ButtonClearKey_Click(object sender, EventArgs e)
        {
            f5_fieldKey.Text = null;
        }

        private void f5_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string alf_en = "abcdefjhigklmnopqrstuvwxyz";
            string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string ALF_EN = "ABCDEFJHIGKLMNOPQRSTUVWXYZ";
            string alf_numeric = "1234567890";
            string Source = f5_fieldOriginal.Text;
            //Source = Regex.Replace(f5_fieldOriginal.Text, "[^a-zA-Zа-яА-ЯёЁ]", ""); //разрешить на вход только буквы
            if (Source.Length == 0 && f5_fieldOriginal.TextLength > 0)
            {
                MessageBox.Show("Исходный текст должен содержать символы русского или английского алфавита. Прочие символы недопустимы и будут удалены.", "Ошибка"); //Выводится только при запрете ввода символов
                goto metka_exit;
            }
            string result = "";

            if (KeyToMatrix() == -1) goto metka_exit;

            //Определение алфавита для мусорных символов
            int ru_symbols = 0, en_symbols = 0, RU_symbols = 0, EN_symbols = 0, num_symbols = 0;
            for (int i = 0; i < Source.Length; i++) //Подсчет количества входящих в исходный текст символов каждого алфавита
            {
                if (alf_ru.IndexOf(Source[i]) >= 0) ru_symbols++;
                if (ALF_RU.IndexOf(Source[i]) >= 0) RU_symbols++;
                if (alf_en.IndexOf(Source[i]) >= 0) en_symbols++;
                if (ALF_EN.IndexOf(Source[i]) >= 0) EN_symbols++;
                if (alf_numeric.IndexOf(Source[i]) >= 0) num_symbols++;
            }

            //Создание решетки Кардано
            int sizeOfGrid = Convert.ToInt32(numericUpDown1.Value);
            char[,] CardanoGrid = new char[sizeOfGrid, sizeOfGrid];
            Random rnd = new Random();
            
            int amount_of_encrypted_symbols = 0; //Количество уже зашифрованных символов
            while (amount_of_encrypted_symbols < Source.Length)
            {
                //Подготовка решетки (заполнение мусором)
                if (en_symbols >= ru_symbols && en_symbols >= EN_symbols && en_symbols >= RU_symbols && en_symbols >= num_symbols) //заполняем строчным английским мусором
                {
                    for (int i = 0; i < sizeOfGrid; i++)
                        for (int j = 0; j < sizeOfGrid; j++)
                            CardanoGrid[i, j] = alf_en[rnd.Next(26)];
                }
                else if (ru_symbols >= EN_symbols && ru_symbols >= RU_symbols && ru_symbols >= num_symbols) //заполняем строчным русским мусором
                {
                    for (int i = 0; i < sizeOfGrid; i++)
                        for (int j = 0; j < sizeOfGrid; j++)
                            CardanoGrid[i, j] = alf_ru[rnd.Next(33)];
                }
                else if (RU_symbols >= EN_symbols && RU_symbols >= num_symbols) //заполняем заглавным русским мусором
                {
                    for (int i = 0; i < sizeOfGrid; i++)
                        for (int j = 0; j < sizeOfGrid; j++)
                            CardanoGrid[i, j] = ALF_RU[rnd.Next(33)];
                }
                else if (EN_symbols >= num_symbols) //заполняем заглавным английским мусором
                {
                    for (int i = 0; i < sizeOfGrid; i++)
                        for (int j = 0; j < sizeOfGrid; j++)
                            CardanoGrid[i, j] = ALF_EN[rnd.Next(26)];
                }
                else //Заполняем мусорными цифрами
                {
                    for (int i = 0; i < sizeOfGrid; i++)
                        for (int j = 0; j < sizeOfGrid; j++)
                            CardanoGrid[i, j] = alf_numeric[rnd.Next(alf_numeric.Length)];
                }

                //Заполнение решетки исходным текстом
                int curSymb = 0;
                while (curSymb < Source.Length - amount_of_encrypted_symbols && curSymb < (sizeOfGrid * sizeOfGrid))
                {
                    CardanoGrid[x_seq[curSymb], y_seq[curSymb]] = Source[curSymb+amount_of_encrypted_symbols];
                    curSymb++;
                }

                //Считывание шифртекста с решетки
                for (int i = 0; i < sizeOfGrid; i++)  
                    for (int j = 0; j < sizeOfGrid; j++)
                    {
                        result = result + CardanoGrid[i, j];    
                    }

                amount_of_encrypted_symbols += (sizeOfGrid * sizeOfGrid);
            }
            f5_fieldCiphertext.Text = result;
        metka_exit:;
        }

        private void f5_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f5_fieldCiphertext.Text;
            int sizeOfGrid = Convert.ToInt32(numericUpDown1.Value);
            //Source = Regex.Replace(f5_fieldCiphertext.Text, "[^a-zA-Zа-яА-ЯёЁ]", "");   //разрешить на вход только буквы
            if ((Source.Length == 0 || Source.Length % (sizeOfGrid * sizeOfGrid) > 0)) //Если шифртекст не содержит натуральное число блоков
            {
                MessageBox.Show("Шифртекст должен содержать как минимум 1 блок из n*n символов.", "Ошибка");
                goto metka_exit;
            }
            string result = "";

            if (KeyToMatrix() == -1) goto metka_exit;

            //Создание решетки Кардано
            sizeOfGrid = Convert.ToInt32(numericUpDown1.Value);
            char[,] CardanoGrid = new char[sizeOfGrid, sizeOfGrid];
            Random rnd = new Random();

            int amount_of_decrypted_symbols = 0;//Количество уже расшифрованных символов
            while (amount_of_decrypted_symbols < Source.Length)
            {
                //Заполнение решетки шифртекстом
                for (int i = 0; i < sizeOfGrid; i++)
                    for (int j = 0; j < sizeOfGrid; j++)
                    {
                        CardanoGrid[i, j] = Source[amount_of_decrypted_symbols+i*sizeOfGrid+j];
                    }

                //Считывание с решетки исходного текста
                int curSymb = 0;
                while (curSymb < (sizeOfGrid * sizeOfGrid))
                {
                    result += CardanoGrid[x_seq[curSymb], y_seq[curSymb]];
                    curSymb++;
                }
                amount_of_decrypted_symbols += (sizeOfGrid * sizeOfGrid);
            }
            f5_fieldOriginal.Text = result;
        metka_exit:;
        }

        private int KeyToMatrix()
        {
            f5_fieldKey.Text = Regex.Replace(f5_fieldKey.Text, "[^0-9 ]", ""); 
            int[] sequence = f5_fieldKey.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray(); ;

            int lines = Convert.ToInt32(Math.Sqrt(sequence.Length*4));
            if (lines < 4)
            {
                MessageBox.Show("Некорректный ключ", "Ошибка");
                return -1;
            }
            Key_Matrix = new int[lines, lines];
            
            numericUpDown1.Value = lines;

            foreach (int a in sequence)
            {
                int temp = 0;
                for (int i = 0; i < lines / 2; i++)
                {
                    for (int j = 0; j < lines / 2; j++)
                    {
                        temp++;
                        if (temp == a)
                        {
                            Key_Matrix[i, j] = 1;
                            Key_Matrix = Matrix_Rotation(Key_Matrix);
                            goto metka_cont;
                        }
                    }
                }
            metka_cont:
                continue;
            }

            int[,] tmpMatrix = new int[lines, lines];

            //Обозначим порядок элементов на этой итерации
            int times = 0;
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    if (Key_Matrix[i, j] == 1)
                        Key_Matrix[i, j] += times++;
                }
            }

            times++;

            //Расставим метки и повернем вспомогательную матрицу
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    if (Key_Matrix[i, j] > 0)
                    {
                        tmpMatrix[i, j] = times;
                    }
                    else
                        tmpMatrix[i, j] = 0;
                }
            }

            for (int k = 0; k < 3; k++)
            {
                //Расставим метки и повернем вспомогательную матрицу
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < lines; j++)
                    {
                        if (tmpMatrix[i, j] > 0)
                        {
                            tmpMatrix[i, j] = times;
                        }
                        else
                            tmpMatrix[i, j] = 0;
                    }
                }
                tmpMatrix = Matrix_Rotation(tmpMatrix);

                //Переносим значения со вспомогательной матрицы
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < lines; j++)
                    {
                        if (tmpMatrix[i, j] == times)
                            Key_Matrix[i, j] = times;
                    }
                }

                int tmpTimes = 0;
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < lines; j++)
                    {
                        if (Key_Matrix[i, j] == times)
                            Key_Matrix[i, j] += tmpTimes++;
                    }
                }

                times += tmpTimes;
            }

            bool [] check = new bool[lines * lines+1];
            for (int i = 0; i < check.Length; i++)
            {
                check[i] = false;

            }

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    check[Key_Matrix[i, j]] = true;
                }
            }

            for (int i = 1; i < check.Length; i++)
            {
                if (!check[i])
                {
                    MessageBox.Show("Некорректный ключ", "Ошибка");
                    Key_Matrix = null;
                    return -1;
                }
            }

            x_seq = new int[lines * lines];
            y_seq = new int[lines * lines];

            int finding_coords = 0;
            while (finding_coords < lines*lines)
            {
                for (int i = 0; i < lines; i++)
                {
                    for (int j = 0; j < lines; j++)
                    {
                        if (Key_Matrix[i, j] == finding_coords + 1)
                        {
                            x_seq[finding_coords] = i;
                            y_seq[finding_coords] = j;
                        }
                    }
                }

                finding_coords++;
            }
            return 0;
        }

        private void f5_ButtonGenKey_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int key = Convert.ToInt32(numericUpDown1.Value);
            key = (key * key) / 4;
            int[] sequence = Enumerable.Range(1, key).OrderBy(y => rand.Next(key)).Take(key).ToArray();
            
            String seq = null;
            for (int i = 0; i < key; i++)
            {
                seq += sequence[i];
                seq += ' ';
            }
            f5_fieldKey.Text = seq;
        }

        int[,] Matrix_Rotation(int[,] key_matrix)
        {
            int[,] new_key_matrix = new int[key_matrix.GetLength(0), key_matrix.GetLength(1)];
            for (int i = 0; i < key_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < key_matrix.GetLength(1); j++)
                {
                    new_key_matrix[j, key_matrix.GetLength(0) - 1 - i] = key_matrix[i, j];
                }
            }
            return new_key_matrix;
        }

        
    }
}
