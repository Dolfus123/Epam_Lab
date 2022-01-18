using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14FW
{
    public partial class FormResult : Form
    {
        public FormResult()
        {
            InitializeComponent();
        }
        public FormResult(FormMain f)
        {
            InitializeComponent();
        }
        public FormResult(int a, int b, int c)
        {
            InitializeComponent();
            
            if (a != 0)
            {
                labelSum.Text = a.ToString();
                labelSum.Visible = true;
                label1.Visible = true;
            }
            if (b != 0)
            {
                labelDiv.Text = b.ToString();
                labelDiv.Visible = true;
                label2.Visible = true;
            }
            if (c != 0)
            {
                labelMul.Text = c.ToString();
                labelMul.Visible = true;
                label3.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
