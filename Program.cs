// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TicketSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Bug/Defect Ticket");
                Console.WriteLine("2. Add Enhancement Ticket");
                Console.WriteLine("3. Add Task Ticket");
                Console.WriteLine("4. Search Tickets");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    TicketManager.AddBugDefectTicket();
                }
                else if (choice == "2")
                {
                    TicketManager.AddEnhancementTicket();;
                }
                else if (choice == "3")
                {
                    TicketManager.AddTaskTicket();
                }
                else if (choice == "4")
                {
                    TicketManager.SearchTickets();
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
        }
    }
}

