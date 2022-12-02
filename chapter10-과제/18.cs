using System; //10장.보충내용 마우스 이벤트 사용예제
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
    public partial class _18 : Form
    {
        public _18() //생성자
        {
            InitializeComponent(); //초기화
        }

        private Graphics m_objGraphics; //Graphics 객체 참조 변수 선언
        private void _18_Load(object sender, EventArgs e)
        {
            m_objGraphics = this.CreateGraphics();
        }

        private void _18_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_objGraphics.Dispose(); //그래픽 객체 자원 반납
        }

        private void _18_MouseMove(object sender, MouseEventArgs e) //그림 그리기 구현 메소드
        {
            Rectangle rectEllipse = new Rectangle();
            if (e.Button != MouseButtons.Left) return; // 왼쪽 마우스 버튼이 아닐 경우 바로 종료
            rectEllipse.X = e.X - 1;
            rectEllipse.Y = e.Y - 1;
            rectEllipse.Width = 2;
            rectEllipse.Height = 2;
            m_objGraphics.DrawEllipse(System.Drawing.Pens.Blue, rectEllipse);
        }
    }
}
