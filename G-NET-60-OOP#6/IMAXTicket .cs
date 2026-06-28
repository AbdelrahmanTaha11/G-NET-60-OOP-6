
using System.Runtime.CompilerServices;

namespace G_NET_60_OOP_6
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool is3D)
            : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override string TicketType()
        {
            return "IMAX";
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {Is3D} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}";
        }


    }
}
