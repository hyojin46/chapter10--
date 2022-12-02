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
    public partial class _8 : Form
    {
        public _8() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = SystemColors.Control;
            // 현재 상태는 button1이 포커스를 가진 상태 -> button2가 포커스를 갖도록함
            this.button2.Focus(); 
            if (this.button2.Focused)
                this.button2.BackColor = SystemColors.ControlDark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = SystemColors.Control;
            this.button1.Focus();
            if (this.button1.Focused)
                this.button1.BackColor = SystemColors.ControlDark;
        }
    }
}
