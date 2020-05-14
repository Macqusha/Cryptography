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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            f10_fieldKeyword.Text = "playfairexample"; //Пример ключа для пользователей, не желающих придумывать свой
            f10_fieldKeyword.ForeColor = Color.Gray;
        }

        private void f10_fieldKeyword_Enter(object sender, EventArgs e)
        {
            //f9_fieldKeyword.Text = null;
            f10_fieldKeyword.ForeColor = Color.Black;
        }

        private void f10_fieldKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (!(char.IsLetter(symb)) && symb != (char)8) e.Handled = true;
        }

        string ALF_RU = "АБВГДЕЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЭЮЯ";
        string ALF_EN = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
        string alf_ru = "абвгдежзиклмнопрстуфхцчшщъыэюя";
        string alf_en = "abcdefghiklmnopqrstuvwxyz";

        private int what_language(string txt)
        {
            string alf = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            //Определение алфавита текста
            int ru_symbols = 0, en_symbols = 0;
            for (int i = 0; i < txt.Length; i++) //Подсчет количества входящих в исходный текст символов каждого алфавита
            {
                if (alf.IndexOf(txt[i]) <= 65 && alf.IndexOf(txt[i])>=0)
                    ru_symbols++;
                else if (alf.IndexOf(txt[i]) >= 0)
                    en_symbols++;
            }
            if (ru_symbols * en_symbols != 0)
                return -1;  //Некорректный текст (есть буквы обоих алфавитов)
            
            if (ru_symbols > en_symbols)    //Русский текст
                    return 1;
            if (en_symbols > ru_symbols)    //Английский текст
                    return 2;

            return 0;   //Текста нет
        }

        private void f10_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            
            string Source = f10_fieldOriginal.Text;
            string entered_key = Regex.Replace(f10_fieldKeyword.Text, "[^a-zA-Zа-яА-ЯёЁ]", "");
            f10_fieldKeyword.Text = entered_key;
            entered_key = entered_key.Replace("J", "I").Replace("Ё", "Е").Replace("Й", "И").Replace("Ь", "Ъ").Replace("j", "i").Replace("ё", "е").Replace("й", "и").Replace("ь", "ъ").ToLower();

            if (what_language(Source) == -1 || what_language(entered_key) == -1 || (what_language(Source)*what_language(entered_key)) == 2) //Разные языки
            {
                MessageBox.Show("Поля должны быть заполнены только на английском или только на русском языке.", "Ошибка");
                goto metka_exit;
            }
            Source = Source.Replace("J", "I").Replace("Ё", "Е").Replace("Й", "И").Replace("Ь", "Ъ").Replace("j", "i").Replace("ё", "е").Replace("й", "и").Replace("ь", "ъ");

            //Выбор алфавита
            string ALF, alf;
            bool lenIsRus;
            int rows, columns;
            if (what_language(Source) == 1) //Русский текст и русский/пустой ключ 
            {
                ALF = ALF_RU;
                alf = alf_ru;
                lenIsRus = true;
                rows = 5;
                columns = 6;
            }
            else
            {
                ALF = ALF_EN;
                alf = alf_en;
                lenIsRus = false;
                rows = 5;
                columns = 5;
            }

            //Сохраним регистр и будем работать только с нижним
            int[] isUpper = new int[Source.Length];
            for (int i = 0; i < Source.Length; i++)
            {
                if (ALF.IndexOf(Source[i]) >= 0)
                    isUpper[i] = 1;
                else
                    isUpper[i] = 0;
            }
            Source = Source.ToLower();
            char[] message = Source.ToCharArray();
            
            //Формирование таблицы, на основе которой будет происходить шифрование (будет располагаться в одномерном массиве) 5 строк, 6 столбцов
            int gridSize = alf.Length;
            char[] PlayfairGrid = new char[gridSize];
            int keyPos = 0;
            int gridPos = 0;
            int[] times = new int[alf.Length];   //иницилизация массива вхождений
            for (int i = 0; i < times.Length; i++) times[i] = 0; //обнуление массива вхождений
            while (keyPos < entered_key.Length)
            {
                if (alf.IndexOf(entered_key[keyPos]) >= 0 && times[alf.IndexOf(entered_key[keyPos])] == 0)
                {
                    times[alf.IndexOf(entered_key[keyPos])]++;
                    PlayfairGrid[gridPos] = entered_key[keyPos];
                    gridPos++;
                }
                keyPos++;
            }
            int alfPos = 0;
            while (gridPos < gridSize)
            {
                if (times[alfPos] == 0)
                {
                    times[alfPos]++;
                    PlayfairGrid[gridPos] = alf[alfPos];
                    gridPos++;
                }
                alfPos++;
            }

            //Добавим мусорные буквы в последовательные пары одинаковых буквы
            int similar = 0;
            int previousLetter = 0;
            while (!char.IsLetter(message[previousLetter])) previousLetter++;
            //Считаем количество пар одинаковых букв, идущих подряд.
            for (int i = previousLetter + 1; i < message.Length; i++)
            {
                if (message[previousLetter] == message[i]) similar++;
                if (char.IsLetter(message[i])) previousLetter = i;
            }

            char[] tmp = new char[message.Length + similar];
            int[] register = new int[message.Length + similar + 1];
            int rot = 0;
            char letter = '⁣';
            //Добавление букв
            for (int i = 0; i < tmp.Length; i++)
            {
                if (char.IsLetter(message[i - rot]) && message[i - rot] == letter)
                {
                    
                    if (lenIsRus)
                    {
                        tmp[i] = 'х';
                        if (letter == 'х') tmp[i] = 'ъ';
                    }
                    else
                    {
                        tmp[i] = 'x';
                        if (letter == 'x') tmp[i] = 'q';
                    }
                    register[i] = 0;
                    i++;
                    rot++;
                    tmp[i] = message[i - rot];
                    register[i] = isUpper[i - rot];
                }
                else
                {
                    tmp[i] = message[i - rot];
                    register[i] = isUpper[i - rot];
                }
                if (char.IsLetter(message[i - rot])) letter = message[i - rot];
            }

            //Добавим букву в конец, если букв нечетное количество
            int amount_letters = 0;
            for (int i = 0; i < tmp.Length; i++)
                if (char.IsLetter(tmp[i])) amount_letters++;
            if (amount_letters % 2 == 1)
            {
                char[] tmp2 = tmp;
                tmp = new char[tmp.Length + 1];
                for (int i = 0; i < tmp2.Length; i++)
                    tmp[i] = tmp2[i];
                if (lenIsRus)
                {
                    tmp[tmp.Length - 1] = 'х';
                    if (tmp[tmp.Length - 2] == 'х') tmp[tmp.Length - 1] = 'ъ';
                }
                else
                {
                    tmp[tmp.Length - 1] = 'x';
                    if (tmp[tmp.Length - 2] == 'x') tmp[tmp.Length - 1] = 'q';
                }
                register[tmp.Length - 1] = 0;
            }

            //Парное шифрование
            string playfair = new string(PlayfairGrid);
            int pair_found = 0;//сколько элементов найдено для пары
            int first_letter_ind = 0, second_letter_ind = 0; //индексы элементов, составляющих пару
            for (int i = 0; i < tmp.Length; i++)
            {
                if (playfair.IndexOf(tmp[i]) >= 0)
                {
                    if (pair_found == 0)
                    {
                        first_letter_ind = i;
                        pair_found++;
                    }
                    else
                    {
                        second_letter_ind = i;
                        char[] pair = new char[2];  //Адреса символов в исходном тексте
                        pair[0] = tmp[first_letter_ind];
                        pair[1] = tmp[second_letter_ind];
                        int[] x_coord = new int[2];
                        x_coord[0] = playfair.IndexOf(pair[0]) % columns; //столбец
                        x_coord[1] = playfair.IndexOf(pair[1]) % columns; //столбец
                        int[] y_coord = new int[2];
                        y_coord[0] = playfair.IndexOf(pair[0]) / columns; //строка
                        y_coord[1] = playfair.IndexOf(pair[1]) / columns; //строка
                        //Зашифрование пары символов
                        if ((y_coord[0] == y_coord[1]) && (x_coord[0] != x_coord[1])) //символы находятся в одной строке
                        {
                            tmp[first_letter_ind] = playfair[columns * y_coord[0] + ((x_coord[0] + 1) % columns)];
                            tmp[second_letter_ind] = playfair[columns * y_coord[1] + ((x_coord[1] + 1) % columns)];
                        }
                        if ((y_coord[0] != y_coord[1]) && (x_coord[0] == x_coord[1])) //символы находятся в одном столбце
                        {
                            tmp[first_letter_ind] = playfair[columns * ((y_coord[0] + 1) % rows) + x_coord[0]];
                            tmp[second_letter_ind] = playfair[columns * ((y_coord[1] + 1) % rows) + x_coord[1]];
                        }
                        if ((y_coord[0] != y_coord[1]) && (x_coord[0] != x_coord[1])) //символы образуют прямоугольник
                        {
                            tmp[first_letter_ind] = playfair[columns * y_coord[0] + x_coord[1]];
                            tmp[second_letter_ind] = playfair[columns * y_coord[1] + x_coord[0]];
                        }
                        //Конец зашифрования пары символов
                        pair_found = 0;
                    }
                }
            }
            
            for (int i = 0; i < tmp.Length; i++)
                if (register[i] == 1) tmp[i] = ALF[alf.IndexOf(tmp[i])];

            f10_fieldCiphertext.Text = new string(tmp);
            metka_exit:;
        }

        private void f10_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string Source = f10_fieldCiphertext.Text;
            string entered_key = Regex.Replace(f10_fieldKeyword.Text, "[^a-zA-Zа-яА-ЯёЁ]", "");
            f10_fieldKeyword.Text = entered_key;
            entered_key = entered_key.Replace("J", "I").Replace("Ё", "Е").Replace("Й", "И").Replace("Ь", "Ъ").Replace("j", "i").Replace("ё", "е").Replace("й", "и").Replace("ь", "ъ").ToLower();

            if (what_language(Source) == -1 || what_language(entered_key) == -1 || (what_language(Source) * what_language(entered_key)) == 2) //Разные языки
            {
                MessageBox.Show("Поля должны быть заполнены только на английском или только на русском языке.", "Ошибка");
                goto metka_exit;
            }
            Source = Source.Replace("J", "I").Replace("Ё", "Е").Replace("Й", "И").Replace("Ь", "Ъ").Replace("j", "i").Replace("ё", "е").Replace("й", "и").Replace("ь", "ъ");

            //Выбор алфавита
            string ALF, alf;
            int rows, columns;
            if (what_language(Source) == 1) //Русский текст и русский/пустой ключ 
            {
                ALF = ALF_RU;
                alf = alf_ru;
                rows = 5;
                columns = 6;
            }
            else
            {
                ALF = ALF_EN;
                alf = alf_en;
                rows = 5;
                columns = 5;
            }

            //Сохраним регистр и будем работать только с нижним
            int[] isUpper = new int[Source.Length];
            for (int i = 0; i < Source.Length; i++)
            {
                if (ALF.IndexOf(Source[i]) >= 0)
                    isUpper[i] = 1;
                else
                    isUpper[i] = 0;
            }
            Source = Source.ToLower();
            char[] message = Source.ToCharArray();
            
            //Формирование таблицы, на основе которой будет происходить шифрование (будет располагаться в одномерном массиве) 5 строк, 6 столбцов
            int gridSize = alf.Length;
            char[] PlayfairGrid = new char[gridSize];
            int keyPos = 0;
            int gridPos = 0;
            int[] times = new int[alf.Length];   //иницилизация массива вхождений
            for (int i = 0; i < times.Length; i++) times[i] = 0; //обнуление массива вхождений
            while (keyPos < entered_key.Length)
            {
                if (alf.IndexOf(entered_key[keyPos]) >= 0 && times[alf.IndexOf(entered_key[keyPos])] == 0)
                {
                    times[alf.IndexOf(entered_key[keyPos])]++;
                    PlayfairGrid[gridPos] = entered_key[keyPos];
                    gridPos++;
                }
                keyPos++;
            }
            int alfPos = 0;
            while (gridPos < gridSize)
            {
                if (times[alfPos] == 0)
                {
                    times[alfPos]++;
                    PlayfairGrid[gridPos] = alf[alfPos];
                    gridPos++;
                }
                alfPos++;
            }

            //Парное шифрование
            string playfair = new string(PlayfairGrid);
            int pair_found = 0;//сколько элементов найдено для пары
            int first_letter_ind = 0, second_letter_ind = 0; //индексы элементов, составляющих пару
            for (int i = 0; i < message.Length; i++)
            {
                if (playfair.IndexOf(message[i]) >= 0)
                {
                    if (pair_found == 0)
                    {
                        first_letter_ind = i;
                        pair_found++;
                    }
                    else
                    {
                        second_letter_ind = i;
                        char[] pair = new char[2];  //Адреса символов в исходном тексте
                        pair[0] = message[first_letter_ind];
                        pair[1] = message[second_letter_ind];
                        int[] x_coord = new int[2];
                        x_coord[0] = playfair.IndexOf(pair[0]) % columns; //столбец
                        x_coord[1] = playfair.IndexOf(pair[1]) % columns; //столбец
                        int[] y_coord = new int[2];
                        y_coord[0] = playfair.IndexOf(pair[0]) / columns; //строка
                        y_coord[1] = playfair.IndexOf(pair[1]) / columns; //строка
                        //Зашифрование пары символов
                        if ((y_coord[0] == y_coord[1]) && (x_coord[0] != x_coord[1])) //символы находятся в одной строке
                        {
                            message[first_letter_ind] = playfair[columns * y_coord[0] + ((x_coord[0] - 1 + columns) % columns)];
                            message[second_letter_ind] = playfair[columns * y_coord[1] + ((x_coord[1] - 1 + columns) % columns)];
                        }
                        if ((y_coord[0] != y_coord[1]) && (x_coord[0] == x_coord[1])) //символы находятся в одном столбце
                        {
                            message[first_letter_ind] = playfair[columns * ((y_coord[0] - 1 + rows) % rows) + x_coord[0]];
                            message[second_letter_ind] = playfair[columns * ((y_coord[1] - 1 + rows) % rows) + x_coord[1]];
                        }
                        if ((y_coord[0] != y_coord[1]) && (x_coord[0] != x_coord[1])) //символы образуют прямоугольник
                        {
                            message[first_letter_ind] = playfair[columns * y_coord[0] + x_coord[1]];
                            message[second_letter_ind] = playfair[columns * y_coord[1] + x_coord[0]];
                        }
                        //Конец зашифрования пары символов
                        pair_found = 0;
                    }
                }
            }
            for (int i = 0; i < message.Length; i++)
                if (isUpper[i] == 1) message[i] = ALF[alf.IndexOf(message[i])];
            f10_fieldOriginal.Text = new string(message);
        
        metka_exit:;
        }

        private void f10_ButtonClearKeyword_Click(object sender, EventArgs e)
        {
            f10_fieldKeyword.Text = null;
        }

        private void f10_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f10_fieldOriginal.Text = null;
        }

        private void f10_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f10_fieldCiphertext.Text = null;
        }
    }
}
