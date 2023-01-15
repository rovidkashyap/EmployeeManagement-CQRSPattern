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
    public class GetEmployeeByFirstNameQueryHandler : IRequestHandler<GetEmployeeByFirstNameQuery, List<Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByFirstNameQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Core.Entities.Employee>> Handle(GetEmployeeByFirstNameQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Employee>)await _employeeRepository.GetEmployeeByFirstName(request.FirstName);
        }
    }
}
