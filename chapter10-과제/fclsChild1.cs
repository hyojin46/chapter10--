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
    public partial class fclsChild1 : Form
    {
        public fclsChild1()
        {
            InitializeComponent();
        }

        private void btnShowChild2_Click(object sender, EventArgs e)
        {
            fclsChild2 objChild = new fclsChild2();
            objChild.MdiParent = this.MdiParent; // this (Child 1 form)의 MdiParent는 부모 가리킴
            objChild.Show();
        }
    }
}
