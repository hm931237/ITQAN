using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.Configurations
{
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(I => I.Id).IsRequired();
            builder.Property(P => P.Subject).IsRequired();
            builder.Property(I => I.TicketTypeId).IsRequired();
        }
    }
}
