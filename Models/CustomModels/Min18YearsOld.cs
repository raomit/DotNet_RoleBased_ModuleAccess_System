using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models.CustomModels
{
    public class Min18YearsOldAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            value = Convert.ToDateTime(value);
            if (value is DateTime birthDate)
            {
                int age = DateTime.Today.Year - birthDate.Year;
                if (birthDate.AddYears(age) > DateTime.Today)
                {
                    age--;
                }
                if (age >= 18)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("You must be at least 18 years old.");
        }
    }
}