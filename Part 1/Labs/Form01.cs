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
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void f01_Button_Crypt_Click(object sender, EventArgs e)
        {
            string Source = f01_fieldMessage.Text;
            char[] Code = Source.ToCharArray();
            
            for (int i = 0; i < Code.Length; i++)
            {
                int tmp = Convert.ToInt16(Code[i]); //Код текущего символа
                if (tmp >= 65 && tmp <= 90) //Английские заглавные
                {
                    tmp = 155 - tmp;
                }
                else if (tmp >= 97 && tmp <= 122) //Английские строчные
                {
                    tmp = 219 - tmp;
                }
                else if ((tmp >= 1040 && tmp <= 1071) || tmp == 1025) //Русские заглавные
                {
                    string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                    char tmp2 = Convert.ToChar(tmp);
                    tmp = ALF.IndexOf(tmp2);
                    tmp2 = ALF[ALF.Length - tmp - 1];
                    Code[i] = tmp2;
                    continue;
                }
                else if ((tmp >= 1072 && tmp <= 1103) || tmp == 1105) //Русские строчные
                {
                    string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                    char tmp2 = Convert.ToChar(tmp);
                    tmp = alf.IndexOf(tmp2);
                    tmp2 = alf[alf.Length - tmp - 1];
                    Code[i] = tmp2;
                    continue;
                }
                Code[i] = Convert.ToChar(tmp);
            }
            string txt = new string(Code);
            f01_fieldMessage.Text = txt;
        }

        private void f01_ButtonClear_Click(object sender, EventArgs e)
        {
            f01_fieldMessage.Text = null;
        }
    }
}
