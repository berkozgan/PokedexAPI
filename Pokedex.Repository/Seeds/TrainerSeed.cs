using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Repository.Seeds
{
    internal class TrainerSeed : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasData(
                new Trainer
                {
                    Id = 1,
                    Name= "Ash Ketchum",
                    RegisteredDate = DateTime.Now
                },
                new Trainer
                {
                    Id = 2,
                    Name = "Misty",
                    RegisteredDate = DateTime.Now
                },
                new Trainer
                {
                    Id = 3,
                    Name = "Brock",
                    RegisteredDate = DateTime.Now
                },
                new Trainer
                {
                    Id = 4,
                    Name = "Gary Oak",
                    RegisteredDate = DateTime.Now
                },
                new Trainer
                {
                    Id = 5,
                    Name = "Red",
                    RegisteredDate = DateTime.Now
                }


                );
        }
    }
}
