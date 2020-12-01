using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingClients.Model.Configuration
{
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
           
           // var ticketBilder = modelBuilder.Entity<Ticket>();

           builder
                 .HasKey(t => t.Id); //non e necessario se si rispettano le convenzione

            builder
                .Property(t => t.Title)
                .HasMaxLength(100)
                .IsRequired();

          builder
                .Property(t => t.Description)
                .HasMaxLength(500);

            builder
                .Property(t => t.Category)
                .IsRequired();

            builder
                .Property(t => t.Requestor)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(t => t.Notes)
                .WithOne(n => n.Ticket)
                .HasForeignKey(n => n.TicketId)
                .HasConstraintName("FK_Ricket_Note")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
