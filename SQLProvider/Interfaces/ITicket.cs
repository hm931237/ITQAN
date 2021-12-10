using SQLProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLProvider.Results;

namespace SQLProvider.Interfaces
{
    public interface ITicket
    {
       Task<Result> AddRequestAsync(Ticket ticket);
    }
}
