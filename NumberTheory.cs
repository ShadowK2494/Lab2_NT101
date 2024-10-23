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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Eventing.Reader;
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

        // Hàm tách hai số từ chuỗi đầu vào
        static BigInteger[] ExtractTwoNumbers(string input)
        {
            // Thay thế các dấu phân cách (, ; hoặc dấu cách) bằng dấu cách
            string cleanedInput = input.Replace(",", " ").Replace(";", " ");

            // Tách chuỗi dựa trên dấu cách, loại bỏ các chuỗi rỗng
            string[] parts = cleanedInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Kiểm tra nếu có đúng 2 phần tử và cả hai đều là số hợp lệ
            if (parts.Length == 2 && BigInteger.TryParse(parts[0], out BigInteger num1) && BigInteger.TryParse(parts[1], out BigInteger num2))
            {
                return new[] { num1, num2 };
            }

            // Nếu không hợp lệ, trả về null
            return null;
        }

        // Hàm tìm ước chung lớn nhất (GCD) của hai số BigInteger
        static BigInteger FindGCD(BigInteger a, BigInteger b)
        {
            // Sử dụng thuật toán Euclid
            while (b != 0)
            {
                BigInteger remainder = a % b;
                a = b;
                b = remainder;
            }
            return BigInteger.Abs(a); // Trả về giá trị tuyệt đối của GCD
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbInput.Text = null;
            tbText.Text = null;
        }

        private void NumberTheory_Load(object sender, EventArgs e)
        {
            tbInput.Text = null;
            tbText.Text = null;
        }

        private void btn1_1_8_Click(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(8).ToString();
        }

        private void btn1_1_16_Click(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(16).ToString();
        }

        private void btn1_1_64_Click(object sender, EventArgs e)
        {
            tbText.Text = GeneratePrime(64).ToString();
        }

        private void btn1_2_Click(object sender, EventArgs e)
        {
            // Danh sách 10 số nguyên tố Mersenne đầu tiên
            List<BigInteger> mersennePrimes = new List<BigInteger>
            {
                new BigInteger(3),
                new BigInteger(7),
                new BigInteger(31),
                new BigInteger(127),
                new BigInteger(8191),
                new BigInteger(131071),
                new BigInteger(524287),
                new BigInteger(2147483647),
                //new BigInteger(2305843009213693951),
                //BigInteger.Parse("2305843009213693951")
                //BigInteger.Parse("618970019642690137449562111")
            };

            tbText.Text = "8 số nguyên tố lớn nhất dưới 8 số nguyên tố Mersenne đầu tiên: ";

            // Kiểm tra tất cả các số nhỏ hơn từng số Mersenne và thêm vào danh sách nếu là số nguyên tố
            foreach (var mersennePrime in mersennePrimes)
            {
                for (BigInteger i = mersennePrime - 1; i > 1; i--)
                {
                    if (IsPrime(i))
                    {
                        tbText.Text += i.ToString() + ", ";
                        break;
                    }
                }
            }
        }

        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(tbInput.Text, out BigInteger n))
            {
                if (IsPrime(n))
                    tbText.Text = n.ToString() + " là số nguyên tố";
                else
                    tbText.Text = n.ToString() + " không phải số nguyên tố";
            }
            else
            {
                tbText.Text = null;
                MessageBox.Show("Nhập vào INPUT một số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Gọi hàm để tách hai số
            var numbers = ExtractTwoNumbers(tbInput.Text);

            if (numbers != null)
            {
                tbText.Text = ("Ước chung của hai số "+ numbers[0].ToString() + ", " + numbers[1].ToString()+" là : "+ FindGCD(numbers[0], numbers[1]).ToString());
            }
            else
            {
                tbText.Text = null;
                MessageBox.Show($"Nhập vào Input 2 số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static BigInteger ModularExponentiation(BigInteger a, BigInteger x, BigInteger p)
        {
            BigInteger result = 1;
            a = a % p; // giảm a mod p

            while (x > 0)
            {
                // Nếu x lẻ, nhân a với kết quả
                if ((x & 1) == 1) // x % 2 == 1
                {
                    result = (result * a) % p;
                }

                // x /= 2
                x >>= 1; // dịch phải 1 bit (tương đương x = x / 2)
                a = (a * a) % p; // a = a^2 mod p
            }
            return result;
        }

        // Hàm tách ba số từ chuỗi đầu vào
        static BigInteger[] ExtractThreeNumbers(string input)
        {
            // Thay thế các dấu phân cách (, ; hoặc dấu cách) bằng dấu cách
            string cleanedInput = input.Replace(",", " ").Replace(";", " ");

            // Tách chuỗi dựa trên dấu cách, loại bỏ các chuỗi rỗng
            string[] parts = cleanedInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Kiểm tra nếu có đúng 3 phần tử và cả ba đều là số hợp lệ
            if (parts.Length == 3 &&
                BigInteger.TryParse(parts[0], out BigInteger num1) &&
                BigInteger.TryParse(parts[1], out BigInteger num2) &&
                BigInteger.TryParse(parts[2], out BigInteger num3))
            {
                return new[] { num1, num2, num3 };
            }

            // Nếu không hợp lệ, trả về null
            return null;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Gọi hàm để tách ba số
            var numbers = ExtractThreeNumbers(tbInput.Text);

            if (numbers != null)
            {
                tbText.Text = ("Tính lũy thừa modular "+ numbers[0].ToString() + "^" + numbers[1].ToString()+" mod "+ numbers[2].ToString() + " bằng : "+ModularExponentiation(numbers[0], numbers[1], numbers[2]).ToString());
            }
            else
            {
                tbText.Text = null;
                MessageBox.Show($"Nhập vào Input 2 số nguyên!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
