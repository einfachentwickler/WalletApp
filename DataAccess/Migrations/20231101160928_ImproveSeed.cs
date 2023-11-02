using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ImproveSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Description" },
                values: new object[] { new DateTime(2023, 11, 1, 16, 9, 27, 988, DateTimeKind.Utc).AddTicks(22), "Some description 1" });

            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "IsAutorizedUser" },
                values: new object[] { 12.15, false });

            migrationBuilder.InsertData(
                table: "ct_transactions",
                columns: new[] { "Id", "Amount", "Date", "Description", "IsAutorizedUser", "IsPending", "Name", "Type", "UserId" },
                values: new object[,]
                {
                    { 3, 1256.0, new DateTime(2002, 12, 12, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 3", false, false, "Transaction 3", 1, 1 },
                    { 4, 1256.0, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 4", false, false, "Transaction 4", 0, 1 },
                    { 5, 456.0, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 5", false, false, "Transaction 5", 0, 1 },
                    { 6, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 6", false, false, "Transaction 6", 0, 1 },
                    { 7, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 7", false, false, "Transaction 7", 0, 1 },
                    { 8, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 8", false, false, "Transaction 8", 0, 1 },
                    { 9, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 8", false, false, "Transaction 9", 0, 1 },
                    { 10, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 10", false, false, "Transaction 10", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "ct_users",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "User 2" });

            migrationBuilder.InsertData(
                table: "ct_transactions",
                columns: new[] { "Id", "Amount", "Date", "Description", "IsAutorizedUser", "IsPending", "Name", "Type", "UserId" },
                values: new object[,]
                {
                    { 11, 12.130000000000001, new DateTime(2023, 11, 1, 16, 9, 27, 988, DateTimeKind.Utc).AddTicks(172), "Some description 1", true, true, "Transaction 1", 0, 2 },
                    { 12, 12.15, new DateTime(2002, 12, 12, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 2", false, false, "Transaction 2", 1, 2 },
                    { 13, 1256.0, new DateTime(2002, 12, 12, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 3", false, false, "Transaction 3", 1, 2 },
                    { 14, 1256.0, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 4", false, false, "Transaction 4", 0, 2 },
                    { 15, 456.0, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 5", false, false, "Transaction 5", 0, 2 },
                    { 16, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 6", false, false, "Transaction 6", 0, 2 },
                    { 17, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 7", false, false, "Transaction 7", 0, 2 },
                    { 18, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 8", false, false, "Transaction 8", 0, 2 },
                    { 19, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 8", false, false, "Transaction 9", 0, 2 },
                    { 20, 189.91999999999999, new DateTime(2023, 11, 2, 12, 12, 12, 0, DateTimeKind.Unspecified), "Some description 10", false, false, "Transaction 10", 0, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ct_users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Description" },
                values: new object[] { new DateTime(2023, 10, 31, 19, 30, 31, 559, DateTimeKind.Utc).AddTicks(5215), "Some description" });

            migrationBuilder.UpdateData(
                table: "ct_transactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "IsAutorizedUser" },
                values: new object[] { 12.130000000000001, true });
        }
    }
}
