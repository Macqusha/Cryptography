using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form14_2 : Form
    {
        public Form14_2()
        {
            InitializeComponent();
        }

        public string alf_en = "abcdefghijklmnopqrstuvwxyz";
        public string alf_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string alf_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string alf_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public double[] freqs_ru = { 0.062,0.014,0.038,0.013,0.025,0.072,0.0001,0.007,0.016,0.062,0.01,0.028,0.035,0.026,0.053,
            0.09,0.023,0.04,0.045,0.053,0.021,0.002,0.009,0.004,0.012,0.006,0.003,0.0004,0.016,0.014,0.003,0.006,0.018};
        public double[] freqs_en = { 0.081,0.016,0.032,0.036,0.123,0.023,0.016,0.051,0.071,0.001,0.005,0.04,0.022,0.072,
            0.079,0.023,0.002,0.06,0.066,0.096,0.031,0.009,0.02,0.002,0.019,0.001};
        public string oftenAlf_en = "etaonisrhldcupfmwygbvkzxqj";
        public string oftenAlf_ru = "оеиатнсрвлкмдпуяызьбгчйхжюшцэщфъё";

        private void f14_2_ButtonReadCiphertext_Click(object sender, EventArgs e)
        {
            string textFromFile = "";
            Stream myStream = null;
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.InitialDirectory = "D:\\Учеба\\Крипта\\Labs\\Labs\\bin\\Debug\\TextFiles";
            myDialog.DefaultExt = "txt";
            myDialog.FileName = "14_in_en.txt";
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
            f14_2_fieldCiphertext.Text = textFromFile;
            f14_2_fieldOriginal.Text = null;
            f14_2_fieldKey.Text = null;
            f14_2_key1.Text = null;
            f14_2_key2.Text = null;
            f14_2_key3.Text = null;
            f14_2_fieldKey.Text = "1";
            f14_2_fieldKey.Text = null;
        }

        private void f14_2_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f14_2_fieldCiphertext.Text = null;
        }

        private void f14_2_ButtonSaveOriginal_Click(object sender, EventArgs e)
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
                if ((myStream = new StreamWriter(myDialog.OpenFile(), Encoding.GetEncoding(1251))) != null)
                {
                    myStream.WriteLine(Convert.ToString(f14_2_fieldOriginal.Text));
                    myStream.Close();
                }
            }
        }

        private void f14_2_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f14_2_fieldOriginal.Text = null;
        }

        private void f14_2_useKey1_Click(object sender, EventArgs e)
        {
            f14_2_fieldKey.Text = f14_2_key1.Text;
        }

        private void f14_2_useKey2_Click(object sender, EventArgs e)
        {
            f14_2_fieldKey.Text = f14_2_key2.Text;
        }

        private void f14_2_useKey3_Click(object sender, EventArgs e)
        {
            f14_2_fieldKey.Text = f14_2_key3.Text;
        }

        private void f14_Table_Chart_func()
        {
            int[] times_ru = new int[alf_ru.Length];    //Массив подсчета вхождений каждой буквы 
            int[] times_en = new int[alf_en.Length];
            Array.Clear(times_ru, 0, alf_ru.Length);
            Array.Clear(times_en, 0, alf_en.Length);

            string analyzedText = f14_2_fieldOriginal.Text.ToLower();

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

            f14_2_dataGridView.ColumnCount = 4;
            f14_2_dataGridView.RowCount = 1;
            int real_index = 0;
            for (int i = 0; i < times_ru.Length; i++)
            {
                if (times_ru[i] > 0)
                {
                    f14_2_dataGridView.RowCount++;
                    f14_2_dataGridView.Rows[real_index].Cells[0].Value = alf_ru[i];
                    f14_2_dataGridView.Rows[real_index].Cells[1].Value = times_ru[i];
                    f14_2_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_ru[i] / amount_ru, 6); //округлим до 6 знаков после ,
                    f14_2_dataGridView.Rows[real_index].Cells[3].Value = freqs_ru[i];
                    real_index++;
                }
            }
            for (int i = 0; i < times_en.Length; i++)
            {
                if (times_en[i] > 0)
                {
                    f14_2_dataGridView.RowCount++;
                    f14_2_dataGridView.Rows[real_index].Cells[0].Value = alf_en[i];
                    f14_2_dataGridView.Rows[real_index].Cells[1].Value = times_en[i];
                    f14_2_dataGridView.Rows[real_index].Cells[2].Value = Math.Round((double)times_en[i] / amount_en, 6); //округлим до 6 знаков после ,
                    f14_2_dataGridView.Rows[real_index].Cells[3].Value = freqs_en[i];
                    real_index++;
                }
            }

            //Заполнение гистограммы
            f14_2_chart.Series[0].Points.Clear(); //Очистка старых точек
            if (amount_ru > 0)
            {
                for (int i = 0; i < times_ru.Length; i++)
                {
                    f14_2_chart.Series[0].Points.Add(times_ru[i]);
                }
            }
            if (amount_en > 0)
            {
                for (int i = 0; i < times_en.Length; i++)
                {
                    f14_2_chart.Series[0].Points.Add(times_en[i]);
                }
            }

        }

        private void f14_2_fieldOriginal_TextChanged(object sender, EventArgs e)
        {
            f14_Table_Chart_func();
        }

        private void f14_2_fieldKey_TextChanged(object sender, EventArgs e)
        {
            //Проверим шифртекст
            bool isTextCorrect = true;
            int languagesCode = 0; // +1 русский +2 английский +3 мешанина

            for (int i = 0; i < f14_2_fieldCiphertext.TextLength; i++)
            {
                if (alf_ru.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0 || alf_RU.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //символ русский
                {
                    if (languagesCode == 0 || languagesCode == 2) languagesCode++; //русский еще не был учтен - учтем
                }
                else //символ не русский
                {
                    if (alf_en.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0 || alf_EN.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //символ русский
                    {
                        if (languagesCode == 0 || languagesCode == 1) languagesCode += 2; //английский еще не был учтен - учтем
                    }
                }
            }
            //Используется 0 или 2 алфавита?
            if (languagesCode == 0 || languagesCode == 3) isTextCorrect = false;
            //Если используется один алфавит, отобразим для него поля замены
            if (languagesCode == 1)
            {
                f14_2_alf.Text = alf_ru;
                f14_2_alf2.Text = alf_ru;
            }
            if (languagesCode == 2)
            {
                f14_2_alf.Text = alf_en;
                f14_2_alf2.Text = alf_en;
            }

            //Проверим ключ
            f14_2_fieldKey.Text.ToLower();
            bool isKeyCorrect = true;
            for (int i = 0; i < f14_2_fieldKey.TextLength; i++)
            {
                //Тест русский, а ключ содержит английский символ
                if (languagesCode == 1 && alf_en.IndexOf(f14_2_fieldKey.Text[i]) >= 0) isKeyCorrect = false;
                //Тест английский, а ключ содержит русский символ
                if (languagesCode == 2 && alf_ru.IndexOf(f14_2_fieldKey.Text[i]) >= 0) isKeyCorrect = false;
                //Символ встречается более одного раза
                if (f14_2_fieldKey.Text.IndexOf(f14_2_fieldKey.Text[i]) != f14_2_fieldKey.Text.LastIndexOf(f14_2_fieldKey.Text[i])) isKeyCorrect = false;
            }
            //Длина ключа не соответствует длине алфавита
            if (languagesCode == 1 && f14_2_fieldKey.TextLength != alf_ru.Length) isKeyCorrect = false;
            if (languagesCode == 2 && f14_2_fieldKey.TextLength != alf_en.Length) isKeyCorrect = false;
            
            if (isTextCorrect && isKeyCorrect)
            {
                string result = "";
                //Выберем алфавит
                string alf = "";
                string ALF = "";
                if (languagesCode == 1)
                {
                    alf = alf_ru;
                    ALF = alf_RU;
                }
                if (languagesCode == 2)
                {
                    alf = alf_en;
                    ALF = alf_EN;
                }
                //Осуществляем замену
                for (int i = 0; i < f14_2_fieldCiphertext.TextLength; i++)
                {
                    if (alf.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //строчная буква
                    {
                        result += f14_2_fieldKey.Text[alf.IndexOf(f14_2_fieldCiphertext.Text[i])];
                    }
                    else
                    {
                        if (ALF.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //заглавная буква
                        {
                            result += f14_2_fieldKey.Text[ALF.IndexOf(f14_2_fieldCiphertext.Text[i])].ToString().ToUpper();
                        }
                        else //не буква
                        {
                            result += f14_2_fieldCiphertext.Text[i];
                        }
                    }
                }
                f14_2_fieldOriginal.Text = Convert.ToString(result);
            }
            if (f14_2_fieldKey.Text == "") f14_2_fieldOriginal.Text = null;
        }

        private void f14_buttonCountKey_Click(object sender, EventArgs e)
        {
            //Проверим шифртекст
            bool isTextCorrect = true;
            int languagesCode = 0; // +1 русский +2 английский +3 мешанина

            for (int i = 0; i < f14_2_fieldCiphertext.TextLength; i++)
            {
                if (alf_ru.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0 || alf_RU.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //символ русский
                {
                    if (languagesCode == 0 || languagesCode == 2) languagesCode++; //русский еще не был учтен - учтем
                }
                else //символ не русский
                {
                    if (alf_en.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0 || alf_EN.IndexOf(f14_2_fieldCiphertext.Text[i]) >= 0) //символ русский
                    {
                        if (languagesCode == 0 || languagesCode == 1) languagesCode += 2; //английский еще не был учтен - учтем
                    }
                }
            }
            //Используется 0 или 2 алфавита?
            if (languagesCode == 0 || languagesCode == 3) isTextCorrect = false;
            //Если используется один алфавит, сохраним его и отобразим для него поля замены 
            string alf = "", ALF = "", oftenAlf = "";
            int popularLetterRot = 0;
            if (languagesCode == 1)
            {
                f14_2_alf.Text = alf_ru;
                f14_2_alf2.Text = alf_ru;
                alf = alf_ru;
                ALF = alf_RU;
                oftenAlf = oftenAlf_ru;
            }
            if (languagesCode == 2)
            {
                f14_2_alf.Text = alf_en;
                f14_2_alf2.Text = alf_en;
                alf = alf_en;
                ALF = alf_EN;
                oftenAlf = oftenAlf_en;
            }

            //Проверим ключ
            if (isTextCorrect)
            {
                //Проанализируем данный шифртекст
                string cipherText = f14_2_fieldCiphertext.Text.ToLower();
                //Массив подсчета вхождений каждой буквы 
                int[] times = new int[alf.Length];
                Array.Clear(times, 0, times.Length);
                for (int i = 0; i < cipherText.Length; i++)
                {
                    if (alf.IndexOf(cipherText[i]) >= 0)
                    {
                        times[alf.IndexOf(cipherText[i])]++;
                    }
                }

                //ФОРМИРУЕМ КЛЮЧ №1
                char[] key1 = alf.ToCharArray();
                int [] isMoreOften = new int [key1.Length];
                for (int i = 0; i < alf.Length; i++)    //для каждого символа проверим, сколько символов встречаются чаще него
                {                    
                    for (int j = 0; j < alf.Length; j++) 
                    {
                        if (times[i] < times[j]) isMoreOften[i]++;
                    }
                }
                int mark = 0;
                int[] isMarked = new int[key1.Length];
                Array.Clear(isMarked, 0, key1.Length);
                while (times.Max() != -1)    //Пометим порядок убывания частоты символов
                {
                    for (int i = 0; i < alf.Length; i++)
                    {
                        if (times[i] == times.Max() && times.Max() != -1)
                        {
                            times[i] = -1;
                            isMarked[i] = mark;
                            mark++;
                        }
                    }
                }

                string result = "";
                for (int i = 0; i < key1.Length; i++)
                {
                    result += oftenAlf[isMarked[i]];
                }
                f14_2_key1.Text = Convert.ToString(result);

                //ФОРМИРУЕМ КЛЮЧ №2
                //Пересчитаем испорченный массив times
                Array.Clear(times, 0, times.Length);
                for (int i = 0; i < cipherText.Length; i++)
                {
                    if (alf.IndexOf(cipherText[i]) >= 0)
                    {
                        times[alf.IndexOf(cipherText[i])]++;
                    }
                }
                
                char[] key2 = alf.ToCharArray();
                int[] isMoreOften2 = new int[key2.Length];
                for (int i = 0; i < alf.Length; i++)    //для каждого символа проверим, сколько символов встречаются чаще него
                {
                    for (int j = 0; j < alf.Length; j++)
                    {
                        if (times[i] < times[j]) isMoreOften2[i]++;
                    }
                }
                int mark2 = 0;
                int[] isMarked2 = new int[key2.Length];
                Array.Clear(isMarked2, 0, key2.Length);
                while (times.Max() != -1)    //Пометим порядок убывания частоты символов
                {
                    for (int i = alf.Length - 1; i >= 0; i--)
                    {
                        if (times[i] == times.Max() && times.Max() != -1)
                        {
                            times[i] = -1;
                            isMarked2[i] = mark2;
                            mark2++;
                        }
                    }
                }

                result = "";
                for (int i = 0; i < key2.Length; i++)
                {
                    result += oftenAlf[isMarked2[i]];
                }
                f14_2_key2.Text = Convert.ToString(result);


                //ФОРМИРУЕМ КЛЮЧ №3
                //Пересчитаем испорченный массив times
                Array.Clear(times, 0, times.Length);
                for (int i = 0; i < cipherText.Length; i++)
                {
                    if (alf.IndexOf(cipherText[i]) >= 0)
                    {
                        times[alf.IndexOf(cipherText[i])]++;
                    }
                }

                string key3 = alf;
                for (int i = key3.Length - 1; i >= 0; i--)
                {
                    if (times[i] == times.Max())
                    {
                        // i - номер места, на котором будет стоять буква англ "e" или русс "о"
                        while (key3[i] != 'e' && key3[i] != 'о')
                        {
                            var parts = key3.Split(key3[1]);
                            key3 = key3[1] + parts[1] + parts[0];
                        }
                    }
                }                
                f14_2_key3.Text = Convert.ToString(key3);
            }
        }

        private void f14_2_fieldCiphertext_TextChanged(object sender, EventArgs e)
        {
            string tmp = f14_2_fieldKey.Text;
            f14_2_fieldKey.Text = "1";
            f14_2_fieldKey.Text = tmp;
        }
    }
}
