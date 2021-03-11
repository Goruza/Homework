using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.DTO
{
    public class AddProduct
    {
        [Required]
        public int id { get; set; }

        [Required]
        public int products_Id { get; set; }
    }
}
