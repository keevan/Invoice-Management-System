using IMS.DAL.Data;
using IMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL.Repositories {
    public class CustomerRepository : BaseRepository<Customer> {
        public CustomerRepository(DataContext context)
            : base(context) {
                if (context == null)
                    throw new ArgumentNullException();
        }
    }
}
