using Dal.DalApi;
namespace Bl.Blservices
{

    public class DietitianService
    {
        IDietitianService _dietitianService;
        public DietitianService(IDietitianService _dietitianService)
        {
        this._dietitianService=_dietitianService;

    }


        //public Dietitian Add(Dietitian dietitian)
        //{
        //    nutritionContext.Dietitians.Add(dietitian);
        //    nutritionContext.SaveChanges();
        //    return dietitian;
        //}

        //public int Delete(Dietitian dietitian)
        //{
        //    nutritionContext.Dietitians.Remove(dietitian);
        //    nutritionContext.SaveChanges();
        //    return dietitian.Id;
        //}

        //public List<Dietitian> GetAll()
        //{
        //    return nutritionContext.Dietitians.ToList();
        //}

        //public Dietitian Update(Dietitian dietitian, int id)
        //{
        //    Dietitian dietitian1 = nutritionContext.Dietitians.FirstOrDefault(d => d.Id == id);
        //    dietitian1.Email = dietitian.Email;
        //    dietitian1.FirstName = dietitian.FirstName;
        //    dietitian1.LastName = dietitian.LastName;
        //    dietitian1.Phone = dietitian.Phone;
        //    nutritionContext.SaveChanges();
        //    return dietitian;
        //}
    }
}

