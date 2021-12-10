using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SQLProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLProvider.Configurations
{
    public class TicketTypeConfig : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.Property(I => I.Id).IsRequired();
            builder.Property(P => P.Name).IsRequired();
        }
    }
}
