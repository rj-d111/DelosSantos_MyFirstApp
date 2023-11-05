using DelosSantos_Project.CustomControls;
using DelosSantos_Project.Forms;
using DelosSantos_Project.Implementations;
using DelosSantos_Project.Registration;
using DelosSantos_Project.ValidatePerson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DelosSantos_Project
{
    public partial class LoginUser : Form, IButtonWindow
    {
        public LoginUser()
        {
            InitializeComponent();
            //Apply Rounded Form
            RoundedForms.ApplyRoundedRegion(this, Width, Height, 20, 20);
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseHandler();
        }

        public void CloseHandler()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Message", MessageBoxButtons.YesNo);

            // If the user clicked Yes, quit the application.
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

            if(DifferentClass.StudentNumber == null || DifferentClass.Password == null)
            {
                MessageBox.Show("Please click the 'Apply Here' button below first." +
                    "\nOnce you finish registering, come back here to log in using your account.", "Register First",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }


            if(LoginStudNumTextBox.Text == DifferentClass.StudentNumber)
            {
                if(LoginPassTextBox.Text == DifferentClass.Password)
                {
                    MessageBox.Show("Successfully logged in");
                    DisplayForm displayForm = new DisplayForm();
                    displayForm.Show();
                    this.Hide();
                    RemovePasswordText();
                }
                else
                {
                    MessageBox.Show("Wrong Password. Please try again");
                    CheatSheet();
                }
            }
            else
            {
                MessageBox.Show("Wrong Student Number or Password... Please Try again!");
                CheatSheet();
                RemovePasswordText();
            }
        }

        private void RemovePasswordText()
        {
            LoginPassTextBox.Text = String.Empty;
        }

        private void CheatSheet()
        {
               MessageBox.Show($"Hint for you to log in..." +
                   $"\nStudent Number: {DifferentClass.StudentNumber}" +
                $"\nPassword: {DifferentClass.Password}", "Cheat Sheet");
        }

        private void LoginPassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of roundButton1
                roundButton1.PerformClick();
            }
        }
    }
}
