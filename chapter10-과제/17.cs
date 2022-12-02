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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'k') || (e.KeyChar == 'K')) // k를 누르는 경우(대문자,소문자 상관 x)
                e.Handled = true;
        }
    }
}
