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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

        //一键删除
        private void button1_Click(object sender, EventArgs e)
        {
            string cliname = textBox2.Text;
            string orderid = textBox1.Text;
            string proname = textBox3.Text;
            int quantity = Int32.Parse(textBox4.Text);

            for(int i = 0; i< Form1.os.orderlist.Count(); i++)
            {
                if (Form1.os.orderlist[i].OrderId == orderid)
                    Form1.os.orderlist.Remove(Form1.os.orderlist[i]);
                else
                    MessageBox.Show("找不到该订单！");
            }

            Form3 frm4 = new Form3();
            frm4.Show();
            frm4.Visible = false;
            frm4.ShowDialog();
            if (frm4.DialogResult == DialogResult.OK)
            {
                frm4.Dispose();
                this.Close();
            }
            else
            {
                frm4.Dispose();
                this.Close();
            }
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
