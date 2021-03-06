﻿using IMS.DAL.Data;
using IMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL.Repositories {
    public class ProductRepository : BaseRepository<Product>{
        public ProductRepository(DataContext context)
            : base(context) {
                if (context == null)
                    throw new ArgumentNullException();
        }

    }
}
