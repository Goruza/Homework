using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.Models
{
    public class Products_table
    {
        [Key]
        public int id { get; set; }
        public int products_Id { get; set; }
    }
}
