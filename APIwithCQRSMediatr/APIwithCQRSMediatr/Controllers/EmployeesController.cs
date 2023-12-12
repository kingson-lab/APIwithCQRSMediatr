using APIwithCQRSMediatr.DataAccess.Commands;
using APIwithCQRSMediatr.DataAccess.Handlers;
using APIwithCQRSMediatr.DataAccess.Querys;
using APIwithCQRSMediatr.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIwithCQRSMediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //GET: api/<EmployeesController>
        [HttpGet]
        public async Task<List<Employee>> GetEmployeeList()
        {
            var employeeList = await _mediator.Send(new GetEmployeeListQuery());
            return employeeList;
        }

        //GET: api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _mediator.Send(new GetEmployeeByIdQuery() { Id = id});
            return employee;
        }

        //POST: api/<EmployeesController>
        [HttpPost()]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var emp = await _mediator.Send(new CreateEmployeeCommand(employee.Name, employee.Address, 
                employee.Email, employee.Mobile));
            return emp;
        }

        //PUT: api/<EmployeesController>
        [HttpPut()]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var emp = await _mediator.Send(new UpdateEmployeeCommand(employee.Id, employee.Name, employee.Address,
                employee.Email, employee.Mobile));
            return emp;
        }

        //DELETE: api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            var emp = await _mediator.Send(new DeleteEmployeeCommand() { Id = id });
            return emp;
        }
    }
}
