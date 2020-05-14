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
    public partial class Form02 : Form
    {
        public Form02()
        {
            InitializeComponent();
            f2_fieldDiametr.Text = "2"; //Пример диаметра для пользователей, не желающих придумывать свой
            f2_fieldDiametr.ForeColor = Color.Gray;
        }

        private void f2_fieldDiametr_Enter(object sender, EventArgs e)
        {
            f2_fieldDiametr.Text = null;
            f2_fieldDiametr.ForeColor = Color.Black;
        }

        private void f2_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f2_fieldOriginal.Text = null;
        }

        private void f2_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f2_fieldCiphertext.Text = null;
        }

        private void f2_fieldDiametr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != (char)8)
            {
                e.Handled = true;
            }
        }

        private void f2_fieldDiametr_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(f2_fieldDiametr, "Количество cтрок");
        }

        private void f2_fieldLength_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(f2_fieldLength, "Количество столбцов");
        }

        private void f2_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            int dia, len, tmpout;
            if (f2_fieldDiametr.TextLength < 1 || !int.TryParse(f2_fieldDiametr.Text, out tmpout) || ((dia = Convert.ToInt32(f2_fieldDiametr.Text)) < 2))
            {
                MessageBox.Show("Неверный диаметр");
            }
            else
            {
                string Source = f2_fieldOriginal.Text;
                char[] Code = Source.ToCharArray();

                //Вычисление длины Скиталы по диаметру и длине исходного текста
                if (f2_fieldOriginal.TextLength % dia == 0)
                    len = f2_fieldOriginal.TextLength / dia;
                else
                    len = f2_fieldOriginal.TextLength / dia + 1;
                //Отображение найденной длины
                f2_fieldLength.Text = Convert.ToString(len);
                
                if (len < 2)
                {
                    MessageBox.Show("Слишком короткий исходный текст!","Ошибка");
                }
                else
                {
                    //Создаем Скиталу требуемого размера
                    char[][] mas = new char[dia][];
                    for (int m = 0; m < dia; m++)
                        mas[m] = new char [len];

                    //Заполняем всю Скиталу мусорным символом
                    for (int m = 0; m < dia; m++)
                        for (int n = 0; n < len; n++)
                            mas[m][n] = '⁣';

                    //Заполняем Скиталу символами исходного текста
                    int i = 0, j = 0;
                    for (int m = 0; m < Code.Length; m++)
                    {
                        mas[i][j] = Code[m];
                        j++;
                        if (j == len)
                        {
                            i++;
                            j = 0;
                        }
                    }
                    
                    //Считываем шифртекст со Скиталы
                    char[] result = new char [len * dia];
                    int cur = 0;
                    for (int m = 0; m<len; m++)
                        for (int n = 0; n<dia; n++)
                        {
                            result[cur] = mas[n][m];
                            cur++;
                        }
                    string txt = new string(result);
                    f2_fieldCiphertext.Text = txt;
                }
            }
        }

        private void f2_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            int dia, len, tmpout;
            if (f2_fieldDiametr.TextLength < 1 || !int.TryParse(f2_fieldDiametr.Text, out tmpout) || ((dia = Convert.ToInt32(f2_fieldDiametr.Text)) < 2))
            {
                MessageBox.Show("Неверный диаметр");
            }
            else
            {
                string Source = f2_fieldCiphertext.Text;
                char[] Code = Source.ToCharArray();

                //Вычисление длины Скиталы по диаметру и длине исходного текста
                if (f2_fieldCiphertext.TextLength % dia == 0)
                    len = f2_fieldCiphertext.TextLength / dia;
                else
                    len = f2_fieldCiphertext.TextLength / dia + 1;

                //Отображение найденной длины
                f2_fieldLength.Text = Convert.ToString(len);

                if (len < 2)
                {
                    MessageBox.Show("Слишком короткий шифртекст", "Ошибка");
                }
                else
                {
                    //Создаем Скиталу требуемого размера
                    char[][] mas = new char[len][];
                    for (int m = 0; m < len; m++)
                        mas[m] = new char[dia];

                    //Заполняем всю Скиталу мусорным символом
                    for (int m = 0; m < len; m++)
                        for (int n = 0; n < dia; n++)
                            mas[m][n] = '⁣';

                    //Заполняем Скиталу символами шифртекста
                    int i = 0, j = 0;
                    for (int m = 0; m < Code.Length; m++)
                    {
                        mas[i][j] = Code[m];
                        j++;
                        if (j == dia)
                        {
                            i++;
                            j = 0;
                        }
                    }

                    //Считываем шифртекст со Скиталы
                    char[] tmp = new char[dia * len];
                    int cur = 0;
                    for (int m = 0; m < dia; m++)
                        for (int n = 0; n < len; n++)
                        {
                            tmp[cur] = mas[n][m];
                            cur++;
                        }
                    string txt = new string(tmp);
                    f2_fieldOriginal.Text = txt;
                }
            }
        }
    }
}
