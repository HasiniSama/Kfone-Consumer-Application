﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kfone_Consumer_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool isLoggedIn = CheckIfUserIsLoggedIn();

            // Show or hide the buttons based on the user's login status
            button1.Visible = !isLoggedIn;
            button2.Visible = !isLoggedIn;
            button5.Visible = isLoggedIn;
            button7.Visible = isLoggedIn;
        }

        private bool CheckIfUserIsLoggedIn()
        {
            // login logic

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void cardButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
