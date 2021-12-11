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
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;
using SQLProvider.Enums;

namespace ITQAN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicket _ticketRepo;
        private readonly IMail _mail;
        private readonly IMapper _mapper;
        public TicketController(ITicket ticketRepo, IMapper mapper,IMail mail)
        {
            _ticketRepo = ticketRepo;
            _mapper = mapper;
            _mail = mail;
        }
        [HttpPost]
        public async Task<Result> AddTicketAsync(TicketMapper ticketDTO)
        {
            //SendEmail();
            Ticket ticket = _mapper.Map<Ticket>(ticketDTO);
            Result result =await _ticketRepo.AddRequestAsync(ticket);
            if (result.StatusCode == (int)Status.Success)
            {
                result = _mail.Send();
            }
            return result;
        }
    }
}