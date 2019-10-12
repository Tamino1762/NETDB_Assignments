using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TicketsWIthClasses
{
    public interface ITicket 
    {
        int TicketID { get; set; }
        string Status { get; set; }
        string Priority { get; set; }
        string Submitter { get; set; }
        string Assigned { get; set; }
        string Watching { get; set; }
        void WriteFile();
        void ReadFile();
    }
}
