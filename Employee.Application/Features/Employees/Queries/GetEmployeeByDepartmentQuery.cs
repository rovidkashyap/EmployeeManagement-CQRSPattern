using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Features.Employees.Queries
{
    public class GetEmployeeByDepartmentQuery : IRequest<List<Employee.Core.Entities.Employee>>
    {
        public string Department { get; set; }
    }
}
