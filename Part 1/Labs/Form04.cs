using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form04 : Form
    {
        public Form04()
        {
            InitializeComponent();
        }

        private void f4_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f4_fieldCiphertext.Text = null;
        }

        private void f4_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f4_fieldOriginal.Text = null;
        }

        private void f4_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ⁣⁤⁢"; //невидимые разделители
            string ALF_EN = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; //J
            string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя­͏⁠"; //невидимые разделители
            string alf_en = "abcdefghiklmnopqrstuvwxyz"; //j
            string Source = f4_fieldOriginal.Text.Replace("J","I").Replace("j", "i");

            //Создание матриц - квадратов Полибия
            char[,] EN = new char[5, 5];
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    EN[i, j] = ALF_EN[k];
                    k++;
                }
            }
            k = 0;
            char[,] en = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    en[i, j] = alf_en[k];
                    k++;
                }
            }
            k = 0;
            char[,] RU = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    RU[i, j] = ALF_RU[k];
                    k++;
                }
            }
            k = 0;
            char[,] ru = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    ru[i, j] = alf_ru[k];
                    k++;
                }
            }

            //Создадим одномерный массив координат для каждого квадрата
            int[,] koord_EN = new int[2, Source.Length];
            int ind_EN = 0;

            int[,] koord_en = new int[2, Source.Length];
            int ind_en = 0;

            int[,] koord_RU = new int[2, Source.Length];
            int ind_RU = 0;

            int[,] koord_ru = new int[2, Source.Length];
            int ind_ru = 0;
            //Заполним созданные массивы
            k = 0;

            bool flag = false;

            for (k = 0; k < Source.Length; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == EN[i, j])
                        {

                            koord_EN[0, ind_EN] = j;
                            koord_EN[1, ind_EN] = i;
                            ind_EN++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == en[i, j])
                        {

                            koord_en[0, ind_en] = j;
                            koord_en[1, ind_en] = i;
                            ind_en++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == RU[i, j])
                        {

                            koord_RU[0, ind_RU] = j;
                            koord_RU[1, ind_RU] = i;
                            ind_RU++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == ru[i, j])
                        {

                            koord_ru[0, ind_ru] = j;
                            koord_ru[1, ind_ru] = i;
                            ind_ru++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                flag = false;
            }
            //Перепишем координаты в 1 строку

            k = 0;
            int[] coord_str_EN = new int[ind_EN * 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < ind_EN; j++)
                {
                    coord_str_EN[k] = koord_EN[i, j];
                    k++;
                }


            k = 0;
            int[] coord_str_en = new int[ind_en * 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < ind_en; j++)
                {
                    coord_str_en[k] = koord_en[i, j];
                    k++;
                }


            k = 0;
            int[] coord_str_RU = new int[ind_RU * 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < ind_RU; j++)
                {
                    coord_str_RU[k] = koord_RU[i, j];
                    k++;
                }


            k = 0;
            int[] coord_str_ru = new int[ind_ru * 2];

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < ind_ru; j++)
                {
                    coord_str_ru[k] = koord_ru[i, j];
                    k++;
                }

            //Запишем шифртекст, используя координаты из строки
            ind_EN = 0;
            ind_en = 0;
            ind_RU = 0;
            ind_ru = 0;
            string result = "";

            for (k = 0; k < Source.Length; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == EN[i, j])
                        {

                            result += EN[coord_str_EN[ind_EN + 1], coord_str_EN[ind_EN]];
                            ind_EN += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == en[i, j])
                        {

                            result += en[coord_str_en[ind_en + 1], coord_str_en[ind_en]];
                            ind_en += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == RU[i, j])
                        {

                            result += RU[coord_str_RU[ind_RU + 1], coord_str_RU[ind_RU]];
                            ind_RU += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == ru[i, j])
                        {

                            result += ru[coord_str_ru[ind_ru + 1], coord_str_ru[ind_ru]];
                            ind_ru += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                    result += Source[k];
                flag = false;
            }
            f4_fieldCiphertext.Text = result;
        }

    

        private void f4_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ⁣⁤⁢"; //невидимые разделители
            string ALF_EN = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; //J
            string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя­͏⁠"; //невидимые разделители
            string alf_en = "abcdefghiklmnopqrstuvwxyz"; //j
            string Source = f4_fieldCiphertext.Text.Replace("J", "I").Replace("j", "i");
            string result = "";

            //Создание матриц - квадратов Полибия
            char[,] EN = new char[5, 5];
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    EN[i, j] = ALF_EN[k];
                    k++;
                }
            }
            k = 0;
            char[,] en = new char[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    en[i, j] = alf_en[k];
                    k++;
                }
            }
            k = 0;
            char[,] RU = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    RU[i, j] = ALF_RU[k];
                    k++;
                }
            }
            k = 0;
            char[,] ru = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    ru[i, j] = alf_ru[k];
                    k++;
                }
            }

            //Создадим одномерный массив координат для каждого квадрата
            int[] coord_str_EN = new int[Source.Length * 2];
            int ind_EN = 0;
            int[] coord_str_en = new int[Source.Length * 2];
            int ind_en = 0;
            int[] coord_str_RU = new int[Source.Length * 2];
            int ind_RU = 0;
            int[] coord_str_ru = new int[Source.Length * 2];
            int ind_ru = 0;

            k = 0;

            bool flag = false;

            for (k = 0; k < Source.Length; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == EN[i, j])
                        {
                            coord_str_EN[ind_EN] = j;
                            coord_str_EN[ind_EN + 1] = i;
                            ind_EN += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == en[i, j])
                        {

                            coord_str_en[ind_en] = j;
                            coord_str_en[ind_en + 1] = i;
                            ind_en += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == RU[i, j])
                        {

                            coord_str_RU[ind_RU] = j;
                            coord_str_RU[ind_RU + 1] = i;
                            ind_RU += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == ru[i, j])
                        {

                            coord_str_ru[ind_ru] = j;
                            coord_str_ru[ind_ru + 1] = i;
                            ind_ru += 2;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                flag = false;
            }

            //Перепишем координаты букв в две строки, содержащие координаты по строке и столбцу
            int[,] koord_EN = new int[2, ind_EN / 2];
            k = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < ind_EN / 2; j++)
                {
                    koord_EN[i, j] = coord_str_EN[k];
                    k++;
                }
            }

            int[,] koord_en = new int[2, ind_en / 2];
            k = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < ind_en / 2; j++)
                {
                    koord_en[i, j] = coord_str_en[k];
                    k++;
                }
            }

            int[,] koord_RU = new int[2, ind_RU / 2];
            k = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < ind_RU / 2; j++)
                {
                    koord_RU[i, j] = coord_str_RU[k];
                    k++;
                }
            }

            int[,] koord_ru = new int[2, ind_ru / 2];
            k = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < ind_ru / 2; j++)
                {
                    koord_ru[i, j] = coord_str_ru[k];
                    k++;
                }
            }
            //Расшифруем текст, используя записанные координаты
            ind_EN = 0;
            ind_en = 0;
            ind_RU = 0;
            ind_ru = 0;

            for (k = 0; k < Source.Length; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == EN[i, j])
                        {

                            result += EN[koord_EN[1, ind_EN], koord_EN[0, ind_EN]];
                            ind_EN++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Source[k] == en[i, j])
                        {

                            result += en[koord_en[1, ind_en], koord_en[0, ind_en]];
                            ind_en++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == RU[i, j])
                        {

                            result += RU[koord_RU[1, ind_RU], koord_RU[0, ind_RU]];
                            ind_RU++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (Source[k] == ru[i, j])
                        {

                            result += ru[koord_ru[1, ind_ru], koord_ru[0, ind_ru]];
                            ind_ru++;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;
                }
                if (!flag)
                    result += Source[k];
                flag = false;
            }

            f4_fieldOriginal.Text = result;
        }
    }
}
