using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_BAL.Services.ClerkDetails;
using Patient_Tracker_DAL.Models;
using System.Data;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClerkDetailsController : ControllerBase
    {
        private readonly IServiceClerkDetails _iserviceclerkdetails;


        public ClerkDetailsController(IServiceClerkDetails serviceclerkdetails)
        {
            _iserviceclerkdetails = serviceclerkdetails;
        }

       
        [HttpPost]
   

        public IActionResult AddClerk(Clerk_details obj)
        {
            try
            {
                Clerk_details result = _iserviceclerkdetails.AddClerk(obj);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message); 
             }

        }

        [HttpPut]
     
        public IActionResult UpdateClerk(Clerk_details obj)
        {
            try
            {
                Clerk_details result = _iserviceclerkdetails.UpdateClerk(obj);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }
    }
}
