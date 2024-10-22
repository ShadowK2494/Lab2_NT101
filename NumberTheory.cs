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
using System.U

namespace Lab3
{
    public partial class NumberTheory : Form
    {
        public NumberTheory()
        {
            InitializeComponent();
        }

        // Hàm sinh số BigInteger ngẫu nhiên trong khoảng [min, max]
        static BigInteger GenerateRandomBigInteger(BigInteger min, BigInteger max, Random random)
        {
            BigInteger result;
            do
            {
                byte[] bytes = max.ToByteArray();
                random.NextBytes(bytes);  // Tạo mảng byte ngẫu nhiên
                bytes[bytes.Length - 1] &= 0x7F;  // Bảo đảm số không âm
                result = new BigInteger(bytes);
            } while (result < min || result > max);

            return result;
        }

        // Hàm kiểm tra tính nguyên tố bằng thuật toán Miller-Rabin
        static bool IsProbablePrime(BigInteger n, int k)
        {
            if (n < 2)
                return false;
            if (n == 2 || n == 3)
                return true;
            if (n % 2 == 0)
                return false;

            BigInteger d = n - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random random = new Random();

            for (int i = 0; i < k; i++)
            {
                BigInteger a = GenerateRandomBigInteger(2, n - 2, random); // Thay thế random.Next()
                BigInteger x = BigInteger.ModPow(a, d, n);

                if (x == 1 || x == n - 1)
                    continue;


                bool continueLoop = false;

                for (int r = 0; r < s - 1; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);

                    if (x == 1)
                        return false;

                    if (x == n - 1)
                    {
                        continueLoop = true;
                        break;
                    }
                }

                if (!continueLoop)
                    return false;
            }

            return true;
        }

        // Hàm để tạo số nguyên tố ngẫu nhiên với độ dài bit được cung cấp
        static BigInteger GeneratePrime(int bits)
        {
            Random random = new Random();
            BigInteger prime;

            do
            {
                prime = GenerateRandomNumber(bits, random);
            } while (!IsProbablePrime(prime, 10)); // Kiểm tra nguyên tố bằng thuật toán Miller-Rabin

            return prime;
        }

        // Hàm tạo số ngẫu nhiên với độ dài bit được chỉ định
        static BigInteger GenerateRandomNumber(int bits, Random random)
        {
            byte[] bytes = new byte[(bits + 7) / 8]; // Số byte cần thiết cho số bit
            random.NextBytes(bytes);

            BigInteger number = new BigInteger(bytes);
            number = BigInteger.Abs(number); // Loại bỏ số âm
            number |= BigInteger.One << (bits - 1); // Đảm bảo độ dài đủ số bit
            number |= 1; // Đảm bảo số là lẻ (số chẵn không thể là số nguyên tố trừ số 2)

            return number;
        }

        private void btn8bitprime_CheckedChanged(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(8).ToString();
        }

        private void btn16bitprime_CheckedChanged(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(16).ToString();
        }

        private void btn64bitprime_CheckedChanged(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(64).ToString();
        }

        // Hàm tính căn bậc hai của BigInteger
        static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                BigInteger x = n / 2 + 1;
                BigInteger y = (x + n / x) / 2;
                while (y < x)
                {
                    x = y;
                    y = (x + n / x) / 2;
                }
                return x;
            }
            throw new ArithmeticException("NaN");
        }

        // Hàm kiểm tra tính nguyên tố
        static bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            for (BigInteger i = 3; i <= Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private void btnMersenne_CheckedChanged(object sender, EventArgs e)
        {
            // Danh sách 10 số nguyên tố Mersenne đầu tiên
            List<UInt128>
            List<BigInteger> mersennePrimes = new List<BigInteger>
            {
                //new BigInteger(3),
                //new BigInteger(7),
                //new BigInteger(31),
                //new BigInteger(127),
                //new BigInteger(8191),
                //new BigInteger(131071),
                //new BigInteger(524287),
                //new BigInteger(2147483647),
                new BigInteger(2305843009213693951),
                //BigInteger.Parse("2305843009213693951")
                //BigInteger.Parse("618970019642690137449562111")
            };

            Console.WriteLine(mersennePrimes[0]);
            //tbText.Text = mersennePrimes[0].ToString();

            //tbText.Text = "10 số nguyên tố lớn nhất dưới 10 số nguyên tố Mersenne đầu tiên: ";

            // Kiểm tra tất cả các số nhỏ hơn từng số Mersenne và thêm vào danh sách nếu là số nguyên tố
            foreach (var mersennePrime in mersennePrimes)
            {
                for (BigInteger i = mersennePrime - 1; i > 1; i--)
                {
                    if (IsPrime(i))
                    {
                        tbText.Text += i.ToString() + " ";
                        break;
                    }
                }
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
