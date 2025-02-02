using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace LocalShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpGet(Name = "Login")]
        public Boolean Login(string username, string password)
        {
            if(username=="krishna" && password=="krishna")
            return true;
            else return false;
        }

        [HttpGet(Name = "Register")]
        public Boolean Register(Register registerModel)
        {
           
                return true;
         
        }
    }
}
