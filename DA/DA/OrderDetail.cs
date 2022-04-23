using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DA.DA
{
  public class OrderDetail
    {
        public OrderDetail()
        { }
        public OrderDetail(FoodType foodType, int count)
        {
            if (count==0)
            {
                throw new Exception("لطفا موارد ذکر شده را تکمیل نمایید");
            }
            this.FoodType = foodType;
            Count = count;
        }

        public int Id { get; set; }
        public FoodType FoodType { get; set;}
        public int Count { get; set;}

    }
}
