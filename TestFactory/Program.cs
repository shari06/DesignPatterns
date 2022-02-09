using FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Start:

            Console.WriteLine("\n\n\nPlease enter DB type \n 1 for PostgresSQL \n 2 for SQLServer \n 3 for MongoDB ");
            var strDBType = Console.ReadLine();

       

            if (!string.IsNullOrEmpty(strDBType))
            {
                var dbRepository = FactoryDatabase.GetDBRepository(strDBType);
                dbRepository.InsertOrUpdate(new Employee());
                dbRepository.Delete(1);
                dbRepository.GetEmployees();
            }

            goto Start;

            Console.ReadKey();

        }
    }
}
