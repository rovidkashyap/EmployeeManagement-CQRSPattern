using Employee.Application.Features.Employees.Queries;
using Employee.Application.Features.Employees.Responses;
using Employee.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Features.Employees.Handlers.QueryHandlers
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQuery, List<Employee.Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Core.Entities.Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return (List<Employee.Core.Entities.Employee>)await _employeeRepository.GetAllAsync();
        }
    }
}
