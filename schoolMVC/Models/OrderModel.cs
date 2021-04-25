using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolMVC.Models
{
    public class OrderModel : BaseModel2
    {
        public string CustomerName { get; set; }
        public string CustomerADD { get; set; }
        public string CustomerContact { get; set; }

    }
}
