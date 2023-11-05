using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelosSantos_Project.ValidatePerson
{
    public class PersonValidation2 : AbstractValidator<AlumniModel>
    {
        public PersonValidation2()
        {
            // ----------------Part 2 --------------------

            //Contact Number
            RuleFor(p => p.ContactNum.Trim())
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("Please fill out the Contact Number field")
                .Must(NoLettersShouldBeFound).WithMessage("Not a valid contact number");


            //Primary Email
            RuleFor(p => p.PrimaryEmail.Trim())
                .Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress().WithMessage("Please enter a valid LPU email address")
                .Must(email => email.EndsWith("@lpunetwork.edu.ph")).WithMessage("Please enter your LPU Office 365 account email address, ensuring that it ends with @lpunetwork.edu.ph");

            //Secondary Email
            RuleFor(p => p.SecondaryEmail)
                .Must(BeAValidSecondaryEmail);
        
            //Password
            RuleFor(p => p.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .MinimumLength(8).WithMessage("Password should contain at least 8 characters at length")
                .Must(BeAStrongPassword).WithMessage("Please put a strong password with at least a capital letter/a special symbol/a number");

            //Confirm Password
            RuleFor(p => p.ConfirmPassword)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Equal(p => p.Password).WithMessage("Password and confirm must match.");

        }

        private bool NoLettersShouldBeFound(string contactNum)
        {
            if (contactNum == null) return false;
            return !contactNum.Any(Char.IsLetter);
        }

        private bool BeAValidSecondaryEmail(string email)
        {
          
                var trimmedEmail = email.Trim();

                if (string.IsNullOrWhiteSpace(email)) return true;

                if (trimmedEmail.EndsWith("."))
                {
                    return false; // suggested by @TK-421
                }
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == trimmedEmail;
                }
                catch
                {
                    return false;
                }
            
        }

        // ----------------------- Part 2 ------------------------


        protected bool BeAStrongPassword(string password)
        {

            bool hasCapitalLetter = Regex.IsMatch(password, @"[A-Z]");
            bool hasSpecialChars = Regex.IsMatch(password, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            bool hasNumber = Regex.IsMatch(password, @"[0-9]");

            if (hasCapitalLetter || hasSpecialChars || hasNumber) return true;

            return false;
        }
    }
}
