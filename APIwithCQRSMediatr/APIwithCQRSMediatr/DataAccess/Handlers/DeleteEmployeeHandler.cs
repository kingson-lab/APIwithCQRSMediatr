﻿using APIwithCQRSMediatr.DataAccess.Commands;
using APIwithCQRSMediatr.Services;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;
            return await _employeeRepository.DeleteEmployeeAsync(request.Id);
        }
    }
}
