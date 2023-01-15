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
    public class GetEmployeeByDepartmentQueryHandler : IRequestHandler<GetEmployeeByDepartmentQuery, List<Core.Entities.Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByDepartmentQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Core.Entities.Employee>> Handle(GetEmployeeByDepartmentQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Employee>)await _employeeRepository.GetEmployeeByDepartment(request.Department);
        }
    }
}
