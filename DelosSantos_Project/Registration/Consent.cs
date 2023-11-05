using DelosSantos_Project.CustomControls;
using DelosSantos_Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Registration
{
    public partial class Consent : UserControl
    {
        public Consent()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now successfully registered");

         

            //Return to Login Form
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            Register.instance.Hide();
        }

        private void customRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(customRadioButton1.Checked)
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;

            }
        }

        private void Consent_Load(object sender, EventArgs e)
        {
  
        }

        private void customRadioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of roundButton1
                SubmitButton.PerformClick();
            }
        }
    }
}
