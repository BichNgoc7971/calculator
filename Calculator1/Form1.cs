using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KetQua = a + b;
            txtKetqua.Text = KetQua.ToString();
        }
        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KetQua = a - b;
            txtKetqua.Text = KetQua.ToString();
        }

    }
}
