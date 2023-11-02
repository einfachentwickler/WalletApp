using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 31, 19, 30, 31, 559, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.InsertData(
                table: "ct_users",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "User 1" });

            migrationBuilder.CreateIndex(
                name: "IX_ct_transactions_UserId",
                table: "ct_transactions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ct_transactions_ct_users_UserId",
                table: "ct_transactions",
                column: "UserId",
                principalTable: "ct_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ct_transactions_ct_users_UserId",
                table: "ct_transactions");

            migrationBuilder.DropIndex(
                name: "IX_ct_transactions_UserId",
                table: "ct_transactions");

            migrationBuilder.DeleteData(
                table: "ct_users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 31, 19, 10, 51, 229, DateTimeKind.Utc).AddTicks(7611));
        }
    }
}
