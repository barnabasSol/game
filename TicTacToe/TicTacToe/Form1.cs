using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//CODE BY: BARNABAS SOLOMON

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        TicTac t = new TicTac();
        bool isNext = false;
        bool b1AlreadyClicked = false;
        bool b2AlreadyClicked = false;
        bool b3AlreadyClicked = false;
        bool b4AlreadyClicked = false;
        bool b5AlreadyClicked = false;
        bool b6AlreadyClicked = false;
        bool b7AlreadyClicked = false;
        bool b8AlreadyClicked = false;
        bool b9AlreadyClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (!b1AlreadyClicked)
            {
                if (!isNext)
                {
                    box1.Text = "X";
                    box1.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box1.Text = "O";
                    box1.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b1AlreadyClicked = true;        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (!b2AlreadyClicked)
            {
                if (!isNext)
                {
                    box2.Text = "X";
                    box2.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box2.Text = "O";
                    box2.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b2AlreadyClicked = true;

        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (!b3AlreadyClicked)
            {
                if (!isNext)
                {
                    box3.Text = "X";
                    box3.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box3.Text = "O";
                    box3.ForeColor = Color.Green;
                    isNext = false;

                }
                b3AlreadyClicked = true;
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (!b4AlreadyClicked)
            {
                if (!isNext)
                {
                    box4.Text = "X";
                    box4.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box4.Text = "O";
                    box4.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b4AlreadyClicked = true;
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (!b5AlreadyClicked){
                if (!isNext)
                {
                    box5.Text = "X";
                    box5.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box5.Text = "O";
                    box5.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b5AlreadyClicked = true;
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (!b6AlreadyClicked)
            {
                if (!isNext)
                {
                    box6.Text = "X";
                    box6.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box6.Text = "O";
                    box6.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b6AlreadyClicked = true;
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (!b7AlreadyClicked)
            {
                if (!isNext)
                {
                    box7.Text = "X";
                    box7.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box7.Text = "O";
                    box7.ForeColor = Color.Green;
                    isNext = false;
                }
            }
            b7AlreadyClicked = true;
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (!b8AlreadyClicked)
            {
                if (!isNext)
                {
                    box8.Text = "X";
                    box8.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box8.Text = "O";
                    box8.ForeColor = Color.Green;
                    isNext = false;
                }
            }
            b8AlreadyClicked = true;
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (!b9AlreadyClicked)
            {
                if (!isNext)
                {
                    box9.Text = "X";
                    box9.ForeColor = Color.Red;
                    isNext = true;

                }
                else
                {
                    box9.Text = "O";
                    box9.ForeColor = Color.Green;
                    isNext = false;

                }
            }
            b9AlreadyClicked = true;
        }

        private void restart_button(object sender, EventArgs e)
        {
            isNext = false;
            b1AlreadyClicked = false;
            b2AlreadyClicked = false;
            b3AlreadyClicked = false;
            b4AlreadyClicked = false;
            b5AlreadyClicked = false;
            b6AlreadyClicked = false;
            b7AlreadyClicked = false;
            b8AlreadyClicked = false;
            b9AlreadyClicked = false;
            box1.Text = "0";
            box1.ForeColor = Color.Black;
            box2.Text = "0";
            box2.ForeColor = Color.Black;
            box3.Text = "0";
            box3.ForeColor = Color.Black;
            box4.Text = "0";
            box4.ForeColor = Color.Black;
            box5.Text = "0";
            box5.ForeColor = Color.Black;
            box6.Text = "0";
            box6.ForeColor = Color.Black;
            box7.Text = "0";
            box7.ForeColor = Color.Black;
            box8.Text = "0";
            box8.ForeColor = Color.Black;
            box9.Text = "0";
            box9.ForeColor = Color.Black;
        }
    }
}
