using APIwithCQRSMediatr.Models;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Commands
{
    public class CreateEmployeeCommand : IRequest<Employee>
    {
        public CreateEmployeeCommand(string name, string address, string email, string mobile)
        {
            Name = name;
            Address = address;
            Email = email;
            Mobile = mobile;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
