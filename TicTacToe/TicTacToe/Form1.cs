using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        string winner;
        string loser;
        ArrayList<String> player1 = new ArrayList<String>();
        bool isNext = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
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

        private void box2_Click(object sender, EventArgs e)
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

        private void box3_Click(object sender, EventArgs e)
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
        }

        private void box4_Click(object sender, EventArgs e)
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

        private void box5_Click(object sender, EventArgs e)
        {
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

        private void box6_Click(object sender, EventArgs e)
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

        private void box7_Click(object sender, EventArgs e)
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

        private void box8_Click(object sender, EventArgs e)
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

        private void box9_Click(object sender, EventArgs e)
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
    }
}
