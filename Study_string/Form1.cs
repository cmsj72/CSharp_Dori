using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wednesday);
            lboxDay.Items.Add(enumDay.Thursday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strResult = textBox1.Text + "와 " 
                + lboxDay.SelectedItem.ToString() + "(요일) " 
                + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";

            richTextBox1.Text = strResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strResult = TextLoad(textBox1.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            richTextBox1.Text = strResult;
        }
        
        
        /// <summary>
        /// 문자열을 만들어 줍니다.
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strDay">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns>합친 문자열을 반환합니다.</returns>
        public string TextLoad(string strName, string strDay, string strTime)
        {
            return String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", strName, strDay, strTime);
        }
    }
}
