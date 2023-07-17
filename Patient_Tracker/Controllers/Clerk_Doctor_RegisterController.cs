using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_DAL.Repositories;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clerk_Doctor_RegisterController : ControllerBase
    {
        private readonly IServiceClerkDoctorRegistration _iserviceclerkdoctorregister;


        public Clerk_Doctor_RegisterController(IServiceClerkDoctorRegistration serviceclerkdoctorregister)
        {
            _iserviceclerkdoctorregister = serviceclerkdoctorregister;
        }

        [HttpGet]
        [Authorize(Roles ="Clerk")]
        public IActionResult GetDetailsDoctor()
        {
            try
            {
                List < doctor_details> result = _iserviceclerkdoctorregister.GetDetailsDoctor().ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }
          
        }

        [HttpPost]
        [Authorize(Roles = "Clerk")]
        public IActionResult SaveDoctorDetails(doctor_details obj)
        {
            try
            {
                doctor_details result =_iserviceclerkdoctorregister.SaveDoctorDetails(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }

        [HttpPut]
        [Authorize(Roles = "Clerk")]
        public IActionResult UpdateDoctorDetails(doctor_details obj)
        {
            try
            {
                doctor_details result = _iserviceclerkdoctorregister.UpdateDoctorDetails(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }


        }


    }
}
