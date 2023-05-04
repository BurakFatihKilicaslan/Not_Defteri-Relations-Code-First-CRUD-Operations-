using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Configurations
{
    internal class NoteCFG : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.Property(a=>a.Title).HasMaxLength(100);
            builder.Property(a=>a.Content).HasMaxLength(1000);
        }
    }
}
