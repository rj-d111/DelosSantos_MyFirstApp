using DelosSantos_Project.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.AlumniPortal
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Part 1
            lbl_salutation.Text = DifferentClass.Salutation;
            lbl_fname.Text = DifferentClass.FirstName;
            lbl_lname.Text = DifferentClass.LastName;
            lbl_gender.Text = DifferentClass.Gender;
            lbl_civil.Text = DifferentClass.CivilStatus;
            lbl_birth.Text = DifferentClass.DateOfBirth.ToString("MMMM d, yyyy");
            lbl_mname.Text = DifferentClass.MiddleName;
            lbl_mdname.Text = DifferentClass.MaidenName;

            //Part 2
            lbl_contact.Text = DifferentClass.ContactNum;
            txt_p1mail.Text = DifferentClass.PrimaryEmail;
            txt_p2mail.Text = DifferentClass.SecondaryEmail;
            txt_resume.Text = DifferentClass.ResumeLink;

            //Educational Background
            lbl_studnum.Text = DifferentClass.StudentNumber;
            txt_program.Text = DifferentClass.Program;
            lbl_yeargrad.Text = DifferentClass.YearGraduated;
            lbl_semgrad.Text = DifferentClass.SemesterGraduated;

            //Dashboard Display
            lbl_dash_phone.Text = DifferentClass.ContactNum;
            txt_dash_name.Text = String.Join(" ",
                DifferentClass.FirstName, DifferentClass.LastName);
            txt_dash_prog.Text = DifferentClass.Program;
            txt_dash_email.Text = DifferentClass.PrimaryEmail;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
