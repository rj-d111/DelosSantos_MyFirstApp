using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace DelosSantos_Project.ValidatePerson
{
    public class AlumniModel
    {

        public static AlumniModel CurrentAlumniModel { get; set; }

        public static AlumniModel instance;
        public static string fname;


        public AlumniModel()
        {
            instance = this;
            
        }

  

        //Basic Information
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string CivilStatus { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }


        //Contact Information
        public string ContactNum { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string ResumeLink { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        //Educational Background
        public string StudentNumber { get; set; }
        public string Program { get; set; }
        public string YearGraduated { get; set; }
        public string SemesterGraduated { get; set; }

      
     
    }
}