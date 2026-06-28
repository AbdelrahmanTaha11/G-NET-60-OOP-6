
namespace G_NET_60_OOP_6
{
    internal static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            return
    $@"========== RECEIPT ==========
Movie    : {ticket.MovieName}
Type     : {ticket.GetType().Name}
Price    : {ticket.Price}
Final    : {ticket.CalculateFinalPrice():F2}
Status   : {(ticket.IsBooked ? "Booked" : "Not Booked")}
=============================";
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            return tickets.Sum(t => t.CalculateFinalPrice());
        }

    }
}
