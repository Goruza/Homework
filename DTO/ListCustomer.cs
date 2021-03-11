using HomeworkV3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.DTO
{
    public class ListCustomer
    {
        [Required]
        public int id { get; set; }

        [Required]
        public int customer_Id { get; set; }
        public List<Orders_table> Orders { get; set; }
    }
}
