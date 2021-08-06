using System;
using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Payments = new HashSet<Payment>();
        }

        //Method to get the OrderId
        public int OrderId { get; set; }

        //Method to get the Order date
        public DateTime? OrderDate { get; set; }

        //Method to get the Total amount of Order
        public decimal? TotalAmount { get; set; }

        //Method to get the CustomerId
        public int CustomerId { get; set; }

        //Method to get the Order status
        public string OrderStatus { get; set; }

        //Method to access the Customer table
        public virtual Customer Customer { get; set; }

        //Method to access the OrderItem table
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        //Method to access the Payment table
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
