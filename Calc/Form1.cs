using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //숫자 버튼 클릭 이벤트
        private void Button_Num_Click(object sender, EventArgs e)
        {
            Text_Display.Text += ((Button)sender).Text;
        }

        //연산 버튼 클릭 이벤트
        private void Button_Calc_Click(object sender, EventArgs e)
        {
            Text_Display.Text += ((Button)sender).Text;
        }

        //C 버튼 클릭 이벤트
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Text_Display.Clear();
            Text_Result.Clear();
        }

        //= 버튼 클릭 이벤트
        private void Button_Equal_Click(object sender, EventArgs e)
        {
            //Text_Display의 식을 가져와서 계산 후 Text_Result에 출력
            string line = Text_Display.Text;
            char[] char_line = line.ToCharArray(); // 처음 식
            double[] num_line = new double[100];
            char[] for_line = new char[100];

            bool long_num = false;

            //배열에 정리
            for (int i = 0; i < char_line.Length; i++)
            {
                //숫자라면
                if (char_line[i] >= '0' && char_line[i] <= '9')
                {
                    if (long_num)
                    {
                        num_line[i] = (num_line[i] * 10) + Convert.ToDouble(char_line[i]);
                    }
                    else
                    {
                        num_line[i] = Convert.ToDouble(char_line[i]);
                    }
                }
            }
        }
    }
}
