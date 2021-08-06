#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Payment
    {
        //Method to get the payment Id
        public int PaymentId { get; set; }

        //Method to get the OrderId
        public int? OrderId { get; set; }

        //Method to get the total amount of order
        public decimal? TotalAmount { get; set; }

        //Method to get the details of customer
        public string PaidBy { get; set; }

        //Method to get the payment status
        public string PaymentStatus { get; set; }

        //Method to access Order table
        public virtual Order Order { get; set; }
    }
}
