using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.Entities
{
   public class Employment
    {
        public int EmploymentId { get; set; }
        public String  FirstName { get; set; }
        public String LastName { get; set; }
        public int Salary { get; set; }
        public String Address { get; set; }
        public String PhoneNo { get; set; }

    }
    public class Company
    {
        public int CompanyId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Property { get; set; }
        public String Address { get; set; }
        public String PhoneNo { get; set; }

    }
}
