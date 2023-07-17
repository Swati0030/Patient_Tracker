using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Patient_Tracker.Models;
using Patient_Tracker_BAL.Services.AuthenticationLogin;
using Patient_Tracker_DAL.Models;

namespace Patient_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IServiceLogin _iServiceLogin;
        public LoginController(IServiceLogin iServiceLogin)
        {
            _iServiceLogin = iServiceLogin;
        }
        [HttpPost("/Login")]
        public IActionResult  Login(Users user)
        {
            try
            {
                string result = _iServiceLogin.Authenticate(user.user_name, user.password);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal error occurred.");
            }

        }
    }
}
    

