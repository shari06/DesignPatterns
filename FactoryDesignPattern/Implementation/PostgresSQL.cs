using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    /// <summary>
    /// Postgres Repository
    /// </summary>
    internal class PostgresSQL : IDBRepository, IDisposable
    {
        public PostgresSQL()
        {
            // Open PostgresSQL Connection
            OpenConnection();
        }

        public bool Delete(int employeeID)
        {
            bool result = false;
            try
            {
                Console.WriteLine("Postgres SQL Delete");
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
                Console.WriteLine("Postgres SQL Get All");
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
                Console.WriteLine("Postgres SQL InsertOrUpdate");
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
