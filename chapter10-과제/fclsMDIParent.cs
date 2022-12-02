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
    public partial class _14 : Form
    {
        public _14()
        {
            InitializeComponent();
        }

        private void _14_Load(object sender, EventArgs e)
        {
            // 생성한 자식 폼의 MdiParent속성을 현재의 폼(부모폼)으로 설정
            fclsChild1 objChild = new fclsChild1();
            objChild.MdiParent = this;
            objChild.Show();
        }
    }
}
