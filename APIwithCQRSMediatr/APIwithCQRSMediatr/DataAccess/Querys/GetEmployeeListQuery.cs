using APIwithCQRSMediatr.Models;
using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Querys
{
    public class GetEmployeeListQuery : IRequest<List<Employee>>
    {

    }
}
