using APIwithCQRSMediatr.Models;
using MediatR;
using System.Net;
using System.Reflection;

namespace APIwithCQRSMediatr.DataAccess.Commands
{
    public class UpdateEmployeeCommand : IRequest<int>
    {
        public UpdateEmployeeCommand(int id, string name, string address, string email, string mobile)
        {
            Id = id;
            Name = name;
            Address = address;
            Email = email;
            Mobile = mobile;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}
