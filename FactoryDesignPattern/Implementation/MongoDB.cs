using System;
using System.Collections.Generic;

namespace FactoryDesignPattern
{
    /// <summary>
    /// MonogoDB Repository
    /// </summary>
    internal class MongoDB : IDBRepository, IDisposable
    {
        public MongoDB()
        {
            // Open mongoDB Connection
            OpenConnection();
        }

        public bool Delete(int employeeID)
        {
            bool result = false;
            try
            {
                Console.WriteLine("Mongo DB Delete");
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
                Console.WriteLine("Mongo DB Get All");
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
                Console.WriteLine("Mongo DB InsertOrUpdate");
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
