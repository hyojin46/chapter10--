using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter10_과제
{
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // 텍스트박스의 내용을 리스트박스에 저장
        {
            // 비어 있지 않으면 타이핑 된 값을 받아들임
            if (textBox1.Text == "") // 비어있는 경우
            {
                return;
            }
            if (listBox1.Items.Count == 100) // 최대 100개
            {
                MessageBox.Show("Maximum of 100 items has been reached.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.Add(textBox1.Text); // ListBox에 추가
            textBox1.Text = ""; // TextBox 내용 비움
            textBox1.Focus(); // TextBox1에 초점을 맞춤
        }

        private void button2_Click(object sender, EventArgs e) //clear버튼 이벤트 처리기
        {
            // 새로운 평균 계산을 위해 리스트 박스와 모든 TextBox 내용을 비움
            listBox1.Items.Clear();
            textBox2.Text = ""; // 평균 결과 TextBox 내용도 비움
            textBox1.Text = "";
            textBox1.Focus();
        }

        public double Average(int numberValues, double[] values) //사용자 정의함수(평균을 구하는 함수)
        {
            double sum = 0.0;
            for(int i = 0; i < numberValues; i++)
            {
                sum+=values[i];
            }
            return (sum/numberValues);
        }
        private void button3_Click(object sender, EventArgs e) // 평균 버튼 이벤트 처리기
        {
            double[] myValues = new double[100];
            double myAverage;
            if (listBox1.Items.Count != 0)
            {
                // 배열에 값을 저장
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    myValues[i] = Convert.ToDouble(listBox1.Items[i]);
                }
                // 사용자 정의 함수를 호춣하여 평균을 계산
                myAverage = Average(listBox1.Items.Count, myValues);
                textBox2.Text = String.Format("{0:f2}", myAverage);
            }
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
            {
                // 숫자 혹은 backspace 키
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                // 음의 부호가 1개인지 확인하고, 첫 자리인지 확인
                if (textBox1.Text.IndexOf("-") != -1 || textBox1.SelectionStart != 0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else if (e.KeyChar == '.')
            {
                // 1자리만 허용
                if (textBox1.Text.IndexOf(".") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13)
            {
                // Enter key -- click on Accept Button
                button1.PerformClick(); // 소프트웨어적으로 버튼을 클릭함
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }
        
    }
}
