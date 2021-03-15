using HomeworkV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.DTO
{
    public class AddCustomer
    {
        public int Customer_Id { get; set; }
        public int id { get; set; }
        public List<Orders_table> Orders { get; set; }

    }
}
