﻿using CarRentalManagment.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagment.Server.Configuration.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "3 Series",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    Updatedby = "System"
                },
                new Model
                {
                        Id = 2,
                        Name = "X5",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        Updatedby = "System"
                },
                   new Model
                   {
                       Id = 3,
                       Name = "Prius",
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       CreatedBy = "System",
                       Updatedby = "System"
                   },
                       new Model
                       {
                           Id = 4,
                           Name = "RAV4",
                           DateCreated = DateTime.Now,
                           DateUpdated = DateTime.Now,
                           CreatedBy = "System",
                           Updatedby = "System"
                       }
);
        }
    }
}
