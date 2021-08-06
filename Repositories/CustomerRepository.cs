using SprintFoodOrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SprintProject.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Sprint1Context context = null;
        public CustomerRepository(Sprint1Context context)
        {
            this.context = context;
        }

        //Add customer
        public void AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
        }

        //Add order 
        public void AddOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        //Add orderitem
        public void AddOrderItem(OrderItem orderItem)
        {
            context.OrderItems.Add(orderItem);
            context.SaveChanges();
        }

        //Delete customer
        public void DeleteCustomer(int CustId)
        {
            Customer customer = context.Customers.SingleOrDefault(s => s.CustomerId ==
            CustId);
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        //Delete order
        public void DeleteOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            context.Orders.Remove(order);
            context.SaveChanges();
        }

        //Delete order item
        public void DeleteOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.OrderItems.Remove(orderitem);
            context.SaveChanges();
        }

        //Edit order
        public void EditOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            context.Orders.Update(order);
            context.SaveChanges();
        }

        //Edit orderitem
        public void EditOrderItem(int orderItemId)
        {
            OrderItem orderitem = context.OrderItems.SingleOrDefault(s => 
            s.OrderItemId == orderItemId);
            context.OrderItems.Update(orderitem);
            context.SaveChanges();
        }

        //Get complete menu as a list
        public List<Menu> GetMenu() => context.Menus.ToList();

        //Get complete orders as a list
        public List<Order> GetOrders() => context.Orders.ToList();
        
        //Make payment
        public void MakePayment(Payment payment)
        {
            //var orders = (from or in context.OrderItems
            //             where or.OrderId == orderId
            //             select or).ToList();

            //decimal? totalamount = 0;

            //foreach (var i in orders)
            //{
            //    decimal serving = Convert.ToDecimal(i.NoofServing);
            //    totalamount += (i.Amount * serving);
            //}
            //order.TotalAmount = totalamount;
            context.Add(payment);
            context.SaveChanges();
        }

        //To track order
        public string TrackOrder(int orderId)
        {
            Order order = context.Orders.SingleOrDefault(s => s.OrderId == orderId);
            return $"Order Status: {order.OrderStatus}";
        }

        //Update customer 
        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}