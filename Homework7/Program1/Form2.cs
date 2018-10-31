using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form2 : Form
    {
        Button btn1 = new Button();
        Button btn2 = new Button();
        Label lbl = new Label();
        
        public Form2()
        {
            InitializeComponent();

            this.Size = new Size(200, 100);
            this.Controls.Add(btn1);
            btn1.Location = new Point(30, 30);
            btn1.Size = new Size(60, 30);
            btn1.Text = "确定";
            this.Controls.Add(btn2);
            btn2.Location = new Point(170, 30);
            btn2.Size = new Size(60, 30);
            btn2.Text = "取消";
            this.Controls.Add(lbl);
            lbl.Location = new Point(100, 80);
            lbl.Text = "确认要新建订单吗？";

            btn1.DialogResult = DialogResult.OK;
            btn2.DialogResult = DialogResult.Cancel;
            
        }
    }
}
