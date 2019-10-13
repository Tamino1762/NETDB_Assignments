using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsWIthClasses
{
    class Enhancements : ITicket
    {
        

        

        public string Software { get; set; }

        public double Cost { get; set; }

        public string Reason { get; set; }

        public double Estimate { get; set; }

        public int TicketID { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public string Watching { get; set; }

        public void WriteFile()
        {
            throw new NotImplementedException();
        }

        public void ReadFile()
        {
            throw new NotImplementedException();
        }
        public String ToString()
        {
            return null; //for now
        }
    }
}
