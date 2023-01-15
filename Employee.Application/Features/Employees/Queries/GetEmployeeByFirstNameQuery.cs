using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Features.Employees.Queries
{
    public class GetEmployeeByFirstNameQuery : IRequest<List<Core.Entities.Employee>>
    {
        public string FirstName { get; set; }
    }
}
