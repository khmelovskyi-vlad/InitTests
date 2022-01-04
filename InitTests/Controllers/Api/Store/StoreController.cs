using InitTests.Models.StoreValues;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InitTests.Controllers.Api.Store
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [Route("product")]
        public IActionResult GetProduct()
        {
            return Ok(new Models.StoreValues.Store().GetProduct(Guid.NewGuid()));
        }
    }
}
