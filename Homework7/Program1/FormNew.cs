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
using System.Text.RegularExpressions;

namespace Program1
{
    public partial class FormNew : Form
    {
        Order result = null;

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

            //订单号不能为空，且为“年月日+三位流水号”的格式
            string pattern = @"^((((1[6-9]|[2-9]\d)\d{2})+(0?[13578]|1[02])+(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})+(0?[13456789]|1[012])+(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))+[0-9]{3}$";
            if (!Regex.IsMatch(orderid, pattern))
            {
                MessageBox.Show("订单号不符合格式！");
                Refresh();
            }
            else if(orderid==null)
            {
                MessageBox.Show("订单号不能为空！");
                Refresh();
            }
            else
            {
                Order ord = new Order(cliname, orderid, proname, quantity, price);
                Form1.os.orderlist.Add(ord);

                result = (Order)ord;

                Form2 frm3 = new Form2();
                frm3.Show();
                frm3.Visible = false;
                frm3.ShowDialog();
                if (frm3.DialogResult == DialogResult.OK)
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
        }

        public Order getResult()
        {
            return result;
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            //OrderService os = new OrderService();
            //binding1.DataSource = os.orderlist;

        }

        
    }
}
