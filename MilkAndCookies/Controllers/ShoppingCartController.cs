using Microsoft.AspNetCore.Mvc;

namespace MilkAndCookies.Controllers
{
    [ApiController]
    [Route("shoppingcart")]
    public class ShoppingCartController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get(string productName, int price)
        {
            if (HttpContext.Session.GetObjectFromJson<Product>("Session") == null)
            {
                var myComplexObjectNew = Enumerable.Range(1, 1).Select(index => new Product
                {
                    Name = productName,
                    Price = price
                }).ToArray();
                HttpContext.Session.SetObjectAsJson("Session", myComplexObjectNew);              

                return Ok(myComplexObjectNew);
            }
            else
            {
                return Enumerable.Range(1, 1).Select(index => new Product
                {
                    Name = productName,
                    Price = price
                })
            .ToArray();
            }
        }

        
    }
}
