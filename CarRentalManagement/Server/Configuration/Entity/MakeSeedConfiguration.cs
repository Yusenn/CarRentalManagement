using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configuration.Entity
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(

                new Make
                {
                    id = 1,
                    Name = "BWM",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreateBy = "System",
                    UpdateBy = "System"
                },

                new Make
                {
                    id = 2,
                    Name = "Toyota",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreateBy = "System",
                    UpdateBy = "System"
                }
                
            
           );

        }
    }
}
