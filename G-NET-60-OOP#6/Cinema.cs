
namespace G_NET_60_OOP_6;

internal partial class Cinema
{
    private List<Ticket> tickets = new List<Ticket>();

    public Cinema()
    {
        Console.WriteLine("=== Cinema Opened ===");
        Console.WriteLine("Projector ON");
    }

    public void AddTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public void BookTicket(Ticket ticket)
    {
        ticket.Book();
    }

    public void Close()
    {
        Console.WriteLine("Projector OFF");
        Console.WriteLine("=== Cinema Closed ===");


    }
}