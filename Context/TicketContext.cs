using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TicketingClients.Model;
using TicketingHelpers;

namespace TicketingClients.Context
{
    public class TicketContext : DbContext
    {
        DbSet<Ticket> Ticket { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            string connString = Config.GetConnectionString("TicketDb");
            optionsBuilder.UseSqlServer(connString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ticketBilder = modelBuilder.Entity<Ticket>();

            ticketBilder
                 .HasKey(t => t.Id); //non e necessario se si rispettano le convenzione

            ticketBilder
                .Property(t => t.Title)
                .HasMaxLength(100)
                .IsRequired();

            ticketBilder
                .Property(t => t.Description)
                .HasMaxLength(500);

            ticketBilder
                .Property(t => t.Category)
                .IsRequired();

            ticketBilder
                .Property(t => t.Requestor)
                .HasMaxLength(50)
                .IsRequired();
        }
       
    }
}
