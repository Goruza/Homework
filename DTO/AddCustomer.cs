using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.DTO
{
    public class AddCustomer
    {
        [Required]
        public int id { get; set; }

        [Required]
        public int customer_Id { get; set; }
    }
}
