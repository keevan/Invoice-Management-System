using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Model {
    public class Customer {
        public int CustomerId;
        public string CustomerName;

        public string Address1 {get;set;}
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}
