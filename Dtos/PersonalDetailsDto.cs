using System;
using System.ComponentModel.DataAnnotations;
using TaskProject.CustomValidations;
using TaskProject.Models;

namespace TaskProject.Dtos
{
	public class PersonalDetailsDto
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MobileNumber(ErrorMessage = "Please enter a valid mobile number")]
        public string MobileNumber { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }

        public PersonalDetails MapToPersonalDetails()
        {
            var personalDetails = new PersonalDetails
            {
                FirstName = FirstName,
                LastName = LastName,
                FullName = $"{FirstName} {this.LastName}",
                DateOfBirth = DateOfBirth,
                AgeInYears = Convert.ToByte(DateTime.Now.Year - this.DateOfBirth.Year),
                MobileNumber = MobileNumber,
                EmailId = EmailId
            };
            return personalDetails;
        }
    }
}

