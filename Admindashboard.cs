﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderManaging
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Offerdetails offerDetailsForm = new Offerdetails();
            offerDetailsForm.Show();
            this.Hide();
        }

        private void Admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Addfood addFoodForm = new Addfood();
            addFoodForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Managefood manageFoodForm = new Managefood();
            manageFoodForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Manageoffers manageOfferForm = new Manageoffers();
            manageOfferForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fooddetails foodDetailsForm = new Fooddetails();
            foodDetailsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Userdetails userDetailsForm = new Userdetails();
            userDetailsForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Adduser addUserForm = new Adduser();
            addUserForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manageuser manageUserForm = new Manageuser();
            manageUserForm.Show();
            this.Hide();
        }
    }
}
