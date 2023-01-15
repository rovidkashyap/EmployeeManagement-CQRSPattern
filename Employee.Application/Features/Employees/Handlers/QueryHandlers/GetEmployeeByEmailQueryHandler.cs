using Employee.Application.Features.Employees.Queries;
using Employee.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Features.Employees.Handlers.QueryHandlers
{
    public class GetEmployeeByEmailQueryHandler : IRequestHandler<GetEmployeeByEmailQuery, List<Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByEmailQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Core.Entities.Employee>> Handle(GetEmployeeByEmailQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Employee>)await _employeeRepository.GetEmployeeByEmailId(request.Email);
        }
    }
}
