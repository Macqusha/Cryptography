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
    public partial class Form07 : Form
    {
        public Form07()
        {
            InitializeComponent();
            f7_fieldRotate.Text = "3"; //Пример ключа для пользователей, не желающих придумывать свой
            f7_fieldRotate.ForeColor = Color.Gray;
            f7_fieldLength.Text = "3"; //Пример ключа для пользователей, не желающих придумывать свой
            f7_fieldLength.ForeColor = Color.Gray;
        }

        string ALF = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюяABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-={};'/.,<>?№: ";
        string ALF_mixed = "'LеиNмgШmQVЯаX{Y6Zabc01ПРСТсур$Д#Э7H8kчшяAф4DF!%p^*)+НvОЧ-=}lЫRгЬЛ;зKёSjTЩUА3CnжEУ5ВMu&ткqOЦP/.s>_хцФщъwxьyЁЖы№BefМhi(2нопoБrG?d:tЗИ@ЙКz, ЪдЕWйЮIлбJвГ9эюХ<";

        private void f7_fieldRotate_Enter(object sender, EventArgs e)
        {
            f7_fieldRotate.ForeColor = Color.Black;
        }

        private void f7_fieldLength_Enter(object sender, EventArgs e)
        {
            f7_fieldLength.ForeColor = Color.Black;
        }

        private void f7_fieldLength_TextChanged(object sender, EventArgs e)
        {
            f7_fieldLength.Text = Regex.Replace(f7_fieldLength.Text, "[^0-9]", "");
        }

        private void f7_fieldRotate_TextChanged(object sender, EventArgs e)
        {
            f7_fieldRotate.Text = Regex.Replace(f7_fieldRotate.Text, "[^0-9]", "");
        }

        private void f7_ButtonClearCiphertext_Click(object sender, EventArgs e)
        {
            f7_fieldCiphertext.Text = null;
        }

        private void f7_ButtonClearOriginal_Click(object sender, EventArgs e)
        {
            f7_fieldOriginal.Text = null;
        }

        private void f7_fieldOriginal_TextChanged(object sender, EventArgs e)
        {
            f7_fieldOriginal.Text = Regex.Replace(f7_fieldOriginal.Text, "[^0-9a-zA-Zа-яА-ЯёЁ!@#$%^&*()_+-={};'/.,<>?№: ]", "");
        }

        private void f7_fieldCiphertext_TextChanged(object sender, EventArgs e)
        {
            f7_fieldCiphertext.Text = Regex.Replace(f7_fieldCiphertext.Text, "[^0-9a-zA-Zа-яА-ЯёЁ!@#$%^&*()_+-={};'/.,<>?№: ]", "");
        }

        private void f7_ButtonEncrypt_Click(object sender, EventArgs e)
        {
            char[] Source = f7_fieldOriginal.Text.ToCharArray();
            int rot = Convert.ToInt32(f7_fieldRotate.Text);
            int blockLength = Convert.ToInt32(f7_fieldLength.Text);
            for (int i = 0; i < Source.Length; i++)
            {
                Source[i] = ALF_mixed[(ALF.LastIndexOf(Source[i]) + (rot * (i / blockLength))) % ALF_mixed.Length];
            }

            f7_fieldCiphertext.Text = new string(Source);
        }

        private void f7_ButtonDecrypt_Click(object sender, EventArgs e)
        {
            char[] Source = f7_fieldCiphertext.Text.ToCharArray();
            int rot = Convert.ToInt32(f7_fieldRotate.Text);
            int blockLength = Convert.ToInt32(f7_fieldLength.Text);
            for (int i = 0; i < Source.Length; i++)
            {
                Source[i] = ALF[(((ALF_mixed.LastIndexOf(Source[i]) - (rot * (i / blockLength))) % ALF.Length) + ALF.Length) % ALF.Length];
            }

            f7_fieldOriginal.Text = new string(Source);
        }
    }
}
