using Employee.Core.Repository;
using Employee.Infrastructure.Context;
using Employee.Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repository
{
    public class EmployeeRepository : Repository<Core.Entities.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByDepartment(string department)
        {
            return await _context.employees.Where(x => x.Department == department).ToListAsync();
        }

        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByEmailId(string email)
        {
            return await _context.employees.Where(x => x.Email == email).ToListAsync();
        }

        public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByFirstName(string fname)
        {
            return await _context.employees.Where(x => x.FirstName == fname).ToListAsync();
        }
    }
}
