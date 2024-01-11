using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskProject.Models
{
	public class EducationDetails
	{
        [Key]
        public int EducationDetailsId { get; set; }
        [ForeignKey("PersonalDetails")]
        public int PersonalDetailsId { get; set; }
		public string NameOfInstitute { get; set; }
		public DateOnly YearOfPassing { get; set; }
		public TypeOfDegree TypeOfDegree{ get; set; }
	}

	public enum TypeOfDegree
	{
		Tenth,
		Inter,
		Graduation,
		PostGraduation
	}
}

