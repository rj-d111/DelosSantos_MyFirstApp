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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.Registration
{
    public partial class EducationalBg : UserControl
    {
        BindingList<string> errors = new BindingList<string>();
        public EducationalBg()
        {
            InitializeComponent();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();
        }
        private void PreviousButton_Click_1(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();

        }

        private void EducationalBg_Load(object sender, EventArgs e)
        {

        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            Register.instance.contact1.BringToFront();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.LaunchConsentHandler();
        }
        public AlumniModel GetEducationalBg()
        {
            AlumniModel alumniModel = new AlumniModel();
            alumniModel.StudentNumber = StudentNumberTextBox.Text.Trim();
            alumniModel.Program = ProgramComboBox.Text;
            alumniModel.YearGraduated = YearGraduatedComboBox.Text;
            alumniModel.SemesterGraduated = SemesterGraduatedComboBox.Text;
            return alumniModel;
        }
        public (string StudentNumber, string Program, string YearGraduated, string SemesterGraduated) Part3()
        {
            string studentNumber = StudentNumberTextBox.Text.Trim();
            string program = ProgramComboBox.Text;
            string yearGraduated = YearGraduatedComboBox.Text;
            string semesterGraduated = SemesterGraduatedComboBox.Text;

            return (studentNumber, program, yearGraduated, semesterGraduated);
        }

        public void LaunchConsentHandler()
        {

            AlumniModel alumniModel = new AlumniModel();
            alumniModel.StudentNumber = StudentNumberTextBox.Text.Trim();
            alumniModel.Program = ProgramComboBox.Text;
            alumniModel.YearGraduated = YearGraduatedComboBox.Text;
            alumniModel.SemesterGraduated = SemesterGraduatedComboBox.Text;


            DifferentClass.StudentNumber = StudentNumberTextBox.Text.Trim();
            DifferentClass.Program = ProgramComboBox.Text;
            DifferentClass.YearGraduated = YearGraduatedComboBox.Text;
            DifferentClass.SemesterGraduated = SemesterGraduatedComboBox.Text;

            //Validate my Data
            PersonValidation3 validation3 = new PersonValidation3();

            ValidationResult validationResult = validation3.Validate(alumniModel);
            //If results are invalid
            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in validationResult.Errors)
                {
                    errors.Add($"{failure.ErrorMessage}");
                }

                //The Message box will print the errors
                PrintErrors();
            }
            else
            {
                //Go to next step
                Register.instance.consent1.BringToFront();
            }

        }

        private void PrintErrors()
        {
            MessageBox.Show(string.Join("\n", errors));
            errors.Clear();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Register.instance.contact1.BringToFront();
        }

        private void SemesterGraduatedComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Trigger the click event of roundButton1
                roundButton1.PerformClick();
            }
        }
    }
    }
