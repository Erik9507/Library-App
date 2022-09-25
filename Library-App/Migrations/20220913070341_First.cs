using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_App.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Examples = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 25, nullable: false),
                    EMail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanId);
                    table.ForeignKey(
                        name: "FK_Loans_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Description", "Examples", "Title" },
                values: new object[,]
                {
                    { 1, "JK Rowling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 5, "Harry Potter 1" },
                    { 2, "JK Rowling", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 6, "Harry Potter 2" },
                    { 3, "JRR Tolkien", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 4, "The fellowship of the ring" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "EMail", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "ErikNorell@gmail.com", "Erik", "Norell" },
                    { 2, "ViktorGunnarsson@gmail.com", "Viktor", "Gunnarsson" },
                    { 3, "LukasRose@gmail.com", "Lukas", "Rose" }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 1, 1, 1, new DateTime(2022, 9, 13, 9, 3, 41, 112, DateTimeKind.Local).AddTicks(379), new DateTime(2022, 10, 13, 9, 3, 41, 115, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 2, 1, 2, new DateTime(2022, 9, 13, 9, 3, 41, 115, DateTimeKind.Local).AddTicks(4224), new DateTime(2022, 10, 13, 9, 3, 41, 115, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoanId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[] { 3, 2, 3, new DateTime(2022, 9, 13, 9, 3, 41, 115, DateTimeKind.Local).AddTicks(4296), new DateTime(2022, 10, 13, 9, 3, 41, 115, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CustomerId",
                table: "Loans",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
