using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace schoolMVC.Models
{
    public class BaseModel2
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string SellerName { get; set; }
        public double prize { get; set; }
        public string image { get; set; }
    }
}
