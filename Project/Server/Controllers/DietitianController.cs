
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;
using Dal.Models;
using Bl.BlModels;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietitianController : ControllerBase
    {
        IBlDietitianService dietitianSevice;

        public DietitianController(IBlDietitianService dietitianSevice)
        {
            this.dietitianSevice = dietitianSevice;
        }
        [HttpGet]
        public ActionResult<List<BlDietitian>> GetAll()
        {
            return dietitianSevice.GetAll();
        }
        [HttpGet("{DietitianId}")]

        public ActionResult<List<Bl.BlModels.Meeting>> GetTodayMeetingsById(int DietitianId)
        {
            return dietitianSevice.GetTodatMeetingsById(DietitianId);

        }


    }
}
