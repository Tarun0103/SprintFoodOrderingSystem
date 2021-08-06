using Microsoft.AspNetCore.Mvc;
using SprintFoodOrderingSystem.Models;
using SprintProject.Repositories;
using System;
using System.Collections.Generic;

namespace SprintFoodOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;
        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        //Add customer
        [HttpPost]
        [Route("AddCustomer")]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                _repository.AddCustomer(customer);
                return Ok("Customer Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Update Customer Details
        [HttpPut]
        [Route("UpdateCustomerDetails")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            try
            {
                _repository.UpdateCustomer(customer);
                return Ok("Updated Customer Details");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete Customer by customerId
        [HttpDelete]
        [Route("DeleteCustomer/{customerId}")]
        public IActionResult DeleteCustomer(int customerId)
        {
            try
            {
                _repository.DeleteCustomer(customerId);
                return Ok("Deleted Customer");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Add order 
        [HttpPost]
        [Route("AddOrder")]
        public IActionResult AddOrder(Order order)
        {
            try
            {
                _repository.AddOrder(order);
                return Ok("Order Added");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Add orderitem
        [HttpPost]
        [Route("AddOrderItem")]
        public IActionResult AddOrderItem(OrderItem orderitem)
        {
            try
            {
                _repository.AddOrderItem(orderitem);
                return Ok("Order Item Added");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete order
        [HttpDelete]
        [Route("DeleteOrder/{orderId}")]
        public IActionResult DeleteOrder(int orderId)
        {
            try
            {
                _repository.DeleteOrder(orderId);
                return Ok("Deleted Order");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Delete order item
        [HttpDelete]
        [Route("DeleteOrderItem/{orderId}")]
        public IActionResult DeleteOrderItem(int orderItemId)
        {
            try
            {
                _repository.DeleteOrder(orderItemId);
                return Ok("Deleted OrderItem");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Edit order
        [HttpPut]
        [Route("EditOrder/{orderId}")]
        public IActionResult EditOrder(int orderId)
        {
            try
            {
                _repository.EditOrder(orderId);
                return Ok("Order Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Edit orderitem
        [HttpPut]
        [Route("EditOrderItem/{orderItemId}")]
        public IActionResult EditOrderItem(int orderItemId)
        {
            try
            {
                _repository.EditOrder(orderItemId);
                return Ok("OrderItem Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Get complete menu as a list
        [HttpGet]
        [Route("MenuList")]
        public List<Menu> GetMenu()
        {
            return _repository.GetMenu();
        }

        //Get complete orders as a list
        [HttpGet]
        [Route("OrderList")]
        public List<Order> GetOrder()
        {
            return _repository.GetOrders();
        }


        // Make Payment By OrderId
        [HttpPost]
        [Route("MakePayment")]
        public IActionResult MakePayment(Payment payment)
        {
            try
            {
                _repository.MakePayment(payment);
                return Ok("payment Success");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //To track order
        [HttpPut]
        [Route("Status")]
        public IActionResult TrackOrder(int orderId)
        {
            try
            {
                _repository.TrackOrder(orderId);
                return Ok("OrderStatus Updated");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
