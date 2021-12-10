using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.DTO
{
    public class TicketMapper
    {
        public string Subject { get; set; }
        public string Details { get; set; }
        public int TicketTypeId { get; set; }
    }
}
