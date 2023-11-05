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
    public partial class BasicInformation : UserControl
    {
        BindingList<string> errors = new BindingList<string>();
        public static BasicInformation instance;



        public BasicInformation()
        {
            InitializeComponent();
            instance = this;

            //Focus on Full Name Text Box
        }

        private void customDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public (string Salutation, string FirstName, string MiddleName, string LastName, string MaidenName, string CivilStatus, string Gender, DateTime DateOfBirth) Part1()
        {
            string salutation = SalutationComboBox.Text;
            string firstName = FirstNameTextBox.Text;
            string middleName = MiddleNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string maidenName = MaidenTextBox.Text;
            string civilStatus = CivilStatusComboBox.Text;
            string gender = GenderComboBox.Text;
            DateTime dateOfBirth = customDateTimePicker.Value;

            return (salutation, firstName, middleName, lastName, maidenName, civilStatus, gender, dateOfBirth);
        }
        public AlumniModel GetBasicInformation()
        {
            AlumniModel alumniModel = new AlumniModel();
            alumniModel.Salutation = SalutationComboBox.Text;
            alumniModel.FirstName = FirstNameTextBox.Text;
            alumniModel.MiddleName = MiddleNameTextBox.Text;
            alumniModel.LastName = LastNameTextBox.Text;
            alumniModel.MaidenName = MaidenTextBox.Text;
            alumniModel.CivilStatus = CivilStatusComboBox.Text;
            alumniModel.Gender = GenderComboBox.Text;
            alumniModel.DateOfBirth = customDateTimePicker.Value;
            return alumniModel;
        }

        private AlumniModel alumniModel = new AlumniModel();

        private void roundButton1_Click(object sender, EventArgs e)
        {
            
            AlumniModel alumniModel = new AlumniModel();
            alumniModel.Salutation = SalutationComboBox.Text;
            alumniModel.FirstName = FirstNameTextBox.Text;
            alumniModel.MiddleName = MiddleNameTextBox.Text;
            alumniModel.LastName = LastNameTextBox.Text;
            alumniModel.MaidenName = MaidenTextBox.Text;
            alumniModel.CivilStatus = CivilStatusComboBox.Text;
            alumniModel.Gender = GenderComboBox.Text;
            alumniModel.DateOfBirth = customDateTimePicker.Value;

            DifferentClass.Salutation = SalutationComboBox.Text;
            DifferentClass.FirstName = FirstNameTextBox.Text;
            DifferentClass.MiddleName = MiddleNameTextBox.Text;
            DifferentClass.LastName = LastNameTextBox.Text;
            DifferentClass.MaidenName = MaidenTextBox.Text;
            DifferentClass.CivilStatus = CivilStatusComboBox.Text;
            DifferentClass.Gender = GenderComboBox.Text;
            DifferentClass.DateOfBirth = customDateTimePicker.Value;



            //Validate my Data
            PersonValidation1 validation1 = new PersonValidation1();

            ValidationResult validationResult= validation1.Validate(alumniModel);
            //If results are invalid
            if (!validationResult.IsValid)
            {
                foreach(ValidationFailure failure in validationResult.Errors)
                {
                    errors.Add($"{failure.ErrorMessage}");
                }

                //The Message box will print the errors
                PrintErrors();
            }
            else
            {
                //Go to next step
                Register.instance.contact1.BringToFront();

            }

        }

        private void PrintErrors()
        {
            MessageBox.Show(string.Join("\n",errors));
            errors.Clear();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

     
    

        private void BasicInfo_Load(object sender, EventArgs e)
        {

        }

        private void SalutationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Assuming SalutationComboBox.SelectedValue contains the selected value (e.g., "Mr.")

            switch (SalutationComboBox.Text)
            {
                case "Mr.":
                    GenderComboBox.Text = "Male";
                    GenderComboBox.Enabled = false; // Disable GenderComboBox
                    MaidenTextBox.Enabled = false;
                    break;
                case "Ms.":
                    GenderComboBox.Text = "Female";
                    GenderComboBox.Enabled = false; // Disable GenderComboBox
                    MaidenTextBox.Enabled = false;
                    break;
                case "Mrs.":
                    GenderComboBox.Text = "Female";
                    GenderComboBox.Enabled = false; // Disable GenderComboBox
                    MaidenTextBox.Enabled = true;
                    break;
                default:
                    GenderComboBox.Text = String.Empty;
                    GenderComboBox.Enabled = true;
                    MaidenTextBox.Enabled = true; // Enable MaidenTextBox
                    break;
            }
               
        
        }
    }
}
