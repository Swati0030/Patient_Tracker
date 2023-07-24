using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Repositories;
using System.Collections.Generic;
using System.Data;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clerk_MedicineDetailsController : ControllerBase
    {

        private readonly IClerkMedicineDetails _iserviceclerkaddmedicinedetails;


        public Clerk_MedicineDetailsController(IClerkMedicineDetails serviceclerkaddmedicinedetails)
        {
            _iserviceclerkaddmedicinedetails = serviceclerkaddmedicinedetails;
        }
        
        [HttpGet]
        [Authorize(Roles = "Clerk")]

        public IActionResult GetDetailsMedicine()
        {
            try
            {


                List<medicine_details>  result = _iserviceclerkaddmedicinedetails.GetDetailsMedicine().ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }
        }
        [HttpGet("{medicine_id}")]
        [Authorize(Roles = "Clerk,Doctor")]

        public IActionResult GetDetailsMedicinebyid(string medicine_id)
        {
            try
            {

                List<medicine_details> result = _iserviceclerkaddmedicinedetails.GetDetailsMedicinebyid(medicine_id).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Authorize(Roles = "Clerk")]

        public IActionResult SaveMedicineDetails(medicine_details obj)
        {
            try
            {
                medicine_details result = _iserviceclerkaddmedicinedetails.SaveMedicineDetails(obj);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                    //StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        [Authorize(Roles = "Clerk")]
        public IActionResult UpdateMedicineDetails(medicine_details obj)
        {
            try
            {
                medicine_details result =  _iserviceclerkaddmedicinedetails.UpdateMedicineDetails(obj);
                return Ok(result);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message); 
            }

        }
     



    }
}
