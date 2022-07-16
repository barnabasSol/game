﻿using System;
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
        TicTac t = new TicTac();

        private void box1_Click(object sender, EventArgs e)
        {
           if (!isNext)
            {
                box1.Text = "X";
                box1.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b1");
            }
            else
            {
                box1.Text = "O";
                box1.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b1");
            }

           
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box2.Text = "X";
                box2.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b2");
            }
            else
            {
                box2.Text = "O";
                box2.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b2");
            }

        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box3.Text = "X";
                box3.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b3");
            }
            else
            {
                box3.Text = "O";
                box3.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b3");
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box4.Text = "X";
                box4.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b4");
            }
            else
            {
                box4.Text = "O";
                box4.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b4");
            }
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box5.Text = "X";
                box5.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b5");
            }
            else
            {
                box5.Text = "O";
                box5.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b5");
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box6.Text = "X";
                box6.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b6");
            }
            else
            {
                box6.Text = "O";
                box6.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b6");
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box7.Text = "X";
                box7.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b7");
            }
            else
            {
                box7.Text = "O";
                box7.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b7");
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box8.Text = "X";
                box8.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b8");
            }
            else
            {
                box8.Text = "O";
                box8.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b8");
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (!isNext)
            {
                box9.Text = "X";
                box9.ForeColor = Color.Red;
                isNext = true;
                t.add_p1_choices("b9");
            }
            else
            {
                box9.Text = "O";
                box9.ForeColor = Color.Green;
                isNext = false;
                t.add_p2_choices("b9");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isNext = false;
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
