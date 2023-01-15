using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Features.Employees.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Core.Entities.Employee>>
    {
    }
}
