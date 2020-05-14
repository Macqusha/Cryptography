using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Labs
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        Decimal BinaryModPow(Decimal Number, Int64 Deg, Decimal Mod)
        {
            Decimal Result = 1;
            Decimal Bit = Number;
            if (Bit < 0) Bit = (Number + Mod) % Mod;
            else
                Bit = Number % Mod;

             while (Deg > 0)
             {
                 if ((Deg % 2) == 1)
                 {
                    Result *= Bit;
                    Result %= Mod;
                 }
                Deg >>= 1;
                if (Deg > 0)
                {
                    Bit *= Bit;
                    Bit %= Mod;
                }
             }
            return Result;        
        }

        public static Decimal Foo(Decimal element, Decimal Mod) 
        {
            if (element < 0) element = (element + Mod) % Mod;
            Decimal x, y;
            Decimal g = GCD(element, Mod, out x, out y);
            if (g == -1)
            {
                    g = 1;
                    x = -x;
                    y = -y;
            }

            //Обратный элемент не существует, если кольцо не является полем (модуль не является степенью простого числа) и элемент не взаимно прост с модулем
            //Возвращает 0 в случае, если обратный элемент не существует
            if (g != 1) x = 0; 

            //Приведем результат в положительный вид по модулю
            x = x % Mod;
            if (x < 0) x = (x + Mod) % Mod;
            return x;
        }

        static Decimal IntegerDivision (Decimal x, Decimal y)
        {
            //Производим целочисленное деление x/y
            decimal celoe = Decimal.Round(x / y);
            if (celoe > 0 && x / celoe < y) celoe--;
            return celoe;
        }

        Decimal LCM(Decimal a, Decimal b)
        {
            if (a<b)
            {
                Decimal tmp = a;
                a = b;
                b = tmp;
            }

            if ( a / GCD(a, b, out Decimal x, out Decimal y) < 281474976710656 && b < 281474976710656)
                return a / GCD(a, b, out x, out y) * b;
            else
                return 0;
        }

        public static Decimal GCD(Decimal a, Decimal b, out Decimal x, out Decimal y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            Decimal x1, y1;
            Decimal d = GCD(b % a, a, out x1, out y1);
            
            x = y1 - (IntegerDivision(b,a)) * x1;
            y = x1;
            return d;
        }

        private void f1_1_buttonDegCount_Click(object sender, EventArgs e)
        {
            Decimal res = BinaryModPow(f1_1_numericNumber.Value, Math.Abs(Convert.ToInt64(f1_1_numericDeg.Value)), f1_1_numericMod.Value);

            if (f1_1_numericDeg.Value < 0)                                   //Отрицательная степень
            {
                res = Foo(res, f1_1_numericMod.Value);
                if (res == 0)                                                //Обратный элемент не существует
                    f1_1_textBoxResult.Text = "-";
                else
                    f1_1_textBoxResult.Text = Convert.ToString(res);        //Обратный элемент найден
            }
            else
            {
                f1_1_textBoxResult.Text = Convert.ToString(res);
            }               
        }

        private void f1_2_buttonCountGCD_LCM_Click(object sender, EventArgs e)
        {
            f1_2_textBoxGCD.Text = Convert.ToString(GCD(f1_2_numericNumberA.Value, f1_2_numericNumberB.Value, out Decimal x, out Decimal y));
            Decimal myLCM = LCM(f1_2_numericNumberA.Value, f1_2_numericNumberB.Value);
            if (myLCM != 0)
                f1_2_textBoxLCM.Text = Convert.ToString(LCM(f1_2_numericNumberA.Value, f1_2_numericNumberB.Value));
            else
            {
                if (f1_2_numericNumberA.Value == f1_2_numericNumberB.Value)
                    f1_2_textBoxLCM.Text = f1_2_textBoxGCD.Text;
                else
                    f1_2_textBoxLCM.Text = "overflow";
            }
        }

        private void f1_3_buttonCountReverse_Click(object sender, EventArgs e)
        {
            Decimal res = Foo(f1_3_numericNumber.Value, f1_3_numericMod.Value);
            if (res != 0)
                f1_3_textBoxResult.Text = Convert.ToString(res);
            else
                f1_3_textBoxResult.Text = "-";
        }
        
    }
}
