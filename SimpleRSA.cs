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
using System.Security.Cryptography;

namespace Lab3
{
    public partial class SimpleRSA : Form
    {
        public SimpleRSA()
        {
            InitializeComponent();
        }

        // Hàm tính nghịch đảo modulo
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            // Áp dụng Euclid mở rộng
            while (a > 1)
            {
                // q là thương
                q = a / m;
                t = m;

                // m là số dư, tương đương với a % m
                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            // Đảm bảo x1 dương
            if (x1 < 0)
                x1 += m0;

            return x1;
        }


        private void GenerateRSAKeys(out BigInteger e, out BigInteger d, out BigInteger n)
        {
            BigInteger p, q;

            // Kiểm tra nếu tbP và tbQ có giá trị, nếu không tạo giá trị ngẫu nhiên
            if (BigInteger.TryParse(tbP.Text, out p) && BigInteger.TryParse(tbQ.Text, out q))
            {
                
            }
            else
            {
                // Nếu không có giá trị hợp lệ, tự động tạo p, q ngẫu nhiên (ví dụ đơn giản)
                p = GenerateRandomPrime();
                tbP.Text = p.ToString();
                q = GenerateRandomPrime();
                tbQ.Text = q.ToString();
            }

            // Tính toán n = p * q
            n = p * q;
            BigInteger phi = (p - 1) * (q - 1); // Phi(n)

            // Kiểm tra nếu tbE có giá trị, nếu không tạo giá trị ngẫu nhiên
            if (!BigInteger.TryParse(tbE.Text, out e))
            {
                e = 65537; // Giá trị e phổ biến
                tbE.Text = e.ToString();
            }

            // Tính d (khóa riêng tư) bằng cách tìm nghịch đảo của e mod phi
            d = ModInverse(e, phi);
        }

        //Hàm kiểm tra số nguyên tố 
        private bool IsPrime(BigInteger number)
        {
            if (number < 2)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            BigInteger i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }

        // Hàm tạo số nguyên tố ngẫu nhiên 
        private BigInteger GenerateRandomPrime(int bitLength = 32)
        {
            Random random = new Random();
            BigInteger prime;

            do
            {
                prime = GenerateRandomBigInteger(bitLength);

                // Đảm bảo rằng số sinh ra là lẻ (số chẵn không thể là số nguyên tố trừ số 2)
                if (prime % 2 == 0)
                {
                    prime += 1;
                }

            } while (!IsPrime(prime));

            return prime;
        }

        private BigInteger GenerateRandomBigInteger(int bitLength)
        {
            byte[] bytes = new byte[bitLength / 8];

            // Sử dụng RNGCryptoServiceProvider để sinh số ngẫu nhiên an toàn
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            return new BigInteger(bytes) | 1; // Đảm bảo số sinh ra là số dương và lẻ
        }




        private void btnMahoa_Click(object sender, EventArgs e)
        {
            pbCode.Show();
            pbDecode.Hide();

            BigInteger E, d, n;
            GenerateRSAKeys(out E, out d, out n); // Tạo cặp khóa từ giá trị nhập

            // Lấy thông điệp cần mã hóa từ TextBox
            string message = tbPlaintext.Text;

            // Chuyển đổi thông điệp thành số nguyên
            var messageBytes = Encoding.UTF8.GetBytes(message);
            BigInteger messageInt = new BigInteger(messageBytes);

            // Mã hóa thông điệp
            BigInteger cipher = BigInteger.ModPow(messageInt, E, n);

            // Hiển thị kết quả mã hóa
            tbCiphertext.Text = cipher.ToString();
        }

        private void btnGiaima_Click(object sender, EventArgs e)
        {
            pbDecode.Show();
            pbCode.Hide();

            BigInteger E, d, n;
            GenerateRSAKeys(out E, out d, out n); // Tạo cặp khóa từ giá trị nhập

            // Lấy thông điệp mã hóa từ TextBox
            BigInteger cipher = BigInteger.Parse(tbCiphertext.Text);

            // Giải mã thông điệp
            BigInteger decryptedMessageInt = BigInteger.ModPow(cipher, d, n);

            // Chuyển đổi số nguyên thành chuỗi
            var decryptedBytes = decryptedMessageInt.ToByteArray();
            string decryptedMessage = Encoding.UTF8.GetString(decryptedBytes);

            // Hiển thị thông điệp đã giải mã
            tbPlaintext.Text = decryptedMessage;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCiphertext.Text = null;
            tbPlaintext.Text = null;
            tbE.Text = null;
            tbP.Text = null;
            tbQ.Text = null;
            pbCode.Hide();
            pbDecode.Hide();
        }

        private void SimpleRSA_Load(object sender, EventArgs e)
        {
            pbCode.Hide();
            pbDecode.Hide();
        }
    }
}
