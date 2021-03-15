using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeworkV3.Data;
using HomeworkV3.Models;
using HomeworkV3.DTO;
using Microsoft.EntityFrameworkCore;

namespace HomeworkV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly Context _context;

        public CustomerController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer_table>>> GetCustomers()
        {
            return await _context.customer_table.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<AddCustomer>> Add_Customer(Customer_table addCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = new Customer_table()
            {
                id = addCustomer.id,
                customer_Id = addCustomer.customer_Id
            };
            await _context.customer_table.AddAsync(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.id }, addCustomer);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AddCustomer>> GetCustomers_ById(int id)
        {
            var orders = _context.orders_table.ToList().Where(x => x.customer_Id == id);
            var customer_by_id = _context.customer_table.ToList().Find(x => x.id == id);
            if (customer_by_id == null || orders == null)
                return NotFound();
            var customerDTO = new AddCustomer
            {
                id = id,
                Customer_Id = customer_by_id.customer_Id,
                Orders = orders.ToList()
            };
            return customerDTO;
        }
    }
}
