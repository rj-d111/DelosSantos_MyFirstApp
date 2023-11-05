using DelosSantos_Project.ValidatePerson;
using System.Windows.Forms;
using System;

namespace DelosSantos_Project.Registration
{
    public static class DifferentClass
    {


        //Basic Information
        public static string Salutation { get; set; }
        public static string FirstName { get; set; }
        public static string MiddleName { get; set; }
        public static string LastName { get; set; }
        public static string MaidenName { get; set; }
        public static string CivilStatus { get; set; }
        public static string Gender { get; set; }
        public static DateTime DateOfBirth { get; set; }


        //Contact Information
        public static string ContactNum { get; set; }
        public static string PrimaryEmail { get; set; }
        public static string SecondaryEmail { get; set; }
        public static string ResumeLink { get; set; }

        public static string Password { get; set; }
        public static string ConfirmPassword { get; set; }

        //Educational Background
        public static string StudentNumber { get; set; }
        public static string Program { get; set; }
        public static string YearGraduated { get; set; }
        public static string SemesterGraduated { get; set; }



    }

}