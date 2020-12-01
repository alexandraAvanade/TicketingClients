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
           // config.GetSection("ConnectionString")["TicketDb"]; alternativa
            optionsBuilder.UseSqlServer("connString");
        }
        protected TicketContext()
        {
        }
    }
}
