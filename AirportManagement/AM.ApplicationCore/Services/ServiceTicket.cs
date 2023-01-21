using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Domain;
using System.Text.RegularExpressions;

namespace AM.ApplicationCore.Interfaces
{
    public class ServiceTicket : Service<Ticket>, IServiceTicket
    {
        public ServiceTicket(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Ticket> GetTicketByPrice(string prix)
        {
            return GetMany(m => m.Prix >= float.Parse(prix));
        }
    }
}
