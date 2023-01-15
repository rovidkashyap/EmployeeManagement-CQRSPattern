using Employee.Application.Features.Employees.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Features.Employees.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeResponse>
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Department { get; set; }
    }
}
