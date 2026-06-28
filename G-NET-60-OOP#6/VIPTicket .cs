
namespace G_NET_60_OOP_6
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal VipFee { get; set; }

        public VIPTicket(string movieName, decimal price, bool loungeAccess, decimal vipFee)
            : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
            VipFee = vipFee;
        }

        public override decimal CalculateFinalPrice()
        {
            return (Price + VipFee) * 1.14m;
        }

        public override string TicketType()
        {
            return "VIP";
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {LoungeAccess} | Fee: {VipFee} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}";
        }
    }
}
