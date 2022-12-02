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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Toolbar Button1 is clicked";
            listBox1.Items.Add(((ToolStripButton)sender).Text);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "ToolBar Button2 is clicked";
            listBox1.Items.Add(((ToolStripButton)sender).Text);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "ToolBar Button3 is clicked";
            listBox1.Items.Add(((ToolStripButton)sender).Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // 응용 프로그램 종료
        }
    }
}
