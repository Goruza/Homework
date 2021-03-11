using HomeworkV3.Data;
using HomeworkV3.DTO;
using HomeworkV3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public async Task<ActionResult<AddProduct>> Add_Product(AddProduct Product_table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product = new Products_table()
            {
                id = Product_table.id,
                products_Id = Product_table.products_Id
            };
            await _context.products_table.AddAsync(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = product.id }, Product_table);
        }
    }

    
}
