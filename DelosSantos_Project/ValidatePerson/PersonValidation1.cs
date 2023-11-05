using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Project.ValidatePerson
{
    public class PersonValidation1 : AbstractValidator<AlumniModel>
    {
        public PersonValidation1()
        {

            //Salutation
            RuleFor(p => p.Salutation)
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotEmpty().WithMessage("Please fill out the {PropertyName}");

            // Full Name
            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill out the {PropertyName}")
                .Length(2, 255).WithMessage("The length of {PropertyName} is invalid")
                .Must(BeAValidFullName).WithMessage("{PropertyName} contains invalid characters");     // Full Name
          
            RuleFor(p => p.MiddleName)
                .Must(BeAValidMiddleName).WithMessage("{PropertyName} contains invalid characters");

            RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill out the {PropertyName}")
                .Length(2, 255).WithMessage("The length of {PropertyName} is invalid")
                .Must(BeAValidFullName).WithMessage("{PropertyName} contains invalid characters");

            //Civil Status
            RuleFor(p => p.CivilStatus)
             .Cascade(CascadeMode.StopOnFirstFailure)
             .NotEmpty().WithMessage("Please fill out the {PropertyName}");

            // Gender at Birth
            RuleFor(p => p.Gender)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill out the {PropertyName}")
                .Must(gender => gender ==  "Male" || gender == "Female")
    .WithMessage("The {PropertyName} must be either Male or Female.");

            // Date of Birth
            RuleFor(p => p.DateOfBirth)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(BeAValidAge).WithMessage("Select a proper date of Birth");


     
        }

            protected bool BeAValidMiddleName(string name)
           {
            if (string.IsNullOrWhiteSpace(name)) return true;

            name = name.Trim().Replace("-", ""); //Remove dashes and trim spaces
            
            
            return name.All(Char.IsLetter);
           }
            protected bool BeAValidFullName(string name)
            {
                name = name.Trim().Replace("-", ""); //Remove dashes and trim spaces
                return name.All(c => Char.IsLetter(c) || c == ' ');
        }

        protected bool BeAValidAge(DateTime date)
           {
            //Compare the two dates date of the user input and the date now
             if(DateTime.Compare(date, DateTime.Now)>0) return false;

            //If user inputted less than 20th century
            if (date.Year < 1900) return false;
            
            return true;
           }


    }
}
