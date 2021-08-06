using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        //Method to enter Customer Id
        public int CustomerId { get; set; }
        
        //Method to enter FirstName of customer
        public string FirstName { get; set; }

        //Method to enter LastName of customer
        public string LastName { get; set; }

        //Method to enter Email of customer
        public string Email { get; set; }

        //Method to enter MobileNo of customer
        public long? Mobile { get; set; }

        //Method to enter Customer Password
        public string CustPassword { get; set; }

        //Method to enter Customer Status
        public string CustStatus { get; set; }

        //Method to access Order Table
        public virtual ICollection<Order> Orders { get; set; }
    }
}
