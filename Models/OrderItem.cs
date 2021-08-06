#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class OrderItem
    {
        //Method to enter the OrderId
        public int OrderId { get; set; }

        //Method to enter the MenuId
        public int MenuId { get; set; }

        //Method to get the price of order item
        public decimal? Amount { get; set; }

        //Method to enter number of servings required
        public int? NoofServing { get; set; }

        //Method to get the total amount
        public decimal? Total { get; set; }

        //Method to enter the OrderItemId
        public int OrderItemId { get; set; }

        //Method to access the Menu table
        public virtual Menu Menu { get; set; }

        //Method to access the Order table
        public virtual Order Order { get; set; }
    }
}
