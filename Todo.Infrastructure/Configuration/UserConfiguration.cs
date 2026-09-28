using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.Infrastructure.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.Property(x => x.Email).IsRequired().HasMaxLength(255);

            builder.Property(x => x.FullName).IsRequired().HasMaxLength(255);
        } 
    }
}
