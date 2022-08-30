using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionTime",
                table: "RemainingTransactions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "aut", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "eius", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "ipsa", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 345.03636019303673, 15m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6417), 9.8589646757488207 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 725.57673256897465, 32m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6480), 6.3880405985366568 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 289.04669457533259, 14m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6489), 3.0308851721844454 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 617.59000086729463, 25m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7769), 7.1451265360034881 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 892.08277253755057, 29m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7826), 0.57624244099814037 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 71.316363453127536, 5m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7835), 7.3647142820276335 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Density", "TransactionTime", "Volume" },
                values: new object[] { 314.54952581083728, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8430), 0.64874006092619285 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 921.47745679263755, 25m, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8486), 6.3970933074926268 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 672.11698748635581, 21m, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8494), 8.3835532734381903 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "TransactionTime",
                value: new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "South Ignatius");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "West Glendaburgh");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Maximusfort");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 835, DateTimeKind.Utc).AddTicks(7064), "NP2XltWPHd0AAlgx0QfsYazalYwESl3gC2FfQoOthJU=", "VR71SoC0Y16NXd/JB28Yb2dDTZ48GXECWCff+rpFYf0=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 841, DateTimeKind.Utc).AddTicks(3064), "7Y0bBKo8uS7Z/ycW6G/U8cK5AmWcHssxQcjRSNC8jdM=", "ZjxbSyCpZX7ijBrLDH+/XvQMBHMHsJ3/VrWxxF5tpSs=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 846, DateTimeKind.Utc).AddTicks(8256), "iCAvDT1QA8FT0n0As9QnzTuO+7ilTIvmDdisVMQS/mg=", "2gv4eunkigV/WKC++mU261hY4NuYM1l7APXqm0DxUoM=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionTime",
                table: "RemainingTransactions");

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "illum", new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "earum", new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "hic", new DateTime(2022, 8, 29, 15, 12, 4, 122, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 203.76581116376369, 24m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4201), 2.8529461505992781 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 177.58433055769385, 19m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4263), 0.59478387491236462 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 942.02445390075172, 26m, new DateTime(2022, 8, 29, 15, 12, 4, 128, DateTimeKind.Utc).AddTicks(4272), 8.7698562379961391 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 884.59515306240723, 8m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9504), 1.7106051817490953 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 455.81095015875485, 20m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9608), 1.041288474118679 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 768.04733485540885, 10m, new DateTime(2022, 8, 29, 15, 12, 4, 129, DateTimeKind.Utc).AddTicks(9617), 6.8812724686393301 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Density", "TransactionTime", "Volume" },
                values: new object[] { 538.83911467476287, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3513), 1.2921261579447063 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 458.72929975343266, 29m, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3570), 2.9408921417415748 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Density", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 604.12799637190585, 19m, new DateTime(2022, 8, 29, 15, 12, 4, 131, DateTimeKind.Utc).AddTicks(3578), 8.6007063517956226 });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "New Claudebury");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Wintheiserborough");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Shadchester");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 29, 15, 12, 4, 101, DateTimeKind.Utc).AddTicks(7004), "qIzSBSQ0ystV+FnRwTX7c/d0AvFhBHfs6xu14UL3n7A=", "i/hcji3ce3iQ5gi3sDfS82JhblXWz3RTFty0jLJ2Eaw=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 29, 15, 12, 4, 107, DateTimeKind.Utc).AddTicks(1736), "ETsE5M7nNvhZ7sVpsbb2/he66vp6IuJGTHLPWlT5J6c=", "uCVBGBb4HbfXoHOmK3rfO3F2bHsG/grd8Q7zcJcbsRw=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 8, 29, 15, 12, 4, 112, DateTimeKind.Utc).AddTicks(5888), "ufe5CrZpygjeNHLRmteght9JPEAJJhZqq0g+QbgvqHY=", "ZLDh9m4nwPy4GKAKIERvJXclelYRJxUDA3mSiWfv35s=" });
        }
    }
}
