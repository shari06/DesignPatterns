using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    /// <summary>
    /// Factory Method
    /// </summary>
    public class FactoryDatabase
    {
        public static IDBRepository GetDBRepository(string dbtype)
        {
            IDBRepository dBRepository = null;
            if (dbtype == "1")
            {
                dBRepository = new PostgresSQL();
            }
            else if (dbtype == "2")
            {
                dBRepository = new SQLServer();
            }
            else if (dbtype == "3")
            {
                dBRepository = new MongoDB();
            }
            return dBRepository;
        }
    }
}
