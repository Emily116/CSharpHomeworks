using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program
{
    public partial class Form1 : Form
    {
        public string value;

        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        RadioButton rbt1 = new RadioButton();
        RadioButton rbt2 = new RadioButton();
        RadioButton rbt3 = new RadioButton();

        public Form1()
        {
            InitializeComponent();
            ////新建订单弹出窗口
            //this.Controls.Add(btn1);
            //btn1.Dock = DockStyle.Bottom;
            //btn1.Text = "新建订单";
            //btn1.Click += new System.EventHandler(this.button1_Click);

            ////删除订单弹出窗口
            //this.Controls.Add(btn2);
            //btn2.Dock = DockStyle.Bottom;
            //btn2.Text = "删除订单";
            //btn2.Click += new System.EventHandler(this.button2_Click);

            ////关闭当前窗口
            //this.Controls.Add(btn3);
            //btn3.Dock = DockStyle.Bottom;
            //btn3.Text = "关闭";
            //btn3.Click += new System.EventHandler(this.button3_Click);

            ////查询
            //this.Controls.Add(rbt1);
            //rbt1.Text = "订单编号";
            //this.Controls.Add(rbt2);
            //rbt2.Text = "客户姓名";
            //this.Controls.Add(rbt3);
            //rbt3.Text = "商品名称";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNew frm1 = new FormNew();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDelete frm2 = new FormDelete();
            frm2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            value = "OrderId";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            value = "ClientName";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            value = "ProductName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //新建订单弹出窗口
            this.Controls.Add(btn1);
            btn1.Dock = DockStyle.Bottom;
            btn1.Text = "新建订单";
            btn1.Click += new System.EventHandler(this.button1_Click);

            //删除订单弹出窗口
            this.Controls.Add(btn2);
            btn2.Dock = DockStyle.Bottom;
            btn2.Text = "删除订单";
            btn2.Click += new System.EventHandler(this.button2_Click);

            //关闭当前窗口
            this.Controls.Add(btn3);
            btn3.Dock = DockStyle.Bottom;
            btn3.Text = "关闭";
            btn3.Click += new System.EventHandler(this.button3_Click);

            //查询
            this.Controls.Add(rbt1);
            rbt1.Text = "订单编号";
            this.Controls.Add(rbt2);
            rbt2.Text = "客户姓名";
            this.Controls.Add(rbt3);
            rbt3.Text = "商品名称";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
