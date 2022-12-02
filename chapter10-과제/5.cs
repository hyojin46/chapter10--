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
    public partial class _5 : Form
    {
        public _5() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void _5_MouseEnter(object sender, EventArgs e)
        {
            Point mousePoint = PointToClient(MousePosition); //Form내의 마우스 좌표를 생성
            string msg = "Mouse Position :" + mousePoint.X + "," +mousePoint.Y;
            MessageBox.Show(msg);
        }
    }
}
