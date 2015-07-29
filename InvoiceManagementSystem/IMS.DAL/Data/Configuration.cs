using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL.Data {
    class Configuration : DbMigrationsConfiguration<DataContext> {

        public Configuration() {
            //Setting this so any changes made will be reflected on the server.
            //This may not always be the case (someone might manually migrate from the command line)

            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

    }
}
