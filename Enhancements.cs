using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsWIthClasses
{
    class Enhancements : ITicket
    {
        public void TicketID()
        {
            Random ticketId = new Random(1 - 5000);
        }

        public void Summary()
        {
           Summary();
        }

        public void Status()
        {
            Status();
        }

        public void Priority()
        {
            Priority();
        }

        public void Submitter()
        {
            Submitter();
        }

        public void Assigned()
        {
            Assigned();
        }

        public void Watching()
        {
            Watching();
        }

        

        public void Software()
        {
            Software();
        }

        public void Cost()
        {
            Cost();
        }

        public void Reason()
        {
            Reason();
        }

        public void Estimate()
        {
            Estimate();
        }
        public String ToString()
        {
            return null; //for now
        }
        public void WriteFile()
        {
            throw new NotImplementedException();
        }

        public void ReadFile()
        {
            throw new NotImplementedException();
        }
    }
}
