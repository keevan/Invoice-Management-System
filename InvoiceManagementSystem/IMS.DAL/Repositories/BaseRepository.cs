using IMS.DAL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Allows the abstraction of multiple repositories */
namespace IMS.DAL.Repositories {
    abstract class BaseRepository<TEntity> where TEntity:class  {
        internal DataContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(DataContext context) {
            this.context = context;
            this.dbSet = context.Set<TEntity>();

        }

    }
}
