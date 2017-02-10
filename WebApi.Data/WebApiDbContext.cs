using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Entities;

namespace WebApi.Data
{
    public class WebApiDbContext:DbContext
    {
        public WebApiDbContext() : base("Emp")
        {

        }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
    }
}
