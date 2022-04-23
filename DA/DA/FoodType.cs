using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DA.DA
{
   public class FoodType
    {
        public FoodType()
        { }
        public FoodType(string name, decimal price)
        {
            if (name == "" || price == 0)
            {
                throw new Exception("لطفا موارد ذکر شده را تکمیل نمایید");
            }
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get;set; }
        public decimal Price { get; set;}
    }

}
