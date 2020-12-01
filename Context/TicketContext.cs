using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TicketingClients.Model;

namespace TicketingClients.Context
{
    public class TicketContext : DbContext
    {
        DbSet<Ticket> Ticket { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  //forzo il config builder ad andare a cercare il file in esecuzione del programma
                .AddJsonFile("appsetings.json")
                .Build();
            string connString = config.GetConnectionString("TicketDb");
           // config.GetSection("ConnectionString")["TicketDb"]; alternativa
            optionsBuilder.UseSqlServer("connString");
        }
        protected TicketContext()
        {
        }
    }
}
