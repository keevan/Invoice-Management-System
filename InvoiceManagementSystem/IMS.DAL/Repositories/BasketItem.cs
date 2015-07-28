using IMS.DAL.Data;
using IMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL.Repositories {
    public class BasketItemRepository : BaseRepository<BasketItem> {
        public BasketItemRepository(DataContext context)
            : base(context) {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
