using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkV3.Model
{
    public class students_description
    {
        [Key]
        public int id { get; set; }
        public int Students_Id { get; set; }
        public int Students_Age { get; set; }
        public string Students_First_Name { get; set; }
        public string Students_Last_Name { get; set; }
        public string Students_Adress { get; set; }
        public string Students_Country { get; set; }
    }
}
