using DelosSantos_Project.CustomControls;
using DelosSantos_Project.Implementations;
using DelosSantos_Project.Registration;
using DelosSantos_Project.ValidatePerson;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Forms
{
    public partial class Register : Form, IButtonWindow
    {
        BindingList<string> errors = new BindingList<string>();
        public static Register instance;
        

        public Register()
        {
            InitializeComponent();

            instance = this;
            //Apply Rounded Form
            RoundedForms.ApplyRoundedRegion(this, Width, Height, 20, 20);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void basicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseHandler();
        }

        public void CloseHandler()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?\nYour progress will not be saved.", "Register Message", MessageBoxButtons.YesNo);

            // If the user clicked Yes, quit the application.
            if (result == DialogResult.Yes)
            {
                LoginUser loginUser = new LoginUser();
                loginUser.Show();
                this.Hide();
            }
        }

        private void contact1_Load(object sender, EventArgs e)
        {

        }

        private void circlePanel1_Click(object sender, EventArgs e)
        {
            basicInfo1.BringToFront();
        }

        private void transparentBackgroundTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void basicInfo1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
