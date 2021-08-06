using System.Collections.Generic;

#nullable disable

namespace SprintFoodOrderingSystem.Models
{
    public partial class Menu
    {
        public Menu()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        //Method to enter MenuId
        public int MenuId { get; set; }

        //Method to enter Menu Name
        public string MenuName { get; set; }

        //Method to enter the quantity of menu
        public int? Quantity { get; set; }

        //Method to enter the price of each quantity
        public decimal? Price { get; set; }

        //Method to enter the Food Category
        public string FoodCategory { get; set; }

        //Method to access OrderItem table
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
