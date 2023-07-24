using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.Clerk;
using System.Collections.Generic;
using System.Data;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clerk_Patient_RegisterController : ControllerBase
    {
        private readonly IServiceClerkPatientRegistration _serviceClerkPatientRegistration;

        public Clerk_Patient_RegisterController(IServiceClerkPatientRegistration serviceClerkPatientRegistration)
        {
            _serviceClerkPatientRegistration = serviceClerkPatientRegistration;
        }

        [HttpGet]
        [Authorize(Roles = "Clerk")]
        public IActionResult GetDetailsPatient()
        {
            try
            {
                List<patient_details> result =  _serviceClerkPatientRegistration.GetDetailsPatient().ToList();
                return Ok(result);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }





        [HttpPost]
        [Authorize(Roles = "Clerk")]
        public IActionResult AddPatient(patient_details obj)
        {
            try
            {
                patient_details result =  _serviceClerkPatientRegistration.AddPatient(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        [Authorize(Roles = "Clerk")]
        public IActionResult UpdatePatient(patient_details obj)
        {
            try
            {
                patient_details result =  _serviceClerkPatientRegistration.UpdatePatient(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }

        
    }
}