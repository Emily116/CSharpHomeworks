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
    public partial class Form1 : Form
    {
        public string value;
        public string KeyWord { get; set; }
        public static OrderService os = new OrderService();

        public Form1()
        {
            InitializeComponent();

            Order ord1 = new Order("Mark", "0001", "apple", 4, 1.5);
            Order ord2 = new Order("Jackson", "0002", "milk", 2, 3.0);
            
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord2);

            programBindingSource.DataSource = os.orderlist;
            formNewBindingSource.DataSource = os.orderlist;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //新建订单
        private void button1_Click(object sender, EventArgs e)
        {
            FormNew frm1 = new FormNew();
            frm1.Show();
        }

        //删除订单
        private void button2_Click(object sender, EventArgs e)
        {
            FormDelete frm2 = new FormDelete();
            frm2.Show();
        }

        //关闭窗口
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //根据订单编号查询
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            value = "OrderId";
        }

        //根据客户姓名查询
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            value = "ClientName";
        }

        //根据商品名称查询
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            value = "ProductName";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //一键查询按钮
        private void button4_Click(object sender, EventArgs e)
        {
            if (value == "OrderId")
                programBindingSource.DataSource =
                os.orderlist.Where(s => s.OrderId == KeyWord);
            else if (value == "ClientName")
                programBindingSource.DataSource =
                os.orderlist.Where(s => s.CliName == KeyWord);
            else if (value == "ProductName")
                programBindingSource.DataSource =
                os.orderlist.Where(s => s.ProName == KeyWord);
            else
                MessageBox.Show("请先选择一种查询方式！");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void formNewBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
