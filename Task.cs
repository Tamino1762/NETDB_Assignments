using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsWIthClasses
{
    class Task : ITicket
    {
        public void TicketID()
        {
            Random ticketId = new Random(1-5000);
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

        public void ProjectName()
        {
            ProjectName();
        }

        public void DueDate()
        {
            DueDate();
        }
        public String ToString()
        {
            return null; //for now
        }
        public void WriteFile()
        {
            var file = "BugDefect.txt";
        }

        public void ReadFile()
        {
            var file = "BugDefect.txt";
        }
    }
}
