using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program2;

namespace Program1
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private BindingSource binding1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //一键新建
        private void button1_Click(object sender, EventArgs e)
        {
            string cliname = textBox2.Text;
            string orderid = textBox1.Text;
            string proname = textBox3.Text;
            int quantity = Int32.Parse(textBox4.Text);
            double price = Double.Parse(textBox5.Text);

            //binding1.DataSource = Form1.os.orderlist;
            //textBox2.DataBindings.Add("Text", binding1, "客户姓名");
            //textBox1.DataBindings.Add("Text", binding1, "订单编号");
            //textBox3.DataBindings.Add("Text", binding1, "商品名称");
            //textBox4.DataBindings.Add("Text", binding1, "商品数量");
            //textBox5.DataBindings.Add("Text", binding1, "商品单价");

            Order ord = new Order(cliname, orderid, proname, quantity, price);
            Form1.os.orderlist.Add(ord);
            
            //Form1 f1;
            //f1 = (Form1)this.Owner;
            //f1.Refresh();
            

            Form2 frm3 = new Form2();
            frm3.Show();
            frm3.Visible = false;
            frm3.ShowDialog();
            if(frm3.DialogResult==DialogResult.OK)
            {
                frm3.Dispose();
                this.Close();
            }
            else
            {
                frm3.Dispose();
                this.Close();
            }
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            //OrderService os = new OrderService();
            //binding1.DataSource = os.orderlist;

        }

        
    }
}
