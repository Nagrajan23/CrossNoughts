using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cross_N_Noughts_XO
{
    public partial class GameBox : Form
    {
        public GameBox()
        {
            InitializeComponent();
            InitializeGame();
            InitializeVariables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeVariables();
        }
        private void Box1_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[0] == 0)
            {
                this.Box1.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box1.Text = nextchar;
            }
        }
        private void Box1_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[0] == 0)
                Box1.Text = " ";
        }
        private void Box1_Click(object sender, EventArgs e)
        {
            if (BoardMap[0] == 0)
            {
                this.Box1.ForeColor = System.Drawing.SystemColors.ControlText;
                Box1.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[0] = 1;
                }
                else
                {
                    BoardMap[0] = 2;
                }
                TurnChange();
            }
        }
        private void Box2_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[1] == 0)
            {
                this.Box2.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box2.Text = nextchar;
            }
        }
        private void Box2_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[1] == 0)
                Box2.Text = " ";
        }
        private void Box2_Click(object sender, EventArgs e)
        {
            if (BoardMap[1] == 0)
            {
                this.Box2.ForeColor = System.Drawing.SystemColors.ControlText;
                Box2.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[1] = 1;
                }
                else
                {
                    BoardMap[1] = 2;
                }
                TurnChange();
            }
        }
        private void Box3_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[2] == 0)
            {
                this.Box3.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box3.Text = nextchar;
            }
        }
        private void Box3_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[2] == 0)
                Box3.Text = " ";
        }
        private void Box3_Click(object sender, EventArgs e)
        {
            if (BoardMap[2] == 0)
            {
                this.Box3.ForeColor = System.Drawing.SystemColors.ControlText;
                Box3.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[2] = 1;
                }
                else
                {
                    BoardMap[2] = 2;
                }
                TurnChange();
            }
        }
        private void Box4_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[3] == 0)
            {
                this.Box4.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box4.Text = nextchar;
            }
        }
        private void Box4_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[3] == 0)
                Box4.Text = " ";
        }
        private void Box4_Click(object sender, EventArgs e)
        {
            if (BoardMap[3] == 0)
            {
                this.Box4.ForeColor = System.Drawing.SystemColors.ControlText;
                Box4.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[3] = 1;
                }
                else
                {
                    BoardMap[3] = 2;
                }
                TurnChange();
            }
        }
        private void Box5_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[4] == 0)
            {
                this.Box5.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box5.Text = nextchar;
            }
        }
        private void Box5_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[4] == 0)
                Box5.Text = " ";
        }
        private void Box5_Click(object sender, EventArgs e)
        {
            if (BoardMap[4] == 0)
            {
                this.Box5.ForeColor = System.Drawing.SystemColors.ControlText;
                Box5.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[4] = 1;
                }
                else
                {
                    BoardMap[4] = 2;
                }
                TurnChange();
            }
        }
        private void Box6_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[5] == 0)
            {
                this.Box6.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box6.Text = nextchar;
            }
        }
        private void Box6_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[5] == 0)
                Box6.Text = " ";
        }
        private void Box6_Click(object sender, EventArgs e)
        {
            if (BoardMap[5] == 0)
            {
                this.Box6.ForeColor = System.Drawing.SystemColors.ControlText;
                Box6.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[5] = 1;
                }
                else
                {
                    BoardMap[5] = 2;
                }
                TurnChange();
            }
        }
        private void Box7_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[6] == 0)
            {
                this.Box7.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box7.Text = nextchar;
            }
        }
        private void Box7_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[6] == 0)
                Box7.Text = " ";
        }
        private void Box7_Click(object sender, EventArgs e)
        {
            if (BoardMap[6] == 0)
            {
                this.Box7.ForeColor = System.Drawing.SystemColors.ControlText;
                Box7.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[6] = 1;
                }
                else
                {
                    BoardMap[6] = 2;
                }
                TurnChange();
            }
        }
        private void Box8_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[7] == 0)
            {
                this.Box8.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box8.Text = nextchar;
            }
        }
        private void Box8_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[7] == 0)
                Box8.Text = " ";
        }
        private void Box8_Click(object sender, EventArgs e)
        {
            if (BoardMap[7] == 0)
            {
                this.Box8.ForeColor = System.Drawing.SystemColors.ControlText;
                Box8.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[7] = 1;
                }
                else
                {
                    BoardMap[7] = 2;
                }
                TurnChange();
            }
        }
        private void Box9_MouseEnter(object sender, EventArgs e)
        {
            if (BoardMap[8] == 0)
            {
                this.Box9.ForeColor = System.Drawing.SystemColors.ControlDark;
                Box9.Text = nextchar;
            }
        }
        private void Box9_MouseLeave(object sender, EventArgs e)
        {
            if (BoardMap[8] == 0)
                Box9.Text = " ";
        }
        private void Box9_Click(object sender, EventArgs e)
        {
            if (BoardMap[8] == 0)
            {
                this.Box9.ForeColor = System.Drawing.SystemColors.ControlText;
                Box9.Text = nextchar;
                if (nextchar == "X")
                {
                    BoardMap[8] = 1;
                }
                else
                {
                    BoardMap[8] = 2;
                }
                TurnChange();
            }
        }
    }
}
