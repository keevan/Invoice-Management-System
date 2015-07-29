using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Model {
    public class Order {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }

        [MaxLength(255)]
        public string OrderLocation { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
