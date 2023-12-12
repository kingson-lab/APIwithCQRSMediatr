using APIwithCQRSMediatr.Models;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Querys
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
