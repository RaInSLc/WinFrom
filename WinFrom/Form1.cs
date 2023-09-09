using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrom
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 弹窗事件
            MessageBox.Show("窗口测试");

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这是容器内的按钮");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.ActiveForm.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form1.ActiveForm.Text = "张麻子来喽";
        }
    }
}
