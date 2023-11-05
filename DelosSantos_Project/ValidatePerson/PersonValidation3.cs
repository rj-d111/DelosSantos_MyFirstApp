using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelosSantos_Project.ValidatePerson
{
    internal class PersonValidation3 : AbstractValidator<AlumniModel>
    {
        public PersonValidation3() {
            //Student Number
            RuleFor(p => p.StudentNumber)
                .NotEmpty().WithMessage("Please ensure that you provide your student number")
                .Must(BeAValidStudentNumber).WithMessage("Invalid Student Number\n" +
                "It must follow this format: 1234-5-67890");
            //Program
            RuleFor(p => p.Program)
                .NotEmpty();
            //Year Graduated
            RuleFor(p => p.YearGraduated)
                .NotEmpty();

            //Semester Graduated
            RuleFor(p=> p.SemesterGraduated)
                .NotEmpty();
        }

        private bool BeAValidStudentNumber(string studNum) =>
            Regex.IsMatch(studNum, @"^\d{4}-\d-\d{5}$");

    }
}
