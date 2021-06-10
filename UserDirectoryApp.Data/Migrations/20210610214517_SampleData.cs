using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserDirectoryApp.Data.Migrations
{
    public partial class SampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Location", "Name", "Surname" },
                values: new object[,]
                {
                    { new Guid("fc066eb7-5bf7-d32d-dc32-1282260ffe25"), new DateTime(2020, 8, 29, 1, 28, 13, 37, DateTimeKind.Local).AddTicks(8163), "Vicente_Wintheiser31@yahoo.com", "West Albertburgh", "Vicente", "Wintheiser" },
                    { new Guid("d8256cd7-8125-1c78-2f9c-64e83199fef0"), new DateTime(2020, 9, 7, 13, 26, 51, 366, DateTimeKind.Local).AddTicks(890), "Benedict_Hudson@hotmail.com", "East Camden", "Benedict", "Hudson" },
                    { new Guid("47e466ed-2615-ad41-8156-66b659ec00ae"), new DateTime(2020, 12, 10, 15, 23, 50, 17, DateTimeKind.Local).AddTicks(9410), "Mina41@hotmail.com", "Bodeport", "Mina", "Hoeger" },
                    { new Guid("f2b94b92-660e-99b9-3c38-1b93d4197523"), new DateTime(2020, 11, 15, 14, 56, 5, 242, DateTimeKind.Local).AddTicks(6398), "Jewell.Gusikowski86@hotmail.com", "Juddburgh", "Jewell", "Gusikowski" },
                    { new Guid("6a8c29a1-694b-c949-82da-88ba73efad1c"), new DateTime(2020, 7, 3, 12, 44, 56, 22, DateTimeKind.Local).AddTicks(6044), "Helen.Pagac@gmail.com", "Port Teresa", "Helen", "Pagac" },
                    { new Guid("4403b9f1-a425-48b8-36c5-900dd2ecb149"), new DateTime(2021, 5, 19, 14, 49, 1, 172, DateTimeKind.Local).AddTicks(3413), "Ahmed88@yahoo.com", "Lebsackstad", "Ahmed", "Langworth" },
                    { new Guid("8f1bf250-ebb8-af15-745a-af46855d36cf"), new DateTime(2021, 2, 8, 3, 36, 49, 428, DateTimeKind.Local).AddTicks(7174), "Michaela13@yahoo.com", "East Lorenzoborough", "Michaela", "Donnelly" },
                    { new Guid("7541791f-65b4-2618-d5b1-9db97dda7a5e"), new DateTime(2021, 1, 19, 11, 53, 44, 426, DateTimeKind.Local).AddTicks(3488), "Donato_Dickinson@hotmail.com", "Amyaville", "Donato", "Dickinson" },
                    { new Guid("0ecd2bff-2a06-bee8-a4cc-9b6dffa64a2d"), new DateTime(2021, 5, 10, 21, 35, 1, 520, DateTimeKind.Local).AddTicks(1635), "Luella_Ruecker@yahoo.com", "Donnystad", "Luella", "Ruecker" },
                    { new Guid("cd3035ed-e68e-7516-65b4-394b18cf86b5"), new DateTime(2020, 12, 13, 22, 26, 41, 359, DateTimeKind.Local).AddTicks(7663), "Judah25@gmail.com", "Millstown", "Judah", "Lang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
