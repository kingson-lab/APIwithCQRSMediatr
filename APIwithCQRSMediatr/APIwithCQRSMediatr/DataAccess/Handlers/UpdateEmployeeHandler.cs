using APIwithCQRSMediatr.DataAccess.Commands;
using APIwithCQRSMediatr.Models;
using APIwithCQRSMediatr.Services;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee()
            {
                Id = request.Id,
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Mobile = request.Mobile,
            };
            return await _employeeRepository.UpdateEmployeeAsync(emp);
        }
    }
}
