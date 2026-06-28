using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_60_OOP_6
{
    internal partial class Cinema
    {
        public void PrintTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket);
            }
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"\nTotal Tickets: {tickets.Count}");
        }

    }
}
