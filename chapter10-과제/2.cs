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
    public partial class _2 : Form
    {
        public _2() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e) //Clear버튼 이벤트 처리기
        {
            listBox1.Items.Clear(); // listbox내용 비움
        }

        private void button2_Click(object sender, EventArgs e) //Exit버튼 이벤트 처리기
        {
            Application.Exit(); // 응용 프로그램 종료
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //리스트 박스에 Item추가: ToolStripMenuItem의 text프로퍼티의 값을 출력
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text); 
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //리스트 박스에 Item추가: ToolStripMenuItem의 text프로퍼티의 값을 출력
            listBox1.Items.Add(((ToolStripMenuItem)sender).Text);
        }
    }
}
