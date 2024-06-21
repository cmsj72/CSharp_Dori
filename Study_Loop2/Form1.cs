using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Loop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = new int[6];
            int cnt = 0;
            StringBuilder sb = new StringBuilder();
            Random rd = new Random();
            while (Array.IndexOf(array, 0) != -1)
            {
                int number = rd.Next(1, 46);

                if(Array.IndexOf(array, number) == -1)
                {
                    array[cnt] = number;
                    cnt++;
                }
            }

            Array.Sort(array);

            for(int i = 0; i < array.Length; i++)
            {
                sb.Append(string.Format(i == array.Length - 1 ? "{0}" : "{0}. ", array[i]));
            }

            label1.Text = sb.ToString();
            listBox1.Items.Add(sb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int number = int.Parse(textBox1.Text);
            int checkNumber = 0;
            int cnt = 0;
            if(number < 1 || number > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 입력해주세요");
            }
            do
            {
                checkNumber = rd.Next(1, 101);
                cnt++;
            }while(number != checkNumber);

            label2.Text = string.Format("{0}을 {1}회 만에 찾았습니다.", number, cnt);
        }
    }
}
