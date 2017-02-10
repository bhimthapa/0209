using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.Entities
{
   public class EventLog
    {
        public int Id { get; set; }
        public string MethodName { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
