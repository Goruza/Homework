using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.Models
{
    public class Customer_table
    {
        [Key]
        public int id { get; set; }
        public int customer_Id { get; set; }
    }
}
