using HomeworkV3.Data;
using HomeworkV3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly Context _context;

        public OrderController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orders_table>>> GetOrders()
        {
            return await _context.orders_table.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Orders_table>> Add_Orders(Orders_table addOrder)
        {
            await _context.orders_table.AddAsync(addOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrders", new { id = addOrder.id }, addOrder);
        }
    }

    
}
