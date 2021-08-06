using System.Collections.Generic;
using SprintFoodOrderingSystem.Models;

namespace SprintProject.Repositories
{
    public interface ICustomerRepository
    {
        //Method to add customer
        public void AddCustomer(Customer customer);

        //Method to update customer
        public void UpdateCustomer(Customer customer);

        //Method to delete customer
        public void DeleteCustomer(int CustId);

        //Get complete menu as a list
        public List<Menu> GetMenu();

        //Get all orders as a list
        public List<Order> GetOrders();

        //Method to add orderitem
        public void AddOrderItem(OrderItem orderItem);

        //Method to delete orderitem
        public void DeleteOrderItem(int orderItemId);

        //Method to edit orderitem
        public void EditOrderItem(int orderId);

        //Method to track order
        public string TrackOrder(int orderId);

        //Method to add order
        public void AddOrder(Order order);

        //Method to delete order
        public void DeleteOrder(int orderId);

        //Method to edit order
        public void EditOrder(int orderId);

        //Method to make payment
        public void MakePayment(Payment payment);
    }
}