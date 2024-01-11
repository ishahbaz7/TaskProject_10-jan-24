using System;
using Microsoft.EntityFrameworkCore;
using TaskProject.Data;
using TaskProject.Dtos;
using TaskProject.Models;
using TaskProject.Repositories.Interfaces;

namespace TaskProject.Repositories
{
	public class Repository:IRepository
	{
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
		{
            this.context = context;
        }


        public async Task<PersonalDetails> CreatePersonalDetails(PersonalDetailsDto modal)
        {

            PersonalDetails pd = context.PersonalDetails.Where(x => x.MobileNumber == modal.MobileNumber).FirstOrDefault();

            PersonalDetails personalDetails = modal.MapToPersonalDetails();
            if (pd == null)
            {
                await context.PersonalDetails.AddAsync(personalDetails);
                
            }
            else
            {
                pd.FirstName = personalDetails.FirstName;
                pd.LastName = personalDetails.LastName;
                pd.FullName = personalDetails.FullName;
                pd.DateOfBirth = personalDetails.DateOfBirth;
                pd.AgeInYears = personalDetails.AgeInYears;
                pd.MobileNumber = personalDetails.MobileNumber;
                pd.EmailId = personalDetails.EmailId;

                context.Entry(pd).State = EntityState.Modified;
                personalDetails.PersonalDetailsId = pd.PersonalDetailsId;
            };

            await context.SaveChangesAsync();
            return personalDetails;
        }

        public async Task<PersonalDetails>? GetPersonalDetailsByMobileNo(string mobileNo)
        {
            var pd = await context.PersonalDetails.Include(pd => pd.EducationDetails).Where(pd => pd.MobileNumber == mobileNo).FirstOrDefaultAsync();
            return pd;
        }

        public async Task<EducationDetails>? CreateEducationDetails(EducationDetailsDto modal)
        {
            var isExist = context.PersonalDetails.Any(x => x.PersonalDetailsId == modal.PersonalDetailsId);
            if (!isExist)
            {
                return null;
            }
            var ed = modal.MapToEducationDetails();

            await context.EducationDetails.AddAsync(ed);
            await context.SaveChangesAsync();

            return ed;
            
        }

    }
}

