using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public interface IDBRepository
    {
        /// <summary>
        /// Insert or Upate based on the ID
        /// </summary>
        /// <param name="employee">Emlpoyee Object</param>
        /// <returns>Emlpoyee Object</returns>
        Employee InsertOrUpdate(Employee employee);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeID">employee ID</param>
        /// <returns></returns>
        bool Delete(int employeeID);

        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();

    }
}
