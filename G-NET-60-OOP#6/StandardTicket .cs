using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G_NET_60_OOP_6
{
    internal class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movie, decimal price, string seat)
            : base(movie, price)
        {
            Seat = seat;
        }

        public override decimal CalculateFinalPrice()
        {
            return Price * 1.14m;
        }

        public override string TicketType()
        {
            return "Standard";
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
