using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    /// <summary>
    /// SQLServer Repository
    /// </summary>
    internal class SQLServer : IDBRepository, IDisposable
    {
        public SQLServer()
        {
            // Open SQLServer Connection
            OpenConnection();
        }

        public bool Delete(int employeeID)
        {
            bool result = false;
            try
            {
                Console.WriteLine("SQLServer Delete");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                Console.WriteLine("SQLServer Get All");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return new List<Employee>();
        }

        public Employee InsertOrUpdate(Employee employee)
        {
            try
            {
                Console.WriteLine("SQLServer InsertOrUpdate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return new Employee();
        }

        public void Dispose()
        {
            // Dispose All Object
            CloseConnection();
        }


        private string OpenConnection()
        {
            return "Connection";
        }

        private string CloseConnection()
        {
            return "Connection";
        }
    }
}
