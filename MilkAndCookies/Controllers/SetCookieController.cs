using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SetCookieController : Controller
    {
        [HttpGet]
        public string Get(string favoriteMilkshake)
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddMinutes(20);
            Response.Cookies.Append("favoriteMilkshake", favoriteMilkshake, cookieOptions);
            
            return favoriteMilkshake;
        }

        // GET: api/SetCookie
        [HttpGet]
        [Route("[action]")]
        public string GetFromCookie()
        {
            if (Request.Cookies["favoriteMilkshake"] != null)
            {
                return Request.Cookies["favoriteMilkshake"];
            }
            else
                return "unknown";
        }


        //DELETE/SetCookie
        [HttpGet]
        [Route("[action]")]
        public void DeleteCookie()
        {
            if (Request.Cookies["favoriteMilkshake"] != null)
            {
                Response.Cookies.Delete("favoriteMilkshake");
            }
        }
    }
}
