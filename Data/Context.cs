using HomeworkV3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using HomeworkV3.Models;

namespace HomeworkV3.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Student> students{ get; set; }
        public DbSet<students_description> students_description { get; set; }
        public DbSet<Customer_table> customer_table { get; set; }
        public DbSet<Products_table> products_table { get; set; }
        public DbSet<Orders_table> orders_table { get; set; }


        public static implicit operator ContextBoundObject(Context v)
        {
            throw new NotImplementedException();
        }
    }
}
