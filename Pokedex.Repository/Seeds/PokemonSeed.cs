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
    internal class PokemonSeed : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasData(
                new Pokemon
                {
                    Id = 1,
                    Name = "Bulbasaur",
                    Type = "Grass",
                    Description = "A strange seed was planted on its back at birth. The plant sprouts and grows with this POKéMON.",
                    TrainerId = 1,
                    RegisteredDate = DateTime.Now
                },
                new Pokemon
                {
                    Id = 2,
                    Name = "Ivysaur",
                    Type = "Grass",
                    Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.",
                    TrainerId=1,
                    RegisteredDate = DateTime.Now

                },
    new Pokemon
    {
        Id = 3,
        Name = "Venusaur",
        Type = "Grass",
        Description = "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.",
        TrainerId=1,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 4,
        Name = "Charmander",
        Type = "Fire",
        Description = "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.",
        TrainerId=1,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 5,
        Name = "Charmeleon",
        Type = "Fire",
        Description = "When it swings its burning tail, it elevates the temperature to unbearably high levels.",
        TrainerId=2,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 6,
        Name = "Charizard",
        Type = "Fire",
        Description = "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.",
        TrainerId=2,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 7,
        Name = "Squirtle",
        Type = "Water",
        Description = "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.",
        TrainerId=2,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 8,
        Name = "Wartortle",
        Type = "Water",
        Description = "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.",
        TrainerId=2,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 9,
        Name = "Blastoise",
        Type = "Water",
        Description = "A brutal POKéMON with pressurized water jets on its shell. They are used for high-speed tackles.",
        TrainerId =3,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 10,
        Name = "Caterpie",
        Type = "Bug",
        Description = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.",
        TrainerId =3,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 11,
        Name = "Metapod",
        Type = "Bug",
        Description = "This POKéMON is vulnerable to attack while its shell is soft, exposing its weak and tender body.",
        TrainerId =3,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 12,
        Name = "Butterfree",
        Type = "Bug",
        Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air.",
        TrainerId =3,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 13,
        Name = "Weedle",
        Type = "Bug",
        Description = "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.",
        TrainerId =4,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 14,
        Name = "Kakuna",
        Type = "Bug",
        Description = "Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.",
        TrainerId =4,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 15,
        Name = "Beedrill",
        Type = "Bug",
        Description = "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.",
        TrainerId =4,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 16,
        Name = "Pidgey",
        Type = "Flying",
        Description = "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.",
        TrainerId =4,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 17,
        Name = "Pidgeotto",
        Type = "Flying",
        Description = "Very protective of its sprawling territorial area, this POKéMON will fiercely peck at any intruder.",
        TrainerId =5,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 18,
        Name = "Pidgeot",
        Type = "Flying",
        Description = "This POKéMON flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.",
        TrainerId =5,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 19,
        Name = "Rattata",
        Type = "Normal",
        Description = "Bites anything when it attacks. Small and very quick, it is a common sight in many places.",
        TrainerId =5,
        RegisteredDate = DateTime.Now
    },
    new Pokemon
    {
        Id = 20,
        Name = "Raticate",
        Type = "Normal",
        Description = "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.",
        TrainerId =5,
        RegisteredDate = DateTime.Now
    }

           );
        }
    }
}
