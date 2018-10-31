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
    public partial class Form3 : Form
    {
        Button btn1 = new Button();
        Button btn2 = new Button();
        

        public Form3()
        {
            InitializeComponent();

            btn1.Click += button1_Click;
            btn2.Click += button2_Click;

            btn1.DialogResult = DialogResult.OK;
            btn2.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
