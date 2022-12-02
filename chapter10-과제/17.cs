using System; //10장. 보충내용 문자 k를 받아들이지 않는 텍스트 박스 구현
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
        public _17() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //눌려진 키는 e매개변수의 KeyChar속성을 통해 알 수 있음
            if ((e.KeyChar == 'k') || (e.KeyChar == 'K')) // k를 누르는 경우(대문자,소문자 상관 x)
                e.Handled = true; //별도처리 설정 -> 키가 무시됨
        }
    }
}
