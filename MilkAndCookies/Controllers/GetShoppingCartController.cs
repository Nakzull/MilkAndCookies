using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("showcart")]
    public class GetShoppingCartController : Controller
    {
        [HttpGet]
        public ActionResult GetShoppingCart()
        {
            var myComplexObject = HttpContext.Session.GetObjectFromJson<Product>("Session");
            return Ok(myComplexObject);
        }
    }
}
