﻿using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configuration.Entity
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    id = 1,
                    Name = "Black",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreateBy = "System",
                    UpdateBy = "System"

                },
                new Colour
                {
                    id = 2,
                    Name = "Blue",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreateBy = "System",
                    UpdateBy = "System"

                }

                );
        }
    }
}
