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
    public partial class _9 : Form
    {
        public _9() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("비밀번호를 입력하세요");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("두번째 TextBox 입력");
        }
    }
}
