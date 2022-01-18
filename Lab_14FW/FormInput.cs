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
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }
        public FormInput(FormMain f)
        {
            InitializeComponent();
        }

        bool sum = false;
        bool dev = false;
        bool mul = false;
        public void buttonClose_Click(object sender, EventArgs e)
        {
                if (maskedTextBox1.Text!= string.Empty & maskedTextBox2.Text != string.Empty)
                {
                    int a = Convert.ToInt32(maskedTextBox1.Text);
                    int b = Convert.ToInt32(maskedTextBox2.Text);
                if (sum == true)
                {
                    int resultSum = a + b;
                    FormMain.sum = resultSum;
                }
                if (dev == true)
                {
                    int min;
                    if (a > b) min = b;
                    else min = a;
                    int i = min;
                    int c = 0;
                    while (i > 0 && c == 0)
                    {
                        if ((a % i == 0) && (b % i == 0))
                            c = i;
                        i--;
                    }
                    int resultDiv = c;
                    FormMain.div = resultDiv;
                }
                if (mul == true)
                {
                    int resultMul = a * b;
                    FormMain.mul = resultMul;
                }
                Close();
            }else  MessageBox.Show("Введите значения");
        }
        private void checkBoxSum_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                 sum = true;
            }else  sum = false;
        }
        private void checkBoxDiv_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                dev = true;
            }else dev = false;
        }
        private void checkBoxMul_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; 
            if (checkBox.Checked == true)
            {
                mul = true;
            }else mul = false;
        }
    }
}
