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
            double[] num_line = new double[100]; //숫자 저장 식
            char[] for_line = new char[100]; //기호 저장 식

            bool long_num = false;

            int num_i = 0;
            int for_i = 0;
            //배열에 정리
            for (int i = 0; i < char_line.Length; i++)
            {
                //숫자라면
                if (char_line[i] >= '0' && char_line[i] <= '9')
                {
                    if (long_num)
                    {
                        //두자리 이상
                        num_line[num_i] = (num_line[num_i] * 10) + double.Parse(char_line[i].ToString());
                        num_i++;
                    }
                    else
                    {
                        //한자리
                        num_line[num_i] = double.Parse(char_line[i].ToString());
                        long_num = true;
                        num_i++;
                    }
                }
                else
                {
                    //기호 저장
                    long_num = false;
                    for_line[for_i] = char_line[i];
                    for_i++; 
                }
            }
            int count = 0; //기호 개수 저장
            for(int k = 0; k < for_line.Length; k++)
            {
                if (for_line[k] != 0)
                {
                    count++;
                }
            }
            double result = 0;//현재까지의 계산결과 저장
            for (int j = 0; j < char_line.Length; j++)
            {
                if(for_line[j]=='x')
                {
                    //곱하기 연산
                    num_line[j] = (num_line[j + 1]) * (num_line[j]);
                    count--;
                }
                else if(for_line[j] == '÷')
                {
                    //나누기 연산
                    num_line[j] = (num_line[j + 1]) / (num_line[j]);
                    count--;
                }
                result = num_line[j];
            }
            
            for (int j = 0; j < char_line.Length; j++)
            {
                if (result == 0)
                {
                    // x나 ÷가 없을 경우 초기값 지정
                    result = num_line[1];
                }
                if (count == 0)
                {
                    //기호가 0개, 계산 완료
                    Text_Result.Text = result.ToString();
                    break;
                }
                else if (for_line[j] == '+')
                {
                    //빼기 연산
                    result = result + (num_line[j]);
                    count--;
                }
                else if (for_line[j] == '-')
                {
                    //더하기 연산
                    result = result - num_line[j + 1];
                    count--;
                }
            }
        }
    }
}
