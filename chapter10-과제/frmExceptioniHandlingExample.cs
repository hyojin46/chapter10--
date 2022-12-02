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
        public btnCatchException()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Try");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Catch");
            }
            finally
            {
                Debug.WriteLine("Finally");
            }
            Debug.WriteLine("Done Trying");
        }
    }
}
