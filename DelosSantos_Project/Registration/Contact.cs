using DelosSantos_Project.Forms;
using DelosSantos_Project.ValidatePerson;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Registration
{
    public partial class Contact : UserControl
    {
        BindingList<string> errors = new BindingList<string>();
        public static Contact instance;

        public Contact()
        {
            InitializeComponent();

            instance = this;
            
            //When the form loads
            FocusText(PrimaryTextBox, "Your Office 365 Address");
            FocusText(SecondaryTextBox, "Your active personal Email Address");

            TextPlaceHolder(PrimaryTextBox, "Your Office 365 Address");
            TextPlaceHolder(SecondaryTextBox, "Your active personal Email Address");

        }

        private void TextPlaceHolder(TextBox textBox, string placeholder)
        {
            textBox.GotFocus += (sender, e) => RemoveText(sender, e, textBox, placeholder);
            textBox.LostFocus += (sender, e) => AddText(sender, e, textBox, placeholder);


        }

        public void RemoveText(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
            }
        }

        public void RemoveText(object sender, EventArgs e, TextBox textBox, string placeholder)
        {
            if(textBox.Text == placeholder)
            {
                textBox.Text = "";
            }
        }
        public void AddText(object sender, EventArgs e, TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                textBox.Text = placeholder;
        }

        public void FocusText(TextBox textBox, string placeholder)
        { 
            if(textBox.Text == placeholder || string.IsNullOrWhiteSpace(textBox.Text))
            textBox.Text = placeholder;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Register.instance.basicInfo1.BringToFront();            
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            Register.instance.basicInfo1.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Register.instance.basicInfo1.BringToFront();

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Contact_Load(object sender, EventArgs e)
        {
        }

        public AlumniModel GetContactInformation()
        {
            AlumniModel alumniModel = new AlumniModel();
            alumniModel.ContactNum = ContactNumberTextBox.Text.Trim();
            alumniModel.PrimaryEmail = PrimaryTextBox.Text.Trim();
            alumniModel.SecondaryEmail = SecondaryTextBox.Text.Trim();
            alumniModel.Password = PasswordTextBox.Text;
            alumniModel.ConfirmPassword = PasswordConfirmTextBox.Text;
            return alumniModel;
        }

        public (string ContactNumber, string PrimaryEmail, string SecondaryEmail, string Password, string ConfirmPassword) Part2()
        {
            string contactNum = ContactNumberTextBox.Text.Trim();
            string primaryEmail = PrimaryTextBox.Text.Trim();
            string secondaryEmail = SecondaryTextBox.Text.Trim();
            string password = PasswordTextBox.Text;
            string confirmPassword = PasswordConfirmTextBox.Text;

            return (contactNum, primaryEmail, secondaryEmail, password, confirmPassword);
        }


        private void roundButton1_Click(object sender, EventArgs e)
        {

            RemoveText(PrimaryTextBox, "Your Office 365 Address");
            RemoveText(SecondaryTextBox, "Your active personal Email Address");
            //Code starts here
            AlumniModel alumniModel = new AlumniModel(); 
            alumniModel.ContactNum = ContactNumberTextBox.Text.Trim();
            alumniModel.PrimaryEmail = PrimaryTextBox.Text.Trim();
            alumniModel.SecondaryEmail = SecondaryTextBox.Text.Trim();
            alumniModel.Password = PasswordTextBox.Text;
            alumniModel.ConfirmPassword = PasswordConfirmTextBox.Text;
            alumniModel.ResumeLink = ResumeTextBox.Text;

            DifferentClass.ContactNum = ContactNumberTextBox.Text.Trim();
            DifferentClass.PrimaryEmail = PrimaryTextBox.Text.Trim();
            DifferentClass.SecondaryEmail = SecondaryTextBox.Text.Trim();
            DifferentClass.Password = PasswordTextBox.Text;
            DifferentClass.ConfirmPassword = PasswordConfirmTextBox.Text;
            DifferentClass.ResumeLink = ResumeTextBox.Text;



            //Validate my Data
            PersonValidation2 validation2 = new PersonValidation2();

            ValidationResult validationResult = validation2.Validate(alumniModel);
            //If results are invalid
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    errors.Add($"{failure.ErrorMessage}");
                }

                //The Message box will print the errors
                PrintErrors();
                RemoveConfirmPassword();
            }
            else
            {

                // Save the data
                // DifferentClass differentClass = new DifferentClass(alumniModel2);
                // differentClass.RetrieveHandler();
                //Go to next step
                Register.instance.educationalBg1.BringToFront();
            }

        }

        private void RemoveConfirmPassword()
        {
            PasswordConfirmTextBox.Text = String.Empty;
        }

        private void PrintErrors()
        {
            MessageBox.Show(string.Join("\n", errors));
            errors.Clear();

            //Show this again if necessary
            FocusText(PrimaryTextBox, "Your Office 365 Address");
            FocusText(SecondaryTextBox, "Your active personal Email Address");
        }

        // Initialize variables to track password strength criteria
        bool hasCapitalLetter = false;
        bool hasSpecialChars = false;
        bool hasNumber = false;
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            CheckingPassword();

        }
        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckingPassword();
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckingPassword();
        }

        private void CheckingPassword()
        {
            ResetPanelStrength();

            if (Regex.IsMatch(PasswordTextBox.Text, @"[A-Z]"))
            {
                hasCapitalLetter = true;
            }

            // Check if the key pressed is a special character
            if (Regex.IsMatch(PasswordTextBox.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"))
            {
                hasSpecialChars = true;
            }

            // Check if the key pressed is a number
            if (Regex.IsMatch(PasswordTextBox.Text, @"[0-9]"))
            {
                hasNumber = true;
            }

            // Update the password strength indicator
            UpdatePasswordStrengthIndicator();
        }

        // Update the password strength indicator
        private void UpdatePasswordStrengthIndicator()
        {


            // Calculate the password strength
            int passwordStrength = 0;
            if (hasCapitalLetter) passwordStrength++;
            if (hasSpecialChars) passwordStrength++;
            if (hasNumber) passwordStrength++;

            //  If user did not put anything
            if (PasswordTextBox.TextLength == 0)
            {
                StrengthTextBox.Text = string.Empty;
                return;
            }
            // If password less than 8 characters
            else if (PasswordTextBox.TextLength < 8)
            {
                StrengthTextBox.Text = "Too Short";
                return;
            }

            // Update the password strength indicator UI
            switch (passwordStrength)
            {
                case 0:
                    // Display "Weak"
                    WeakPanel.BackColor = Color.Red;
                    StrengthTextBox.Text = "Weak";
                    break;
                case 1:
                    // Display "Fair"
                    WeakPanel.BackColor = Color.Yellow;
                    FairPanel.BackColor = Color.Yellow;
                    StrengthTextBox.Text = "Fair";
                    break;
                case 2:
                    // Display "Good"
                    WeakPanel.BackColor = Color.Green;
                    FairPanel.BackColor = Color.Green;
                    GoodPanel.BackColor = Color.Green;
                    StrengthTextBox.Text = "Good";
                    break;
                case 3:
                    // Display "Strong"
                    WeakPanel.BackColor = Color.Aqua;
                    FairPanel.BackColor = Color.Aqua;
                    GoodPanel.BackColor = Color.Aqua;
                    StrongPanel.BackColor = Color.Aqua;
                    StrengthTextBox.Text = "Strong";
                    break;
                default:
                    // Display "Unknown"
                    break;
            }
        }

        private void ResetPanelStrength()
        {
            WeakPanel.BackColor = Color.FromArgb(240, 240, 240);
            FairPanel.BackColor = Color.FromArgb(240, 240, 240);
            GoodPanel.BackColor = Color.FromArgb(240, 240, 240);
            StrongPanel.BackColor = Color.FromArgb(240, 240, 240);
            hasCapitalLetter = false;
            hasSpecialChars = false;
            hasNumber = false;
        }

        private void PasswordConfirmTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of roundButton1
                roundButton1.PerformClick();
                
                
            }
        }

 
    }
}
