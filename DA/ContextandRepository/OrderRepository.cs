using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.DA;
using Microsoft.EntityFrameworkCore;


namespace DA.ContextandRepository
{
    public class OrderRepository
    {
        public void Add(Order order)
        {
            List<FoodType> foodTypes = new List<FoodType>();
            using var context = new Da_Context();
            foreach (var orderDetail in order.OrderDetails)
            {
                foodTypes.Add(orderDetail.FoodType);
                orderDetail.FoodType = null;
            }
            context.Orders.Add(order);
            for (int i = 0; i < order.OrderDetails.Count; i++)
            {
                order.OrderDetails[i].FoodType = foodTypes[i];
            }
            context.SaveChanges();
        }
        public List<Order> Gets()
        {
            using var context = new Da_Context();
            return context.Orders.Include(p => p.OrderDetails).ThenInclude(p => p.FoodType).ToList();
        }
        public Order Get(int id)
        {
            using var context = new Da_Context();
            return context.Orders.Include(p => p.OrderDetails).ThenInclude(p => p.FoodType).First(p => p.Id == id);
        }

    }
}
