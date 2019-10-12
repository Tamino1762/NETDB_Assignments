using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace TicketsWIthClasses
/** The interface holds all the commonalities of each ticket type.
 * Each ticket has its own unique things to go with each different ticket.
 * I added the read and write file in the menu in comments to show how each ticket type could be used.
 * I added a console write line to show that the menu works.
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string fileChoice;
            BugDefect bugTicket = new BugDefect();
            ITicket enhancementTicket = new Enhancements();
            ITicket taskTicket = new Task();
            

            do
            {
                Console.WriteLine("Enter the ticket you would like:\nA. Bug/Defect\nB. Enhancement\nC. Task\nEnter Q to Quit");
                choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "A":
                        var bugSearch = bugTicket.BugList.Where(b => b.Priority.Contains("Low"));
                        Console.WriteLine($"There are {bugSearch.Count()} low priority bug tickets");
                        








                        /*Console.WriteLine("(R)ead file\n(W)rite file");
                        fileChoice = Console.ReadLine().ToUpper();
                        if (fileChoice == "R")
                    {
                            bugTicket.ReadFile();
                    }
                        else
                        {
                            bugTicket.WriteFile();
                        }

//                        Console.WriteLine("");
//                        Console.WriteLine("Bug Ticket");
//                        Console.WriteLine("");
                        break;
                    case "B":
                        /*Console.WriteLine("(R)ead file\n(W)rite file");
                        fileChoice = Console.ReadLine().ToUpper();
                        if (fileChoice == "R")
                        {
                            enhancementTicket.ReadFile();
                        }
                        else
                        {
                            enhancementTicket.WriteFile();
                        } */
                        Console.WriteLine("");
                        Console.WriteLine("Enhancement Ticket");
                        Console.WriteLine("");
                        break;
                    case "C":
                        /*Console.WriteLine("(R)ead file\n(W)rite file");
                        fileChoice = Console.ReadLine().ToUpper();
                        if (fileChoice == "R")
                        {
                            taskTicket.ReadFile();
                        }
                        else
                        {
                            taskTicket.WriteFile();
                        } */
                        Console.WriteLine("");
                        Console.WriteLine("Task Ticket");
                        Console.WriteLine("");
                        break;
                    case "Q":
                        Console.WriteLine("Have a great day!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }//switch
            } while (choice != "Q");
        }
    }
}
