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
    public partial class Form03 : Form
    {
        public Form03()
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
            public static string Numeric = "1234567890";
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
        public class DiffieHellman
        {
            public struct Params
            {
                static public BigInteger P { get; set; }
                static public BigInteger Q { get; set; }
                static public BigInteger G { get; set; }
            }

        }

        private void f3_textParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (MyAlphabets.Numeric.IndexOf(e.KeyChar) == -1 && e.KeyChar != (char)8) e.Handled = true;
        }

        private void f3_textQ_Validated(object sender, EventArgs e)
        {
            if (f3_textQ.TextLength > 0)
            {
                BigInteger Q = BigInteger.Parse(f3_textQ.Text);
                if (Q % 2 == 0) { Q++; f3_textQ.Text = Convert.ToString(Q); }
                f3_textP.Text = Convert.ToString(Q * 2 + 1);
            }
        }

        private void f3_buttonNextPrime_Click(object sender, EventArgs e)
        {
            f3_textQ.Text = new string(f3_textQ.Text.Where(t => char.IsDigit(t)).ToArray());
            BigInteger ParamP, ParamQ;
            if (f3_textQ.TextLength > 0)
                ParamQ = BigInteger.Parse(f3_textQ.Text);
            else
                ParamQ = 0;
            if (++ParamQ % 2 == 0) ParamQ++;
            while (!RabinMiller.IsPrime(ParamQ, 3) || !RabinMiller.IsPrime(ParamP = 2 * ParamQ + 1, 3))
                ParamQ += 2;

            f3_textP.Text = Convert.ToString(ParamP);
            f3_textQ.Text = Convert.ToString(ParamQ);
        }

        private void f3_buttonNextGenerator_Click(object sender, EventArgs e)
        {
            f3_textP.Text = new string(f3_textP.Text.Where(t => char.IsDigit(t)).ToArray());
            f3_textQ.Text = new string(f3_textQ.Text.Where(t => char.IsDigit(t)).ToArray());
            f3_textG.Text = new string(f3_textG.Text.Where(t => char.IsDigit(t)).ToArray());

            BigInteger ParamP, ParamQ, ParamG = 0;
            if (f3_textP.TextLength > 0 && f3_textQ.TextLength > 0 && RabinMiller.IsPrime(ParamP = BigInteger.Parse(f3_textP.Text), 3)
                 && RabinMiller.IsPrime(ParamQ = BigInteger.Parse(f3_textQ.Text), 3))
            {
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                while (ParamG < 2 || ParamG >= ParamP - 1 || NumberTheory.BinaryModPow(ParamG, ParamQ, ParamP) == 1)
                {
                    ParamG = BigIntegerRandomUtils.RandomInRange(rng, 2, ParamP - 1);
                }
                f3_textG.Text = Convert.ToString(ParamG);
            }
        }

        private void f3_textP_TextChanged(object sender, EventArgs e)
        {
            f3_textG.Text = "";
        }

        private void f3_buttonSetKeys_Click(object sender, EventArgs e)
        {
            f3_textP.Text = new string(f3_textP.Text.Where(t => char.IsDigit(t)).ToArray());
            f3_textQ.Text = new string(f3_textQ.Text.Where(t => char.IsDigit(t)).ToArray());
            f3_textG.Text = new string(f3_textG.Text.Where(t => char.IsDigit(t)).ToArray());

            BigInteger p = 0, q = 0, g = 0;
            if (f3_textP.TextLength > 0 && f3_textQ.TextLength > 0 && f3_textG.TextLength > 0 &&
                RabinMiller.IsPrime(p = BigInteger.Parse(f3_textP.Text), 10) &&
                RabinMiller.IsPrime(q = BigInteger.Parse(f3_textQ.Text), 10) &&
                ((g = BigInteger.Parse(f3_textG.Text)) >= 2) && g < p - 1 && NumberTheory.BinaryModPow(g, q, p) != 1)
            {
                DiffieHellman.Params.P = p;
                DiffieHellman.Params.Q = q;
                DiffieHellman.Params.G = g;

                f3_buttonSetKeys.Enabled = false;
                f3_buttonClearKeys.Enabled = true;
                f3_buttonNextPrime.Enabled = false;
                f3_buttonNextGenerator.Enabled = false;
                
                f3_textQ.ReadOnly = true;
                f3_textG.ReadOnly = true;

                f3_button_SetSecretA.Enabled = true;
                f3_button_GetRandomSecretA.Enabled = true;
                f3_textSecretA.ReadOnly = false;
                f3_button_SetSecretB.Enabled = true;
                f3_button_GetRandomSecretB.Enabled = true;
                f3_textSecretB.ReadOnly = false;
            }
        }

        private void f3_buttonClearKeys_Click(object sender, EventArgs e)
        {
            f3_buttonSetKeys.Enabled = true;
            f3_buttonClearKeys.Enabled = false;
            f3_buttonNextPrime.Enabled = true;
            f3_buttonNextGenerator.Enabled = true;
            
            f3_textQ.ReadOnly = false;
            f3_textG.ReadOnly = false;

            f3_button_SetSecretA.Enabled = false;
            f3_button_GetRandomSecretA.Enabled = false;
            f3_textSecretA.ReadOnly = true;
            f3_button_SetSecretB.Enabled = false;
            f3_button_GetRandomSecretB.Enabled = false;
            f3_textSecretB.ReadOnly = true;

            f3_textSecretA.Text = "";
            f3_textOpenA.Text = "";
            f3_textOpenB_inWindowA.Text = "";
            f3_textCommonSecret_inWindowA.Text = "";            
            f3_textSecretB.Text = "";
            f3_textOpenB.Text = "";
            f3_textOpenA_inWindowB.Text = "";
            f3_textCommonSecret_inWindowB.Text = "";
        }

        private void f3_button_GetRandomSecretA_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            f3_textSecretA.Text = Convert.ToString(BigIntegerRandomUtils.RandomInRange(rng, DiffieHellman.Params.Q, DiffieHellman.Params.P));
        }

        private void f3_button_GetRandomSecretB_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            f3_textSecretB.Text = Convert.ToString(BigIntegerRandomUtils.RandomInRange(rng, DiffieHellman.Params.Q, DiffieHellman.Params.P));
        }

        private void f3_button_SetSecretA_Click(object sender, EventArgs e)
        {
            f3_textSecretA.Text = new string(f3_textSecretA.Text.Where(t => char.IsDigit(t)).ToArray());
            if (f3_textSecretA.TextLength > 0)
            {
                BigInteger Xa = BigInteger.Parse(f3_textSecretA.Text);

                f3_textOpenA.Text = Convert.ToString(NumberTheory.BinaryModPow(DiffieHellman.Params.G,Xa, DiffieHellman.Params.P));
                f3_textOpenA_inWindowB.Text = f3_textOpenA.Text;

                if (f3_textOpenB_inWindowA.TextLength > 0)
                {
                    f3_textCommonSecret_inWindowA.Text = 
                        Convert.ToString(NumberTheory.BinaryModPow(BigInteger.Parse(f3_textOpenB_inWindowA.Text), Xa, DiffieHellman.Params.P));
                    f3_textCommonSecret_inWindowB.Text = f3_textCommonSecret_inWindowA.Text;
                }
            }
        }

        private void f3_button_SetSecretB_Click(object sender, EventArgs e)
        {
            f3_textSecretB.Text = new string(f3_textSecretB.Text.Where(t => char.IsDigit(t)).ToArray());
            if (f3_textSecretB.TextLength > 0)
            {
                BigInteger Xb = BigInteger.Parse(f3_textSecretB.Text);

                f3_textOpenB.Text = Convert.ToString(NumberTheory.BinaryModPow(DiffieHellman.Params.G, Xb, DiffieHellman.Params.P));
                f3_textOpenB_inWindowA.Text = f3_textOpenB.Text;

                if (f3_textOpenA_inWindowB.TextLength > 0)
                {
                    f3_textCommonSecret_inWindowB.Text =
                        Convert.ToString(NumberTheory.BinaryModPow(BigInteger.Parse(f3_textOpenA_inWindowB.Text), Xb, DiffieHellman.Params.P));
                    f3_textCommonSecret_inWindowA.Text = f3_textCommonSecret_inWindowB.Text;
                }
            }
        }

        private void f3_textSecretA_TextChanged(object sender, EventArgs e)
        {
            f3_textOpenA.Text = "";
            f3_textOpenA_inWindowB.Text = "";
            f3_textCommonSecret_inWindowA.Text = "";
            f3_textCommonSecret_inWindowB.Text = "";
        }

        private void f3_textSecretB_TextChanged(object sender, EventArgs e)
        {
            f3_textOpenB.Text = "";
            f3_textOpenB_inWindowA.Text = "";
            f3_textCommonSecret_inWindowA.Text = "";
            f3_textCommonSecret_inWindowB.Text = "";
        }
    }

}
