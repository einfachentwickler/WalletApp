using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ct_transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<double>(type: "double precision", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "character varying(64000)", maxLength: 64000, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsPending = table.Column<bool>(type: "boolean", nullable: false),
                    IsAutorizedUser = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ct_transactions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ct_transactions",
                columns: new[] { "Id", "Amount", "Date", "Description", "IsAutorizedUser", "IsPending", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 12.130000000000001, new DateTime(2023, 10, 31, 18, 16, 11, 573, DateTimeKind.Utc).AddTicks(4225), "Some description", true, true, "Transaction 1", 0 },
                    { 2, 12.130000000000001, new DateTime(2002, 12, 12, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 2", true, false, "Transaction 2", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ct_transactions");
        }
    }
}
