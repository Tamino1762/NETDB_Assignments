using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsWIthClasses
{
    public interface ITicket 
    {
        void TicketID();
        void Summary();
        void Status();
        void Priority();
        void Submitter();
        void Assigned();
        void Watching();
        void WriteFile();
        void ReadFile();
    }
}
