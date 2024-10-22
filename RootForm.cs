using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberTheory numberTheory = new NumberTheory();
            numberTheory.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SimpleRSA rsa = new SimpleRSA();
            rsa.Show();
        }
    }
}
