using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Details { get; set; }
        public TicketType TicketType { get; set; }
        public int TicketTypeId { get; set; }
    }
}
