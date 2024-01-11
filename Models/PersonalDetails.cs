using System;
using System.ComponentModel.DataAnnotations;
using TaskProject.CustomValidations;
using TaskProject.Dtos;

namespace TaskProject.Models
{
	public class PersonalDetails : PersonalDetailsDto
	{
		[Key]
		public int PersonalDetailsId { get; set; }
		public string FullName { get; set; }
		public byte AgeInYears { get; set; }

		public EducationDetails EducationDetails { get; set; }
	}
}
