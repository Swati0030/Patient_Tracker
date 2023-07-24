using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_BAL.Services.Doctor;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography.Xml;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Doctor_AddPrescriptiondetailsController : ControllerBase
    {
      
            private readonly IServiceDoctorAddPrescription _iservicedoctoraddprescription;


            public Doctor_AddPrescriptiondetailsController(IServiceDoctorAddPrescription servicedoctoraddprescription)
            {
            _iservicedoctoraddprescription = servicedoctoraddprescription;
            }

            [HttpGet]
        [Authorize(Roles = "Doctor")]
        public IActionResult GetPrescriptionDetails()
        {
            try
            {
                List<prescription_details> result = _iservicedoctoraddprescription.GetPrescriptionDetails().ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }


        }

        [HttpGet("{patient_id}")]
        [Authorize(Roles = "Patient")]
        public IActionResult GetPrescriptionDetailsid(string patient_id)
        {
            try
            {
                List<prescription_details> result = _iservicedoctoraddprescription.GetPrescriptionDetailsid(patient_id).ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }


        }


    
      
        



        [HttpPost]
        [Authorize(Roles = "Doctor")]
        public IActionResult SavePrescriptionDetails(prescription_details obj)
        {
            try
            {
                prescription_details result = _iservicedoctoraddprescription.SavePrescriptionDetails(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }


        [HttpPut]
        [Authorize(Roles = "Doctor")]

        public IActionResult UpdatePrescriptionDetails(prescription_details obj)
        {
            try
            {
                prescription_details result = _iservicedoctoraddprescription.UpdatePrescriptionDetails(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }



    
      


    }
}








