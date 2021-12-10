using SQLProvider.DatabaseContext;
using SQLProvider.Entities;
using SQLProvider.Enums;
using SQLProvider.Interfaces;
using SQLProvider.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLProvider.Repositories
{
    public class TicketRepository : ITicket
    {
        private readonly TaskContext _context;
        public TicketRepository(TaskContext context)
        {
            _context = context;
        }
        public async Task<Result> AddRequestAsync(Ticket ticket)
        {
            await _context.Tickets.AddAsync(ticket);
            bool saveChanges = SaveChamges();
            if (saveChanges)
                return new Result { StatusCode=(int)Status.Success, Message = "Ticket added succeflly" };
            else
                return new Result { StatusCode= (int)Status.Fail, Message = "Faild" };
        }
        public bool SaveChamges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
