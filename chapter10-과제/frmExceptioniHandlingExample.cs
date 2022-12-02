using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; //Debug객체를 참조하는 using문
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter10_과제
{
    public partial class btnCatchException : Form
    {
        public btnCatchException() //생성자
        {
            InitializeComponent(); //초기화
        }

        private void button1_Click(object sender, EventArgs e) //버튼 이벤트 처리기
        {
            try 
            {
                Debug.WriteLine("Try"); //예외가 발생하지 않음
            }
            catch (Exception ex) //예외발생시 실행
            {
                Debug.WriteLine("Catch");
            }
            finally //try-코드와 catch코드가 모두 실행을 마치고 무조건 실행
            {
                Debug.WriteLine("Finally");
            }
            Debug.WriteLine("Done Trying");
        }
    }
}
