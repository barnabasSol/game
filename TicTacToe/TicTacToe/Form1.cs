using System;
using System.Collections.Generic;
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
        int turn = -1;
        int player1=0;
        int player2=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            box1.Text = "X";
            ++turn;

        }

        private void box2_Click(object sender, EventArgs e)
        {

        }

        private void box3_Click(object sender, EventArgs e)
        {

        }

        private void box4_Click(object sender, EventArgs e)
        {

        }

        private void box5_Click(object sender, EventArgs e)
        {

        }

        private void box6_Click(object sender, EventArgs e)
        {

        }

        private void box7_Click(object sender, EventArgs e)
        {

        }

        private void box8_Click(object sender, EventArgs e)
        {

        }

        private void box9_Click(object sender, EventArgs e)
        {

        }
    }
}
