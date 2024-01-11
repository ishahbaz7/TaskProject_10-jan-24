using System;
using TaskProject.Dtos;
using TaskProject.Models;

namespace TaskProject.Repositories.Interfaces
{
	public interface IRepository
	{
		Task<PersonalDetails> CreatePersonalDetails(PersonalDetailsDto personalDetails);
        Task<PersonalDetails>? GetPersonalDetailsByMobileNo(string mobileNo);
        Task<EducationDetails> CreateEducationDetails(EducationDetailsDto educationDetails);
    }
}

