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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            f11_fieldKeyword.Text = "альпинизм";
            f11_fieldKeyword.ForeColor = Color.Gray;                
        }

        public string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя.,! "; //Length = 33+4=37
        public string ALF_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ:;?*"; //Length = 33+4=37
        public string alf_en = "abcdefghijklmnopqrstuvwxyz.,!' ";        //Length = 26+5=31
        public string ALF_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ:;?^*";        //Length = 26+5=31
        
        private void f11_ButtonClearKeyword_Click(object sender, EventArgs e)
        {
            f11_fieldKeyword.Text = null;
        }

        private void f11_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f11_fieldCiphertext.Text = null;
        }

        private void f11_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f11_fieldOriginal.Text = null;
        }

        private void f11_field_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symb = e.KeyChar;
            if (f11_radioButtonRus.Checked && alf_ru.IndexOf(symb) == -1 && ALF_RU.IndexOf(symb) == -1 && symb != (char)8) e.Handled = true; //Стоит русский язык, а вводится не русский символ
            if (f11_radioButtonEn.Checked && alf_en.IndexOf(symb) == -1 && ALF_EN.IndexOf(symb) == -1 && symb != (char)8) e.Handled = true; //Стоит английский язык, а вводится не английский символ
        }

        private void f11_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            f11_fieldKeyword.Text = null;
            f11_fieldOriginal.Text = null;
            f11_fieldCiphertext.Text = null;
        }

        private void f11_fieldKeyword_Enter(object sender, EventArgs e)
        {
            //f11_fieldKeyword.Text = null;
            f11_fieldKeyword.ForeColor = Color.Black;
        }

        private bool isSquare(int n)
        {
            if ((Math.Sqrt(n) % 1) == 0)
                return true;
            else
                return false;
        }
        
        private void f11_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            //Подготовка сообщения и ключа
            string Source = f11_fieldOriginal.Text;
            string entered_key = f11_fieldKeyword.Text;
            string alf, ALF;
            if (f11_radioButtonRus.Checked)
            {
                Source = Regex.Replace(Source, "[^а-яА-ЯёЁ .,!:;?*]", "");
                entered_key = Regex.Replace(entered_key, "[^а-яА-ЯёЁ .,!:;?*]", "");
                alf = alf_ru;
                ALF = ALF_RU;
            }
            else
            {
                Source = Regex.Replace(Source, "[^a-zA-Z .,!':;?*^]", "");
                entered_key = Regex.Replace(entered_key, "[^a-zA-Z .,!':;?*^]", "");
                alf = alf_en;
                ALF = ALF_EN;
            }
            
            //Проверка длины ключа на квадратность
            if (!isSquare(entered_key.Length))
            {
                MessageBox.Show("Некорректный ключ. Ожидаемая длина ключа - полный квадрат>1.", "Ошибка");
                goto metka_exit;
            }
            int matrixSize = Convert.ToInt32(Math.Sqrt(entered_key.Length));

            //Приведение сообщения и ключа к корректному виду
            while (Source.Length % matrixSize != 0) Source = Source + " ";
            f11_fieldOriginal.Text = Source;
            f11_fieldKeyword.Text = entered_key;
            entered_key = entered_key.ToLower().Replace(":", ".").Replace(";", ",").Replace("?", "!")
                 .Replace("*", " ").Replace("^", "'");

            //Сохранение регистра сообщения
            bool[] isUpper = new bool[Source.Length];
            for (int i = 0; i < Source.Length; i++)
                if (alf.IndexOf(Source[i]) >= 0)
                    isUpper[i] = false;
                else
                    isUpper[i] = true;
            Source = Source.ToLower().Replace(":", ".").Replace(";",",").Replace("?","!")
                .Replace("*"," ").Replace("^","'");

            //Заполнение матрицы-ключа
            Matrix keyMatrix = new Matrix(matrixSize, matrixSize);
            for (int i = 0; i < keyMatrix.row; i++)
            {
                for (int j = 0; j < keyMatrix.column; j++)
                {
                        keyMatrix.array[i, j] = alf.IndexOf(entered_key[i * keyMatrix.column + j]); 
                }
            }

            //Проверка матрицы-ключа на обратимость
            if (keyMatrix.Determinant() == 0)
            {
                MessageBox.Show("Некорректный ключ. Матрица не обратима. Расшифрование невозможно.", "Ошибка");
                goto metka_exit;
            }
            
            //Зашифрование
            string result = "";
            int finiteFieldSize = alf.Length;
            int amount_of_crypted_symbs = 0;
            while (amount_of_crypted_symbs < Source.Length)
            {
                Matrix message = new Matrix(1, matrixSize);

                for (int i = 0; i < matrixSize; i++)
                    message.array[0,i] = alf.IndexOf(Source[i + amount_of_crypted_symbs]);

                Matrix res = message * keyMatrix;

                for (int i = 0; i < matrixSize; i++)
                    if (isUpper[i + amount_of_crypted_symbs])
                        result += ALF[Convert.ToInt32((res.array[0, i]) % finiteFieldSize)];
                    else 
                        result += alf[Convert.ToInt32((res.array[0,i]) % finiteFieldSize)];

                amount_of_crypted_symbs += matrixSize;
            }

            f11_fieldCiphertext.Text = result;
        metka_exit:;
        }

        private void f11_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            //Подготовка сообщения и ключа
            string Source = f11_fieldCiphertext.Text;
            string entered_key = f11_fieldKeyword.Text;
            string alf, ALF;
            if (f11_radioButtonRus.Checked)
            {
                Source = Regex.Replace(Source, "[^а-яА-ЯёЁ .,!*:;?]", "");
                entered_key = Regex.Replace(entered_key, "[^а-яА-ЯёЁ .,!*:;?]", "");
                alf = alf_ru;
                ALF = ALF_RU;
            }
            else
            {
                Source = Regex.Replace(Source, "[^a-zA-Z .,!'*:;?^]", "");
                entered_key = Regex.Replace(entered_key, "[^a-zA-Z .,!'*:;?^]", "");
                alf = alf_en;
                ALF = ALF_EN;
            }

            //Проверка длины ключа на квадратность
            if (!isSquare(entered_key.Length) || entered_key.Length < 4)
            {
                MessageBox.Show("Некорректный ключ. Ожидаемая длина ключа - полный квадрат>1", "Ошибка");
                goto metka_exit;
            }
            int matrixSize = Convert.ToInt32(Math.Sqrt(entered_key.Length));

            //Проверка шифртекста на соответствие длины
            if (Source.Length % matrixSize != 0)
            {
                MessageBox.Show("Некорректный шифртекст. Ожидаемая длина шифртекста кратна корню из длины ключа", "Ошибка");
                goto metka_exit;
            }

            //Приведение сообщения и ключа к корректному виду
            f11_fieldCiphertext.Text = Source;
            f11_fieldKeyword.Text = entered_key;
            entered_key = entered_key.ToLower().Replace(":", ".").Replace(";", ",").Replace("?", "!")
                 .Replace("*", " ").Replace("^", "'");

            //Сохранение регистра сообщения
            bool[] isUpper = new bool[Source.Length];
            for (int i = 0; i < Source.Length; i++)
                if (alf.IndexOf(Source[i]) >= 0)
                    isUpper[i] = false;
                else
                    isUpper[i] = true;
            Source = Source.ToLower().Replace(":", ".").Replace(";", ",").Replace("?", "!")
                 .Replace("*", " ").Replace("^", "'");

            //Заполнение матрицы-ключа
            Matrix keyMatrix = new Matrix(matrixSize, matrixSize);
            for (int i = 0; i < keyMatrix.row; i++)
            {
                for (int j = 0; j < keyMatrix.column; j++)
                {
                    keyMatrix.array[i, j] = alf.IndexOf(entered_key[i * keyMatrix.column + j]);
                }
            }

            //Проверка матрицы-ключа на обратимость
            if (keyMatrix.Determinant() == 0)
            {
                MessageBox.Show("Некорректный ключ. Матрица не обратима. Расшифрование невозможно.", "Ошибка");
                goto metka_exit;
            }

            //Обратная матрица
            Matrix antiKeyMatrix = keyMatrix.Inverse(alf.Length);

            //Расшифрование
            string result = "";
            int finiteFieldSize = alf.Length;
            int amount_of_crypted_symbs = 0;
            while (amount_of_crypted_symbs < Source.Length)
            {
                Matrix message = new Matrix(1, matrixSize);

                for (int i = 0; i < matrixSize; i++)
                    message.array[0, i] = alf.IndexOf(Source[i + amount_of_crypted_symbs]);

                Matrix res = message * antiKeyMatrix;

                for (int i = 0; i < matrixSize; i++)
                    if (isUpper[i + amount_of_crypted_symbs])
                        result += ALF[Convert.ToInt32((res.array[0, i]) % finiteFieldSize)];
                    else
                        result += alf[Convert.ToInt32((res.array[0, i]) % finiteFieldSize)];

                amount_of_crypted_symbs += matrixSize;
            }

            f11_fieldOriginal.Text = result;
        metka_exit:;
        }

        public static int Foo(int element, int fSize)
        {
            int x, y;
            int g = GCD(element, fSize, out x, out y);
            if (g != 1)
                if (g == -1)
                {
                    g = 1;
                    x = -x;
                    y = -y;
                }
            return (x % fSize + fSize) % fSize;
        } //поиск обратного элемента в поле

        public static int GCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int d = GCD(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }   //поиск НОД расширенным алгоритмом Евклида

        public class Matrix
        {
            static Random rnd = new Random();

            public Decimal[,] array;
            public int row, column;

            public int Row { get { return row; } }
            public int Column { get { return column; } }

            public void Random()
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = rnd.Next(10);
                    }
                }
            }

            public void Random(int min, int max)
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = rnd.Next(min, max);
                    }
                }
            }

            public Matrix(int row, int colunm)
            {
                this.row = row;
                this.column = colunm;
                array = new Decimal[row, column];
            }

            public Matrix Transpose()
            {
                Matrix m = new Matrix(column, row);

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        m.array[j, i] = array[i, j];
                    }
                }

                return m;
            }

            public void TransposeMyself()
            {
                array = Transpose().array;
            }

            public Matrix Inverse()
            {
                Decimal det = Determinant();
                if (det == 0)
                {
                    throw new Exception("Матрица вырождена");
                }

                Matrix m = new Matrix(row, column);

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        m.array[i, j] = Cofactor(array, i, j) / det;
                    }
                }

                return m.Transpose();
            }

            public Matrix Inverse(int finiteFieldSize)
            {
                Decimal det = Determinant();
                if (det == 0)
                {
                    throw new Exception("Матрица вырождена");
                }

                Matrix m = new Matrix(row, column);
                int antiDet = Foo(Convert.ToInt32(det), finiteFieldSize); //Элемент, обратный к определителю 

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        m.array[i, j] = (((Cofactor(array, i, j)) % finiteFieldSize * antiDet) % finiteFieldSize + finiteFieldSize) % finiteFieldSize;
                    }
                }

                return m.Transpose();
            }
            public Decimal Determinant()
            {
                if (column != row)
                {
                    throw new Exception("Расчет определителя невозможен");
                }
                return Determinant(array);
            }

            private Decimal Determinant(Decimal[,] array)
            {
                int n = (int)Math.Sqrt(array.Length);

                if (n == 1)
                {
                    return array[0, 0];
                }

                Decimal det = 0;

                for (int k = 0; k < n; k++)
                {
                    det += array[0, k] * Cofactor(array, 0, k);
                }

                return det;
            }

            private Decimal Cofactor(Decimal[,] array, int row, int column)
            {
                return Convert.ToDecimal(Math.Pow(-1, column + row)) * Determinant(Minor(array, row, column));
            }

            private Decimal[,] Minor(Decimal[,] array, int row, int column)
            {
                int n = (int)Math.Sqrt(array.Length);
                Decimal[,] minor = new Decimal[n - 1, n - 1];

                int _i = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i == row)
                    {
                        continue;
                    }
                    int _j = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == column)
                        {
                            continue;
                        }
                        minor[_i, _j] = array[i, j];
                        _j++;
                    }
                    _i++;
                }
                return minor;
            }

            public static Matrix operator +(Matrix m1, Matrix m2)
            {
                if (m1.row != m2.row || m1.column != m2.column)
                {
                    throw new Exception("Сложение невозможно");
                }

                Matrix m = new Matrix(m1.row, m1.column);

                for (int i = 0; i < m1.row; i++)
                {
                    for (int j = 0; j < m1.column; j++)
                    {
                        m.array[i, j] = m1.array[i, j] + m2.array[i, j];
                    }
                }

                return m;
            }

            public static Matrix operator -(Matrix m1, Matrix m2)
            {
                if (m1.row != m2.row || m1.column != m2.column)
                {
                    throw new Exception("Вычитание невозможно");
                }

                Matrix m = new Matrix(m1.row, m1.column);

                for (int i = 0; i < m1.row; i++)
                {
                    for (int j = 0; j < m1.column; j++)
                    {
                        m.array[i, j] = m1.array[i, j] - m2.array[i, j];
                    }
                }

                return m;
            }

            public static Matrix operator *(Matrix m1, Matrix m2)
            {
                if (m1.column != m2.row)
                {
                    throw new Exception("Умножение невозможно");
                }

                Matrix m = new Matrix(m1.row, m2.column);

                for (int i = 0; i < m1.row; i++)
                {
                    for (int j = 0; j < m2.column; j++)
                    {
                        decimal sum = 0;

                        for (int k = 0; k < m1.column; k++)
                        {
                            sum += m1.array[i, k] * m2.array[k, j];
                        }

                        m.array[i, j] = sum;
                    }
                }

                return m;
            }

            public override string ToString()
            {
                string str = "";

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        str += array[i, j] + "\t";
                    }
                    str += "\n";
                }

                return str;
            }
        }
    }
}
