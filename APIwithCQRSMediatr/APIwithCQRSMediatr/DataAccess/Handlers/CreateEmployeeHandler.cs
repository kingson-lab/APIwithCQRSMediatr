using APIwithCQRSMediatr.DataAccess.Commands;
using APIwithCQRSMediatr.Models;
using APIwithCQRSMediatr.Services;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee()
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Mobile = request.Mobile,
            };

            return await _employeeRepository.AddEmployeeAsync(emp);
        }
    }
}
