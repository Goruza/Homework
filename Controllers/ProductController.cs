using HomeworkV3.Data;
using HomeworkV3.DTO;
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
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products_table>>> GetProducts()
        {
            return await _context.products_table.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Products_table>> Add_Orders(Products_table addProducts)
        {
            await _context.products_table.AddAsync(addProducts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = addProducts.id }, addProducts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products_table>> GetProducts_ById(int id)
        {
            return _context.products_table.ToList().Find(x => x.id == id);
        }
    }

    
}
