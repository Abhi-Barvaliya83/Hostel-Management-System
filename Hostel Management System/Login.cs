﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtusername.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtPassword.Text == "123")
            {
                this.Hide();
                new Welcome().Show();
            }
            else
            {
                MessageBox.Show("Username Or Password Is Incorrect");
            }
        }
    }
} 
