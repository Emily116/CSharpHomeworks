using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Program2;

namespace Program
{
    class Program : Form
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        RadioButton rbt1 = new RadioButton();
        RadioButton rbt2 = new RadioButton();
        RadioButton rbt3 = new RadioButton();

        public void init()
        {
            //初始化订单
            //Client cli1 = new Client("1", "Mark");
            //Client cli2 = new Client("2", "Coco");
            //Client cli3 = new Client("3", "Jackson");

            //Goods apple = new Goods("1", "Apple", 1.5);
            //Goods milk = new Goods("2", "Milk", 3.0);
            //Goods bed = new Goods("3", "Bed", 200);

            //OrderDetails pro1 = new OrderDetails("1", 4, apple);
            //OrderDetails pro2 = new OrderDetails("2", 2, milk);
            //OrderDetails pro3 = new OrderDetails("3", 1, bed);

            //Order ord1 = new Order("0001", cli1);
            //Order ord2 = new Order("0002", cli2);
            //Order ord3 = new Order("0003", cli3);

            //OrderService os = new OrderService();
            //os.orderlist.Add(ord1);
            //os.orderlist.Add(ord2);
            //os.orderlist.Add(ord3);

            //os.orderlist[0].AddProduct(pro1);
            //os.orderlist[0].AddProduct(pro2);
            //os.orderlist[0].AddProduct(pro3);
            //os.orderlist[1].AddProduct(pro1);
            //os.orderlist[1].AddProduct(pro3);
            //os.orderlist[2].AddProduct(pro3);


            //定义控件
            this.Size = new Size(1080, 720);

            //新建订单弹出窗口
            this.Controls.Add(btn1);
            btn1.Dock = DockStyle.Bottom;
            btn1.Text = "新建订单";
            btn1.Size = new Size(150, 50);
            btn1.Click += new System.EventHandler(this.button1_Click);

            //删除订单弹出窗口
            this.Controls.Add(btn2);
            btn2.Dock = DockStyle.Bottom;
            btn2.Text = "删除订单";
            btn2.Size = new Size(150, 50);
            btn2.Click += new System.EventHandler(this.button2_Click);

            //关闭当前窗口
            this.Controls.Add(btn3);
            btn3.Dock = DockStyle.Bottom;
            btn3.Text = "关闭";
            btn3.Size = new Size(150, 50);
            btn3.Click += new System.EventHandler(this.button3_Click);

            //查询
            this.Controls.Add(rbt1);
            rbt1.Text = "订单编号";
            rbt1.Dock = DockStyle.Top;
            this.Controls.Add(rbt2);
            rbt2.Text = "客户姓名";
            rbt2.Dock = DockStyle.Top;
            this.Controls.Add(rbt3);
            rbt3.Text = "商品名称";
            rbt3.Dock = DockStyle.Top;

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

        static void Main()
        {
            Program p = new Program();
            p.init();
            Application.Run(p);
        }
    }
}
