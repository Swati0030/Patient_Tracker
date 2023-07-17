using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using Microsoft.Extensions.Configuration;
using Patient_Tracker_BAL.Services.Clerk;
using Microsoft.AspNetCore.Authorization;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clerk_Generate_MedicineBillsController : ControllerBase
    {
        private readonly IServiceGenerateMedicineBills _iservicegenerateMedicalBills;
        public Clerk_Generate_MedicineBillsController(IServiceGenerateMedicineBills servicegenerateMedicalBills)
        {
            _iservicegenerateMedicalBills = servicegenerateMedicalBills;


        }
        [HttpGet]
        [Authorize(Roles = "Clerk")]
        public IActionResult GetMedicineBills()
        {
            try
            {
               List<medicine_bill> result =  _iservicegenerateMedicalBills.GetMedicineBills().ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }
        }

        [HttpGet("{ccNumber}")]
        [Authorize(Roles = "Clerk")]

        public IActionResult GetMedicineByCcNumber(int ccNumber)
        {
            try
            {


                List<medicine_bill> result = _iservicegenerateMedicalBills.GetMedicineByCcNumber(ccNumber).ToList();
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }
        }

    }
}
