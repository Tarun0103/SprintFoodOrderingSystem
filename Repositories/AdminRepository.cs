using SprintFoodOrderingSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SprintProject.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private Sprint1Context context = null;
        public AdminRepository(Sprint1Context context)
        {
            this.context= context;
        }

        //Add item into Menu
        public void AddItem(Menu menu)
        {
            context.Add(menu);
            context.SaveChanges();
        }

        //Delete item from menu
        public void DeleteItem(int menuId)
        {
            Menu menu = context.Menus.SingleOrDefault(s => s.MenuId ==
            menuId);
            context.Menus.Remove(menu);
            context.SaveChanges();
        }

        //Get customer details
        public object GetCustomers(int custId)
        {
            var data = (from cus in context.Customers
                        where cus.CustomerId == custId
                        select new
                        {
                            cus.FirstName,
                            cus.LastName,
                            cus.Email,
                            cus.Mobile,
                            cus.CustStatus
                        }).ToList();

            return data;

        }

        //Get complete menu
        public List<Menu> GetMenu() => context.Menus.ToList();

        //Get single menu item
        public Menu GetMenuItem(int menuId)
        {
            Menu menu = context.Menus.SingleOrDefault(s => s.MenuId == menuId);
            return menu;
        }

        //Get order status
        public void OrderStatus(Order orders)
        {
            context.Orders.Update(orders);
            context.SaveChanges();
        }

        //Update item in menu
        public void UpdateItem(Menu menu)
        {
            context.Menus.Update(menu);
            context.SaveChanges();
        }
    }
}