using APIwithCQRSMediatr.DataAccess.Querys;
using APIwithCQRSMediatr.Models;
using APIwithCQRSMediatr.Services;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeHandler(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
