using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            f10_chooseHashFun.Text = "MD5";
            f10_chooseHashFunRecieved.Text = "MD5";
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
        public static class HashFunctions
        {
            public static class MD5
            {
                public static string GetHashMD5(byte[] arr)
                {
                    //Step 1
                    int bytesToAddAmount = (arr.Length + 1) % 64 > 56 ? (arr.Length + 1) % 64 - 56 : -(arr.Length + 1) % 64 + 56;

                    byte[] arrEx = new byte[arr.Length + bytesToAddAmount + 1];
                    arr.CopyTo(arrEx, 0);
                    arrEx[arr.Length] = 0x80;                                       //Добавляем единицу

                    //Step 2
                    byte[] arrExtended = new byte[arrEx.Length + 8];                //Добавляем слоты для длины файла
                    arrEx.CopyTo(arrExtended, 0);
                    byte[] len = BitConverter.GetBytes(arr.Length * 8);
                    len.CopyTo(arrExtended, arrEx.Length);

                    //Step 3
                    uint[] buf = new uint[4];
                    buf[0] = 0x67452301;
                    buf[1] = 0xEFCDAB89;
                    buf[2] = 0x98BADCFE;
                    buf[3] = 0x10325476;

                    //Step 4
                    //Функции funF, funG, funH, funI определены
                    uint[] T = new uint[64];
                    for (int i = 1; i <= 64; i++)
                    {
                        T[i - 1] = (uint)(0x100000000 * Math.Abs(Math.Sin(i)));
                    }

                    int[] shiftValues = { 7, 12, 17, 22, 5, 9, 14, 20, 4, 11, 16, 23, 6, 10, 15, 21 }; //константы для сдвигов
                    for (int circle = 0; circle < arrExtended.Length / 64; circle++)
                    {
                        //HMD5

                        uint[] tmp = new uint[4];
                        buf.CopyTo(tmp, 0);

                        byte[] piece = new byte[64];
                        Array.Copy(arrExtended, 64 * circle, piece, 0, 64);

                        for (int i = 0; i < 16; i++)
                        {
                            var ff = piece.Skip(4 * i).Take(4).ToArray();
                            tmp[0] += funF(tmp[1], tmp[2], tmp[3]) + T[i] + BitConverter.ToUInt32(piece.Skip(4 * i).Take(4).ToArray(), 0);
                            tmp[0] = BitShift(tmp[0], shiftValues[i % 4]);
                            tmp[0] += tmp[1];
                            tmp = Shift(tmp);
                        }
                        for (int i = 0; i < 16; i++)
                        {
                            int g = (5 * i + 1) % 16;
                            tmp[0] += funG(tmp[1], tmp[2], tmp[3]) + T[16 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                            tmp[0] = BitShift(tmp[0], shiftValues[4 + (i % 4)]);
                            tmp[0] += tmp[1];
                            tmp = Shift(tmp);
                        }
                        for (int i = 0; i < 16; i++)
                        {
                            int g = (3 * i + 5) % 16;
                            tmp[0] += funH(tmp[1], tmp[2], tmp[3]) + T[32 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                            tmp[0] = BitShift(tmp[0], shiftValues[8 + (i % 4)]);
                            tmp[0] += tmp[1];
                            tmp = Shift(tmp);
                        }
                        for (int i = 0; i < 16; i++)
                        {
                            int g = (7 * i) % 16;
                            tmp[0] += funI(tmp[1], tmp[2], tmp[3]) + T[48 + i] + BitConverter.ToUInt32(piece.Skip(4 * g).Take(4).ToArray(), 0);
                            tmp[0] = BitShift(tmp[0], shiftValues[12 + (i % 4)]);
                            tmp[0] += tmp[1];
                            tmp = Shift(tmp);
                        }
                        buf[0] += tmp[0];
                        buf[1] += tmp[1];
                        buf[2] += tmp[2];
                        buf[3] += tmp[3];
                    }

                    //Step 5
                    return OutHash(buf[0]) + OutHash(buf[1]) + OutHash(buf[2]) + OutHash(buf[3]);
                }

                private static uint funF(uint x, uint y, uint z)
                {
                    return (x & y) | (~x & z);
                }
                private static uint funG(uint x, uint y, uint z)
                {
                    return (x & z) | (~z & y);
                }
                private static uint funH(uint x, uint y, uint z)
                {
                    return x ^ y ^ z;
                }
                private static uint funI(uint x, uint y, uint z)
                {
                    return y ^ (~z | x);
                }

                private static uint[] Shift(uint[] arr)
                {
                    var tmp = arr[0];
                    arr[0] = arr[3];
                    arr[3] = arr[2];
                    arr[2] = arr[1];
                    arr[1] = tmp;
                    return arr;
                }

                private static uint BitShift(uint numb, int pos)
                {
                    uint hi = (uint)(numb >> (32 - pos));
                    return (numb << pos) | hi;
                }

                private static string OutHash(uint reg)
                {
                    var bytes = BitConverter.GetBytes(reg);

                    var tmp = reg.ToString("x");
                    if (tmp.Length != 8)
                    {
                        var k = 8 - tmp.Length;
                        for (int i = 0; i < k; i++)
                        {
                            tmp = "0" + tmp;
                        }
                    }

                    return new string(new char[] { tmp[6], tmp[7], tmp[4], tmp[5], tmp[2], tmp[3], tmp[0], tmp[1] });
                }
            }
            public static class SHA1
            {
                private static uint fun1(uint x, uint y, uint z)
                {
                    return (x & y) | (~x & z);
                }
                private static uint fun2(uint x, uint y, uint z)
                {
                    return x ^ y ^ z;
                }
                private static uint fun3(uint x, uint y, uint z)
                {
                    return (x & y) | (x & z) | (y & z);
                }
                static uint swapEndianness(uint x)
                {
                    return ((x & 0x000000ff) << 24) +  // First byte
                           ((x & 0x0000ff00) << 8) +   // Second byte
                           ((x & 0x00ff0000) >> 8) +   // Third byte
                           ((x & 0xff000000) >> 24);   // Fourth byte
                }
                static UInt64 swapEndianness64(UInt64 x)
                {
                    return ((x & 0x00000000000000ff) << 56) |  // First byte
                           ((x & 0x000000000000ff00) << 40) |   // Second byte
                           ((x & 0x0000000000ff0000) << 24) |   // Third byte
                           ((x & 0x00000000ff000000) << 8) |  // Fourth byte
                           ((x & 0x000000ff00000000) >> 8) |  // First byte
                           ((x & 0x0000ff0000000000) >> 24) |   // Second byte
                           ((x & 0x00ff000000000000) >> 40) |   // Third byte
                           ((x & 0xff00000000000000) >> 56);
                }

                private static uint BitShift(uint numb, int pos)
                {
                    uint hi = (uint)(numb >> (32 - pos));
                    return (numb << pos) | hi;
                }
                public static string GetHashSHA1(byte[] arr)
                {
                    int bytesToAddAmount = (arr.Length + 1) % 64 > 56 ? (arr.Length + 1) % 64 - 56 : -(arr.Length + 1) % 64 + 56;

                    byte[] arrEx = new byte[arr.Length + bytesToAddAmount + 1];
                    arr.CopyTo(arrEx, 0);
                    arrEx[arr.Length] = 0x80;                                       //Добавляем единицу

                    byte[] arrExtended = new byte[arrEx.Length + 8];                //Добавляем слоты для длины файла
                    arrEx.CopyTo(arrExtended, 0);
                    UInt64 length = Convert.ToUInt64(arr.Length);
                    byte[] len = BitConverter.GetBytes(swapEndianness64(length * 8));
                    len.CopyTo(arrExtended, arrEx.Length);

                    uint[] buf = new uint[5];
                    buf[0] = 0x67452301;
                    buf[1] = 0xEFCDAB89;
                    buf[2] = 0x98BADCFE;
                    buf[3] = 0x10325476;
                    buf[4] = 0xC3D2E1F0;

                    for (int circle = 0; circle < arrExtended.Length / 64; circle++)
                    {
                        uint[] tmp = new uint[5];
                        buf.CopyTo(tmp, 0);

                        byte[] piece = new byte[64];
                        Array.Copy(arrExtended, 64 * circle, piece, 0, 64);

                        uint[] w = new uint[80];
                        for (int i = 0; i < 16; i++)
                        {
                            w[i] = swapEndianness(BitConverter.ToUInt32(piece, i * 4));
                        }
                        for (int i = 16; i < 80; i++)
                        {
                            w[i] = BitShift(w[i - 3] ^ w[i - 8] ^ w[i - 14] ^ w[i - 16], 1);
                        }

                        uint k;
                        for (int i = 0; i < 80; i++)
                        {
                            uint temp = 0;

                            switch (i / 20)
                            {
                                case 0:
                                    k = 0x5A827999;
                                    temp = BitShift(tmp[0], 5) + fun1(tmp[1], tmp[2], tmp[3]) + tmp[4] + k + w[i];
                                    break;
                                case 1:
                                    k = 0x6ED9EBA1;
                                    temp = BitShift(tmp[0], 5) + fun2(tmp[1], tmp[2], tmp[3]) + tmp[4] + k + w[i];
                                    break;
                                case 2:
                                    k = 0x8F1BBCDC;
                                    temp = BitShift(tmp[0], 5) + fun3(tmp[1], tmp[2], tmp[3]) + tmp[4] + k + w[i];
                                    break;
                                case 3:
                                    k = 0xCA62C1D6;
                                    temp = BitShift(tmp[0], 5) + fun2(tmp[1], tmp[2], tmp[3]) + tmp[4] + k + w[i];
                                    break;
                            }

                            tmp[4] = tmp[3];
                            tmp[3] = tmp[2];
                            tmp[2] = BitShift(tmp[1], 30);
                            tmp[1] = tmp[0];
                            tmp[0] = temp;

                        }
                        buf[0] += tmp[0];
                        buf[1] += tmp[1];
                        buf[2] += tmp[2];
                        buf[3] += tmp[3];
                        buf[4] += tmp[4];
                    }

                    byte[] result = new byte[20];
                    Array.Copy(BitConverter.GetBytes((buf[4])), 0, result, 0, 4);
                    Array.Copy(BitConverter.GetBytes((buf[3])), 0, result, 4, 4);
                    Array.Copy(BitConverter.GetBytes((buf[2])), 0, result, 8, 4);
                    Array.Copy(BitConverter.GetBytes((buf[1])), 0, result, 12, 4);
                    Array.Copy(BitConverter.GetBytes((buf[0])), 0, result, 16, 4);

                    string str = "";
                    foreach (var bt in result)
                    {
                        var tmp = bt.ToString("x");
                        if (tmp.Length < 2)
                            tmp = "0" + tmp;
                        str = tmp + str;
                    }
                    return str;
                }
            }
            public static class GOST
            {
                // пи подстановка
                private static readonly byte[] pi ={
        0xfc, 0xee, 0xdd, 0x11, 0xcf, 0x6e, 0x31, 0x16, 0xfb, 0xc4, 0xfa, 0xda, 0x23, 0xc5, 0x04, 0x4d,
        0xe9, 0x77, 0xf0, 0xdb, 0x93, 0x2e, 0x99, 0xba, 0x17, 0x36, 0xf1, 0xbb, 0x14, 0xcd, 0x5f, 0xc1,
        0xf9, 0x18, 0x65, 0x5a, 0xe2, 0x5c, 0xef, 0x21, 0x81, 0x1c, 0x3c, 0x42, 0x8b, 0x01, 0x8e, 0x4f,
        0x05, 0x84, 0x02, 0xae, 0xe3, 0x6a, 0x8f, 0xa0, 0x06, 0x0b, 0xed, 0x98, 0x7f, 0xd4, 0xd3, 0x1f,
        0xeb, 0x34, 0x2c, 0x51, 0xea, 0xc8, 0x48, 0xab, 0xf2, 0x2a, 0x68, 0xa2, 0xfd, 0x3a, 0xce, 0xcc,
        0xb5, 0x70, 0x0e, 0x56, 0x08, 0x0c, 0x76, 0x12, 0xbf, 0x72, 0x13, 0x47, 0x9c, 0xb7, 0x5d, 0x87,
        0x15, 0xa1, 0x96, 0x29, 0x10, 0x7b, 0x9a, 0xc7, 0xf3, 0x91, 0x78, 0x6f, 0x9d, 0x9e, 0xb2, 0xb1,
        0x32, 0x75, 0x19, 0x3d, 0xff, 0x35, 0x8a, 0x7e, 0x6d, 0x54, 0xc6, 0x80, 0xc3, 0xbd, 0x0d, 0x57,
        0xdf, 0xf5, 0x24, 0xa9, 0x3e, 0xa8, 0x43, 0xc9, 0xd7, 0x79, 0xd6, 0xf6, 0x7c, 0x22, 0xb9, 0x03,
        0xe0, 0x0f, 0xec, 0xde, 0x7a, 0x94, 0xb0, 0xbc, 0xdc, 0xe8, 0x28, 0x50, 0x4e, 0x33, 0x0a, 0x4a,
        0xa7, 0x97, 0x60, 0x73, 0x1e, 0x00, 0x62, 0x44, 0x1a, 0xb8, 0x38, 0x82, 0x64, 0x9f, 0x26, 0x41,
        0xad, 0x45, 0x46, 0x92, 0x27, 0x5e, 0x55, 0x2f, 0x8c, 0xa3, 0xa5, 0x7d, 0x69, 0xd5, 0x95, 0x3b,
        0x07, 0x58, 0xb3, 0x40, 0x86, 0xac, 0x1d, 0xf7, 0x30, 0x37, 0x6b, 0xe4, 0x88, 0xd9, 0xe7, 0x89,
        0xe1, 0x1b, 0x83, 0x49, 0x4c, 0x3f, 0xf8, 0xfe, 0x8d, 0x53, 0xaa, 0x90, 0xca, 0xd8, 0x85, 0x61,
        0x20, 0x71, 0x67, 0xa4, 0x2d, 0x2b, 0x09, 0x5b, 0xcb, 0x9b, 0x25, 0xd0, 0xbe, 0xe5, 0x6c, 0x52,
        0x59, 0xa6, 0x74, 0xd2, 0xe6, 0xf4, 0xb4, 0xc0, 0xd1, 0x66, 0xaf, 0xc2, 0x39, 0x4b, 0x63, 0xb6
        };
                // l-подстановка
                private static readonly ulong[] l = {
        0x8e20faa72ba0b470, 0x47107ddd9b505a38, 0xad08b0e0c3282d1c, 0xd8045870ef14980e,
        0x6c022c38f90a4c07, 0x3601161cf205268d, 0x1b8e0b0e798c13c8, 0x83478b07b2468764,
        0xa011d380818e8f40, 0x5086e740ce47c920, 0x2843fd2067adea10, 0x14aff010bdd87508,
        0x0ad97808d06cb404, 0x05e23c0468365a02, 0x8c711e02341b2d01, 0x46b60f011a83988e,
        0x90dab52a387ae76f, 0x486dd4151c3dfdb9, 0x24b86a840e90f0d2, 0x125c354207487869,
        0x092e94218d243cba, 0x8a174a9ec8121e5d, 0x4585254f64090fa0, 0xaccc9ca9328a8950,
        0x9d4df05d5f661451, 0xc0a878a0a1330aa6, 0x60543c50de970553, 0x302a1e286fc58ca7,
        0x18150f14b9ec46dd, 0x0c84890ad27623e0, 0x0642ca05693b9f70, 0x0321658cba93c138,
        0x86275df09ce8aaa8, 0x439da0784e745554, 0xafc0503c273aa42a, 0xd960281e9d1d5215,
        0xe230140fc0802984, 0x71180a8960409a42, 0xb60c05ca30204d21, 0x5b068c651810a89e,
        0x456c34887a3805b9, 0xac361a443d1c8cd2, 0x561b0d22900e4669, 0x2b838811480723ba,
        0x9bcf4486248d9f5d, 0xc3e9224312c8c1a0, 0xeffa11af0964ee50, 0xf97d86d98a327728,
        0xe4fa2054a80b329c, 0x727d102a548b194e, 0x39b008152acb8227, 0x9258048415eb419d,
        0x492c024284fbaec0, 0xaa16012142f35760, 0x550b8e9e21f7a530, 0xa48b474f9ef5dc18,
        0x70a6a56e2440598e, 0x3853dc371220a247, 0x1ca76e95091051ad, 0x0edd37c48a08a6d8,
        0x07e095624504536c, 0x8d70c431ac02a736, 0xc83862965601dd1b, 0x641c314b2b8ee083
        };
                // перестановка байт
                private static readonly byte[] t = {
        0, 8, 16, 24, 32, 40, 48, 56,
        1, 9, 17, 25, 33, 41, 49, 57,
        2, 10, 18, 26, 34, 42, 50, 58,
        3, 11, 19, 27, 35, 43, 51, 59,
        4, 12, 20, 28, 36, 44, 52, 60,
        5, 13, 21, 29, 37, 45, 53, 61,
        6, 14, 22, 30, 38, 46, 54, 62,
        7, 15, 23, 31, 39, 47, 55, 63
        };
                // итерационные константы
                private static readonly byte[][] C = {
        new byte[64]{
        0xb1,0x08,0x5b,0xda,0x1e,0xca,0xda,0xe9,0xeb,0xcb,0x2f,0x81,0xc0,0x65,0x7c,0x1f,
        0x2f,0x6a,0x76,0x43,0x2e,0x45,0xd0,0x16,0x71,0x4e,0xb8,0x8d,0x75,0x85,0xc4,0xfc,
        0x4b,0x7c,0xe0,0x91,0x92,0x67,0x69,0x01,0xa2,0x42,0x2a,0x08,0xa4,0x60,0xd3,0x15,
        0x05,0x76,0x74,0x36,0xcc,0x74,0x4d,0x23,0xdd,0x80,0x65,0x59,0xf2,0xa6,0x45,0x07
        },
        new byte[64]{
        0x6f,0xa3,0xb5,0x8a,0xa9,0x9d,0x2f,0x1a,0x4f,0xe3,0x9d,0x46,0x0f,0x70,0xb5,0xd7,
        0xf3,0xfe,0xea,0x72,0x0a,0x23,0x2b,0x98,0x61,0xd5,0x5e,0x0f,0x16,0xb5,0x01,0x31,
        0x9a,0xb5,0x17,0x6b,0x12,0xd6,0x99,0x58,0x5c,0xb5,0x61,0xc2,0xdb,0x0a,0xa7,0xca,
        0x55,0xdd,0xa2,0x1b,0xd7,0xcb,0xcd,0x56,0xe6,0x79,0x04,0x70,0x21,0xb1,0x9b,0xb7
        },
        new byte[64]{
        0xf5,0x74,0xdc,0xac,0x2b,0xce,0x2f,0xc7,0x0a,0x39,0xfc,0x28,0x6a,0x3d,0x84,0x35,
        0x06,0xf1,0x5e,0x5f,0x52,0x9c,0x1f,0x8b,0xf2,0xea,0x75,0x14,0xb1,0x29,0x7b,0x7b,
        0xd3,0xe2,0x0f,0xe4,0x90,0x35,0x9e,0xb1,0xc1,0xc9,0x3a,0x37,0x60,0x62,0xdb,0x09,
        0xc2,0xb6,0xf4,0x43,0x86,0x7a,0xdb,0x31,0x99,0x1e,0x96,0xf5,0x0a,0xba,0x0a,0xb2
        },
        new byte[64]{
        0xef,0x1f,0xdf,0xb3,0xe8,0x15,0x66,0xd2,0xf9,0x48,0xe1,0xa0,0x5d,0x71,0xe4,0xdd,
        0x48,0x8e,0x85,0x7e,0x33,0x5c,0x3c,0x7d,0x9d,0x72,0x1c,0xad,0x68,0x5e,0x35,0x3f,
        0xa9,0xd7,0x2c,0x82,0xed,0x03,0xd6,0x75,0xd8,0xb7,0x13,0x33,0x93,0x52,0x03,0xbe,
        0x34,0x53,0xea,0xa1,0x93,0xe8,0x37,0xf1,0x22,0x0c,0xbe,0xbc,0x84,0xe3,0xd1,0x2e
        },
        new byte[64]{
        0x4b,0xea,0x6b,0xac,0xad,0x47,0x47,0x99,0x9a,0x3f,0x41,0x0c,0x6c,0xa9,0x23,0x63,
        0x7f,0x15,0x1c,0x1f,0x16,0x86,0x10,0x4a,0x35,0x9e,0x35,0xd7,0x80,0x0f,0xff,0xbd,
        0xbf,0xcd,0x17,0x47,0x25,0x3a,0xf5,0xa3,0xdf,0xff,0x00,0xb7,0x23,0x27,0x1a,0x16,
        0x7a,0x56,0xa2,0x7e,0xa9,0xea,0x63,0xf5,0x60,0x17,0x58,0xfd,0x7c,0x6c,0xfe,0x57
        },
        new byte[64]{
        0xae,0x4f,0xae,0xae,0x1d,0x3a,0xd3,0xd9,0x6f,0xa4,0xc3,0x3b,0x7a,0x30,0x39,0xc0,
        0x2d,0x66,0xc4,0xf9,0x51,0x42,0xa4,0x6c,0x18,0x7f,0x9a,0xb4,0x9a,0xf0,0x8e,0xc6,
        0xcf,0xfa,0xa6,0xb7,0x1c,0x9a,0xb7,0xb4,0x0a,0xf2,0x1f,0x66,0xc2,0xbe,0xc6,0xb6,
        0xbf,0x71,0xc5,0x72,0x36,0x90,0x4f,0x35,0xfa,0x68,0x40,0x7a,0x46,0x64,0x7d,0x6e
        },
        new byte[64]{
        0xf4,0xc7,0x0e,0x16,0xee,0xaa,0xc5,0xec,0x51,0xac,0x86,0xfe,0xbf,0x24,0x09,0x54,
        0x39,0x9e,0xc6,0xc7,0xe6,0xbf,0x87,0xc9,0xd3,0x47,0x3e,0x33,0x19,0x7a,0x93,0xc9,
        0x09,0x92,0xab,0xc5,0x2d,0x82,0x2c,0x37,0x06,0x47,0x69,0x83,0x28,0x4a,0x05,0x04,
        0x35,0x17,0x45,0x4c,0xa2,0x3c,0x4a,0xf3,0x88,0x86,0x56,0x4d,0x3a,0x14,0xd4,0x93
        },
        new byte[64]{
        0x9b,0x1f,0x5b,0x42,0x4d,0x93,0xc9,0xa7,0x03,0xe7,0xaa,0x02,0x0c,0x6e,0x41,0x41,
        0x4e,0xb7,0xf8,0x71,0x9c,0x36,0xde,0x1e,0x89,0xb4,0x44,0x3b,0x4d,0xdb,0xc4,0x9a,
        0xf4,0x89,0x2b,0xcb,0x92,0x9b,0x06,0x90,0x69,0xd1,0x8d,0x2b,0xd1,0xa5,0xc4,0x2f,
        0x36,0xac,0xc2,0x35,0x59,0x51,0xa8,0xd9,0xa4,0x7f,0x0d,0xd4,0xbf,0x02,0xe7,0x1e
        },
        new byte[64]{
        0x37,0x8f,0x5a,0x54,0x16,0x31,0x22,0x9b,0x94,0x4c,0x9a,0xd8,0xec,0x16,0x5f,0xde,
        0x3a,0x7d,0x3a,0x1b,0x25,0x89,0x42,0x24,0x3c,0xd9,0x55,0xb7,0xe0,0x0d,0x09,0x84,
        0x80,0x0a,0x44,0x0b,0xdb,0xb2,0xce,0xb1,0x7b,0x2b,0x8a,0x9a,0xa6,0x07,0x9c,0x54,
        0x0e,0x38,0xdc,0x92,0xcb,0x1f,0x2a,0x60,0x72,0x61,0x44,0x51,0x83,0x23,0x5a,0xdb
        },
        new byte[64]{
        0xab,0xbe,0xde,0xa6,0x80,0x05,0x6f,0x52,0x38,0x2a,0xe5,0x48,0xb2,0xe4,0xf3,0xf3,
        0x89,0x41,0xe7,0x1c,0xff,0x8a,0x78,0xdb,0x1f,0xff,0xe1,0x8a,0x1b,0x33,0x61,0x03,
        0x9f,0xe7,0x67,0x02,0xaf,0x69,0x33,0x4b,0x7a,0x1e,0x6c,0x30,0x3b,0x76,0x52,0xf4,
        0x36,0x98,0xfa,0xd1,0x15,0x3b,0xb6,0xc3,0x74,0xb4,0xc7,0xfb,0x98,0x45,0x9c,0xed
        },
        new byte[64]{
        0x7b,0xcd,0x9e,0xd0,0xef,0xc8,0x89,0xfb,0x30,0x02,0xc6,0xcd,0x63,0x5a,0xfe,0x94,
        0xd8,0xfa,0x6b,0xbb,0xeb,0xab,0x07,0x61,0x20,0x01,0x80,0x21,0x14,0x84,0x66,0x79,
        0x8a,0x1d,0x71,0xef,0xea,0x48,0xb9,0xca,0xef,0xba,0xcd,0x1d,0x7d,0x47,0x6e,0x98,
        0xde,0xa2,0x59,0x4a,0xc0,0x6f,0xd8,0x5d,0x6b,0xca,0xa4,0xcd,0x81,0xf3,0x2d,0x1b
        },
        new byte[64]{
        0x37,0x8e,0xe7,0x67,0xf1,0x16,0x31,0xba,0xd2,0x13,0x80,0xb0,0x04,0x49,0xb1,0x7a,
        0xcd,0xa4,0x3c,0x32,0xbc,0xdf,0x1d,0x77,0xf8,0x20,0x12,0xd4,0x30,0x21,0x9f,0x9b,
        0x5d,0x80,0xef,0x9d,0x18,0x91,0xcc,0x86,0xe7,0x1d,0xa4,0xaa,0x88,0xe1,0x28,0x52,
        0xfa,0xf4,0x17,0xd5,0xd9,0xb2,0x1b,0x99,0x48,0xbc,0x92,0x4a,0xf1,0x1b,0xd7,0x20
        }
        };

                private static byte[] ReorderArray(byte[] array)
                {
                    byte[] tmp = new byte[array.Length];
                    for (int i = 0; i < array.Length; i++)
                        tmp[i] = array[array.Length - i - 1];
                    return tmp;
                }

                private static byte[] AddMod512(byte[] a, byte[] b) // Сложение в кольце 2^512
                {
                    byte[] tmp = ((new BigInteger(a) + new BigInteger(b)) % BigInteger.Pow(2, 512)).ToByteArray();
                    byte[] res = new byte[64];
                    try
                    {
                        Array.Copy(tmp, 0, res, 0, tmp.Length);
                    }
                    catch (Exception ex)
                    {
                        Array.Copy(tmp, 0, res, 0, 64);
                    }

                    return res;
                }
                private static byte[] CompressionFunction(byte[] N, byte[] h, byte[] m) // Функция сжатия 
                {
                    byte[] result = TransS(TransX(h, N));
                    result = TransP(result);
                    result = TransL(result);
                    result = TransE(result, m);
                    result = TransX(result, h);
                    result = TransX(result, m);
                    return result;
                }
                private static byte[] TransE(byte[] K, byte[] m) // Е преобразование
                {
                    byte[] result = m;
                    for (int i = 0; i < 12; i++)
                    {
                        result = TransX(K, result);
                        result = TransS(result);
                        result = TransP(result);
                        result = TransL(result);
                        K = GetNextK(K, i);
                    }
                    result = TransX(K, result);
                    return result;
                }
                private static byte[] GetNextK(byte[] K, int i)
                {
                    // Вычисляем следующий итерационный ключ
                    // K - предыдущий ключ, i - номер итерации
                    byte[] result = TransX(K, C[i].Reverse().ToArray());
                    result = TransS(result);
                    result = TransP(result);
                    result = TransL(result);
                    return result;
                }
                private static byte[] TransL(byte[] a) // L-преобразование
                {
                    byte[] result = new byte[64];
                    for (int i = 0; i < 8; i++)
                    {
                        ulong t = 0;
                        byte[] tempArray = new byte[8];
                        Array.Copy(a, i * 8, tempArray, 0, 8);
                        tempArray = tempArray.ToArray();
                        BitArray tempBits1 = new BitArray(tempArray);
                        bool[] tempBits = new bool[64];
                        tempBits1.CopyTo(tempBits, 0);
                        tempBits = tempBits.Reverse().ToArray();
                        for (int j = 0; j < 64; j++)
                        {
                            if (tempBits[j] != false)
                            {
                                t = t ^ l[j];
                            }
                        }
                        byte[] resPart = BitConverter.GetBytes(t);
                        Array.Copy(resPart, 0, result, i * 8, 8);
                    }
                    return result;
                }
                private static byte[] TransP(byte[] a) // P-преобразование
                {
                    byte[] result = new byte[64];
                    for (int i = 0; i < 64; i++)
                    {
                        result[i] = a[t[i]];
                    }
                    return result;
                }
                private static byte[] TransS(byte[] a) // S-преобразование
                {
                    byte[] result = new byte[64];
                    for (int i = 0; i < 64; i++)
                    {
                        result[i] = pi[a[i]];
                    }
                    return result;
                }
                private static byte[] TransX(byte[] k, byte[] a) // X-преобразование
                {
                    byte[] result = new byte[64];
                    for (int i = 0; i < 64; i++)
                    {
                        result[i] = (byte)(k[i] ^ a[i]);
                    }
                    return result;
                }

                public static string GetHashGOST(byte[] arr, int hashLen)
                {
                    arr = ReorderArray(arr);

                    // Векторы для 512-битового и 256-битового хэша
                    byte[] vector0 = new byte[64]; // 0^512
                    byte[] vector1 = vector0.Select(x => (byte)1).ToArray();   // (00000001)^512

                    // Этап 1 - инициализация начальных параметров
                    byte[] IV = hashLen == 256 ? vector1 : vector0;
                    byte[] h = IV;
                    byte[] N = vector0;
                    byte[] Z = vector0;
                    byte[] m;
                    // Этап 2 - сжатие сообщения до размера < 512 бит
                    while (arr.Length > 64)
                    {
                        m = arr.Take(64).ToArray();
                        h = CompressionFunction(N, h, m);
                        N = AddMod512(N, ((BigInteger)512).ToByteArray());
                        Z = AddMod512(Z, m);
                        arr = arr.Skip(64).ToArray();
                    }
                    // Этап 3 - вычисление хэш-кода
                    m = new byte[64];
                    Array.Copy(arr, 0, m, 0, arr.Length);
                    m[arr.Length] = 1;
                    h = CompressionFunction(N, h, m);
                    N = AddMod512(N, ((BigInteger)arr.Length * 8).ToByteArray());
                    Z = AddMod512(Z, m);
                    h = CompressionFunction(vector0, h, N);
                    h = CompressionFunction(vector0, h, Z);

                    // Для 256-битового хэша
                    if (hashLen == 256) h = h.Skip(32).ToArray();

                    string str = "";
                    foreach (var bt in h)
                    {
                        var tmp = bt.ToString("x");
                        if (tmp.Length < 2)
                            tmp = "0" + tmp;
                        str = tmp + str;
                    }
                    return str;
                }
            }
        }

        private void f10_buttonNextPrimeQ_Click(object sender, EventArgs e)
        {
            f10_textQ.Text = new string(f10_textQ.Text.Where(t => char.IsDigit(t)).ToArray());

            BigInteger ParamQ;
            if (f10_textQ.TextLength > 0)
                ParamQ = BigInteger.Parse(f10_textQ.Text);
            else
                ParamQ = 0;
            if (++ParamQ % 2 == 0) ParamQ++;

            BigInteger ParamP = 2 * ParamQ + 1; 
            while (!RabinMiller.IsPrime(ParamQ, 3) || !RabinMiller.IsPrime(ParamP, 3))
            {
                ParamQ += 2;
                ParamP = 2 * ParamQ + 1;
            }

            f10_textQ.Text = Convert.ToString(ParamQ);
            f10_textP.Text = Convert.ToString(ParamP);
        }
        private void f10_buttonNextG_Click(object sender, EventArgs e)
        {
            f10_textP.Text = new string(f10_textP.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textQ.Text = new string(f10_textQ.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textG.Text = new string(f10_textG.Text.Where(t => char.IsDigit(t)).ToArray());

            BigInteger ParamP, ParamQ, ParamG = 0;
            if (f10_textP.TextLength > 0 && f10_textQ.TextLength > 0 && RabinMiller.IsPrime(ParamP = BigInteger.Parse(f10_textP.Text), 3)
                 && RabinMiller.IsPrime(ParamQ = BigInteger.Parse(f10_textQ.Text), 3))
            {
                RandomNumberGenerator rng = RandomNumberGenerator.Create();
                while (ParamG < 2 || ParamG >= ParamP - 1 || NumberTheory.BinaryModPow(ParamG, ParamQ, ParamP) == 1)
                {
                    ParamG = BigIntegerRandomUtils.RandomInRange(rng, 2, ParamP - 1);
                }
                f10_textG.Text = Convert.ToString(ParamG);
            }
        }
        private void f10_textANY_Param_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) e.Handled = true;
        }
        private void f10_buttonSetParams_Click(object sender, EventArgs e)
        {
            f10_textQ.Text = new string(f10_textQ.Text.Where(t => char.IsDigit(t)).ToArray());
            BigInteger ParamQ = 0;
            if (f10_textQ.TextLength > 0)
                ParamQ = BigInteger.Parse(f10_textQ.Text);            

            BigInteger ParamP = 2 * ParamQ + 1;
            f10_textP.Text = Convert.ToString(ParamP);

            f10_textG.Text = new string(f10_textG.Text.Where(t => char.IsDigit(t)).ToArray());
            BigInteger ParamG = 0;
            if (f10_textG.TextLength > 0)
                ParamG = BigInteger.Parse(f10_textG.Text) % ParamP;
            f10_textG.Text = Convert.ToString(ParamG);

            if (RabinMiller.IsPrime(ParamQ, 3) && RabinMiller.IsPrime(ParamP, 3) &&
                ((NumberTheory.BinaryModPow(ParamG, ParamQ, ParamP) != 1)))
                {
                f10_textQ.ReadOnly = true;
                f10_textG.ReadOnly = true;
                f10_buttonNextPrimeQ.Enabled = false;
                f10_buttonNextG.Enabled = false;
                f10_chooseHashFun.Enabled = false;
                f10_buttonSetParams.Enabled = false;
                f10_buttonClearParams.Enabled = true;

                f10_button_GetRandomSecret.Enabled = true;
                f10_button_GetRandomSessionK.Enabled = true;
                f10_textSessionKey.ReadOnly = false;
                f10_textSecretKey.ReadOnly = false;
                f10_button_SetSecretKey.Enabled = true;
                f10_button_ClearSecretKey.Enabled = false;
            }



        }
        private void f10_buttonClearParams_Click(object sender, EventArgs e)
        {
            f10_textQ.ReadOnly = false;
            f10_textG.ReadOnly = false;
            f10_buttonNextPrimeQ.Enabled = true;
            f10_buttonNextG.Enabled = true;
            f10_chooseHashFun.Enabled = true;
            f10_buttonSetParams.Enabled = true;
            f10_buttonClearParams.Enabled = false;

            f10_textSecretKey.Text = "";
            f10_textSessionKey.Text = "";
            f10_textOpenKey.Text = "";
            f10_textBoxSign.Text = "";
            f10_textBoxSignR.Text = "";
            f10_button_GetRandomSecret.Enabled = false;
            f10_button_GetRandomSessionK.Enabled = false;
            f10_textSessionKey.ReadOnly = true;
            f10_textSecretKey.ReadOnly = true;
            f10_button_SetSecretKey.Enabled = false;
            f10_button_ClearSecretKey.Enabled = false;

        }
        private void f10_button_GetRandomSecret_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            BigInteger P = BigInteger.Parse(f10_textP.Text);
            BigInteger SecretKey = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 2);            
            f10_textSecretKey.Text = Convert.ToString(SecretKey);
        }
        private void f10_button_GetRandomSessionK_Click(object sender, EventArgs e)
        {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            BigInteger P = BigInteger.Parse(f10_textP.Text);
            BigInteger Session = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 2);
            while (NumberTheory.GCD(Session, P - 1, out BigInteger x, out BigInteger y) != 1)
                Session = BigIntegerRandomUtils.RandomInRange(rng, 2, P - 2);
            f10_textSessionKey.Text = Convert.ToString(Session);
        }
        private void f10_button_SetSecretKey_Click(object sender, EventArgs e)
        {
            BigInteger P = BigInteger.Parse(f10_textP.Text);
            BigInteger G = BigInteger.Parse(f10_textG.Text);

            f10_textSecretKey.Text = new string(f10_textSecretKey.Text.Where(t => char.IsDigit(t)).ToArray());
            BigInteger SecretKey = 0;
            if (f10_textSecretKey.TextLength > 0)
                SecretKey = BigInteger.Parse(f10_textSecretKey.Text);

            f10_textSessionKey.Text = new string(f10_textSessionKey.Text.Where(t => char.IsDigit(t)).ToArray());
            BigInteger SessionKey = 0;
            if (f10_textSessionKey.TextLength > 0)
                SessionKey = BigInteger.Parse(f10_textSessionKey.Text);


            if (1 < SecretKey && SecretKey < P - 1 && 1 < SessionKey && SessionKey < P - 1 &&
                NumberTheory.GCD(SessionKey, P - 1, out BigInteger x, out BigInteger y) == 1)
            {
                f10_textOpenKey.Text = Convert.ToString(NumberTheory.BinaryModPow(G, SecretKey, P));
                f10_textSecretKey.ReadOnly = true;
                f10_textSessionKey.ReadOnly = true;
                f10_button_ClearSecretKey.Enabled = true;
                f10_button_GetRandomSecret.Enabled = false;
                f10_button_GetRandomSessionK.Enabled = false;
                f10_button_SetSecretKey.Enabled = false;
                f10_buttonSign.Enabled = true;
            }
        }
        private void f10_button_ClearSecretKey_Click(object sender, EventArgs e)
        {
            f10_textSecretKey.ReadOnly = false;
            f10_textSessionKey.ReadOnly = false; ;
            f10_button_ClearSecretKey.Enabled = false;
            f10_button_GetRandomSecret.Enabled = true;
            f10_button_GetRandomSessionK.Enabled = true;
            f10_button_SetSecretKey.Enabled = true;
            f10_buttonSign.Enabled = false;
        }
        private void f10_buttonSign_Click(object sender, EventArgs e)
        {
            BigInteger P = BigInteger.Parse(f10_textP.Text);
            BigInteger G = BigInteger.Parse(f10_textG.Text);
            BigInteger X = BigInteger.Parse(f10_textSecretKey.Text);
            BigInteger K = BigInteger.Parse(f10_textSessionKey.Text);

            //Открываем документ и вычисляем его хэш-функцию в переменную fileHash
            string fileHash = "";
            OpenFileDialog Load = new OpenFileDialog();
            Load.InitialDirectory = "D:\\Учеба\\Крипта 2\\Labs\\Labs\\bin\\Debug\\TextFiles";
            Load.DefaultExt = "txt";
            Load.FileName = "in.txt";
            Load.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Load.FilterIndex = 2;
            Load.RestoreDirectory = true;
            Load.Multiselect = false;
            string sFileName;
            if (Load.ShowDialog() == DialogResult.OK)
            {
                sFileName = Load.FileName;
                byte[] file = File.ReadAllBytes(Load.FileName);

                //Вычисление хэш-строки
                if (f10_chooseHashFun.Text == "MD5")
                    fileHash = HashFunctions.MD5.GetHashMD5(file);
                if (f10_chooseHashFun.Text == "SHA-1")
                    fileHash = HashFunctions.SHA1.GetHashSHA1(file);
                if (f10_chooseHashFun.Text == "ГОСТ Р 34.11-2012 256 бит")
                    fileHash = HashFunctions.GOST.GetHashGOST(file, 256);
                if (f10_chooseHashFun.Text == "ГОСТ Р 34.11-2012 512 бит")
                    fileHash = HashFunctions.GOST.GetHashGOST(file, 512);
            }

            BigInteger hashDigit = new BigInteger(Encoding.Default.GetBytes(fileHash));
            BigInteger r = NumberTheory.BinaryModPow(G, K, P);
            BigInteger u = (hashDigit - X * r) % (P - 1);
            u = (u + (P - 1)) % (P - 1);
            BigInteger antiK = NumberTheory.Foo(K, P - 1);
            BigInteger s = (antiK * u) % (P - 1);

            if (s > 0 && r > 0)
            {
                if (hashDigit > P) MessageBox.Show(("Подпись небезопасна: используйте значение P, большее h(m) = " + Convert.ToString(hashDigit)), "Предупреждение");
                f10_textBoxSign.Text = Convert.ToString(s);
                f10_textBoxSignR.Text = Convert.ToString(r);
            }                
            else
            {
                f10_textBoxSign.Text = "";
                f10_textBoxSignR.Text = "";
            }               
        }
        private void f10_buttonSendSign_Click(object sender, EventArgs e)
        {
            f10_chooseHashFunRecieved.Text = f10_chooseHashFun.Text;
            f10_textOpenKeyRecieved.Text = f10_textOpenKey.Text;
            f10_textBoxSignS_Recieved.Text = f10_textBoxSign.Text;
            f10_textBoxSignR_Recieved.Text = f10_textBoxSignR.Text;
            f10_textP_Recieved.Text = f10_textP.Text;
            f10_textG_Recieved.Text = f10_textG.Text;
        }
        private void f10_buttonCheckSign_Click(object sender, EventArgs e)
        {
            //Удаление недопустимых символов
            f10_textOpenKeyRecieved.Text = new string(f10_textOpenKeyRecieved.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textBoxSignS_Recieved.Text = new string(f10_textBoxSignS_Recieved.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textBoxSignR_Recieved.Text = new string(f10_textBoxSignR_Recieved.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textP_Recieved.Text = new string(f10_textP_Recieved.Text.Where(t => char.IsDigit(t)).ToArray());
            f10_textG_Recieved.Text = new string(f10_textG_Recieved.Text.Where(t => char.IsDigit(t)).ToArray());

            //Считывание полученных параметров подписи            
            BigInteger OpenKey = 0;
            if (f10_textOpenKeyRecieved.TextLength > 0)
                OpenKey = BigInteger.Parse(f10_textOpenKeyRecieved.Text);

            BigInteger SignS = 0;
            if (f10_textBoxSignS_Recieved.TextLength > 0)
                SignS = BigInteger.Parse(f10_textBoxSignS_Recieved.Text);

            BigInteger SignR = 0;
            if (f10_textBoxSignR_Recieved.TextLength > 0)
                SignR = BigInteger.Parse(f10_textBoxSignR_Recieved.Text);

            BigInteger P = 0;
            if (f10_textP_Recieved.TextLength > 0)
                P = BigInteger.Parse(f10_textP_Recieved.Text);

            BigInteger G = 0;
            if (f10_textG_Recieved.TextLength > 0)
                G = BigInteger.Parse(f10_textG_Recieved.Text);

            //Открываем документ и вычисляем его хэш-функцию в переменную fileHash
            string fileHash = "";
            OpenFileDialog Load = new OpenFileDialog();
            Load.InitialDirectory = "D:\\Учеба\\Крипта 2\\Labs\\Labs\\bin\\Debug\\TextFiles";
            Load.DefaultExt = "txt";
            Load.FileName = "in.txt";
            Load.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            Load.FilterIndex = 2;
            Load.RestoreDirectory = true;
            Load.Multiselect = false;
            string sFileName;
            if (Load.ShowDialog() == DialogResult.OK)
            {
                sFileName = Load.FileName;
                byte[] file = File.ReadAllBytes(Load.FileName);

                //Вычисление хэш-строки
                if (f10_chooseHashFunRecieved.Text == "MD5")
                    fileHash = HashFunctions.MD5.GetHashMD5(file);
                if (f10_chooseHashFunRecieved.Text == "SHA-1")
                    fileHash = HashFunctions.SHA1.GetHashSHA1(file);
                if (f10_chooseHashFunRecieved.Text == "ГОСТ Р 34.11-2012 256 бит")
                    fileHash = HashFunctions.GOST.GetHashGOST(file, 256);
                if (f10_chooseHashFunRecieved.Text == "ГОСТ Р 34.11-2012 512 бит")
                    fileHash = HashFunctions.GOST.GetHashGOST(file, 512);
            }

            BigInteger hashDigit = new BigInteger(Encoding.Default.GetBytes(fileHash)); //Вычисляем хэш файла

            if (OpenKey > 0 && SignS > 0 && SignR > 0)
            {
                BigInteger left = NumberTheory.BinaryModPow(OpenKey, SignR, P) *
                    NumberTheory.BinaryModPow(SignR, SignS, P);
                BigInteger right = NumberTheory.BinaryModPow(G, hashDigit, P);
                if (left % P == right)
                    f10_textVerificationResult.Text = "Подпись верна";
                else
                    f10_textVerificationResult.Text = "Подпись неверна";
            }
            else
            {
                f10_textVerificationResult.Text = "Подпись неверна";
            }
        }
    }
}
