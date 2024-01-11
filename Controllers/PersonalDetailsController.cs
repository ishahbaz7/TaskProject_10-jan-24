using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Dtos;
using TaskProject.Repositories.Interfaces;

namespace TaskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailsController : ControllerBase
    {
        private readonly IRepository repository;

        public PersonalDetailsController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostPersonalDetails(PersonalDetailsDto modal)
        {
            var personalDetails = await repository.CreatePersonalDetails(modal);
            return Ok(personalDetails);
        }

        [HttpGet("{mobileNumber}")]
        public async Task<IActionResult> GetPersonalDetails(string mobileNumber)
        {
            var personalDetails = await repository.GetPersonalDetailsByMobileNo(mobileNumber);
            if(personalDetails == null)
            {
                return NotFound();
            }
            return Ok(personalDetails);
        }

        [HttpPost("education-details")]
        public async Task<IActionResult> CreateEducationDetails(EducationDetailsDto modal)
        {
            var ed = await repository.CreateEducationDetails(modal);
            if(ed == null)
            {
                return NotFound("Personal Details id is invalid");
            }
            return Ok(ed);
        }
    }
}
