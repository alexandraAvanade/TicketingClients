using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingClients.Model.Configuration
{
    public class NoteConfig : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder
                .HasKey(n => n.Id);

            builder
                .Property(n => n.Comments)
                .HasMaxLength(10000)
                .IsRequired();

        }
    }
}
