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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static int sum;
        public static int div;
        public static int mul;
        private void button_input_Click(object sender, EventArgs e)
        {
            sum = 0;
            div = 0;
            mul = 0;
            button_calc.Enabled = false;
            FormInput newForm = new FormInput(this);
            newForm.ShowDialog();
            if (sum != 0 | div != 0 | mul != 0)
            {
                button_calc.Enabled = true;
            }
        }
        public void button_calc_Click(object sender, EventArgs e)
        {
            FormResult newForm = new FormResult(sum,div,mul);
            newForm.Show();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
