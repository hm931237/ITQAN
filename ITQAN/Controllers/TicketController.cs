using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLProvider.DTO;
using SQLProvider.Entities;
using SQLProvider.Interfaces;
using SQLProvider.Results;

namespace ITQAN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicket _ticketRepo;
        private readonly IMapper _mapper;
        public TicketController(ITicket ticketRepo, IMapper mapper)
        {
            _ticketRepo = ticketRepo;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<Result> AddTicketAsync(TicketMapper ticketDTO)
        {
            Ticket ticket = _mapper.Map<Ticket>(ticketDTO);
            Result result =await _ticketRepo.AddRequestAsync(ticket);
            return result;
        }
    }
}