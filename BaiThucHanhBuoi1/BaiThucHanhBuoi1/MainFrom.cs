using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaoChep.Text = Ten.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tenDaNhap = Ten.Text;
            MessageBox.Show($"Xin Chào bạn {tenDaNhap}. Rất vui được gặp bạn.", "Thông điệp chào mừng");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
