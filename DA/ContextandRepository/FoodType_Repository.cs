using System;
using System.Collections.Generic;
using System.Text;
using DA.DA;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DA.ContextandRepository
{
   public class FoodType_Repository
    {
        public void Add(FoodType foodType)
        {
            using var context = new Da_Context();
            context.FoodTypes.Add(foodType);
            context.SaveChanges();
        }
        public List<FoodType> Gets()
        {
            using var context = new Da_Context();
            return context.FoodTypes.ToList();
        }
        public FoodType Get(int id)
        {
            using var context = new Da_Context();
            return context.FoodTypes.Find(id);
        }
    }
}
