using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Loop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            StringBuilder sb = new StringBuilder();
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                sum += i;

                //  sb.Append(string.Format("1에서 {0}까지 더하면 {1}\r\n", i, sum));
                sb.Append($"1에서 {i}까지 더하면 {sum}\r\n");
            }

            textBox1.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;

            string[] strArray = { "A", "B", "C", "D", "E", "F", "G" };
            StringBuilder sb = new StringBuilder();

            foreach (var item in strArray)
            {
                sb.Append($"{item}").AppendLine();
            }

            textBox1.Text = sb.ToString();
        }
    }
}
