using Employee.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repository
{
    public interface IEmployeeRepository : IRepository<Core.Entities.Employee>
    {
        Task<IEnumerable<Employee.Core.Entities.Employee>> GetEmployeeByFirstName(string fname);
        Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByEmailId(string email);
        Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByDepartment(string department);
    }
}
