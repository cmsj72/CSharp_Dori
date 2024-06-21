using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_StructAndClass1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct structPlayer
        {
            public int count;

            public int sun;
            public int moon;
            public int star;

            public int cardSum;

            public int CardSum(int sun, int moon, int star)
            {
                return sun + moon + star;
            }

            public string ResultText()
            {
                return string.Format("{0}) 해:{1} 달:{2} 별:{3} 합계:{4}", count, sun, moon, star, cardSum);
            }
        }

        class classPlayer
        {
            public int count = 0;

            public int sun = 2;
            public int moon;
            public int star;

            public int cardSum;

            public int CardSum(int sun, int moon, int star)
            {
                return sun + moon + star;
            }

            public string ResultText()
            {
                return string.Format("{0}) 해:{1} 달:{2} 별:{3} 합계:{4}", count, sun, moon, star, cardSum);
            }
        }

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        Random _rd = new Random();



        private void CheckedChange()
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void Result()
        {
            string strResult = string.Empty;

            if (radioButton1.Checked)
            {
                _stPlayer1.count++;
                _stPlayer1.cardSum = _stPlayer1.CardSum(_stPlayer1.sun, _stPlayer1.moon, _stPlayer1.star);
                strResult = _stPlayer1.ResultText();
                listBox1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.count++;
                _stPlayer2.cardSum = _stPlayer2.CardSum(_stPlayer2.sun, _stPlayer2.moon, _stPlayer2.star);
                strResult = _stPlayer2.ResultText();
                listBox2.Items.Add(strResult);
            }
            CheckedChange();

            if(_stPlayer1.count >=5 && _stPlayer2.count >= 5)
            {
                if(_stPlayer1.cardSum > _stPlayer2.cardSum)
                {
                    MessageBox.Show("p1");
                }
                else if(_stPlayer1.cardSum < _stPlayer2.cardSum)
                {
                    MessageBox.Show("p2");
                }
                else
                {
                    MessageBox.Show("비겼습니다.");
                }                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            int number = _rd.Next(1, 21);

            if (radioButton1.Checked)
            {
                _stPlayer1.sun = number;
            }
            else
            {
                _stPlayer2.sun = number;
            }
            Result();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (radioButton1.Checked)
            {
                _stPlayer1.moon = number;
            }
            else
            {
                _stPlayer2.moon = number;
            }
            Result();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (radioButton1.Checked)
            {
                _stPlayer1.star = number;
            }
            else
            {
                _stPlayer2.star = number;
            }
            Result();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Result();
        }

    }
}
