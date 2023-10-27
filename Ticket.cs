using System;
using System.Collections.Generic;
using System.IO; 
 class Ticket
    {
        public string TicketID { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Submitter { get; set; }
        public string Assigned { get; set; }
        public string Watching { get; set; }

        public Ticket(string ticketID, string summary, string status, string priority, string submitter, string assigned, string watching)
        {
            TicketID = ticketID;
            Summary = summary;
            Status = status;
            Priority = priority;
            Submitter = submitter;
            Assigned = assigned;
            Watching = watching;
        }
    }
    class BugDefectTicket : Ticket
    {
        public string Severity { get; set; }

        public BugDefectTicket(string ticketID, string summary, string status, string priority, string submitter, string assigned, string watching, string severity)
            : base(ticketID, summary, status, priority, submitter, assigned, watching)
        {
            Severity = severity;
        }
    }

    class EnhancementTicket : Ticket
    {
        public string Software { get; set; }
        public double Cost { get; set; }
        public string Reason { get; set;}
        public double Estimate { get; set; }

        public EnhancementTicket(string ticketID, string summary, string status, string priority, string submitter, string assigned, string watching, string software, double cost, string reason, double estimate)
            : base(ticketID, summary, status, priority, submitter, assigned, watching)
        {
            Software = software;
            Cost = cost;
            Reason = reason;
            Estimate = estimate;
        }
    }

