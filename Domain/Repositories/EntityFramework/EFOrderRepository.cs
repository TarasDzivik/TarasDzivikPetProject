//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using TarasDzivikPetProject.Domain.Entities;
//using TarasDzivikPetProject.Domain.Repositories.Abstract;

//namespace TarasDzivikPetProject.Domain.Repositories.EntityFramework
//{
//    public class EFOrderRepository : IOrderRepository
//    {
//        private readonly AppDbContext context;
//        public EFOrderRepository(AppDbContext context)
//        {
//            this.context = context;
//        }

//        public IQueryable<Order> GetOrders()
//        {
//            return context.Orders;
//        }

//        public Order GetOrderById(int id)
//        {
//           return context.Orders.FirstOrDefault(o => o.OrderId == id);
//        }

//        public IQueryable<Order> GetUnAcceptableOrders(bool Not)
//        {
//            return (IQueryable<Order>)context.Orders.FirstOrDefault(o => o.Accepted == false);
//        }

//        public void AcceptOrder(Order entity)
//        {
//            if (entity.Accepted)
//            {
//                context.Entry(entity).State = EntityState.Unchanged;
//            }
//            else
//            {
//                context.Entry(entity).State = EntityState.Modified;
//            }
//            context.SaveChanges();
//        }

//        public void SaveOrder(Order entity)
//        {
//            if (entity.OrderId == default)
//            {
//                context.Entry(entity).State = EntityState.Added;
//            }
//            else
//            {
//                context.Entry(entity).State = EntityState.Modified;
//            }
//            context.SaveChanges();
//        }

//        public void DeleteOrder(int id)
//        {
//            context.Orders.Remove(new Order() { OrderId = id });
//            context.SaveChanges();
//        }
//    }
//}