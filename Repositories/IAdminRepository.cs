using System.Collections.Generic;
using SprintFoodOrderingSystem.Models;


namespace SprintProject.Repositories
{
    public interface IAdminRepository
    {
        //Method to add item into menu
        public void AddItem(Menu menu);

        //Method to get the menu as a list
        public List<Menu> GetMenu();

        //Method to update details of item in menu
        public void UpdateItem(Menu menu);

        //Method to delete an item from menu using menuId
        public void DeleteItem(int menuId);

        //Method to get the status of order
        public void OrderStatus(Order orders);

        //Method to get a single menu item using menuId
        public Menu GetMenuItem(int menuId);

        //Method to get the details of customer using customer Id
        public object GetCustomers(int custId);
    }
}