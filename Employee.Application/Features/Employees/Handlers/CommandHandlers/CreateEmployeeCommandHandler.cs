using Employee.Application.Features.Employees.Commands;
using Employee.Application.Features.Employees.Mappers;
using Employee.Application.Features.Employees.Responses;
using Employee.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Features.Employees.Handlers.CommandHandlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeResponse>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = EmployeeMapper.Mapper.Map<Core.Entities.Employee>(request);
            if (employee is null)
                throw new ApplicationException("issue with mapper");

            var newEmployee = await _employeeRepository.AddAsync(employee);
            var employeeResponse = EmployeeMapper.Mapper.Map<EmployeeResponse>(newEmployee);

            return employeeResponse;
        }
    }
}
