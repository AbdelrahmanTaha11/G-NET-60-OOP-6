

namespace G_NET_60_OOP_6
{
    internal abstract class Ticket
    {
        private static int counter = 0;

        public int TicketId { get; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movieName, decimal price)
        {
            TicketId = ++counter;
            MovieName = movieName;
            Price = price;
        }

      
        public abstract decimal CalculateFinalPrice();

       
        public virtual string TicketType()
        {
            return "Ticket";
        }

       
        public void Book()
        {
            IsBooked = true;
        }

        public void Cancel()
        {
            IsBooked = false;
        }

        public override string ToString()
        {
            return $"[Ticket #{TicketId}] {MovieName} | {TicketType()} | Price: {Price} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}";
        }

    }
}
