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
    public partial class _6 : Form
    {
        public _6() //생성자
        {
            InitializeComponent();
        }
        private void UpdateEventLabels(string msg, int x, int y, MouseEventArgs e) // MouseEventArgs: 마우스 위치와 상태정보 있음
        {
            string message = string.Format("{0} X:{1}, Y:{2}", msg, x, y);
            string eventMsg = DateTime.Now.ToShortTimeString(); //eventMsg에 저장될 형식= 오전 10:51
            eventMsg += " " + message;
            listBox1.Items.Insert(0, eventMsg);
            listBox1.TopIndex = 0;
            string mouseInfo;
            if (e != null) //MouseEventArgs 객체 매개변수의 존재 여부
            {
                mouseInfo = string.Format("Clicks: {0}, Delta: {1}, " + "Buttons: {2}",e.Clicks, e.Delta, e.Button.ToString());
            }
            else { mouseInfo = string.Format("Clicks: {0}", msg); }
            label1.Text = mouseInfo;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateEventLabels("(ListBox)MouseDown", e.X, e.Y, e);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition);
            UpdateEventLabels("(ListBox)DoubleClick", mousePoint.X, mousePoint.Y, null); //더블 클릭이라서 마우스 위치정보를 전달 불가
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //프로그램 종료
        }
    }
}
