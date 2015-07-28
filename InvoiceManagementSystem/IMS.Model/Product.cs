using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Model {
    public class Product {
        
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [MaxLength(255)]
        public string ImageUrl { get; set; }
        
        // Cost of raw product from supplier
        public decimal CostPrice { get; set; }


    }
}
