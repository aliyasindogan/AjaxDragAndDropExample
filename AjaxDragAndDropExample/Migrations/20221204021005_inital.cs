using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AjaxDragAndDropExample.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Mustafa DOĞAN" },
                    { 2, "Ali DOĞAN" },
                    { 3, "Abdullah DOĞAN" },
                    { 4, "Rıza DOĞAN" },
                    { 5, "Salih DOĞAN" },
                    { 6, "Emre DOĞAN" },
                    { 7, "Bulut DOĞAN" },
                    { 8, "Polat DOĞAN" },
                    { 9, "Memati DOĞAN" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "RoomTypeName" },
                values: new object[,]
                {
                    { 1, "Tekli Oda" },
                    { 2, "2'li Oda" },
                    { 3, "3'lü Oda" },
                    { 4, "4'lü Oda" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomName", "RoomTypeID" },
                values: new object[,]
                {
                    { 1, "101", 2 },
                    { 2, "102", 3 },
                    { 3, "103", 2 },
                    { 4, "104", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerRooms");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
