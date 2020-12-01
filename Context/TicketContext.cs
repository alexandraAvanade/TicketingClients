using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TicketingClients.Model;
using TicketingClients.Model.Configuration;
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
            modelBuilder.ApplyConfiguration<Ticket>(new TicketConfig());
            modelBuilder.ApplyConfiguration<Note>(new NoteConfig());
        }
       
    }
}
