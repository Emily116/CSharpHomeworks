using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    class Program : Form
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[STAThread]
        private Graphics graphics;
        static double angle1;
        static double angle2;
        double th1;
        double th2;
        double per1;
        double per2;
        double k;

        Button btn1 = new Button();
        TextBox txt1 = new TextBox();
        Label lbl1 = new Label();
        TextBox txt2 = new TextBox();
        Label lbl2 = new Label();
        TextBox txt3 = new TextBox();
        Label lbl3 = new Label();
        TextBox txt4 = new TextBox();
        Label lbl4 = new Label();
        TextBox txt5 = new TextBox();
        Label lbl5 = new Label();

        public void init()
        {
            graphics = null;
            this.Controls.Add(btn1);
            btn1.Dock = System.Windows.Forms.DockStyle.Top;
            btn1.Text = "DRAW";
            btn1.Click += new System.EventHandler(this.button1_Click);

            this.Controls.Add(txt1);
            txt1.Location = new Point(50, 220);
            this.Controls.Add(lbl1);
            lbl1.Text = "angle1 : ";
            lbl1.Location = new Point(0, 220);

            this.Controls.Add(txt2);
            txt2.Location = new Point(50, 245);
            this.Controls.Add(lbl2);
            lbl2.Text = "angle2 : ";
            lbl2.Location = new Point(0, 245);

            this.Controls.Add(txt3);
            txt3.Location = new Point(50, 270);
            this.Controls.Add(lbl3);
            lbl3.Text = "per1 : ";
            lbl3.Location = new Point(0, 270);

            this.Controls.Add(txt4);
            txt4.Location = new Point(50, 295);
            this.Controls.Add(lbl4);
            lbl4.Text = "per2 : ";
            lbl4.Location = new Point(0, 295);

            this.Controls.Add(txt5);
            txt5.Location = new Point(50, 320);
            this.Controls.Add(lbl5);
            lbl5.Text = "k : ";
            lbl5.Location = new Point(0, 320);

            this.Size = new Size(1600, 900);
        }
       
        static void Main()
        {
            Program p = new Program();
            p.init();
            Application.Run(p);
        }

        private void button1_Click(object sender,EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();

            angle1 = double.Parse(txt1.Text);
            angle2 = double.Parse(txt2.Text);
            per1 = double.Parse(txt3.Text);
            per2 = double.Parse(txt4.Text);
            k = double.Parse(txt5.Text);

            drawFirstCayleyTree(10, 1000, 600, 50, -Math.PI / 2);
            drawSecondCayleyTree(10, 1000, 600, 50, -Math.PI / 2);
        }

        void drawFirstCayleyTree(int n,double x0,double y0,double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine1(x0, y0, x1, y1);

            th1 = angle1 * Math.PI / 180;
            th2 = angle2 * Math.PI / 180;

            drawFirstCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawFirstCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine1(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        void drawSecondCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            drawLine2(x0, y0, x2, y2);

            th1 = angle1 * Math.PI / 180;
            th2 = angle2 * Math.PI / 180;

            drawSecondCayleyTree(n - 1, x2, y2, per1 * leng, th + th1);
            drawSecondCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
        }
        void drawLine2(double x0, double y0, double x2, double y2)
        {
            graphics.DrawLine(
                Pens.Gold,
                (int)x0, (int)y0, (int)x2, (int)y2);
        }
    }
}
