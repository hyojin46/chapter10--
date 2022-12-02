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
    public partial class _10 : Form
    {
        public _10() //생성자
        {
            InitializeComponent();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "Alt", e.Alt);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Control", e.Control);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Handled", e.Handled);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "KeyCode", e.KeyCode);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "KeyValue", e.KeyValue);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "KeyData", e.KeyData);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Modifiers", e.Modifiers);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Shift", e.Shift);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "KeyDown Event");
        }
    }
}
