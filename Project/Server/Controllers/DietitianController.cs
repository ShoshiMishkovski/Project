
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bl.BlApi;
namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietitianController : ControllerBase
    {
        IDietitianService dietitianSevice;

        public DietitianController()
        {
            
        }
        //[HttpGet]
        //public ActionResult<List<Dietitian>> Get() { 
        //return dietitianService.GetAll();
        //}
        //[HttpDelete]
        //public ActionResult<Dietitian> Delete(Dietitian dietitian) {
        //    dietitianService.Delete(dietitian);
        //    return dietitian;
        //}
        //[HttpPost]
        //public ActionResult<Dietitian> Add(Dietitian dietitian)
        //{
        //    dietitianService.Add(dietitian);
        //    return dietitian;
        //}
        //[HttpPut]
        //public ActionResult<Dietitian> Update(Dietitian dietitian,int id)
        //{
        //    dietitianService.Update(dietitian,id);
        //    return dietitian;   
        //}
    }
}
