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
    public partial class formLearn : Form
    {
        public formLearn()
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
            formLearn.ActiveForm.BackColor = Color.Green;
            MessageBox.Show("换背景成功");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLearn.ActiveForm.Text = "张麻子来喽";
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("这是双击事件");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("这是hover事件", "这是hover事件");
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("这是e.Button.ToString", e.Button.ToString());

            //MessageBox.Show("鼠标点击事件", "鼠标点击事件");
            
           
                MessageBox.Show(e.Button.ToString(), e.Button.ToString());
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            //Form2.ActiveForm.Show(); 无效写法
            //Form f2 = new Form2();
            //f2.Show();
            if (textBox1.Text == "123" && textBox2.Text == "123")
            {
                //MessageBox.Show("登录成功");
                new Form2().Show();
                // 直接隐藏当前窗口
                Hide();
            }
            else
            {
                MessageBox.Show("请检查输入的内容");
            }
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 完全关闭所有线程的退出
            System.Environment.Exit(0);
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("这是单击事件");
        //}
    }
}
