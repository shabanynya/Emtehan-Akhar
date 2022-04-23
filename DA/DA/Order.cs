using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DA.DA
{

    public class Order
    {
        private Order()
        { }
       
public Order(List<OrderDetail> orderDetails)
        {
            OrderDetails = orderDetails;
        }

        public int Id { get; set; }
        public string Description => GenerateDescription();
        public decimal TotalAmount => OrderDetails.Sum(p => p.FoodType.Price * p.Count);
        public List<OrderDetail> OrderDetails { get; set; }
        private string GenerateDescription()
        {
            string result = "";
            foreach (var orderDetail in OrderDetails)
            {
                result += orderDetail.Count + " " + orderDetail.FoodType.Name + " ";
            }
            return result;
        }
    }
}
