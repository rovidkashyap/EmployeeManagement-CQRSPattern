using Employee.Application.Features.Employees.Commands;
using Employee.Application.Features.Employees.Queries;
using Employee.Application.Features.Employees.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee.Core.Entities.Employee>> Get()
        {
            return await _mediator.Send(new GetAllEmployeeQuery());
        }

        [HttpGet("GetByFirstName/{fname}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee.Core.Entities.Employee>> GetByFirstName(string fname)
        {
            return await _mediator.Send(new GetEmployeeByFirstNameQuery() { FirstName = fname });
        }

        [HttpGet("GetEmployeeByDepartment/{dept}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee.Core.Entities.Employee>> GetEmployeeByDepartment(string dept)
        {
            return await _mediator.Send(new GetEmployeeByDepartmentQuery() { Department = dept });
        }

        [HttpGet("GetEmployeeByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Employee.Core.Entities.Employee>> GetEmployeeByEmail(string email)
        {
            return await _mediator.Send(new GetEmployeeByEmailQuery() { Email = email });
        }

        [HttpPost("")]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

    }
}
