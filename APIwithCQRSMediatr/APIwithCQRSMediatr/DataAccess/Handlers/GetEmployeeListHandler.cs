using APIwithCQRSMediatr.DataAccess.Querys;
using APIwithCQRSMediatr.Models;
using APIwithCQRSMediatr.Services;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeListHandler(IEmployeeRepository employeeRepository) {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeListAsync();
        }
    }
}
