using MediatR;

namespace APIwithCQRSMediatr.DataAccess.Commands
{
    public class DeleteEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
