
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;
using Dal.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietitianController : ControllerBase
    {
        IDietitianService dietitianSevice;

        public DietitianController(IDietitianService dietitianSevice)
        {
            this.dietitianSevice = dietitianSevice;
        }
        [HttpGet]

public ActionResult<List<Meeting>> GetTodayMeetingsById(int Id) {
       return    dietitianSevice.GetTodayMeetingdById(id);

        }
    }
}
