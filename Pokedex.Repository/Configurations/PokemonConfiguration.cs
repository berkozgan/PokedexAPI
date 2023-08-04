using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Repository.Configurations
{
    internal class PokemonConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Type).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(1000);
            
         
           // builder.Property(x=>x.Id).ValueGeneratedOnAdd();



            builder.ToTable("Pokemons");


            builder.HasOne(x=>x.Trainer).WithMany(x=>x.Pokemons).HasForeignKey(x=>x.TrainerId);
            

           
        }
    }
}
