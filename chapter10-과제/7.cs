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
    public partial class _7 : Form
    {
        public _7()
        {
            InitializeComponent();
        }

        protected const int xNum = 5; // 가로 박스 수
        protected const int yNum = 4; // 세로 박스 수
        protected bool[,] abChecked = new bool[yNum, xNum];
        protected int cxBlock, cyBlock;
        private void _7_Load(object sender, EventArgs e)
        {
            OnResize(EventArgs.Empty); //Resize이벤트 발생시킴
        }

        private void _7_Resize(object sender, EventArgs e)
        {
            cxBlock = ClientSize.Width / xNum;
            cyBlock = ClientSize.Height / yNum;
            Invalidate(); // 화면 갱신 시키는 paint 이벤트 발생시킴
        }

        private void _7_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X / cxBlock; //마우스 클릭위치를 블록 단위 좌표로 구함
            int y = e.Y / cyBlock;
            if (x < xNum && y < yNum) //폼 영역 내인지 검사
            {
                abChecked[y, x] ^= true; //폼 영역임
                Invalidate(new Rectangle(x * cxBlock, y * cyBlock, cxBlock, cyBlock));
            }
        }

        private void _7_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(ForeColor);
            for (int y = 0; y < yNum; y++)
                for (int x = 0; x < xNum; x++)
                {
                    g.DrawRectangle(pen, x * cxBlock, y * cyBlock,
                    cxBlock, cyBlock);
                    if (abChecked[y, x])
                    {
                        g.DrawLine(pen, x * cxBlock, y * cyBlock,(x + 1) * cxBlock, (y + 1) * cyBlock);
                        g.DrawLine(pen, x * cxBlock, (y + 1) * cyBlock,(x + 1) * cxBlock, y * cyBlock);
                    }
                }
        }
    }
}
