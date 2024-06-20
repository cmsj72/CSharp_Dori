using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArrayTest()
        {
            int[] iDay;
            int siz = 10;
            iDay = new int[siz];
        }

        private void ArrayClassTest()
        {
            int[] test = { 1, 2, 3, 4, 5 };
            int t = test.Length;
            Array.Clear(test, 2, 2);
            Array.Resize(ref test, 5);

            int search30 = Array.IndexOf(test, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] test = { 10, 5, 30, 4, 15, 22, 18 };

            label1.Text = String.Format("cnt : {0}", test.Length.ToString());

            dgDay["colDay1", 0].Value = test[0];
            dgDay["colDay2", 0].Value = test[1];
            dgDay["colDay3", 0].Value = test[2];
            dgDay["colDay4", 0].Value = test[3];
            dgDay["colDay5", 0].Value = test[4];
            dgDay["colDay6", 0].Value = test[5];
            dgDay["colDay7", 0].Value = test[6];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[,] test = { { 1, 2, 3, 4, 5, 6, 7 }, { 11, 12, 13, 14, 15, 16, 17 } };

            label1.Text = String.Format("cnt : {0}", test.Length.ToString());

            dgDay.Rows.Add();
            dgDay["colDay1", 0].Value = test[0, 0];
            dgDay["colDay2", 0].Value = test[0, 1];
            dgDay["colDay3", 0].Value = test[0, 2];
            dgDay["colDay4", 0].Value = test[0, 3];
            dgDay["colDay5", 0].Value = test[0, 4];
            dgDay["colDay6", 0].Value = test[0, 5];
            dgDay["colDay7", 0].Value = test[0, 6];

            dgDay["colDay1", 1].Value = test[1, 0];
            dgDay["colDay2", 1].Value = test[1, 1];
            dgDay["colDay3", 1].Value = test[1, 2];
            dgDay["colDay4", 1].Value = test[1, 3];
            dgDay["colDay5", 1].Value = test[1, 4];
            dgDay["colDay6", 1].Value = test[1, 5];
            dgDay["colDay7", 1].Value = test[1, 6];
        }
    }
}
