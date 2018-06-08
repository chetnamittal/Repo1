using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAPI
{
    public class WriteToDatabaseApplication:TopLevelApplication
    {
        string dbConnectionString;
        public WriteToDatabaseApplication(string connectionStriing)
        {
            dbConnectionString = connectionStriing;
        }
        public override bool IndividualApplicationcall()
        {
            //Here we shall write the code to store "Hellow Word" into the database
            //Like here we can write code to create a conenction and then to write queries (SQL) .
            return true;
        }
    }
}
