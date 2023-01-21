using Microsoft.AspNetCore.Mvc;
using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetALLRegions()
        {
            var regions = new List<Region>()
            { 
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington",
                    Code = "WLG",
                    Area = 227755,
                    Lat = 1.8822,
                    long1 = 299.88,
                    Population =500000


                },
                new Region()
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland",
                    Code = "AUCK",
                    Area = 227755,
                    Lat = 1.8822,
                    long1 = 299.88,
                    Population =500000


                }
            };
            return Ok(regions);
        }
    }
}
