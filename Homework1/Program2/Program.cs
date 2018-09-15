using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public class Program : Form
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
     
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();

        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            txt1.Dock = System.Windows.Forms.DockStyle.Top;
            txt2.Dock = System.Windows.Forms.DockStyle.Top;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "求乘积";
            lbl.Text = "用于显示结果的标签";
            this.Size = new System.Drawing.Size(300, 120);

            btn.Click += new System.EventHandler(this.button1_Click);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string s1 = txt1.Text;
            double d = double.Parse(s1);
            string s2 = txt2.Text;
            double n = double.Parse(s2);
            double pro = d * n;
            lbl.Text = d + "和" + n + "的乘积是" + pro;
        }

        static void Main()
        {
            Program f = new Program();
            f.Text = "Program";
            f.init();
            Application.Run(f);
        }
    }
}
