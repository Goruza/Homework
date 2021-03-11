﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.Models
{
    public class Orders_table
    {
        [Key]
        public int id { get; set; }
        public int customer_Id { get; set; }
        public int product_Id { get; set; }
        public int order_Id { get; set; }
    }
}
