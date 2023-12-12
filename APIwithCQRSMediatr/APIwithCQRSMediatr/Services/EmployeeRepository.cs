using APIwithCQRSMediatr.DataAccess;
using APIwithCQRSMediatr.Models;
using Microsoft.EntityFrameworkCore;

namespace APIwithCQRSMediatr.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataBaseContext _databaseContext;
        public EmployeeRepository(DataBaseContext dataBaseContext)
        {
            _databaseContext = dataBaseContext;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result =_databaseContext.Employees.Add(employee);
            await _databaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int Id)
        {
            var filterdata = _databaseContext.Employees.Where(emp => emp.Id == Id).FirstOrDefault();
            _databaseContext.Employees.Remove(filterdata);
            return await _databaseContext.SaveChangesAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {
            var emp =  await _databaseContext.Employees.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            return await _databaseContext.Employees.ToListAsync();
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _databaseContext.Employees.Update(employee);
            return await _databaseContext.SaveChangesAsync();
        }
    }
}
