using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

        public static class BigIntegerRandomUtils
        {
            public static BigInteger RandomInRange(RandomNumberGenerator rng, BigInteger min, BigInteger max)
            {
                if (min > max)
                {
                    var buff = min;
                    min = max;
                    max = buff;
                }

                // offset to set min = 0
                BigInteger offset = -min;
                min = 0;
                max += offset;

                var value = randomInRangeFromZeroToPositive(rng, max) - offset;
                return value;
            }
            private static BigInteger randomInRangeFromZeroToPositive(RandomNumberGenerator rng, BigInteger max)
            {
                BigInteger value;
                var bytes = max.ToByteArray();

                // count how many bits of the most significant byte are 0
                // NOTE: sign bit is always 0 because `max` must always be positive
                byte zeroBitsMask = 0b00000000;

                var mostSignificantByte = bytes[bytes.Length - 1];

                // we try to set to 0 as many bits as there are in the most significant byte, starting from the left (most significant bits first)
                // NOTE: `i` starts from 7 because the sign bit is always 0
                for (var i = 7; i >= 0; i--)
                {
                    // we keep iterating until we find the most significant non-0 bit
                    if ((mostSignificantByte & (0b1 << i)) != 0)
                    {
                        var zeroBits = 7 - i;
                        zeroBitsMask = (byte)(0b11111111 >> zeroBits);
                        break;
                    }
                }

                do
                {
                    rng.GetBytes(bytes);

                    // set most significant bits to 0 (because `value > max` if any of these bits is 1)
                    bytes[bytes.Length - 1] &= zeroBitsMask;

                    value = new BigInteger(bytes);

                    // `value > max` 50% of the times, in which case the fastest way to keep the distribution uniform is to try again
                } while (value > max);

                return value;
            }
        }
        public static class MyAlphabets
        {
            public static string Numeric = "0123456789";
            public static string Alphabet_EN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public static string Alphabet_en = "abcdefghijklmnopqrstuvwxyz";
            public static string Alphabet_RU = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            public static string Alphabet_ru = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            public static string Sybols = ".,:;!?() -";
            public static string Specials = "\n\r";
            public static string AllTypesTogether = Specials + Alphabet_EN + Alphabet_en + Alphabet_RU + Alphabet_ru + Numeric + Sybols;
        }
        public static class NumberTheory
        {
            public static BigInteger BinaryModPow(BigInteger Number, BigInteger Deg, BigInteger Mod)
            {
                BigInteger Result = 1;
                BigInteger Bit = Number;
                if (Bit < 0) Bit = (Number + Mod) % Mod;

                while (Deg > 0)
                {
                    if ((Deg & 1) == 1)
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

            public static BigInteger GCD(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
            {
                if (a == 0)
                {
                    x = 0;
                    y = 1;
                    return b;
                }
                BigInteger x1, y1;
                BigInteger d = GCD(b % a, a, out x1, out y1);

                x = y1 - (b / a) * x1;
                y = x1;

                if (d < 0)
                {
                    d = -d;
                    x = -x;
                    y = -y;
                }
                return d;
            }
            public static BigInteger Foo(BigInteger element, BigInteger Mod)
            {
                if (element < 0) element = (element + Mod) % Mod;
                BigInteger x, y;
                BigInteger g = GCD(element, Mod, out x, out y);

                //Обратный элемент не существует, если кольцо не является полем (модуль не является степенью простого числа) и элемент не взаимно прост с модулем
                //Возвращает 0 в случае, если обратный элемент не существует
                if (g != 1) x = 0;

                //Приведем результат в положительный вид по модулю
                x = x % Mod;
                if (x < 0) x = (x + Mod) % Mod;
                return x;
            }
        }
        public static class RabinMiller
        {
            // Random generator (thread safe)
            private static ThreadLocal<Random> s_Gen = new ThreadLocal<Random>(
                () =>
                {
                    return new Random();
                }
            );

            // Random generator (thread safe)
            private static Random Gen
            {
                get
                {
                    return s_Gen.Value;
                }
            }

            public static Boolean IsPrime(BigInteger value, int witnesses)
            {
                if (value < 5)
                    return (value == 2 || value == 3);

                if (witnesses <= 0)
                    witnesses = 1;

                BigInteger d = value - 1;
                int s = 0;

                while (d % 2 == 0)
                {
                    d /= 2;
                    s += 1;
                }

                Byte[] bytes = new Byte[value.ToByteArray().LongLength];
                BigInteger a;

                for (int i = 0; i < witnesses; i++)
                {
                    do
                    {
                        Gen.NextBytes(bytes);

                        a = new BigInteger(bytes);
                    }
                    while (a < 2 || a >= value - 2);

                    BigInteger x = BigInteger.ModPow(a, d, value);
                    if (x == 1 || x == value - 1)
                        continue;

                    for (int r = 1; r < s; r++)
                    {
                        x = BigInteger.ModPow(x, 2, value);

                        if (x == 1)
                            return false;
                        if (x == value - 1)
                            break;
                    }

                    if (x != value - 1)
                        return false;
                }

                return true;

            }

        }

        private void f5_textParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (MyAlphabets.Numeric.IndexOf(e.KeyChar) == -1 && e.KeyChar != (char)8) e.Handled = true;
        }

        private void f4_buttonSetKeys_Click(object sender, EventArgs e)
        {
            f4_textP.Text = new string(f4_textP.Text.Where(t => char.IsDigit(t)).ToArray());

            if (f4_textP.TextLength > 0)
            {
                if (RabinMiller.IsPrime(BigInteger.Parse(f4_textP.Text), 10))
                {
                    f4_textP.ReadOnly = true;
                    f4_buttonNextPrime.Enabled = false;
                    f4_buttonSetKeys.Enabled = false;
                    f4_buttonClearKeys.Enabled = true;
                    f4_textCa.ReadOnly = false;
                    f4_textCb.ReadOnly = false;
                    f4_textBox_MessageAlice.ReadOnly = false;
                    f4_button_GetRandomCa.Enabled = true;
                    f4_button_GetRandomCb.Enabled = true;
                    f4_button_SetCa.Enabled = true;
                    f4_button_SetCb.Enabled = true;
                }
            }
        }

        private void f4_buttonClearKeys_Click(object sender, EventArgs e)
        {
            f4_textP.ReadOnly = false;
            f4_buttonNextPrime.Enabled = true;
            f4_buttonSetKeys.Enabled = true;
            f4_buttonClearKeys.Enabled = false;
            f4_textCa.ReadOnly = true;
            f4_textCb.ReadOnly = true;
            f4_textCa.Text = "";
            f4_textCb.Text = "";
            f4_textDa.Text = "";
            f4_textDb.Text = "";
            f4_textBox_MessageAlice.Text = "";
            f4_textBox_MessageBob.Text = "";
            f4_textBox_MessageAlice.ReadOnly = true;
            f4_button_GetRandomCa.Enabled = false;
            f4_button_GetRandomCb.Enabled = false;
            f4_button_SetCa.Enabled = false;
            f4_button_SetCb.Enabled = false;
            f5_buttonSendMes.Enabled = false;
            f4_button_ChangeCa.Enabled = false;
            f4_button_ChangeCa.Enabled = false;
        }

        private void f5_buttonNextPrime_Click(object sender, EventArgs e)
        {
            f4_textP.Text = new string(f4_textP.Text.Where(t => char.IsDigit(t)).ToArray());

            BigInteger ParamP;
            if (f4_textP.TextLength > 0)
                ParamP = BigInteger.Parse(f4_textP.Text);
            else
                ParamP = 0;
            if (++ParamP % 2 == 0) ParamP++;
            while (!RabinMiller.IsPrime(ParamP, 3))
                ParamP += 2;

            f4_textP.Text = Convert.ToString(ParamP);
        }

        private void f4_textP_Validated(object sender, EventArgs e)
        {
            f4_textP.Text = new string(f4_textP.Text.Where(t => char.IsDigit(t)).ToArray());

            if (f4_textP.TextLength > 0)
            {
                BigInteger P = BigInteger.Parse(f4_textP.Text);
                if (P % 2 == 0)
                {
                    f4_textP.Text = Convert.ToString(++P);
                }
            }
        }

        private void f4_button_GetRandomCa_Click(object sender, EventArgs e)
        {
            BigInteger P = BigInteger.Parse(f4_textP.Text);
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            BigInteger Da, Ca = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 1);
            while (!(NumberTheory.GCD(Ca, P - 1, out BigInteger x, out BigInteger y) == 1))
                Ca = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 1); ;
            
            f4_textCa.Text = Convert.ToString(Ca);            
        }

        private void f4_button_SetCa_Click(object sender, EventArgs e)
        {
            f4_textCa.Text = new string(f4_textCa.Text.Where(t => char.IsDigit(t)).ToArray());

            if (f4_textCa.TextLength > 0)
            {
                BigInteger P = BigInteger.Parse(f4_textP.Text);
                BigInteger Ca = BigInteger.Parse(f4_textCa.Text);
                if ((NumberTheory.GCD(Ca, P - 1, out BigInteger x, out BigInteger y) == 1))
                {
                    f4_textDa.Text = Convert.ToString(NumberTheory.Foo(Ca, P - 1));
                    f4_textCa.ReadOnly = true;
                    f4_button_GetRandomCa.Enabled = false;
                    f4_button_SetCa.Enabled = false;
                    f4_button_ChangeCa.Enabled = true;
                }
            }       
        }

        private void f4_button_GetRandomCb_Click(object sender, EventArgs e)
        {
            BigInteger P = BigInteger.Parse(f4_textP.Text);
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            BigInteger Db, Cb = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 1);
            while (!(NumberTheory.GCD(Cb, P - 1, out BigInteger x, out BigInteger y) == 1))
                Cb = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 1); ;

            f4_textCb.Text = Convert.ToString(Cb);
        }

        private void f4_button_SetCb_Click(object sender, EventArgs e)
        {
            f4_textCb.Text = new string(f4_textCb.Text.Where(t => char.IsDigit(t)).ToArray());

            if (f4_textCb.TextLength > 0)
            {
                BigInteger P = BigInteger.Parse(f4_textP.Text);
                BigInteger Cb = BigInteger.Parse(f4_textCb.Text);
                if ((NumberTheory.GCD(Cb, P - 1, out BigInteger x, out BigInteger y) == 1))
                {
                    f4_textDb.Text = Convert.ToString(NumberTheory.Foo(Cb, P - 1));
                    f4_textCb.ReadOnly = true;
                    f4_button_GetRandomCb.Enabled = false;
                    f4_button_SetCb.Enabled = false;
                    f4_button_ChangeCb.Enabled = true;
                }
            }
        }

        private void f4_textDa_OR_Db_TextChanged(object sender, EventArgs e)
        {
            if (f4_textDa.TextLength > 0 && f4_textDb.TextLength > 0)
            {
                f5_buttonSendMes.Enabled = true;
            }
            else
            {
                f5_buttonSendMes.Enabled = false;
            }
        }

        private void f5_buttonSendMes_Click(object sender, EventArgs e)
        {
            //Очистка строки от мусора
            string tmp = "";
            for (int i = 0; i < f4_textBox_MessageAlice.TextLength; i++) { if (MyAlphabets.AllTypesTogether.IndexOf(f4_textBox_MessageAlice.Text[i]) != -1) tmp += f4_textBox_MessageAlice.Text[i]; }
            f4_textBox_MessageAlice.Text = "";
            f4_textBox_MessageAlice.Text = tmp;
            
            f4_textStepA0.Text = "";
            if (f4_textBox_MessageAlice.TextLength > 0)
            {
                //Шифрование
                BigInteger m = MyAlphabets.AllTypesTogether.IndexOf(f4_textBox_MessageAlice.Text[0]); //Сообщение         

                f4_textStepA0.Text = Convert.ToString(m);
                f4_textBox_MessageAlice.Text = f4_textBox_MessageAlice.Text.Substring(1);//Удаление зашифрованного символа из строки
            }
        }

        private void f4_textStepA0_TextChanged(object sender, EventArgs e)
        {
            f4_textStepA1.Text = "";
            f4_textStepB1.Text = "";
            if (f4_textStepA0.TextLength > 0)
            {
                BigInteger m = BigInteger.Parse(f4_textStepA0.Text);
                BigInteger p = BigInteger.Parse(f4_textP.Text);
                BigInteger Ca = BigInteger.Parse(f4_textCa.Text);
                //Шаг 1 шифрования
                BigInteger x1 = NumberTheory.BinaryModPow(m, Ca, p);
                f4_textStepA1.Text = Convert.ToString(x1);
                f4_textStepB1.Text = Convert.ToString(x1);
            }     
        }

        private void f4_textStepB1_TextChanged(object sender, EventArgs e)
        {
            f4_textStepA2.Text = "";
            f4_textStepB2.Text = "";
            if (f4_textStepB1.TextLength > 0)
            {
                BigInteger x1 = BigInteger.Parse(f4_textStepB1.Text);
                BigInteger p = BigInteger.Parse(f4_textP.Text);
                BigInteger Cb = BigInteger.Parse(f4_textCb.Text);
                //Шаг 2 шифрования
                BigInteger x2 = NumberTheory.BinaryModPow(x1, Cb, p);
                f4_textStepA2.Text = Convert.ToString(x2);
                f4_textStepB2.Text = Convert.ToString(x2);
            }            
        }

        private void f4_textStepA2_TextChanged(object sender, EventArgs e)
        {
            f4_textStepA3.Text = "";
            f4_textStepB3.Text = "";
            if (f4_textStepA2.TextLength > 0)
            {
                BigInteger x2 = BigInteger.Parse(f4_textStepA2.Text);
                BigInteger p = BigInteger.Parse(f4_textP.Text);
                BigInteger Da = BigInteger.Parse(f4_textDa.Text);
                //Шаг 3 шифрования
                BigInteger x3 = NumberTheory.BinaryModPow(x2, Da, p);
                f4_textStepA3.Text = Convert.ToString(x3);
                f4_textStepB3.Text = Convert.ToString(x3);
            }
        }

        private void f4_textStepB3_TextChanged(object sender, EventArgs e)
        {
            f4_textStepB4.Text = "";
            if (f4_textStepB3.TextLength > 0)
            {
                BigInteger x3 = BigInteger.Parse(f4_textStepB3.Text);
                BigInteger p = BigInteger.Parse(f4_textP.Text);
                BigInteger Db = BigInteger.Parse(f4_textDb.Text);
                //Шаг 4 шифрования
                BigInteger x4 = NumberTheory.BinaryModPow(x3, Db, p);
                f4_textStepB4.Text = Convert.ToString(x4);
            }
        }

        private void f4_textStepB4_TextChanged(object sender, EventArgs e)
        {
            if (f4_textStepB4.TextLength > 0)
            {
                BigInteger x4 = BigInteger.Parse(f4_textStepB4.Text);
                int letterNum = (int)x4;
                f4_textBox_MessageBob.Text += MyAlphabets.AllTypesTogether[letterNum];
            }
        }

        private void f4_button_ChangeCa_Click(object sender, EventArgs e)
        {
            f4_textDa.Text = "";
            f4_textCa.ReadOnly = false;
            f4_button_GetRandomCa.Enabled = true;
            f4_button_SetCa.Enabled = true;
            f4_button_ChangeCa.Enabled = false;
        }

        private void f4_button_ChangeCb_Click(object sender, EventArgs e)
        {
            f4_textDb.Text = "";
            f4_textCb.ReadOnly = false;
            f4_button_GetRandomCb.Enabled = true;
            f4_button_SetCb.Enabled = true;
            f4_button_ChangeCb.Enabled = false;
        }
    }   
}
