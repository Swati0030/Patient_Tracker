using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_BAL.Services.Patients;
using Patient_Tracker_DAL.Repositories;
using patienttracker.Model;
using System.Collections.Generic;
using System.Data;

namespace patienttracker.Controllers
{

    [Route("api/[controller]")]

    [ApiController]
    public class Patient_feedback_detailsController : ControllerBase
    {
        public readonly IServicePatientAddFeedback _iservicepatientaddfeedback;


        public Patient_feedback_detailsController(IServicePatientAddFeedback servicepatientaddfeedback)
        {

            _iservicepatientaddfeedback = servicepatientaddfeedback;
        }


       [Authorize(Roles = "Patient")]
        [HttpPost]
        public IActionResult  SaveFeedbackDetails(feedback_details obj)
        {
            try
            {
                feedback_details result = _iservicepatientaddfeedback.SaveFeedbackDetails(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }


      
        
                        
        
        [HttpPut("{prescription_id}")]
        [Authorize(Roles = "Patient")]
        public IActionResult UpdateFeedbackDetails(feedback_details obj)
        {
            try
            {
                feedback_details result =  _iservicepatientaddfeedback.UpdateFeedbackDetails(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }





        }




    }




