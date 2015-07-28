using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS.Model;

namespace IMS.Model {
    public class Basket {
        public int BasketId { get; set; }
        public DateTime date { get; set; }

        public virtual ICollection<BasketItem> BasketItems { get; set; }
    }
}
