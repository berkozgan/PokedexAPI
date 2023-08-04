using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pokemons_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Name", "RegisteredDate", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ash Ketchum", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2719), null },
                    { 2, "Misty", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2722), null },
                    { 3, "Brock", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2724), null },
                    { 4, "Gary Oak", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2725), null },
                    { 5, "Red", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2726), null }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Description", "Name", "RegisteredDate", "TrainerId", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "A strange seed was planted on its back at birth. The plant sprouts and grows with this POKéMON.", "Bulbasaur", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2367), 1, "Grass", null },
                    { 2, "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs.", "Ivysaur", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2379), 1, "Grass", null },
                    { 3, "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight.", "Venusaur", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2381), 1, "Grass", null },
                    { 4, "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail.", "Charmander", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2382), 1, "Fire", null },
                    { 5, "When it swings its burning tail, it elevates the temperature to unbearably high levels.", "Charmeleon", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2384), 2, "Fire", null },
                    { 6, "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally.", "Charizard", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2386), 2, "Fire", null },
                    { 7, "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth.", "Squirtle", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2387), 2, "Water", null },
                    { 8, "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance.", "Wartortle", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2389), 2, "Water", null },
                    { 9, "A brutal POKéMON with pressurized water jets on its shell. They are used for high-speed tackles.", "Blastoise", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2390), 3, "Water", null },
                    { 10, "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls.", "Caterpie", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2392), 3, "Bug", null },
                    { 11, "This POKéMON is vulnerable to attack while its shell is soft, exposing its weak and tender body.", "Metapod", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2393), 3, "Bug", null },
                    { 12, "In battle, it flaps its wings at great speed to release highly toxic dust into the air.", "Butterfree", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2395), 3, "Bug", null },
                    { 13, "Often found in forests, eating leaves. It has a sharp venomous stinger on its head.", "Weedle", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2396), 4, "Bug", null },
                    { 14, "Almost incapable of moving, this POKéMON can only harden its shell to protect itself from predators.", "Kakuna", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2398), 4, "Bug", null },
                    { 15, "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail.", "Beedrill", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2399), 4, "Bug", null },
                    { 16, "A common sight in forests and woods. It flaps its wings at ground level to kick up blinding sand.", "Pidgey", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2400), 4, "Flying", null },
                    { 17, "Very protective of its sprawling territorial area, this POKéMON will fiercely peck at any intruder.", "Pidgeotto", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2402), 5, "Flying", null },
                    { 18, "This POKéMON flies at Mach 2 speed, seeking prey. Its large talons are feared as wicked weapons.", "Pidgeot", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2403), 5, "Flying", null },
                    { 19, "Bites anything when it attacks. Small and very quick, it is a common sight in many places.", "Rattata", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2404), 5, "Normal", null },
                    { 20, "Its hind feet are webbed. They act as flippers, so it can swim in rivers and hunt for prey.", "Raticate", new DateTime(2023, 8, 1, 14, 3, 56, 358, DateTimeKind.Local).AddTicks(2406), 5, "Normal", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TrainerId",
                table: "Pokemons",
                column: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
