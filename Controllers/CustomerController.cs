using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeworkV3.Data;
using HomeworkV3.Models;
using HomeworkV3.DTO;

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

        [HttpPost]
        public async Task<ActionResult<AddCustomer>> Add_Customer(AddCustomer Customer_table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = new Customer_table()
            {
                id = Customer_table.id,
                customer_Id = Customer_table.customer_Id
            };
            await _context.customer_table.AddAsync(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.id }, Customer_table);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ListCustomer>> List_Customer(int id)
        {
            var customer = from ListCustomer in _context.customer_table
            join  in _context.orders_table on ListCustomer.id equals Orders_table.book_id

            if (customer == null)
            {
                return NotFound();
            }
            else
            {
                
            }
        }
    }
}
