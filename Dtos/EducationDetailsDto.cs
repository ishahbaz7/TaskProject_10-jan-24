using System;
using TaskProject.Models;

namespace TaskProject.Dtos
{
	public class EducationDetailsDto
	{
        public int PersonalDetailsId { get; set; }
        public string NameOfInstitute { get; set; }
        public DateOnly YearOfPassing { get; set; }
        public TypeOfDegree TypeOfDegree { get; set; }

        public EducationDetails MapToEducationDetails()
        {
            var ed = new EducationDetails
            {
                PersonalDetailsId = PersonalDetailsId,
                NameOfInstitute = NameOfInstitute,
                YearOfPassing = YearOfPassing,
                TypeOfDegree = TypeOfDegree

            };
            return ed;
        }
    }
}

