using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using SprintFoodOrderingSystem.Models;
using SprintProject.Repositories;

namespace SprintProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminRepository _repository;
        public AdminController(IAdminRepository repository)
        {
            _repository = repository;
        }

        //Add item into Menu
        [HttpPost]
        [Route("additem")]
        public IActionResult AddItem(Menu menu)
        {
            try
            {
                _repository.AddItem(menu);
                return Ok("Item Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete item from menu
        [HttpDelete]
        [Route("DeleteItem/{menuId}")]
        public IActionResult DeleteItem(int menuId)
        {
            try
            {
                _repository.DeleteItem(menuId);
                return Ok("Item Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get customer details
        [HttpGet]
        [Route("CustDetails/{custId}")]
        public object GetCustomers(int custId)
        {
            return _repository.GetCustomers(custId);
        }

        //Get complete menu
        [HttpGet]
        [Route("MenuList")]
        public List<Menu> GetMenu()
        {
            return _repository.GetMenu();
        }

        //Get single menu item
        [HttpGet]
        [Route("GetItem/{menuId}")]
        public Menu GetMenuItem(int menuId)
        {
            return _repository.GetMenuItem(menuId);
        }

        //Get order status
        [HttpPut]
        [Route("Status")]
        public IActionResult OrderStatus(Order orders)
        {
            try
            {
                _repository.OrderStatus(orders);
                return Ok("OrderStatus Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update item in menu
        [HttpPut]
        [Route("UpdateItem")]
        public IActionResult UpdateItem(Menu menu)
        {
            try
            {
                _repository.UpdateItem(menu);
                return Ok("Item Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}