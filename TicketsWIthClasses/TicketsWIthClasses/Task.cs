using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TicketsWIthClasses
{
    class Task : ITicket
    {
        public string ProjectName { get; set; }
        

        public string DueDate { get; set; }
        public int TicketID { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public string Watching { get; set; }

        public void WriteFile()
        {
            var file = "BugDefect.txt";
        }

        public void ReadFile()
        {
            /*string file = "tickets.csv";
            string line;
            StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                var items = line.Split(',');
                BugDefect bugTicket = new BugDefect();
                for (int i = 0; i < BugList.Count; i++)
                {
                    BugList.Add(bugTicket);
                }
            }
            sr.Close();*/
        }
        /*public List<BugDefect> BugList { get; set; }
        public void Search()
        { 
            //  search
            var searchString = "low";
            var result = BugList.Where(b => b.Priority.Contains(searchString));
        }*/
        public String ToString()
        {
            return null; //for now
        }
    }//iticket
}
