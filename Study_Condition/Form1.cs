using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Condition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = (int)numericUpDown1.Value;
            int num2 = (int)numericUpDown2.Value;

            if(num1 > num2)
            {
                label1.Text = string.Format("num1이 num2보다 {0} 더 크다", num1 - num2);
            }
            else if(num1 < num2)
            {
                label1.Text = string.Format("num2이 num1보다 {0} 더 크다", num2 - num1);
            }
            else
            {
                label1.Text = string.Format("두 숫자는 같습니다.", num2 - num1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSelect = comboBox1.Text;

            switch (strSelect)
            {
                case "월":
                    label2.Text = "월요일";
                    break;
                case "화":
                    label2.Text = "화요일";
                    break;
                case "수":
                    label2.Text = "수요일";
                    break;
                case "목":
                case "금":
                    label2.Text = "목요일 또는 금요일";
                    break;
                default:
                    label2.Text = "주말";
                    break;
            }
        }
    }
}
