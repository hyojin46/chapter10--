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
    public partial class _3 : Form
    {
        public _3() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void drawBorderDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics objGraphics = CreateGraphics(); //그래픽 객체 생성
            objGraphics.DrawRectangle(Pens.Blue,pictureBox1.Left-1, pictureBox1.Top-1,pictureBox1.Width+1, pictureBox1.Height+2);
            objGraphics.Dispose(); //자원 반납
        }
    }
}
