using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TicketsWIthClasses
{
   public class BugDefect : ITicket 
    {
        

        public string Severity { get; set; }
        public int TicketID { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public string Watching { get; set; }
        public string filePath { get; set; }

        public void WriteFile()
        {
            var file = "BugDefect.txt";
        }
        public List<BugDefect> BugList { get; set; }
        public void ReadFile()
        {
            string file = "tickets.csv";
            string line;
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string [] items = line.Split(',');
                BugDefect bugTicket = new BugDefect();
                BugList = new List<BugDefect>();

                for (int i = 0; i < BugList.Count; i++)
                {
                    bugTicket.TicketID = int.Parse((items[0]));
                    bugTicket.Summary = items[1];
                    bugTicket.Status = items[2];
                    bugTicket.Priority = items[3];
                    bugTicket.Submitter = items[4];
                    bugTicket.Assigned = items[5];
                    bugTicket.Watching = items[6];
                }
                BugList.Add(bugTicket);

            }
            sr.Close();
        }
        //Trying stuff here
        /*
        public void Search() 
        {
            List<BugDefect> TicketList = new List<BugDefect>();
            TicketList.Add(new BugDefect() {TicketID = 123, Status = "Open", Priority = "Low", Submitter = "Huey", Assigned = "Duey", Watching = "Luey"});
            TicketList.Add(new BugDefect() { TicketID = 456, Status = "Open", Priority = "Low", Submitter = "Tom", Assigned = "Dick", Watching = "Harry" });
            TicketList.Add(new BugDefect() { TicketID = 456, Status = "Closed", Priority = "High", Submitter = "Harry", Assigned = "Hermione", Watching = "Ron" });
            TicketList.Add(new BugDefect() { TicketID = 456, Status = "Open", Priority = "Meduim", Submitter = "John", Assigned = "Paul", Watching = "Ringo" });
            TicketList.Add(new BugDefect() { TicketID = 456, Status = "Closed", Priority = "Medium", Submitter = "Marsha", Assigned = "Jan", Watching = "Cindy" });

            //  search
            var searchString = "Low";
            var result = TicketList.Where(b => b.Priority.Contains (searchString));
            var count = result.Count();
           // Console.WriteLine($"Low Priority:{result.Priority}");
        }
*/

        public String ToString()
        {
            return null; //for now
        }
    }//bug/defect end
}
