using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsEmailConfirmed", "Password", "Salt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 29, 15, 12, 4, 101, DateTimeKind.Utc).AddTicks(7004), "1@gmail.com", false, "qIzSBSQ0ystV+FnRwTX7c/d0AvFhBHfs6xu14UL3n7A=", "i/hcji3ce3iQ5gi3sDfS82JhblXWz3RTFty0jLJ2Eaw=" },
                    { 2, new DateTime(2022, 8, 29, 15, 12, 4, 107, DateTimeKind.Utc).AddTicks(1736), "2@gmail.com", false, "ETsE5M7nNvhZ7sVpsbb2/he66vp6IuJGTHLPWlT5J6c=", "uCVBGBb4HbfXoHOmK3rfO3F2bHsG/grd8Q7zcJcbsRw=" },
                    { 3, new DateTime(2022, 8, 29, 15, 12, 4, 112, DateTimeKind.Utc).AddTicks(5888), "3@gmail.com", false, "ufe5CrZpygjeNHLRmteght9JPEAJJhZqq0g+QbgvqHY=", "ZLDh9m4nwPy4GKAKIERvJXclelYRJxUDA3mSiWfv35s=" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "New Claudebury", 1 },
                    { 2, "Wintheiserborough", 1 },
                    { 3, "Shadchester", 1 }
                });

            migrationBuilder.InsertData(
                table: "FuelTanks",
                columns: new[] { "Id", "Capacity", "CurrentAmount", "Name", "Number", "StationId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 10.0, 5.5, "illum", 1, 1, new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3477) },
                    { 2, 10.0, 6.5, "earum", 2, 1, new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3529) },
                    { 3, 10.0, 7.5, "hic", 3, 1, new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3540) }
                });

            migrationBuilder.InsertData(
                table: "LevelIndicatorTransactions",
                columns: new[] { "Id", "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[,]
                {
                    { 1, 203.76581116376369, 1, 9.8000000000000007, 24m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4201), 2.8529461505992781 },
                    { 2, 177.58433055769385, 1, 9.6999999999999993, 19m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4263), 0.59478387491236462 },
                    { 3, 942.02445390075172, 1, 9.5999999999999996, 26m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4272), 8.7698562379961391 },
                    { 4, 884.59515306240723, 2, 9.5, 8m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9504), 1.7106051817490953 },
                    { 5, 455.81095015875485, 2, 9.4000000000000004, 20m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9608), 1.041288474118679 },
                    { 6, 768.04733485540885, 2, 9.3000000000000007, 10m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9617), 6.8812724686393301 },
                    { 7, 538.83911467476287, 3, 9.1999999999999993, 28m, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3513), 1.2921261579447063 },
                    { 8, 458.72929975343266, 3, 9.0999999999999996, 29m, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3570), 2.9408921417415748 },
                    { 9, 604.12799637190585, 3, 9.0, 19m, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3578), 8.6007063517956226 }
                });

            migrationBuilder.InsertData(
                table: "RemainingTransactions",
                columns: new[] { "Id", "FuelTankId", "Value" },
                values: new object[,]
                {
                    { 1, 1, 9.8000000000000007 },
                    { 2, 1, 9.6999999999999993 },
                    { 3, 1, 9.5999999999999996 },
                    { 4, 2, 9.5 },
                    { 5, 2, 9.4000000000000004 },
                    { 6, 2, 9.3000000000000007 },
                    { 7, 3, 9.1999999999999993 },
                    { 8, 3, 9.0999999999999996 },
                    { 9, 3, 9.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
