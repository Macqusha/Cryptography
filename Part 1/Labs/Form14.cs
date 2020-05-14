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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        public string alf_en = "abcdefghijklmnopqrstuvwxyz";
        public string alf_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string alf_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        //Тест 1 русский
        public double[] freqs_ru = { 0.062,0.014,0.038,0.013,0.025,0.072,0.0001,0.007,0.016,0.062,0.01,0.028,0.035,0.026,0.053,
            0.09,0.023,0.04,0.045,0.053,0.021,0.002,0.009,0.004,0.012,0.006,0.003,0.0004,0.016,0.014,0.003,0.006,0.018};
        //Тест 1 английский
        public double[] freqs_en = {0.081,0.016,0.032,0.036,0.123,0.023,0.016,0.051,0.071,0.001,0.005,0.04,0.022,0.072,
            0.079,0.023,0.002,0.06,0.066,0.096,0.031,0.009,0.02,0.002,0.019,0.001};
        //Тест 4 русский
        char[,] forbidden_pairs_ru = {{'а','ъ'},{'а','ы'},{'а','ь'},{'б','й'},{'в','й'},{'в','э'},{'г','й'},{'г','ф'},{'г','х'},{'г','ъ'},{'г','ь'},{'г','э'},{'д','й'},
            {'е','ъ'},{'е','ы'},{'е','ь'},{'е','э'},{'ё','а'},{'ё','е'},{'ё','ё'},{'ё','и'},{'ё','о'},{'ё','у'},{'ё','ф'},{'ё','ъ'},{'ё','ъ'},{'ё','ы'},{'ё','ь'},
            {'ё','э'},{'ё','я'},{'ж','ё'},{'ж','ф'},{'ж','х'},{'ж','ш'},{'ж','щ'},{'ж','ы'},{'ж','э'},{'з','й'},{'з','щ'},{'и','ъ'},{'и','ы'},{'и','ь'},{'й','а'},
            {'й','ё'},{'й','ж'},{'й','а'},{'й','1'},{'й','ъ'},{'й','ы'},{'й','ь'},{'й','э'},{'к','й'},{'к','щ'},{'к','ъ'},{'к','ь'},{'л','й'},{'л','ъ'},{'л','э'},
            {'м','й'},{'м','ъ'},{'н','й'},{'о','ъ'},{'о','ы'},{'о','ь'},{'п','в'},{'п','г'},{'п','ж'},{'п','з'},{'п','й'},{'п','ъ'},{'р','ъ'},{'с','й'},{'т','й'},
            {'у','ъ'},{'у','ы'},{'у','ь'},{'ф','б'},{'ф','ж'},{'ф','з'},{'ф','й'},{'ф','п'},{'ф','х'},{'ф','ц'},{'ф','ъ'},{'ф','э'},{'х','ё'},{'х','ж'},{'х','й'},
            {'х','щ'},{'х','ы'},{'х','ь'},{'х','ю'},{'х','я'},{'ц','б'},{'ц','ё'},{'ц','ж'},{'ц','й'},{'ц','ф'},{'ц','х'},{'ц','ч'},{'ц','щ'},{'ц','ъ'},{'ц','ь'},
            {'ц','э'},{'ц','ю'},{'ц','я'},{'ч','б'},{'ч','г'},{'ч','з'},{'ч','й'},{'ч','п'},{'ч','ф'},{'ч','щ'},{'ч','ъ'},{'ч','ы'},{'ч','э'},{'ч','ю'},{'ч','я'},
            {'ш','д'},{'ш','ж'},{'ш','з'},{'ш','й'},{'ш','ш'},{'ш','щ'},{'ш','ъ'},{'ш','ы'},{'ш','э'},{'щ','б'},{'щ','г'},{'щ','д'},{'щ','ж'},{'щ','з'},{'щ','й'},
            {'щ','л'},{'щ','п'},{'щ','т'},{'щ','ф'},{'щ','х'},{'щ','ц'},{'щ','ч'},{'щ','ш'},{'щ','щ'},{'щ','ъ'},{'щ','ы'},{'щ','э'},{'щ','ю'},{'щ','я'},{'ъ','а'},
            {'ъ','б'},{'ъ','в'},{'ъ','г'},{'ъ','д'},{'ъ','ж'},{'ъ','з'},{'ъ','и'},{'ъ','ё'},{'ъ','к'},{'ъ','л'},{'ъ','м'},{'ъ','н'},{'ъ','о'},{'ъ','п'},{'ъ','р'},
            {'ъ','с'},{'ъ','т'},{'ъ','у'},{'ъ','ф'},{'ъ','х'},{'ъ','ц'},{'ъ','ч'},{'ъ','ш'},{'ъ','щ'},{'ъ','ъ'},{'ъ','ы'},{'ъ','ь'},{'ъ','э'},{'ы','а'},{'ы','ё'},
            {'ы','о'},{'ы','ф'},{'ы','ъ'},{'ы','ы'},{'ы','ь'},{'ы','э'},{'ь','а'},{'ь','й'},{'ь','л'},{'ь','у'},{'ь','ъ'},{'ь','ы'},{'ь','ь'},{'э','а'},{'э','е'},
            {'э','ё'},{'э','ц'},{'э','ч'},{'э','ъ'},{'э','ы'},{'э','ь'},{'э','э'},{'э','ю'},{'ю','у'},{'ю','ъ'},{'ю','ы'},{'ю','ь'},{'я','а'},{'я','ё'},{'я','о'},
            {'я','ъ'},{'я','ы'},{'я','ь'},{'я','э'}};
        //Тест 4 английский
        char[,] forbidden_pairs_en = {{'q','a'},{'q','b'},{'q','c'},{'q','d'},{'q','e'},{'q','f'},{'q','g'},{'q','h'},{'q','i'},{'q','j'},{'q','k'},{'q','l'},{'q','m'},
            {'q','n'},{'q','o'},{'q','p'},{'q','q'},{'q','r'},{'q','s'},{'q','t'},{'q','v'},{'q','w'},{'q','x'},{'q','y'},{'q','z'},{'j','x'},{'x','z'},{'z','x'},{'j','z'},
            {'j','x'},{'v','x'},{'b','x'},{'w','x'},{'k','x'},{'c','x'},{'j','q'},{'v','q'},{'x','q'},{'b','q'},{'z','q'},{'j','y'},{'p','x'},{'z','j'},{'h','x'},{'b','z'},
            {'j','v'},{'p','z'},{'x','j'},{'k','z'}};

        private void f14_ButtonClearCiphertext_Click(object sender,EventArgs e)
        {
             f14_fieldCiphertext.Text = null;
        }

        private void f14_ButtonClearOriginal_Click(object sender,EventArgs e)
        {
            f14_fieldOriginal.Text = null;
        }

        private void f14_ButtonReadCiphertext_Click(object sender,EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "14_in.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = myDialog.OpenFile()) != null)
                    {
                        textFromFile = new StreamReader(myStream,Encoding.GetEncoding(1251)).ReadToEnd();
                        myStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            f14_fieldCiphertext.Text = textFromFile;
        }

        private void f14_ButtonSaveOriginal_Click(object sender,EventArgs e)
        {
            StreamWriter myStream = null;
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "14_out.txt";
            myDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            myDialog.FilterIndex = 2;
            myDialog.RestoreDirectory = true;

            if (myDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = new StreamWriter(myDialog.OpenFile(),Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f14_fieldOriginal.Text));
                    myStream.Close();
                }
            }
        }

        private void f14_Ciphertext_Changed(object sender, EventArgs e)
        {
            f14_numRotate.Value = 1;
            f14_numRotate.Value = 0;
            f14_key1.Text = null;
            f14_key2.Text = null;
            f14_key3.Text = null;
            f14_dataGridView.RowCount = 1;
            f14_Table_Chart_func();
        }

        //Вывод результата по предполагаемому сдвигу
        private void f14_Rotate_ValueChanged(object sender,EventArgs e)
        {
            int rot = Convert.ToInt32(f14_numRotate.Value);
            if (rot < 0 || rot > 33)
            {
                MessageBox.Show("Некорректное значение.");
            }
            else
            {
                string Source = f14_fieldCiphertext.Text;
                char[] Code = Source.ToCharArray();
                int rotRU = (33 - rot) % 33;
                int rotEN = (26 - (rot % 26)) % 26;

                for (int i = 0; i < Code.Length; i++)
                {
                    int tmp = Convert.ToInt16(Code[i]); // Код текущего символа 
                    if ((tmp >= 65 && tmp <= 90) || (tmp >= 97 && tmp <= 122)) //Английские заглавные и строчные
                    {
                        tmp = tmp + rotEN;
                        if (tmp > 122 || (tmp > 90 && (tmp - rotEN < 91))) tmp = tmp - 26;

                        Code[i] = Convert.ToChar(tmp);
                    }
                    else if ((tmp >= 1040 && tmp <= 1071) || tmp == 1025) //Русские заглавные 
                    {
                        string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (ALF.IndexOf(tmp2) + rotRU) % 33;
                        tmp2 = ALF[tmp];
                        Code[i] = tmp2;
                    }
                    else if ((tmp >= 1072 && tmp <= 1103) || tmp == 1105) //Русские строчные
                    {
                        string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                        char tmp2 = Convert.ToChar(tmp);
                        tmp = (alf.IndexOf(tmp2) + rotRU) % 33;
                        tmp2 = alf[tmp];
                        Code[i] = tmp2;
                    }
                }
                string txt = new string(Code);
                f14_fieldOriginal.Text = txt;

                f14_Table_Chart_func();
            }
        }

        //Вывод результата подсчета в поле предполагаемого сдвига
        private void f14_key1_TextChanged(object sender,EventArgs e)
        {
            if (f14_key1.Text != "") f14_numRotate.Value = Convert.ToInt32(f14_key1.Text);
        }

        //Основной расчет
        private void f14_buttonCountKey_Click(object sender,EventArgs e)
        {
            int rot = Convert.ToInt32(f14_numRotate.Value);
            if (rot < 0 || rot > 33)
            {
                MessageBox.Show("Некорректное значение.");
            }
            else
            {
                double[] probability = new double[33];

                for (int k = 0; k < 33; k++)
                {
                    if (!(f14_check1.Checked || f14_check2.Checked || f14_check3.Checked || f14_check4.Checked || f14_check5.Checked))
                    {
                        MessageBox.Show("Не выбрано ни одного параметра", "Ошибка");
                        goto metka_noparams;
                    }

                    string Source = f14_fieldCiphertext.Text;
                    char[] Code = Source.ToCharArray();
                    int rotRU = k;
                    int rotEN = (26 - k) % 26;
                    for (int i = 0; i < Code.Length; i++)
                    {
                        int tmp = Convert.ToInt16(Code[i]); // Код текущего символа 
                        if ((tmp >= 65 && tmp <= 90) || (tmp >= 97 && tmp <= 122)) //Английские заглавные и строчные
                        {
                            tmp = tmp + rotEN;
                            if (tmp > 122 || (tmp > 90 && (tmp - rotEN < 91))) tmp = tmp - 26;

                            Code[i] = Convert.ToChar(tmp);
                        }
                        else if ((tmp >= 1040 && tmp <= 1071) || tmp == 1025) //Русские заглавные 
                        {
                            char tmp2 = Convert.ToChar(tmp);
                            tmp = (alf_RU.IndexOf(tmp2) - rotRU + 33) % 33;
                            tmp2 = alf_RU[tmp];
                            Code[i] = tmp2;
                        }
                        else if ((tmp >= 1072 && tmp <= 1103) || tmp == 1105) //Русские строчные
                        {
                            char tmp2 = Convert.ToChar(tmp);
                            Code[i] = alf_ru[(alf_ru.IndexOf(tmp2) - rotRU + 33) % 33];
                        }
                    }
                    string possibleText = new string(Code);
                    possibleText = possibleText.ToLower(); //Нет необходимости хранить регистр

                    //Анализ полученной строки
                    double mistake = (double)f14_numMistake.Value; //Погрешность частоты,при которой частота считается приемлемой

                    int[] times_ru = new int[alf_ru.Length];    //Массив подсчета вхождений каждой буквы 
                    int[] times_en = new int[alf_en.Length];
                    Array.Clear(times_ru, 0, alf_ru.Length);
                    Array.Clear(times_en, 0, alf_en.Length);

                    //Подсчитаем количество русских и английских букв, количество их вхождений
                    int amount_ru = 0, amount_en = 0;
                    for (int i = 0; i < possibleText.Length; i++)
                    {
                        if (alf_ru.IndexOf(possibleText[i]) >= 0)
                        {
                            amount_ru++;
                            times_ru[alf_ru.IndexOf(possibleText[i])]++;
                        }
                        if (alf_en.IndexOf(possibleText[i]) >= 0)
                        {
                            amount_en++;
                            times_en[alf_en.IndexOf(possibleText[i])]++;
                        }
                    }

                    if (amount_ru != 0) //Проверки,свойственные русскому
                    {
                        if (f14_check1.Checked) 
                        {
                            //За каждую букву с частотой,отличающейся от статистической не менее чем на погрешность,добавим частотность в квадрате к вероятности шифра.
                            for (int i = 0; i < alf_ru.Length; i++)
                            {
                                double frq = (double)times_ru[i] / amount_ru;
                                if ((frq - mistake * freqs_ru[i] <= freqs_ru[i]) && (frq + mistake * freqs_ru[i] >= freqs_ru[i]))
                                    probability[k] += (freqs_ru[i]) * (freqs_ru[i]);
                            }
                        }

                        if (f14_check2.Checked)
                        {
                            //Дополнительные баллы вероятности за популярные биграммы
                            if (possibleText.IndexOf("ов") >= 0) probability[k] += 0.00081;
                            if (possibleText.IndexOf("ст") >= 0) probability[k] += 0.00080;
                            if (possibleText.IndexOf("но") >= 0) probability[k] += 0.00063;
                            if (possibleText.IndexOf("ко") >= 0) probability[k] += 0.00062;
                            if (possibleText.IndexOf("ен") >= 0) probability[k] += 0.00061;
                            if (possibleText.IndexOf("во") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("то") >= 0) probability[k] += 0.00056;
                            if (possibleText.IndexOf("ро") >= 0) probability[k] += 0.00054;
                            if (possibleText.IndexOf("ра") >= 0) probability[k] += 0.00053;
                            if (possibleText.IndexOf("на") >= 0) probability[k] += 0.00052;
                            if (possibleText.IndexOf("го") >= 0) probability[k] += 0.00050;
                            if (possibleText.IndexOf("ос") >= 0) probability[k] += 0.00048;
                            if (possibleText.IndexOf("нн") >= 0) probability[k] += 0.00023;
                            if (possibleText.IndexOf("ии") >= 0) probability[k] += 0.00018;
                            if (possibleText.IndexOf("сс") >= 0) probability[k] += 0.00011;
                        }

                        if (f14_check3.Checked)
                        {
                            //Дополнительные баллы вероятности за популярные триграммы
                            if (possibleText.IndexOf("сто") >= 0) probability[k] += 0.00081;
                            if (possibleText.IndexOf("ено") >= 0) probability[k] += 0.00080;
                            if (possibleText.IndexOf("нов") >= 0) probability[k] += 0.00063;
                            if (possibleText.IndexOf("тов") >= 0) probability[k] += 0.00062;
                            if (possibleText.IndexOf("ово") >= 0) probability[k] += 0.00061;
                            if (possibleText.IndexOf("ова") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("ков") >= 0) probability[k] += 0.00057;
                        }

                        if (f14_check4.Checked)
                        {
                            //За каждое недопустимое сочетание обнулим вероятность шифра
                            for (int i = 0; i < forbidden_pairs_ru.Length / 2; i++)
                            {
                                string s = Convert.ToString(forbidden_pairs_ru[i, 0]) + Convert.ToString(forbidden_pairs_ru[i, 1]);
                                if (possibleText.IndexOf(s) >= 0)
                                    probability[k] = -1;
                            }
                        }

                        if (f14_check5.Checked)
                        {
                            //За каждоую недопустимую букву в начале или конце слова обнулим вероятность шифра
                            var words = (possibleText).Split(new char[] { ' ', ',', '.', ':', ';', '?', '!','&'}, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (words[i][0] == 'ъ') probability[k] = -1; //Первая буква - ъ
                                if (words[i][0] == 'ь') probability[k] = -1; //Первая буква - ь
                                if (words[i][words[i].Length - 1] == 'ъ') probability[k] = -1; //Последняя буква - ъ

                                //Проверим одиночные буквы (предлоги, союзы, частицы и местоимения)
                                string cantBeAlone = "бгдеёжзлмнпртфхцчшщъыьэю";
                                if (words[i].Length == 1)
                                {
                                    if (cantBeAlone.IndexOf(words[i][0]) >= 0) probability[k] = -1; //Есть однобуквенное слово, которое не существует
                                }
                            }                                 
                        }

                    }

                    if (amount_en != 0) //Проверки,свойственные английскому
                    {
                        if (amount_ru == 0) // Если русских букв нет, сдвиги от 26 до 32 не учитываем
                            for (int i = 26; i < 33; i++)
                            {
                                probability[i] = -1;
                            }

                        if (f14_check1.Checked)
                        {
                            //За каждую букву с частотой,отличающейся от статистической не менее чем на погрешность,добавим частотность в квадрате к вероятности шифра.
                            for (int i = 0; i < alf_en.Length; i++)
                            {
                                double frq = (double)times_en[i] / amount_en;
                                if ((frq - mistake * freqs_en[i] <= freqs_en[i]) && (frq + mistake * freqs_en[i] >= freqs_en[i]))
                                    probability[k] += (freqs_en[i]) * (freqs_en[i]);
                            }
                        }

                        if (f14_check2.Checked)
                        {
                            //Дополнительные баллы вероятности за популярные биграммы
                            if (possibleText.IndexOf("th") >= 0) probability[k] += 0.00117;
                            if (possibleText.IndexOf("he") >= 0) probability[k] += 0.00101;
                            if (possibleText.IndexOf("in") >= 0) probability[k] += 0.00088;
                            if (possibleText.IndexOf("er") >= 0) probability[k] += 0.00077;
                            if (possibleText.IndexOf("an") >= 0) probability[k] += 0.00070;
                            if (possibleText.IndexOf("re") >= 0) probability[k] += 0.00061;
                            if (possibleText.IndexOf("es") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("on") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("st") >= 0) probability[k] += 0.00054;
                            if (possibleText.IndexOf("nt") >= 0) probability[k] += 0.00051;
                            if (possibleText.IndexOf("en") >= 0) probability[k] += 0.00049;
                            if (possibleText.IndexOf("at") >= 0) probability[k] += 0.00048;
                            if (possibleText.IndexOf("ed") >= 0) probability[k] += 0.00047;
                            if (possibleText.IndexOf("nd") >= 0) probability[k] += 0.00046;
                            if (possibleText.IndexOf("to") >= 0) probability[k] += 0.00046;
                            if (possibleText.IndexOf("or") >= 0) probability[k] += 0.00046;
                            if (possibleText.IndexOf("ea") >= 0) probability[k] += 0.00043;
                            if (possibleText.IndexOf("ti") >= 0) probability[k] += 0.00043;
                            if (possibleText.IndexOf("ar") >= 0) probability[k] += 0.00042;
                            if (possibleText.IndexOf("te") >= 0) probability[k] += 0.00042;
                            if (possibleText.IndexOf("ng") >= 0) probability[k] += 0.00039;
                        }

                        if (f14_check3.Checked)
                        {
                            //Дополнительные баллы вероятности за популярные триграммы
                            if (possibleText.IndexOf("the") >= 0) probability[k] += 0.00117;
                            if (possibleText.IndexOf("and") >= 0) probability[k] += 0.00101;
                            if (possibleText.IndexOf("ing") >= 0) probability[k] += 0.00088;
                            if (possibleText.IndexOf("her") >= 0) probability[k] += 0.00077;
                            if (possibleText.IndexOf("hat") >= 0) probability[k] += 0.00070;
                            if (possibleText.IndexOf("his") >= 0) probability[k] += 0.00061;
                            if (possibleText.IndexOf("tha") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("ere") >= 0) probability[k] += 0.00057;
                            if (possibleText.IndexOf("for") >= 0) probability[k] += 0.00054;
                            if (possibleText.IndexOf("ent") >= 0) probability[k] += 0.00051;
                        }

                        if (f14_check4.Checked)
                        {
                            //За каждое недопустимое сочетание обнулим вероятность шифра
                            for (int i = 0; i < forbidden_pairs_en.Length / 2; i++)
                            {
                                string s = Convert.ToString(forbidden_pairs_en[i, 0]) + Convert.ToString(forbidden_pairs_en[i, 1]);
                                if (possibleText.IndexOf(s) >= 0)// 
                                    probability[k] = -1;
                            }

                        }

                        if (f14_check5.Checked)
                        {
                            //За каждоую недопустимую букву в начале или конце слова обнулим вероятность шифра
                            var words = (possibleText).Split(new char[] { ' ', ',', '.', ':', ';', '?', '!', '&' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (words[i][words[i].Length - 1] == 'v') probability[k] = -1; //Последняя буква - v
                                if (words[i][words[i].Length - 1] == 'q') probability[k] = -1; //Последняя буква - q

                                //Проверим одиночные буквы (предлоги, союзы, частицы и местоимения)
                                string cantBeAlone = "bcdfhjklmnpqrstuvwxyz";
                                if (words[i].Length == 1)
                                {
                                    if (cantBeAlone.IndexOf(words[i][0]) >= 0) probability[k] = -1; //Есть однобуквенное слово, которое не существует
                                }
                            }
                        }
                    }

                }

                
                //Дополнительный массив для сортировки и учета неподходящих ключей
                int[] whatRot = new int[33];
                for (int i = 0; i < 33; i++)
                {
                    whatRot[i] = i;
                    if (probability[i] == -1) whatRot[i] = -1;
                }    
                //Сортировка
                for (int i = 0; i < 33; i++)
                {
                    for (int j = i + 1; j < 33; j++)
                    {
                        if (probability[i] > probability[j])
                        {
                            double tmp = probability[i];
                            probability[i] = probability[j];
                            probability[j] = tmp;

                            int tmp1 = whatRot[i];
                            whatRot[i] = whatRot[j];
                            whatRot[j] = tmp1;
                        }
                    }
                }
                //Вывод результатов
                if (whatRot[32] != -1) f14_key1.Text = Convert.ToString(whatRot[32]);
                else { MessageBox.Show("Нет корректных текстов."); f14_key1.Text = null; }
                if (whatRot[31] != -1) f14_key2.Text = Convert.ToString(whatRot[31]); else f14_key2.Text = null; ;
                if (whatRot[30] != -1) f14_key3.Text = Convert.ToString(whatRot[30]); else f14_key3.Text = null; ;
                
            metka_noparams:;
            }

        }

        private void f14_Table_Chart_func()
        {
            int[] times_ru = new int[alf_ru.Length];    //Массив подсчета вхождений каждой буквы 
            int[] times_en = new int[alf_en.Length];
            Array.Clear(times_ru, 0, alf_ru.Length);
            Array.Clear(times_en, 0, alf_en.Length);

            string analyzedText = f14_fieldOriginal.Text.ToLower();

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

            f14_dataGridView.ColumnCount = 4;
            f14_dataGridView.RowCount = 1;
            int real_index = 0;
            for (int i = 0; i < times_ru.Length; i++)
            {
                if (times_ru[i] > 0)
                {
                    f14_dataGridView.RowCount++;
                    f14_dataGridView.Rows[real_index].Cells[0].Value = alf_ru[i];
                    f14_dataGridView.Rows[real_index].Cells[1].Value = times_ru[i];
                    f14_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_ru[i] / amount_ru, 6); //округлим до 6 знаков после ,
                    f14_dataGridView.Rows[real_index].Cells[3].Value = freqs_ru[i];
                    real_index++;
                }
            }
            for (int i = 0; i < times_en.Length; i++)
            {
                if (times_en[i] > 0)
                {
                    f14_dataGridView.RowCount++;
                    f14_dataGridView.Rows[real_index].Cells[0].Value = alf_en[i];
                    f14_dataGridView.Rows[real_index].Cells[1].Value = times_en[i];
                    f14_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_en[i] / amount_en, 6); //округлим до 6 знаков после ,
                    f14_dataGridView.Rows[real_index].Cells[3].Value = freqs_en[i];
                    real_index++;
                }
            }

            //Заполнение гистограммы
            f14_chart.Series[0].Points.Clear(); //Очистка старых точек
            if (amount_ru > 0)
            {
                for (int i = 0; i < times_ru.Length; i++)
                {
                    f14_chart.Series[0].Points.Add(times_ru[i]);
                }
            }
            if (amount_en > 0)
            {
                for (int i = 0; i < times_en.Length; i++)
                {
                    f14_chart.Series[0].Points.Add(times_en[i]);
                }
            }
            
        }

        private void f14_buttonExtended_Click(object sender, EventArgs e)
        {
            Hide();
            new Form14_2().ShowDialog();
            Show();
        }
    }
}
