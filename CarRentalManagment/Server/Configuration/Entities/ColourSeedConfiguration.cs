﻿using CarRentalManagment.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagment.Server.Configuration.Entities
{
    public class ColourSeedConfiguration : IEntityTypeConfiguration<Colour>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                 new Colour
                     {
                         Id = 1,
                         Name = "Black",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         Updatedby = "System"
                     },
                     new Colour
                     {
                         Id = 2,
                         Name = "Blue",
                         DateCreated = DateTime.Now,
                         DateUpdated = DateTime.Now,
                         CreatedBy = "System",
                         Updatedby = "System"
                     }
);


        }
    }
}
