using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class UpdateSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 9.3300000000000001, "sunt", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 9.3200000000000003, "vel", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 9.3100000000000005, "rerum", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 396.65958222741403, 9.9800000000000004, 12m, new DateTime(2022, 9, 10, 14, 51, 21, 170, DateTimeKind.Utc).AddTicks(9119), 6.9800000000000004 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 440.90813046573652, 9.9700000000000006, 25m, new DateTime(2022, 9, 10, 14, 50, 21, 170, DateTimeKind.Utc).AddTicks(9176), 6.9699999999999998 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 833.54116836059825, 9.9600000000000009, 3m, new DateTime(2022, 9, 10, 14, 49, 21, 170, DateTimeKind.Utc).AddTicks(9185), 6.96 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 769.00047985526794, 1, 9.9499999999999993, 20m, new DateTime(2022, 9, 10, 14, 48, 21, 170, DateTimeKind.Utc).AddTicks(9192), 6.9500000000000002 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 238.87834390045415, 1, 9.9399999999999995, 20m, new DateTime(2022, 9, 10, 14, 47, 21, 170, DateTimeKind.Utc).AddTicks(9197), 6.9400000000000004 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 148.71939231724195, 1, 9.9299999999999997, 8m, new DateTime(2022, 9, 10, 14, 46, 21, 170, DateTimeKind.Utc).AddTicks(9203), 6.9299999999999997 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 999.90955935576631, 1, 9.9199999999999999, 31m, new DateTime(2022, 9, 10, 14, 45, 21, 170, DateTimeKind.Utc).AddTicks(9209), 6.9199999999999999 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 795.2613207320577, 1, 9.9100000000000001, 16m, new DateTime(2022, 9, 10, 14, 44, 21, 170, DateTimeKind.Utc).AddTicks(9214), 6.9100000000000001 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 737.58461485871874, 1, 9.9000000000000004, 37m, new DateTime(2022, 9, 10, 14, 43, 21, 170, DateTimeKind.Utc).AddTicks(9219), 6.9000000000000004 });

            migrationBuilder.InsertData(
                table: "LevelIndicatorTransactions",
                columns: new[] { "Id", "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[,]
                {
                    { 10, 89.186114237091658, 1, 9.8900000000000006, 20m, new DateTime(2022, 9, 10, 14, 42, 21, 170, DateTimeKind.Utc).AddTicks(9224), 6.8899999999999997 },
                    { 11, 282.89071333201832, 1, 9.8800000000000008, 2m, new DateTime(2022, 9, 10, 14, 41, 21, 170, DateTimeKind.Utc).AddTicks(9230), 6.8799999999999999 },
                    { 12, 367.52767377049622, 1, 9.8699999999999992, 33m, new DateTime(2022, 9, 10, 14, 40, 21, 170, DateTimeKind.Utc).AddTicks(9235), 6.8700000000000001 },
                    { 13, 357.59304657454396, 1, 9.8599999999999994, 27m, new DateTime(2022, 9, 10, 14, 39, 21, 170, DateTimeKind.Utc).AddTicks(9240), 6.8600000000000003 },
                    { 14, 149.92150483153222, 1, 9.8499999999999996, 24m, new DateTime(2022, 9, 10, 14, 38, 21, 170, DateTimeKind.Utc).AddTicks(9246), 6.8499999999999996 },
                    { 15, 847.69706280402079, 1, 9.8399999999999999, 37m, new DateTime(2022, 9, 10, 14, 37, 21, 170, DateTimeKind.Utc).AddTicks(9251), 6.8399999999999999 },
                    { 16, 111.46599970320426, 1, 9.8300000000000001, 12m, new DateTime(2022, 9, 10, 14, 36, 21, 170, DateTimeKind.Utc).AddTicks(9256), 6.8300000000000001 },
                    { 17, 992.4364621225119, 1, 9.8200000000000003, 9m, new DateTime(2022, 9, 10, 14, 35, 21, 170, DateTimeKind.Utc).AddTicks(9261), 6.8200000000000003 },
                    { 18, 957.59600364252856, 1, 9.8100000000000005, 33m, new DateTime(2022, 9, 10, 14, 34, 21, 170, DateTimeKind.Utc).AddTicks(9266), 6.8099999999999996 },
                    { 19, 129.04084713336206, 1, 9.8000000000000007, 10m, new DateTime(2022, 9, 10, 14, 33, 21, 170, DateTimeKind.Utc).AddTicks(9271), 6.7999999999999998 },
                    { 20, 298.63325822575962, 1, 9.7899999999999991, 14m, new DateTime(2022, 9, 10, 14, 32, 21, 170, DateTimeKind.Utc).AddTicks(9280), 6.79 },
                    { 21, 862.38328260216053, 1, 9.7799999999999994, 16m, new DateTime(2022, 9, 10, 14, 31, 21, 170, DateTimeKind.Utc).AddTicks(9287), 6.7800000000000002 },
                    { 22, 146.24300253614965, 1, 9.7699999999999996, 1m, new DateTime(2022, 9, 10, 14, 30, 21, 170, DateTimeKind.Utc).AddTicks(9292), 6.7699999999999996 },
                    { 23, 834.95229142076312, 1, 9.7599999999999998, 35m, new DateTime(2022, 9, 10, 14, 29, 21, 170, DateTimeKind.Utc).AddTicks(9297), 6.7599999999999998 },
                    { 24, 526.34269299873552, 1, 9.75, 10m, new DateTime(2022, 9, 10, 14, 28, 21, 170, DateTimeKind.Utc).AddTicks(9302), 6.75 },
                    { 25, 650.31759039335009, 1, 9.7400000000000002, 34m, new DateTime(2022, 9, 10, 14, 27, 21, 170, DateTimeKind.Utc).AddTicks(9308), 6.7400000000000002 },
                    { 26, 386.91294119160312, 1, 9.7300000000000004, 26m, new DateTime(2022, 9, 10, 14, 26, 21, 170, DateTimeKind.Utc).AddTicks(9313), 6.7300000000000004 },
                    { 27, 79.016989871412036, 1, 9.7200000000000006, 31m, new DateTime(2022, 9, 10, 14, 25, 21, 170, DateTimeKind.Utc).AddTicks(9319), 6.7199999999999998 },
                    { 28, 519.40183451185283, 1, 9.7100000000000009, 30m, new DateTime(2022, 9, 10, 14, 24, 21, 170, DateTimeKind.Utc).AddTicks(9324), 6.71 },
                    { 29, 449.23905904357696, 1, 9.6999999999999993, 6m, new DateTime(2022, 9, 10, 14, 23, 21, 170, DateTimeKind.Utc).AddTicks(9329), 6.7000000000000002 },
                    { 30, 986.0905978811453, 1, 9.6899999999999995, 32m, new DateTime(2022, 9, 10, 14, 22, 21, 170, DateTimeKind.Utc).AddTicks(9335), 6.6900000000000004 },
                    { 31, 79.30974032023552, 1, 9.6799999999999997, 30m, new DateTime(2022, 9, 10, 14, 21, 21, 170, DateTimeKind.Utc).AddTicks(9340), 6.6799999999999997 },
                    { 32, 824.66165938353731, 1, 9.6699999999999999, 15m, new DateTime(2022, 9, 10, 14, 20, 21, 170, DateTimeKind.Utc).AddTicks(9346), 6.6699999999999999 },
                    { 33, 331.78077953447729, 1, 9.6600000000000001, 1m, new DateTime(2022, 9, 10, 14, 19, 21, 170, DateTimeKind.Utc).AddTicks(9351), 6.6600000000000001 },
                    { 34, 319.55529459340215, 1, 9.6500000000000004, 39m, new DateTime(2022, 9, 10, 14, 18, 21, 170, DateTimeKind.Utc).AddTicks(9356), 6.6500000000000004 },
                    { 35, 4.7155146783863788, 1, 9.6400000000000006, 16m, new DateTime(2022, 9, 10, 14, 17, 21, 170, DateTimeKind.Utc).AddTicks(9361), 6.6399999999999997 },
                    { 36, 708.80435495536153, 1, 9.6300000000000008, 7m, new DateTime(2022, 9, 10, 14, 16, 21, 170, DateTimeKind.Utc).AddTicks(9366), 6.6299999999999999 },
                    { 37, 79.805969645274416, 1, 9.6199999999999992, 5m, new DateTime(2022, 9, 10, 14, 15, 21, 170, DateTimeKind.Utc).AddTicks(9371), 6.6200000000000001 },
                    { 38, 905.04495752054322, 1, 9.6099999999999994, 9m, new DateTime(2022, 9, 10, 14, 14, 21, 170, DateTimeKind.Utc).AddTicks(9376), 6.6100000000000003 },
                    { 39, 548.45265923217812, 1, 9.5999999999999996, 5m, new DateTime(2022, 9, 10, 14, 13, 21, 170, DateTimeKind.Utc).AddTicks(9381), 6.5999999999999996 },
                    { 40, 157.0851325092888, 1, 9.5899999999999999, 31m, new DateTime(2022, 9, 10, 14, 12, 21, 170, DateTimeKind.Utc).AddTicks(9387), 6.5899999999999999 },
                    { 41, 868.73813255793152, 1, 9.5800000000000001, 19m, new DateTime(2022, 9, 10, 14, 11, 21, 170, DateTimeKind.Utc).AddTicks(9392), 6.5800000000000001 },
                    { 42, 457.26118817005914, 1, 9.5700000000000003, 40m, new DateTime(2022, 9, 10, 14, 10, 21, 170, DateTimeKind.Utc).AddTicks(9397), 6.5700000000000003 },
                    { 43, 92.149334194461701, 1, 9.5600000000000005, 32m, new DateTime(2022, 9, 10, 14, 9, 21, 170, DateTimeKind.Utc).AddTicks(9402), 6.5599999999999996 },
                    { 44, 720.36721420198307, 1, 9.5500000000000007, 16m, new DateTime(2022, 9, 10, 14, 8, 21, 170, DateTimeKind.Utc).AddTicks(9407), 6.5499999999999998 },
                    { 45, 946.86971676924691, 1, 9.5399999999999991, 7m, new DateTime(2022, 9, 10, 14, 7, 21, 170, DateTimeKind.Utc).AddTicks(9412), 6.54 },
                    { 46, 172.82523298003895, 1, 9.5299999999999994, 5m, new DateTime(2022, 9, 10, 14, 6, 21, 170, DateTimeKind.Utc).AddTicks(9417), 6.5300000000000002 },
                    { 47, 980.40732211351929, 1, 9.5199999999999996, 12m, new DateTime(2022, 9, 10, 14, 5, 21, 170, DateTimeKind.Utc).AddTicks(9423), 6.5199999999999996 },
                    { 48, 704.58750360926297, 1, 9.5099999999999998, 2m, new DateTime(2022, 9, 10, 14, 4, 21, 170, DateTimeKind.Utc).AddTicks(9428), 6.5099999999999998 },
                    { 49, 949.43276015873107, 1, 9.5, 21m, new DateTime(2022, 9, 10, 14, 3, 21, 170, DateTimeKind.Utc).AddTicks(9433), 6.5 },
                    { 50, 710.88254245402095, 1, 9.4900000000000002, 5m, new DateTime(2022, 9, 10, 14, 2, 21, 170, DateTimeKind.Utc).AddTicks(9438), 6.4900000000000002 },
                    { 51, 125.16242527814525, 1, 9.4800000000000004, 17m, new DateTime(2022, 9, 10, 14, 1, 21, 170, DateTimeKind.Utc).AddTicks(9443), 6.4800000000000004 },
                    { 52, 485.55629560021987, 1, 9.4700000000000006, 1m, new DateTime(2022, 9, 10, 14, 0, 21, 170, DateTimeKind.Utc).AddTicks(9448), 6.4699999999999998 },
                    { 53, 330.29741719885709, 1, 9.4600000000000009, 11m, new DateTime(2022, 9, 10, 13, 59, 21, 170, DateTimeKind.Utc).AddTicks(9457), 6.46 },
                    { 54, 735.7444571246433, 1, 9.4499999999999993, 40m, new DateTime(2022, 9, 10, 13, 58, 21, 170, DateTimeKind.Utc).AddTicks(9463), 6.4500000000000002 },
                    { 55, 334.72515938791338, 1, 9.4399999999999995, 30m, new DateTime(2022, 9, 10, 13, 57, 21, 170, DateTimeKind.Utc).AddTicks(9468), 6.4399999999999995 },
                    { 56, 423.22877513999026, 1, 9.4299999999999997, 2m, new DateTime(2022, 9, 10, 13, 56, 21, 170, DateTimeKind.Utc).AddTicks(9474), 6.4299999999999997 },
                    { 57, 112.37175669453103, 1, 9.4199999999999999, 6m, new DateTime(2022, 9, 10, 13, 55, 21, 170, DateTimeKind.Utc).AddTicks(9479), 6.4199999999999999 },
                    { 58, 859.31165320561354, 1, 9.4100000000000001, 3m, new DateTime(2022, 9, 10, 13, 54, 21, 170, DateTimeKind.Utc).AddTicks(9484), 6.4100000000000001 },
                    { 59, 331.18057632390509, 1, 9.4000000000000004, 5m, new DateTime(2022, 9, 10, 13, 53, 21, 170, DateTimeKind.Utc).AddTicks(9489), 6.4000000000000004 },
                    { 60, 590.47603399975571, 1, 9.3900000000000006, 29m, new DateTime(2022, 9, 10, 13, 52, 21, 170, DateTimeKind.Utc).AddTicks(9495), 6.3899999999999997 },
                    { 61, 171.41659151344047, 1, 9.3800000000000008, 24m, new DateTime(2022, 9, 10, 13, 51, 21, 170, DateTimeKind.Utc).AddTicks(9500), 6.3799999999999999 },
                    { 62, 797.27459087502029, 1, 9.3699999999999992, 25m, new DateTime(2022, 9, 10, 13, 50, 21, 170, DateTimeKind.Utc).AddTicks(9505), 6.3700000000000001 },
                    { 63, 536.67223994203948, 1, 9.3599999999999994, 12m, new DateTime(2022, 9, 10, 13, 49, 21, 170, DateTimeKind.Utc).AddTicks(9510), 6.3600000000000003 },
                    { 64, 716.94666893181113, 1, 9.3499999999999996, 0m, new DateTime(2022, 9, 10, 13, 48, 21, 170, DateTimeKind.Utc).AddTicks(9515), 6.3499999999999996 },
                    { 65, 881.94129344685439, 1, 9.3399999999999999, 30m, new DateTime(2022, 9, 10, 13, 47, 21, 170, DateTimeKind.Utc).AddTicks(9520), 6.3399999999999999 },
                    { 66, 154.04293476103558, 1, 9.3300000000000001, 28m, new DateTime(2022, 9, 10, 13, 46, 21, 170, DateTimeKind.Utc).AddTicks(9525), 6.3300000000000001 },
                    { 67, 686.69675400233461, 1, 9.3200000000000003, 29m, new DateTime(2022, 9, 10, 13, 45, 21, 170, DateTimeKind.Utc).AddTicks(9530), 6.3200000000000003 },
                    { 68, 687.95109742702755, 1, 9.3100000000000005, 12m, new DateTime(2022, 9, 10, 13, 44, 21, 170, DateTimeKind.Utc).AddTicks(9535), 6.3099999999999996 },
                    { 69, 168.47617503953671, 1, 9.3000000000000007, 34m, new DateTime(2022, 9, 10, 13, 43, 21, 170, DateTimeKind.Utc).AddTicks(9541), 6.2999999999999998 },
                    { 70, 614.18442907534234, 1, 9.2899999999999991, 3m, new DateTime(2022, 9, 10, 13, 42, 21, 170, DateTimeKind.Utc).AddTicks(9546), 6.29 },
                    { 71, 478.35853863734934, 1, 9.2799999999999994, 39m, new DateTime(2022, 9, 10, 13, 41, 21, 170, DateTimeKind.Utc).AddTicks(9551), 6.2800000000000002 },
                    { 72, 104.22572969446919, 1, 9.2699999999999996, 34m, new DateTime(2022, 9, 10, 13, 40, 21, 170, DateTimeKind.Utc).AddTicks(9556), 6.2699999999999996 },
                    { 73, 768.09638329495544, 1, 9.2599999999999998, 4m, new DateTime(2022, 9, 10, 13, 39, 21, 170, DateTimeKind.Utc).AddTicks(9561), 6.2599999999999998 },
                    { 74, 555.99110114994005, 1, 9.25, 25m, new DateTime(2022, 9, 10, 13, 38, 21, 170, DateTimeKind.Utc).AddTicks(9566), 6.25 },
                    { 75, 823.49482636380594, 1, 9.2400000000000002, 15m, new DateTime(2022, 9, 10, 13, 37, 21, 170, DateTimeKind.Utc).AddTicks(9571), 6.2400000000000002 },
                    { 76, 72.359183040417108, 1, 9.2300000000000004, 8m, new DateTime(2022, 9, 10, 13, 36, 21, 170, DateTimeKind.Utc).AddTicks(9576), 6.2300000000000004 },
                    { 77, 911.30922588594751, 1, 9.2200000000000006, 15m, new DateTime(2022, 9, 10, 13, 35, 21, 170, DateTimeKind.Utc).AddTicks(9581), 6.2199999999999998 },
                    { 78, 391.20972109333371, 1, 9.2100000000000009, 35m, new DateTime(2022, 9, 10, 13, 34, 21, 170, DateTimeKind.Utc).AddTicks(9586), 6.21 },
                    { 79, 705.40118343424888, 1, 9.1999999999999993, 34m, new DateTime(2022, 9, 10, 13, 33, 21, 170, DateTimeKind.Utc).AddTicks(9591), 6.2000000000000002 },
                    { 80, 313.67860862921339, 1, 9.1899999999999995, 39m, new DateTime(2022, 9, 10, 13, 32, 21, 170, DateTimeKind.Utc).AddTicks(9596), 6.1899999999999995 },
                    { 81, 134.89646228094065, 1, 9.1799999999999997, 12m, new DateTime(2022, 9, 10, 13, 31, 21, 170, DateTimeKind.Utc).AddTicks(9602), 6.1799999999999997 },
                    { 82, 744.36575477948406, 1, 9.1699999999999999, 0m, new DateTime(2022, 9, 10, 13, 30, 21, 170, DateTimeKind.Utc).AddTicks(9607), 6.1699999999999999 },
                    { 83, 690.84530256670644, 1, 9.1600000000000001, 15m, new DateTime(2022, 9, 10, 13, 29, 21, 170, DateTimeKind.Utc).AddTicks(9612), 6.1600000000000001 },
                    { 84, 887.81134498723202, 1, 9.1500000000000004, 19m, new DateTime(2022, 9, 10, 13, 28, 21, 170, DateTimeKind.Utc).AddTicks(9617), 6.1500000000000004 },
                    { 85, 142.43908597276956, 1, 9.1400000000000006, 20m, new DateTime(2022, 9, 10, 13, 27, 21, 170, DateTimeKind.Utc).AddTicks(9623), 6.1399999999999997 },
                    { 86, 906.01319452285543, 1, 9.1300000000000008, 22m, new DateTime(2022, 9, 10, 13, 26, 21, 170, DateTimeKind.Utc).AddTicks(9632), 6.1299999999999999 },
                    { 87, 930.99356695432039, 1, 9.1199999999999992, 11m, new DateTime(2022, 9, 10, 13, 25, 21, 170, DateTimeKind.Utc).AddTicks(9638), 6.1200000000000001 },
                    { 88, 733.94748560546532, 1, 9.1099999999999994, 29m, new DateTime(2022, 9, 10, 13, 24, 21, 170, DateTimeKind.Utc).AddTicks(9643), 6.1100000000000003 },
                    { 89, 86.455755983890995, 1, 9.0999999999999996, 40m, new DateTime(2022, 9, 10, 13, 23, 21, 170, DateTimeKind.Utc).AddTicks(9648), 6.0999999999999996 },
                    { 90, 249.10449674714553, 1, 9.0899999999999999, 2m, new DateTime(2022, 9, 10, 13, 22, 21, 170, DateTimeKind.Utc).AddTicks(9653), 6.0899999999999999 },
                    { 91, 837.67520040334603, 1, 9.0800000000000001, 33m, new DateTime(2022, 9, 10, 13, 21, 21, 170, DateTimeKind.Utc).AddTicks(9658), 6.0800000000000001 },
                    { 92, 886.01660520494909, 1, 9.0700000000000003, 2m, new DateTime(2022, 9, 10, 13, 20, 21, 170, DateTimeKind.Utc).AddTicks(9664), 6.0700000000000003 },
                    { 93, 981.34672387327203, 1, 9.0600000000000005, 5m, new DateTime(2022, 9, 10, 13, 19, 21, 170, DateTimeKind.Utc).AddTicks(9669), 6.0599999999999996 },
                    { 94, 566.10325181185999, 1, 9.0500000000000007, 38m, new DateTime(2022, 9, 10, 13, 18, 21, 170, DateTimeKind.Utc).AddTicks(9674), 6.0499999999999998 },
                    { 95, 996.77957049476163, 1, 9.0399999999999991, 17m, new DateTime(2022, 9, 10, 13, 17, 21, 170, DateTimeKind.Utc).AddTicks(9679), 6.04 },
                    { 96, 576.17426291549737, 1, 9.0299999999999994, 0m, new DateTime(2022, 9, 10, 13, 16, 21, 170, DateTimeKind.Utc).AddTicks(9684), 6.0300000000000002 },
                    { 97, 392.40868800101703, 1, 9.0199999999999996, 17m, new DateTime(2022, 9, 10, 13, 15, 21, 170, DateTimeKind.Utc).AddTicks(9689), 6.0199999999999996 },
                    { 98, 207.55742270487698, 1, 9.0099999999999998, 5m, new DateTime(2022, 9, 10, 13, 14, 21, 170, DateTimeKind.Utc).AddTicks(9694), 6.0099999999999998 },
                    { 99, 91.77294264494374, 1, 9.0, 11m, new DateTime(2022, 9, 10, 13, 13, 21, 170, DateTimeKind.Utc).AddTicks(9699), 6.0 },
                    { 100, 786.16532551983198, 1, 8.9900000000000002, 40m, new DateTime(2022, 9, 10, 13, 12, 21, 170, DateTimeKind.Utc).AddTicks(9705), 5.9900000000000002 },
                    { 101, 662.71814043754853, 2, 8.9800000000000004, 0m, new DateTime(2022, 9, 10, 13, 11, 21, 172, DateTimeKind.Utc).AddTicks(852), 5.9800000000000004 },
                    { 102, 383.42285363666639, 2, 8.9700000000000006, 39m, new DateTime(2022, 9, 10, 13, 10, 21, 172, DateTimeKind.Utc).AddTicks(909), 5.9699999999999998 },
                    { 103, 99.464239666798846, 2, 8.9600000000000009, 40m, new DateTime(2022, 9, 10, 13, 9, 21, 172, DateTimeKind.Utc).AddTicks(918), 5.96 },
                    { 104, 876.0353164684243, 2, 8.9499999999999993, 16m, new DateTime(2022, 9, 10, 13, 8, 21, 172, DateTimeKind.Utc).AddTicks(924), 5.9500000000000002 },
                    { 105, 8.1411140169755924, 2, 8.9399999999999995, 0m, new DateTime(2022, 9, 10, 13, 7, 21, 172, DateTimeKind.Utc).AddTicks(931), 5.9399999999999995 },
                    { 106, 253.91762988949353, 2, 8.9299999999999997, 3m, new DateTime(2022, 9, 10, 13, 6, 21, 172, DateTimeKind.Utc).AddTicks(936), 5.9299999999999997 },
                    { 107, 353.05267349140769, 2, 8.9199999999999999, 29m, new DateTime(2022, 9, 10, 13, 5, 21, 172, DateTimeKind.Utc).AddTicks(942), 5.9199999999999999 },
                    { 108, 232.2124316002141, 2, 8.9100000000000001, 28m, new DateTime(2022, 9, 10, 13, 4, 21, 172, DateTimeKind.Utc).AddTicks(947), 5.9100000000000001 },
                    { 109, 144.66547790686411, 2, 8.9000000000000004, 7m, new DateTime(2022, 9, 10, 13, 3, 21, 172, DateTimeKind.Utc).AddTicks(953), 5.9000000000000004 },
                    { 110, 176.88573704731502, 2, 8.8900000000000006, 5m, new DateTime(2022, 9, 10, 13, 2, 21, 172, DateTimeKind.Utc).AddTicks(958), 5.8899999999999997 },
                    { 111, 10.653306899520153, 2, 8.879999999999999, 7m, new DateTime(2022, 9, 10, 13, 1, 21, 172, DateTimeKind.Utc).AddTicks(964), 5.8799999999999999 },
                    { 112, 886.32593783660195, 2, 8.8699999999999992, 3m, new DateTime(2022, 9, 10, 13, 0, 21, 172, DateTimeKind.Utc).AddTicks(969), 5.8700000000000001 },
                    { 113, 833.20190098791034, 2, 8.8599999999999994, 35m, new DateTime(2022, 9, 10, 12, 59, 21, 172, DateTimeKind.Utc).AddTicks(975), 5.8599999999999994 },
                    { 114, 898.92862738833594, 2, 8.8499999999999996, 29m, new DateTime(2022, 9, 10, 12, 58, 21, 172, DateTimeKind.Utc).AddTicks(980), 5.8499999999999996 },
                    { 115, 502.38769434467622, 2, 8.8399999999999999, 38m, new DateTime(2022, 9, 10, 12, 57, 21, 172, DateTimeKind.Utc).AddTicks(985), 5.8399999999999999 },
                    { 116, 998.23558337758152, 2, 8.8300000000000001, 11m, new DateTime(2022, 9, 10, 12, 56, 21, 172, DateTimeKind.Utc).AddTicks(991), 5.8300000000000001 },
                    { 117, 194.71689144050586, 2, 8.8200000000000003, 23m, new DateTime(2022, 9, 10, 12, 55, 21, 172, DateTimeKind.Utc).AddTicks(996), 5.8200000000000003 },
                    { 118, 489.64644114400704, 2, 8.8100000000000005, 36m, new DateTime(2022, 9, 10, 12, 54, 21, 172, DateTimeKind.Utc).AddTicks(1001), 5.8100000000000005 },
                    { 119, 349.7809914721206, 2, 8.8000000000000007, 6m, new DateTime(2022, 9, 10, 12, 53, 21, 172, DateTimeKind.Utc).AddTicks(1007), 5.7999999999999998 },
                    { 120, 924.53106993459892, 2, 8.7899999999999991, 40m, new DateTime(2022, 9, 10, 12, 52, 21, 172, DateTimeKind.Utc).AddTicks(1012), 5.79 },
                    { 121, 840.30861907324811, 2, 8.7799999999999994, 25m, new DateTime(2022, 9, 10, 12, 51, 21, 172, DateTimeKind.Utc).AddTicks(1017), 5.7800000000000002 },
                    { 122, 239.74645340284252, 2, 8.7699999999999996, 3m, new DateTime(2022, 9, 10, 12, 50, 21, 172, DateTimeKind.Utc).AddTicks(1022), 5.7699999999999996 },
                    { 123, 169.77582044625152, 2, 8.7599999999999998, 10m, new DateTime(2022, 9, 10, 12, 49, 21, 172, DateTimeKind.Utc).AddTicks(1028), 5.7599999999999998 },
                    { 124, 443.31330696425755, 2, 8.75, 29m, new DateTime(2022, 9, 10, 12, 48, 21, 172, DateTimeKind.Utc).AddTicks(1033), 5.75 },
                    { 125, 512.09723256420318, 2, 8.7400000000000002, 24m, new DateTime(2022, 9, 10, 12, 47, 21, 172, DateTimeKind.Utc).AddTicks(1038), 5.7400000000000002 },
                    { 126, 321.27438215788652, 2, 8.7300000000000004, 23m, new DateTime(2022, 9, 10, 12, 46, 21, 172, DateTimeKind.Utc).AddTicks(1078), 5.7300000000000004 },
                    { 127, 956.5002026707931, 2, 8.7200000000000006, 9m, new DateTime(2022, 9, 10, 12, 45, 21, 172, DateTimeKind.Utc).AddTicks(1085), 5.7199999999999998 },
                    { 128, 633.4134208238429, 2, 8.7100000000000009, 1m, new DateTime(2022, 9, 10, 12, 44, 21, 172, DateTimeKind.Utc).AddTicks(1090), 5.71 },
                    { 129, 793.49629455433501, 2, 8.6999999999999993, 34m, new DateTime(2022, 9, 10, 12, 43, 21, 172, DateTimeKind.Utc).AddTicks(1096), 5.7000000000000002 },
                    { 130, 288.28970653285677, 2, 8.6899999999999995, 1m, new DateTime(2022, 9, 10, 12, 42, 21, 172, DateTimeKind.Utc).AddTicks(1101), 5.6899999999999995 },
                    { 131, 513.31738395020216, 2, 8.6799999999999997, 32m, new DateTime(2022, 9, 10, 12, 41, 21, 172, DateTimeKind.Utc).AddTicks(1106), 5.6799999999999997 },
                    { 132, 82.258932265989344, 2, 8.6699999999999999, 35m, new DateTime(2022, 9, 10, 12, 40, 21, 172, DateTimeKind.Utc).AddTicks(1112), 5.6699999999999999 },
                    { 133, 119.93579625002249, 2, 8.6600000000000001, 18m, new DateTime(2022, 9, 10, 12, 39, 21, 172, DateTimeKind.Utc).AddTicks(1117), 5.6600000000000001 },
                    { 134, 994.13348644613745, 2, 8.6500000000000004, 2m, new DateTime(2022, 9, 10, 12, 38, 21, 172, DateTimeKind.Utc).AddTicks(1123), 5.6500000000000004 },
                    { 135, 668.53540743808696, 2, 8.6400000000000006, 27m, new DateTime(2022, 9, 10, 12, 37, 21, 172, DateTimeKind.Utc).AddTicks(1128), 5.6399999999999997 },
                    { 136, 415.083202733429, 2, 8.629999999999999, 25m, new DateTime(2022, 9, 10, 12, 36, 21, 172, DateTimeKind.Utc).AddTicks(1133), 5.6299999999999999 },
                    { 137, 703.48864794318808, 2, 8.6199999999999992, 39m, new DateTime(2022, 9, 10, 12, 35, 21, 172, DateTimeKind.Utc).AddTicks(1139), 5.6200000000000001 },
                    { 138, 307.94465106209998, 2, 8.6099999999999994, 28m, new DateTime(2022, 9, 10, 12, 34, 21, 172, DateTimeKind.Utc).AddTicks(1144), 5.6099999999999994 },
                    { 139, 926.82977753849218, 2, 8.5999999999999996, 26m, new DateTime(2022, 9, 10, 12, 33, 21, 172, DateTimeKind.Utc).AddTicks(1149), 5.5999999999999996 },
                    { 140, 787.11021003093651, 2, 8.5899999999999999, 2m, new DateTime(2022, 9, 10, 12, 32, 21, 172, DateTimeKind.Utc).AddTicks(1154), 5.5899999999999999 },
                    { 141, 673.6379224466059, 2, 8.5800000000000001, 22m, new DateTime(2022, 9, 10, 12, 31, 21, 172, DateTimeKind.Utc).AddTicks(1160), 5.5800000000000001 },
                    { 142, 497.25315666163715, 2, 8.5700000000000003, 11m, new DateTime(2022, 9, 10, 12, 30, 21, 172, DateTimeKind.Utc).AddTicks(1166), 5.5700000000000003 },
                    { 143, 874.89703066044319, 2, 8.5600000000000005, 12m, new DateTime(2022, 9, 10, 12, 29, 21, 172, DateTimeKind.Utc).AddTicks(1171), 5.5600000000000005 },
                    { 144, 580.02090427896496, 2, 8.5500000000000007, 0m, new DateTime(2022, 9, 10, 12, 28, 21, 172, DateTimeKind.Utc).AddTicks(1176), 5.5499999999999998 },
                    { 145, 224.60013176466398, 2, 8.5399999999999991, 12m, new DateTime(2022, 9, 10, 12, 27, 21, 172, DateTimeKind.Utc).AddTicks(1181), 5.54 },
                    { 146, 362.57195401654695, 2, 8.5299999999999994, 20m, new DateTime(2022, 9, 10, 12, 26, 21, 172, DateTimeKind.Utc).AddTicks(1187), 5.5300000000000002 },
                    { 147, 83.960162216302095, 2, 8.5199999999999996, 40m, new DateTime(2022, 9, 10, 12, 25, 21, 172, DateTimeKind.Utc).AddTicks(1192), 5.5199999999999996 },
                    { 148, 768.34165978279975, 2, 8.5099999999999998, 6m, new DateTime(2022, 9, 10, 12, 24, 21, 172, DateTimeKind.Utc).AddTicks(1197), 5.5099999999999998 },
                    { 149, 429.22480742956373, 2, 8.5, 38m, new DateTime(2022, 9, 10, 12, 23, 21, 172, DateTimeKind.Utc).AddTicks(1203), 5.5 },
                    { 150, 878.51186983133869, 2, 8.4900000000000002, 15m, new DateTime(2022, 9, 10, 12, 22, 21, 172, DateTimeKind.Utc).AddTicks(1209), 5.4900000000000002 },
                    { 151, 473.22149670423318, 2, 8.4800000000000004, 38m, new DateTime(2022, 9, 10, 12, 21, 21, 172, DateTimeKind.Utc).AddTicks(1214), 5.4800000000000004 },
                    { 152, 581.21604475858874, 2, 8.4700000000000006, 27m, new DateTime(2022, 9, 10, 12, 20, 21, 172, DateTimeKind.Utc).AddTicks(1219), 5.4699999999999998 },
                    { 153, 426.2788617980259, 2, 8.4600000000000009, 35m, new DateTime(2022, 9, 10, 12, 19, 21, 172, DateTimeKind.Utc).AddTicks(1224), 5.46 },
                    { 154, 465.33095090542463, 2, 8.4499999999999993, 35m, new DateTime(2022, 9, 10, 12, 18, 21, 172, DateTimeKind.Utc).AddTicks(1230), 5.4500000000000002 },
                    { 155, 404.41406267247027, 2, 8.4399999999999995, 5m, new DateTime(2022, 9, 10, 12, 17, 21, 172, DateTimeKind.Utc).AddTicks(1235), 5.4399999999999995 },
                    { 156, 663.78790714756701, 2, 8.4299999999999997, 21m, new DateTime(2022, 9, 10, 12, 16, 21, 172, DateTimeKind.Utc).AddTicks(1241), 5.4299999999999997 },
                    { 157, 300.55622938118051, 2, 8.4199999999999999, 23m, new DateTime(2022, 9, 10, 12, 15, 21, 172, DateTimeKind.Utc).AddTicks(1246), 5.4199999999999999 },
                    { 158, 691.05194832518566, 2, 8.4100000000000001, 18m, new DateTime(2022, 9, 10, 12, 14, 21, 172, DateTimeKind.Utc).AddTicks(1252), 5.4100000000000001 },
                    { 159, 8.4742690892756212, 2, 8.4000000000000004, 28m, new DateTime(2022, 9, 10, 12, 13, 21, 172, DateTimeKind.Utc).AddTicks(1279), 5.4000000000000004 },
                    { 160, 642.09516271045754, 2, 8.3900000000000006, 26m, new DateTime(2022, 9, 10, 12, 12, 21, 172, DateTimeKind.Utc).AddTicks(1285), 5.3899999999999997 },
                    { 161, 752.03093602168008, 2, 8.379999999999999, 18m, new DateTime(2022, 9, 10, 12, 11, 21, 172, DateTimeKind.Utc).AddTicks(1290), 5.3799999999999999 },
                    { 162, 177.99164256673106, 2, 8.3699999999999992, 13m, new DateTime(2022, 9, 10, 12, 10, 21, 172, DateTimeKind.Utc).AddTicks(1295), 5.3700000000000001 },
                    { 163, 965.27317514679021, 2, 8.3599999999999994, 19m, new DateTime(2022, 9, 10, 12, 9, 21, 172, DateTimeKind.Utc).AddTicks(1301), 5.3599999999999994 },
                    { 164, 810.59558529634262, 2, 8.3499999999999996, 8m, new DateTime(2022, 9, 10, 12, 8, 21, 172, DateTimeKind.Utc).AddTicks(1306), 5.3499999999999996 },
                    { 165, 207.24654897786755, 2, 8.3399999999999999, 31m, new DateTime(2022, 9, 10, 12, 7, 21, 172, DateTimeKind.Utc).AddTicks(1311), 5.3399999999999999 },
                    { 166, 970.21154124415193, 2, 8.3300000000000001, 8m, new DateTime(2022, 9, 10, 12, 6, 21, 172, DateTimeKind.Utc).AddTicks(1317), 5.3300000000000001 },
                    { 167, 560.94302564668556, 2, 8.3200000000000003, 29m, new DateTime(2022, 9, 10, 12, 5, 21, 172, DateTimeKind.Utc).AddTicks(1322), 5.3200000000000003 },
                    { 168, 641.36970305441241, 2, 8.3100000000000005, 3m, new DateTime(2022, 9, 10, 12, 4, 21, 172, DateTimeKind.Utc).AddTicks(1327), 5.3100000000000005 },
                    { 169, 833.05856617112318, 2, 8.3000000000000007, 1m, new DateTime(2022, 9, 10, 12, 3, 21, 172, DateTimeKind.Utc).AddTicks(1333), 5.2999999999999998 },
                    { 170, 574.80624178078324, 2, 8.2899999999999991, 4m, new DateTime(2022, 9, 10, 12, 2, 21, 172, DateTimeKind.Utc).AddTicks(1338), 5.29 },
                    { 171, 608.05944771284737, 2, 8.2799999999999994, 5m, new DateTime(2022, 9, 10, 12, 1, 21, 172, DateTimeKind.Utc).AddTicks(1343), 5.2800000000000002 },
                    { 172, 149.08980652916713, 2, 8.2699999999999996, 31m, new DateTime(2022, 9, 10, 12, 0, 21, 172, DateTimeKind.Utc).AddTicks(1349), 5.2699999999999996 },
                    { 173, 662.59907058812348, 2, 8.2599999999999998, 29m, new DateTime(2022, 9, 10, 11, 59, 21, 172, DateTimeKind.Utc).AddTicks(1354), 5.2599999999999998 },
                    { 174, 436.97147922073367, 2, 8.25, 7m, new DateTime(2022, 9, 10, 11, 58, 21, 172, DateTimeKind.Utc).AddTicks(1359), 5.25 },
                    { 175, 807.85466372512883, 2, 8.2400000000000002, 3m, new DateTime(2022, 9, 10, 11, 57, 21, 172, DateTimeKind.Utc).AddTicks(1365), 5.2400000000000002 },
                    { 176, 228.81334003310226, 2, 8.2300000000000004, 38m, new DateTime(2022, 9, 10, 11, 56, 21, 172, DateTimeKind.Utc).AddTicks(1370), 5.2300000000000004 },
                    { 177, 613.17934775671074, 2, 8.2200000000000006, 16m, new DateTime(2022, 9, 10, 11, 55, 21, 172, DateTimeKind.Utc).AddTicks(1375), 5.2199999999999998 },
                    { 178, 958.81622542676587, 2, 8.2100000000000009, 27m, new DateTime(2022, 9, 10, 11, 54, 21, 172, DateTimeKind.Utc).AddTicks(1381), 5.21 },
                    { 179, 326.97331055241062, 2, 8.1999999999999993, 37m, new DateTime(2022, 9, 10, 11, 53, 21, 172, DateTimeKind.Utc).AddTicks(1386), 5.2000000000000002 },
                    { 180, 208.62537827614759, 2, 8.1899999999999995, 27m, new DateTime(2022, 9, 10, 11, 52, 21, 172, DateTimeKind.Utc).AddTicks(1391), 5.1899999999999995 },
                    { 181, 929.80650166564453, 2, 8.1799999999999997, 19m, new DateTime(2022, 9, 10, 11, 51, 21, 172, DateTimeKind.Utc).AddTicks(1397), 5.1799999999999997 },
                    { 182, 248.18829662793684, 2, 8.1699999999999999, 6m, new DateTime(2022, 9, 10, 11, 50, 21, 172, DateTimeKind.Utc).AddTicks(1402), 5.1699999999999999 },
                    { 183, 340.63001110334091, 2, 8.1600000000000001, 11m, new DateTime(2022, 9, 10, 11, 49, 21, 172, DateTimeKind.Utc).AddTicks(1407), 5.1600000000000001 },
                    { 184, 350.51667367045371, 2, 8.1500000000000004, 0m, new DateTime(2022, 9, 10, 11, 48, 21, 172, DateTimeKind.Utc).AddTicks(1412), 5.1500000000000004 },
                    { 185, 392.88058745302123, 2, 8.1400000000000006, 38m, new DateTime(2022, 9, 10, 11, 47, 21, 172, DateTimeKind.Utc).AddTicks(1418), 5.1399999999999997 },
                    { 186, 385.30885425724068, 2, 8.129999999999999, 20m, new DateTime(2022, 9, 10, 11, 46, 21, 172, DateTimeKind.Utc).AddTicks(1423), 5.1299999999999999 },
                    { 187, 162.415116166171, 2, 8.1199999999999992, 22m, new DateTime(2022, 9, 10, 11, 45, 21, 172, DateTimeKind.Utc).AddTicks(1428), 5.1200000000000001 },
                    { 188, 529.0386733218337, 2, 8.1099999999999994, 29m, new DateTime(2022, 9, 10, 11, 44, 21, 172, DateTimeKind.Utc).AddTicks(1434), 5.1099999999999994 },
                    { 189, 435.30747288645199, 2, 8.0999999999999996, 8m, new DateTime(2022, 9, 10, 11, 43, 21, 172, DateTimeKind.Utc).AddTicks(1439), 5.0999999999999996 },
                    { 190, 864.64030921087556, 2, 8.0899999999999999, 33m, new DateTime(2022, 9, 10, 11, 42, 21, 172, DateTimeKind.Utc).AddTicks(1444), 5.0899999999999999 },
                    { 191, 3.1589005785817026, 2, 8.0800000000000001, 5m, new DateTime(2022, 9, 10, 11, 41, 21, 172, DateTimeKind.Utc).AddTicks(1450), 5.0800000000000001 },
                    { 192, 423.13609843239874, 2, 8.0700000000000003, 30m, new DateTime(2022, 9, 10, 11, 40, 21, 172, DateTimeKind.Utc).AddTicks(1474), 5.0700000000000003 },
                    { 193, 584.36703032324272, 2, 8.0600000000000005, 10m, new DateTime(2022, 9, 10, 11, 39, 21, 172, DateTimeKind.Utc).AddTicks(1479), 5.0600000000000005 },
                    { 194, 93.872607705967511, 2, 8.0500000000000007, 24m, new DateTime(2022, 9, 10, 11, 38, 21, 172, DateTimeKind.Utc).AddTicks(1485), 5.0499999999999998 },
                    { 195, 649.58443031521676, 2, 8.0399999999999991, 24m, new DateTime(2022, 9, 10, 11, 37, 21, 172, DateTimeKind.Utc).AddTicks(1490), 5.04 },
                    { 196, 533.6709182981898, 2, 8.0299999999999994, 7m, new DateTime(2022, 9, 10, 11, 36, 21, 172, DateTimeKind.Utc).AddTicks(1495), 5.0300000000000002 },
                    { 197, 452.74153541501238, 2, 8.0199999999999996, 21m, new DateTime(2022, 9, 10, 11, 35, 21, 172, DateTimeKind.Utc).AddTicks(1501), 5.0199999999999996 },
                    { 198, 436.64159906758437, 2, 8.0099999999999998, 20m, new DateTime(2022, 9, 10, 11, 34, 21, 172, DateTimeKind.Utc).AddTicks(1506), 5.0099999999999998 },
                    { 199, 173.00840315066714, 2, 8.0, 30m, new DateTime(2022, 9, 10, 11, 33, 21, 172, DateTimeKind.Utc).AddTicks(1511), 5.0 },
                    { 200, 583.3091273854526, 2, 7.9900000000000002, 5m, new DateTime(2022, 9, 10, 11, 32, 21, 172, DateTimeKind.Utc).AddTicks(1517), 4.9900000000000002 },
                    { 201, 305.07243586246977, 3, 7.9800000000000004, 32m, new DateTime(2022, 9, 10, 11, 31, 21, 173, DateTimeKind.Utc).AddTicks(1640), 4.9800000000000004 },
                    { 202, 811.78579575523759, 3, 7.9699999999999998, 34m, new DateTime(2022, 9, 10, 11, 30, 21, 173, DateTimeKind.Utc).AddTicks(1695), 4.9699999999999998 },
                    { 203, 382.79294739991309, 3, 7.96, 21m, new DateTime(2022, 9, 10, 11, 29, 21, 173, DateTimeKind.Utc).AddTicks(1704), 4.96 },
                    { 204, 607.96018174473011, 3, 7.9500000000000002, 3m, new DateTime(2022, 9, 10, 11, 28, 21, 173, DateTimeKind.Utc).AddTicks(1710), 4.9500000000000002 },
                    { 205, 541.34330729144858, 3, 7.9399999999999995, 0m, new DateTime(2022, 9, 10, 11, 27, 21, 173, DateTimeKind.Utc).AddTicks(1716), 4.9399999999999995 },
                    { 206, 735.68120594661639, 3, 7.9299999999999997, 34m, new DateTime(2022, 9, 10, 11, 26, 21, 173, DateTimeKind.Utc).AddTicks(1721), 4.9299999999999997 },
                    { 207, 503.85426856054926, 3, 7.9199999999999999, 2m, new DateTime(2022, 9, 10, 11, 25, 21, 173, DateTimeKind.Utc).AddTicks(1727), 4.9199999999999999 },
                    { 208, 68.317690088738331, 3, 7.9100000000000001, 40m, new DateTime(2022, 9, 10, 11, 24, 21, 173, DateTimeKind.Utc).AddTicks(1732), 4.9100000000000001 },
                    { 209, 559.04317821458801, 3, 7.9000000000000004, 32m, new DateTime(2022, 9, 10, 11, 23, 21, 173, DateTimeKind.Utc).AddTicks(1737), 4.9000000000000004 },
                    { 210, 557.98246133551265, 3, 7.8900000000000006, 34m, new DateTime(2022, 9, 10, 11, 22, 21, 173, DateTimeKind.Utc).AddTicks(1742), 4.8900000000000006 },
                    { 211, 556.26745355543858, 3, 7.8799999999999999, 11m, new DateTime(2022, 9, 10, 11, 21, 21, 173, DateTimeKind.Utc).AddTicks(1748), 4.8799999999999999 },
                    { 212, 931.11683948810548, 3, 7.8700000000000001, 16m, new DateTime(2022, 9, 10, 11, 20, 21, 173, DateTimeKind.Utc).AddTicks(1753), 4.8700000000000001 },
                    { 213, 889.22316180585653, 3, 7.8599999999999994, 5m, new DateTime(2022, 9, 10, 11, 19, 21, 173, DateTimeKind.Utc).AddTicks(1758), 4.8599999999999994 },
                    { 214, 968.7943167178272, 3, 7.8499999999999996, 6m, new DateTime(2022, 9, 10, 11, 18, 21, 173, DateTimeKind.Utc).AddTicks(1768), 4.8499999999999996 },
                    { 215, 458.12910575306631, 3, 7.8399999999999999, 32m, new DateTime(2022, 9, 10, 11, 17, 21, 173, DateTimeKind.Utc).AddTicks(1774), 4.8399999999999999 },
                    { 216, 359.75785319917674, 3, 7.8300000000000001, 15m, new DateTime(2022, 9, 10, 11, 16, 21, 173, DateTimeKind.Utc).AddTicks(1779), 4.8300000000000001 },
                    { 217, 540.08936067338675, 3, 7.8200000000000003, 23m, new DateTime(2022, 9, 10, 11, 15, 21, 173, DateTimeKind.Utc).AddTicks(1784), 4.8200000000000003 },
                    { 218, 975.48730123435018, 3, 7.8100000000000005, 31m, new DateTime(2022, 9, 10, 11, 14, 21, 173, DateTimeKind.Utc).AddTicks(1790), 4.8100000000000005 },
                    { 219, 323.34840274303889, 3, 7.7999999999999998, 36m, new DateTime(2022, 9, 10, 11, 13, 21, 173, DateTimeKind.Utc).AddTicks(1795), 4.7999999999999998 },
                    { 220, 185.75447367123411, 3, 7.79, 29m, new DateTime(2022, 9, 10, 11, 12, 21, 173, DateTimeKind.Utc).AddTicks(1801), 4.79 },
                    { 221, 507.81824506561259, 3, 7.7799999999999994, 28m, new DateTime(2022, 9, 10, 11, 11, 21, 173, DateTimeKind.Utc).AddTicks(1806), 4.7799999999999994 },
                    { 222, 794.72895697297179, 3, 7.7699999999999996, 20m, new DateTime(2022, 9, 10, 11, 10, 21, 173, DateTimeKind.Utc).AddTicks(1812), 4.7699999999999996 },
                    { 223, 272.5693002897205, 3, 7.7599999999999998, 14m, new DateTime(2022, 9, 10, 11, 9, 21, 173, DateTimeKind.Utc).AddTicks(1817), 4.7599999999999998 },
                    { 224, 833.80183137387951, 3, 7.75, 22m, new DateTime(2022, 9, 10, 11, 8, 21, 173, DateTimeKind.Utc).AddTicks(1822), 4.75 },
                    { 225, 665.20433224907242, 3, 7.7400000000000002, 15m, new DateTime(2022, 9, 10, 11, 7, 21, 173, DateTimeKind.Utc).AddTicks(1828), 4.7400000000000002 },
                    { 226, 409.54793552060084, 3, 7.7300000000000004, 1m, new DateTime(2022, 9, 10, 11, 6, 21, 173, DateTimeKind.Utc).AddTicks(1833), 4.7300000000000004 },
                    { 227, 80.89548493374987, 3, 7.7199999999999998, 6m, new DateTime(2022, 9, 10, 11, 5, 21, 173, DateTimeKind.Utc).AddTicks(1838), 4.7199999999999998 },
                    { 228, 911.74231329750944, 3, 7.71, 14m, new DateTime(2022, 9, 10, 11, 4, 21, 173, DateTimeKind.Utc).AddTicks(1844), 4.71 },
                    { 229, 696.94464458147274, 3, 7.6999999999999993, 0m, new DateTime(2022, 9, 10, 11, 3, 21, 173, DateTimeKind.Utc).AddTicks(1849), 4.6999999999999993 },
                    { 230, 314.68667914273442, 3, 7.6899999999999995, 18m, new DateTime(2022, 9, 10, 11, 2, 21, 173, DateTimeKind.Utc).AddTicks(1855), 4.6899999999999995 },
                    { 231, 629.29113390550401, 3, 7.6799999999999997, 34m, new DateTime(2022, 9, 10, 11, 1, 21, 173, DateTimeKind.Utc).AddTicks(1860), 4.6799999999999997 },
                    { 232, 237.00269654118833, 3, 7.6699999999999999, 39m, new DateTime(2022, 9, 10, 11, 0, 21, 173, DateTimeKind.Utc).AddTicks(1866), 4.6699999999999999 },
                    { 233, 728.3994857444892, 3, 7.6600000000000001, 12m, new DateTime(2022, 9, 10, 10, 59, 21, 173, DateTimeKind.Utc).AddTicks(1872), 4.6600000000000001 },
                    { 234, 194.43476467433996, 3, 7.6500000000000004, 28m, new DateTime(2022, 9, 10, 10, 58, 21, 173, DateTimeKind.Utc).AddTicks(1877), 4.6500000000000004 },
                    { 235, 287.26307591169621, 3, 7.6400000000000006, 22m, new DateTime(2022, 9, 10, 10, 57, 21, 173, DateTimeKind.Utc).AddTicks(1882), 4.6400000000000006 },
                    { 236, 815.2679781556061, 3, 7.6299999999999999, 25m, new DateTime(2022, 9, 10, 10, 56, 21, 173, DateTimeKind.Utc).AddTicks(1888), 4.6299999999999999 },
                    { 237, 524.58779793908843, 3, 7.6200000000000001, 2m, new DateTime(2022, 9, 10, 10, 55, 21, 173, DateTimeKind.Utc).AddTicks(1893), 4.6200000000000001 },
                    { 238, 82.072430556996977, 3, 7.6099999999999994, 29m, new DateTime(2022, 9, 10, 10, 54, 21, 173, DateTimeKind.Utc).AddTicks(1899), 4.6099999999999994 },
                    { 239, 446.64194648650636, 3, 7.5999999999999996, 8m, new DateTime(2022, 9, 10, 10, 53, 21, 173, DateTimeKind.Utc).AddTicks(1904), 4.5999999999999996 },
                    { 240, 197.67438253279579, 3, 7.5899999999999999, 29m, new DateTime(2022, 9, 10, 10, 52, 21, 173, DateTimeKind.Utc).AddTicks(1910), 4.5899999999999999 },
                    { 241, 954.6753971432513, 3, 7.5800000000000001, 27m, new DateTime(2022, 9, 10, 10, 51, 21, 173, DateTimeKind.Utc).AddTicks(1915), 4.5800000000000001 },
                    { 242, 385.51868580701574, 3, 7.5700000000000003, 35m, new DateTime(2022, 9, 10, 10, 50, 21, 173, DateTimeKind.Utc).AddTicks(1920), 4.5700000000000003 },
                    { 243, 169.66211847786471, 3, 7.5600000000000005, 26m, new DateTime(2022, 9, 10, 10, 49, 21, 173, DateTimeKind.Utc).AddTicks(1926), 4.5600000000000005 },
                    { 244, 67.76828172223837, 3, 7.5499999999999998, 3m, new DateTime(2022, 9, 10, 10, 48, 21, 173, DateTimeKind.Utc).AddTicks(1931), 4.5499999999999998 },
                    { 245, 538.52060275176325, 3, 7.54, 8m, new DateTime(2022, 9, 10, 10, 47, 21, 173, DateTimeKind.Utc).AddTicks(1937), 4.54 },
                    { 246, 852.14245499139543, 3, 7.5299999999999994, 26m, new DateTime(2022, 9, 10, 10, 46, 21, 173, DateTimeKind.Utc).AddTicks(1946), 4.5299999999999994 },
                    { 247, 815.74558824487826, 3, 7.5199999999999996, 8m, new DateTime(2022, 9, 10, 10, 45, 21, 173, DateTimeKind.Utc).AddTicks(1952), 4.5199999999999996 },
                    { 248, 767.97967339164813, 3, 7.5099999999999998, 39m, new DateTime(2022, 9, 10, 10, 44, 21, 173, DateTimeKind.Utc).AddTicks(1958), 4.5099999999999998 },
                    { 249, 478.32111804560242, 3, 7.5, 19m, new DateTime(2022, 9, 10, 10, 43, 21, 173, DateTimeKind.Utc).AddTicks(1963), 4.5 },
                    { 250, 208.66554161783412, 3, 7.4900000000000002, 32m, new DateTime(2022, 9, 10, 10, 42, 21, 173, DateTimeKind.Utc).AddTicks(1969), 4.4900000000000002 },
                    { 251, 809.86479160191789, 3, 7.4800000000000004, 28m, new DateTime(2022, 9, 10, 10, 41, 21, 173, DateTimeKind.Utc).AddTicks(1974), 4.4800000000000004 },
                    { 252, 872.70510113869534, 3, 7.4699999999999998, 30m, new DateTime(2022, 9, 10, 10, 40, 21, 173, DateTimeKind.Utc).AddTicks(1980), 4.4699999999999998 },
                    { 253, 738.34450333844256, 3, 7.46, 22m, new DateTime(2022, 9, 10, 10, 39, 21, 173, DateTimeKind.Utc).AddTicks(1985), 4.46 },
                    { 254, 603.92672454210106, 3, 7.4499999999999993, 11m, new DateTime(2022, 9, 10, 10, 38, 21, 173, DateTimeKind.Utc).AddTicks(1990), 4.4499999999999993 },
                    { 255, 924.92070984685904, 3, 7.4399999999999995, 26m, new DateTime(2022, 9, 10, 10, 37, 21, 173, DateTimeKind.Utc).AddTicks(1996), 4.4399999999999995 },
                    { 256, 292.46595423576537, 3, 7.4299999999999997, 31m, new DateTime(2022, 9, 10, 10, 36, 21, 173, DateTimeKind.Utc).AddTicks(2001), 4.4299999999999997 },
                    { 257, 659.34427380864918, 3, 7.4199999999999999, 7m, new DateTime(2022, 9, 10, 10, 35, 21, 173, DateTimeKind.Utc).AddTicks(2007), 4.4199999999999999 },
                    { 258, 308.41780558227629, 3, 7.4100000000000001, 30m, new DateTime(2022, 9, 10, 10, 34, 21, 173, DateTimeKind.Utc).AddTicks(2012), 4.4100000000000001 },
                    { 259, 968.6266936452954, 3, 7.4000000000000004, 23m, new DateTime(2022, 9, 10, 10, 33, 21, 173, DateTimeKind.Utc).AddTicks(2018), 4.4000000000000004 },
                    { 260, 53.434211611123381, 3, 7.3900000000000006, 7m, new DateTime(2022, 9, 10, 10, 32, 21, 173, DateTimeKind.Utc).AddTicks(2023), 4.3900000000000006 },
                    { 261, 386.36793339778251, 3, 7.3799999999999999, 29m, new DateTime(2022, 9, 10, 10, 31, 21, 173, DateTimeKind.Utc).AddTicks(2029), 4.3799999999999999 },
                    { 262, 106.75832682339237, 3, 7.3700000000000001, 29m, new DateTime(2022, 9, 10, 10, 30, 21, 173, DateTimeKind.Utc).AddTicks(2034), 4.3700000000000001 },
                    { 263, 16.987232828552411, 3, 7.3599999999999994, 17m, new DateTime(2022, 9, 10, 10, 29, 21, 173, DateTimeKind.Utc).AddTicks(2039), 4.3599999999999994 },
                    { 264, 428.09828008864162, 3, 7.3499999999999996, 40m, new DateTime(2022, 9, 10, 10, 28, 21, 173, DateTimeKind.Utc).AddTicks(2045), 4.3499999999999996 },
                    { 265, 691.10631300217074, 3, 7.3399999999999999, 37m, new DateTime(2022, 9, 10, 10, 27, 21, 173, DateTimeKind.Utc).AddTicks(2050), 4.3399999999999999 },
                    { 266, 186.31979814067878, 3, 7.3300000000000001, 34m, new DateTime(2022, 9, 10, 10, 26, 21, 173, DateTimeKind.Utc).AddTicks(2056), 4.3300000000000001 },
                    { 267, 723.96217616980198, 3, 7.3200000000000003, 26m, new DateTime(2022, 9, 10, 10, 25, 21, 173, DateTimeKind.Utc).AddTicks(2061), 4.3200000000000003 },
                    { 268, 97.081515775100712, 3, 7.3100000000000005, 0m, new DateTime(2022, 9, 10, 10, 24, 21, 173, DateTimeKind.Utc).AddTicks(2066), 4.3100000000000005 },
                    { 269, 202.26704654037397, 3, 7.2999999999999998, 31m, new DateTime(2022, 9, 10, 10, 23, 21, 173, DateTimeKind.Utc).AddTicks(2072), 4.2999999999999998 },
                    { 270, 974.68874085204368, 3, 7.29, 23m, new DateTime(2022, 9, 10, 10, 22, 21, 173, DateTimeKind.Utc).AddTicks(2077), 4.29 },
                    { 271, 712.16260859642352, 3, 7.2799999999999994, 26m, new DateTime(2022, 9, 10, 10, 21, 21, 173, DateTimeKind.Utc).AddTicks(2083), 4.2799999999999994 },
                    { 272, 190.5773450331474, 3, 7.2699999999999996, 10m, new DateTime(2022, 9, 10, 10, 20, 21, 173, DateTimeKind.Utc).AddTicks(2088), 4.2699999999999996 },
                    { 273, 679.96015162788092, 3, 7.2599999999999998, 20m, new DateTime(2022, 9, 10, 10, 19, 21, 173, DateTimeKind.Utc).AddTicks(2093), 4.2599999999999998 },
                    { 274, 359.36422058235252, 3, 7.25, 29m, new DateTime(2022, 9, 10, 10, 18, 21, 173, DateTimeKind.Utc).AddTicks(2099), 4.25 },
                    { 275, 994.92184528844894, 3, 7.2400000000000002, 30m, new DateTime(2022, 9, 10, 10, 17, 21, 173, DateTimeKind.Utc).AddTicks(2104), 4.2400000000000002 },
                    { 276, 916.91956785214416, 3, 7.2300000000000004, 33m, new DateTime(2022, 9, 10, 10, 16, 21, 173, DateTimeKind.Utc).AddTicks(2110), 4.2300000000000004 },
                    { 277, 813.37777348210784, 3, 7.2199999999999998, 12m, new DateTime(2022, 9, 10, 10, 15, 21, 173, DateTimeKind.Utc).AddTicks(2115), 4.2199999999999998 },
                    { 278, 804.23339405187244, 3, 7.21, 19m, new DateTime(2022, 9, 10, 10, 14, 21, 173, DateTimeKind.Utc).AddTicks(2120), 4.21 },
                    { 279, 618.08936247960196, 3, 7.1999999999999993, 21m, new DateTime(2022, 9, 10, 10, 13, 21, 173, DateTimeKind.Utc).AddTicks(2131), 4.1999999999999993 },
                    { 280, 100.62995379879824, 3, 7.1899999999999995, 11m, new DateTime(2022, 9, 10, 10, 12, 21, 173, DateTimeKind.Utc).AddTicks(2136), 4.1899999999999995 },
                    { 281, 29.470566296898483, 3, 7.1799999999999997, 17m, new DateTime(2022, 9, 10, 10, 11, 21, 173, DateTimeKind.Utc).AddTicks(2142), 4.1799999999999997 },
                    { 282, 608.33438735945288, 3, 7.1699999999999999, 34m, new DateTime(2022, 9, 10, 10, 10, 21, 173, DateTimeKind.Utc).AddTicks(2147), 4.1699999999999999 },
                    { 283, 993.35462783876608, 3, 7.1600000000000001, 27m, new DateTime(2022, 9, 10, 10, 9, 21, 173, DateTimeKind.Utc).AddTicks(2153), 4.1600000000000001 },
                    { 284, 311.20608738649116, 3, 7.1500000000000004, 40m, new DateTime(2022, 9, 10, 10, 8, 21, 173, DateTimeKind.Utc).AddTicks(2159), 4.1500000000000004 },
                    { 285, 768.84725117663061, 3, 7.1400000000000006, 0m, new DateTime(2022, 9, 10, 10, 7, 21, 173, DateTimeKind.Utc).AddTicks(2164), 4.1400000000000006 },
                    { 286, 716.74473191289371, 3, 7.1299999999999999, 38m, new DateTime(2022, 9, 10, 10, 6, 21, 173, DateTimeKind.Utc).AddTicks(2169), 4.1299999999999999 },
                    { 287, 639.68682506418475, 3, 7.1200000000000001, 6m, new DateTime(2022, 9, 10, 10, 5, 21, 173, DateTimeKind.Utc).AddTicks(2175), 4.1200000000000001 },
                    { 288, 376.20297272123082, 3, 7.1099999999999994, 18m, new DateTime(2022, 9, 10, 10, 4, 21, 173, DateTimeKind.Utc).AddTicks(2180), 4.1099999999999994 },
                    { 289, 500.90378480975119, 3, 7.0999999999999996, 7m, new DateTime(2022, 9, 10, 10, 3, 21, 173, DateTimeKind.Utc).AddTicks(2185), 4.0999999999999996 },
                    { 290, 971.58085377811824, 3, 7.0899999999999999, 34m, new DateTime(2022, 9, 10, 10, 2, 21, 173, DateTimeKind.Utc).AddTicks(2191), 4.0899999999999999 },
                    { 291, 671.47670457574361, 3, 7.0800000000000001, 36m, new DateTime(2022, 9, 10, 10, 1, 21, 173, DateTimeKind.Utc).AddTicks(2196), 4.0800000000000001 },
                    { 292, 308.85832270301216, 3, 7.0700000000000003, 1m, new DateTime(2022, 9, 10, 10, 0, 21, 173, DateTimeKind.Utc).AddTicks(2202), 4.0700000000000003 },
                    { 293, 363.03964701120594, 3, 7.0600000000000005, 16m, new DateTime(2022, 9, 10, 9, 59, 21, 173, DateTimeKind.Utc).AddTicks(2207), 4.0600000000000005 },
                    { 294, 333.7085745985998, 3, 7.0499999999999998, 36m, new DateTime(2022, 9, 10, 9, 58, 21, 173, DateTimeKind.Utc).AddTicks(2213), 4.0499999999999998 },
                    { 295, 22.124920372337154, 3, 7.04, 12m, new DateTime(2022, 9, 10, 9, 57, 21, 173, DateTimeKind.Utc).AddTicks(2218), 4.04 },
                    { 296, 694.05904128508371, 3, 7.0299999999999994, 2m, new DateTime(2022, 9, 10, 9, 56, 21, 173, DateTimeKind.Utc).AddTicks(2223), 4.0299999999999994 },
                    { 297, 223.63657495206402, 3, 7.0199999999999996, 38m, new DateTime(2022, 9, 10, 9, 55, 21, 173, DateTimeKind.Utc).AddTicks(2229), 4.0199999999999996 },
                    { 298, 346.8828312722315, 3, 7.0099999999999998, 21m, new DateTime(2022, 9, 10, 9, 54, 21, 173, DateTimeKind.Utc).AddTicks(2235), 4.0099999999999998 },
                    { 299, 72.683303064525418, 3, 7.0, 18m, new DateTime(2022, 9, 10, 9, 53, 21, 173, DateTimeKind.Utc).AddTicks(2240), 4.0 },
                    { 300, 774.75977336582162, 3, 6.9900000000000002, 34m, new DateTime(2022, 9, 10, 9, 52, 21, 173, DateTimeKind.Utc).AddTicks(2245), 3.9899999999999998 }
                });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 51, 21, 167, DateTimeKind.Utc).AddTicks(6891), 6.9800000000000004 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 50, 21, 167, DateTimeKind.Utc).AddTicks(6954), 6.9699999999999998 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 49, 21, 167, DateTimeKind.Utc).AddTicks(6960), 6.96 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 48, 21, 167, DateTimeKind.Utc).AddTicks(6964), 6.9500000000000002 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 47, 21, 167, DateTimeKind.Utc).AddTicks(6967), 6.9400000000000004 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 46, 21, 167, DateTimeKind.Utc).AddTicks(6971), 6.9299999999999997 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 45, 21, 167, DateTimeKind.Utc).AddTicks(6974), 6.9199999999999999 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 44, 21, 167, DateTimeKind.Utc).AddTicks(6977), 6.9100000000000001 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 1, new DateTime(2022, 9, 10, 14, 43, 21, 167, DateTimeKind.Utc).AddTicks(6980), 6.9000000000000004 });

            migrationBuilder.InsertData(
                table: "RemainingTransactions",
                columns: new[] { "Id", "FuelTankId", "TransactionTime", "Value" },
                values: new object[,]
                {
                    { 10, 1, new DateTime(2022, 9, 10, 14, 42, 21, 167, DateTimeKind.Utc).AddTicks(6984), 6.8899999999999997 },
                    { 11, 1, new DateTime(2022, 9, 10, 14, 41, 21, 167, DateTimeKind.Utc).AddTicks(6987), 6.8799999999999999 },
                    { 12, 1, new DateTime(2022, 9, 10, 14, 40, 21, 167, DateTimeKind.Utc).AddTicks(6990), 6.8700000000000001 },
                    { 13, 1, new DateTime(2022, 9, 10, 14, 39, 21, 167, DateTimeKind.Utc).AddTicks(6993), 6.8600000000000003 },
                    { 14, 1, new DateTime(2022, 9, 10, 14, 38, 21, 167, DateTimeKind.Utc).AddTicks(6996), 6.8499999999999996 },
                    { 15, 1, new DateTime(2022, 9, 10, 14, 37, 21, 167, DateTimeKind.Utc).AddTicks(6999), 6.8399999999999999 },
                    { 16, 1, new DateTime(2022, 9, 10, 14, 36, 21, 167, DateTimeKind.Utc).AddTicks(7003), 6.8300000000000001 },
                    { 17, 1, new DateTime(2022, 9, 10, 14, 35, 21, 167, DateTimeKind.Utc).AddTicks(7006), 6.8200000000000003 },
                    { 18, 1, new DateTime(2022, 9, 10, 14, 34, 21, 167, DateTimeKind.Utc).AddTicks(7009), 6.8099999999999996 },
                    { 19, 1, new DateTime(2022, 9, 10, 14, 33, 21, 167, DateTimeKind.Utc).AddTicks(7013), 6.7999999999999998 },
                    { 20, 1, new DateTime(2022, 9, 10, 14, 32, 21, 167, DateTimeKind.Utc).AddTicks(7016), 6.79 },
                    { 21, 1, new DateTime(2022, 9, 10, 14, 31, 21, 167, DateTimeKind.Utc).AddTicks(7019), 6.7800000000000002 },
                    { 22, 1, new DateTime(2022, 9, 10, 14, 30, 21, 167, DateTimeKind.Utc).AddTicks(7022), 6.7699999999999996 },
                    { 23, 1, new DateTime(2022, 9, 10, 14, 29, 21, 167, DateTimeKind.Utc).AddTicks(7025), 6.7599999999999998 },
                    { 24, 1, new DateTime(2022, 9, 10, 14, 28, 21, 167, DateTimeKind.Utc).AddTicks(7028), 6.75 },
                    { 25, 1, new DateTime(2022, 9, 10, 14, 27, 21, 167, DateTimeKind.Utc).AddTicks(7032), 6.7400000000000002 },
                    { 26, 1, new DateTime(2022, 9, 10, 14, 26, 21, 167, DateTimeKind.Utc).AddTicks(7035), 6.7300000000000004 },
                    { 27, 1, new DateTime(2022, 9, 10, 14, 25, 21, 167, DateTimeKind.Utc).AddTicks(7038), 6.7199999999999998 },
                    { 28, 1, new DateTime(2022, 9, 10, 14, 24, 21, 167, DateTimeKind.Utc).AddTicks(7041), 6.71 },
                    { 29, 1, new DateTime(2022, 9, 10, 14, 23, 21, 167, DateTimeKind.Utc).AddTicks(7044), 6.7000000000000002 },
                    { 30, 1, new DateTime(2022, 9, 10, 14, 22, 21, 167, DateTimeKind.Utc).AddTicks(7047), 6.6900000000000004 },
                    { 31, 1, new DateTime(2022, 9, 10, 14, 21, 21, 167, DateTimeKind.Utc).AddTicks(7050), 6.6799999999999997 },
                    { 32, 1, new DateTime(2022, 9, 10, 14, 20, 21, 167, DateTimeKind.Utc).AddTicks(7053), 6.6699999999999999 },
                    { 33, 1, new DateTime(2022, 9, 10, 14, 19, 21, 167, DateTimeKind.Utc).AddTicks(7057), 6.6600000000000001 },
                    { 34, 1, new DateTime(2022, 9, 10, 14, 18, 21, 167, DateTimeKind.Utc).AddTicks(7060), 6.6500000000000004 },
                    { 35, 1, new DateTime(2022, 9, 10, 14, 17, 21, 167, DateTimeKind.Utc).AddTicks(7063), 6.6399999999999997 },
                    { 36, 1, new DateTime(2022, 9, 10, 14, 16, 21, 167, DateTimeKind.Utc).AddTicks(7066), 6.6299999999999999 },
                    { 37, 1, new DateTime(2022, 9, 10, 14, 15, 21, 167, DateTimeKind.Utc).AddTicks(7069), 6.6200000000000001 },
                    { 38, 1, new DateTime(2022, 9, 10, 14, 14, 21, 167, DateTimeKind.Utc).AddTicks(7073), 6.6100000000000003 },
                    { 39, 1, new DateTime(2022, 9, 10, 14, 13, 21, 167, DateTimeKind.Utc).AddTicks(7076), 6.5999999999999996 },
                    { 40, 1, new DateTime(2022, 9, 10, 14, 12, 21, 167, DateTimeKind.Utc).AddTicks(7079), 6.5899999999999999 },
                    { 41, 1, new DateTime(2022, 9, 10, 14, 11, 21, 167, DateTimeKind.Utc).AddTicks(7082), 6.5800000000000001 },
                    { 42, 1, new DateTime(2022, 9, 10, 14, 10, 21, 167, DateTimeKind.Utc).AddTicks(7085), 6.5700000000000003 },
                    { 43, 1, new DateTime(2022, 9, 10, 14, 9, 21, 167, DateTimeKind.Utc).AddTicks(7088), 6.5599999999999996 },
                    { 44, 1, new DateTime(2022, 9, 10, 14, 8, 21, 167, DateTimeKind.Utc).AddTicks(7091), 6.5499999999999998 },
                    { 45, 1, new DateTime(2022, 9, 10, 14, 7, 21, 167, DateTimeKind.Utc).AddTicks(7094), 6.54 },
                    { 46, 1, new DateTime(2022, 9, 10, 14, 6, 21, 167, DateTimeKind.Utc).AddTicks(7097), 6.5300000000000002 },
                    { 47, 1, new DateTime(2022, 9, 10, 14, 5, 21, 167, DateTimeKind.Utc).AddTicks(7101), 6.5199999999999996 },
                    { 48, 1, new DateTime(2022, 9, 10, 14, 4, 21, 167, DateTimeKind.Utc).AddTicks(7104), 6.5099999999999998 },
                    { 49, 1, new DateTime(2022, 9, 10, 14, 3, 21, 167, DateTimeKind.Utc).AddTicks(7107), 6.5 },
                    { 50, 1, new DateTime(2022, 9, 10, 14, 2, 21, 167, DateTimeKind.Utc).AddTicks(7110), 6.4900000000000002 },
                    { 51, 1, new DateTime(2022, 9, 10, 14, 1, 21, 167, DateTimeKind.Utc).AddTicks(7114), 6.4800000000000004 },
                    { 52, 1, new DateTime(2022, 9, 10, 14, 0, 21, 167, DateTimeKind.Utc).AddTicks(7117), 6.4699999999999998 },
                    { 53, 1, new DateTime(2022, 9, 10, 13, 59, 21, 167, DateTimeKind.Utc).AddTicks(7120), 6.46 },
                    { 54, 1, new DateTime(2022, 9, 10, 13, 58, 21, 167, DateTimeKind.Utc).AddTicks(7123), 6.4500000000000002 },
                    { 55, 1, new DateTime(2022, 9, 10, 13, 57, 21, 167, DateTimeKind.Utc).AddTicks(7126), 6.4399999999999995 },
                    { 56, 1, new DateTime(2022, 9, 10, 13, 56, 21, 167, DateTimeKind.Utc).AddTicks(7129), 6.4299999999999997 },
                    { 57, 1, new DateTime(2022, 9, 10, 13, 55, 21, 167, DateTimeKind.Utc).AddTicks(7132), 6.4199999999999999 },
                    { 58, 1, new DateTime(2022, 9, 10, 13, 54, 21, 167, DateTimeKind.Utc).AddTicks(7135), 6.4100000000000001 },
                    { 59, 1, new DateTime(2022, 9, 10, 13, 53, 21, 167, DateTimeKind.Utc).AddTicks(7139), 6.4000000000000004 },
                    { 60, 1, new DateTime(2022, 9, 10, 13, 52, 21, 167, DateTimeKind.Utc).AddTicks(7146), 6.3899999999999997 },
                    { 61, 1, new DateTime(2022, 9, 10, 13, 51, 21, 167, DateTimeKind.Utc).AddTicks(7149), 6.3799999999999999 },
                    { 62, 1, new DateTime(2022, 9, 10, 13, 50, 21, 167, DateTimeKind.Utc).AddTicks(7152), 6.3700000000000001 },
                    { 63, 1, new DateTime(2022, 9, 10, 13, 49, 21, 167, DateTimeKind.Utc).AddTicks(7155), 6.3600000000000003 },
                    { 64, 1, new DateTime(2022, 9, 10, 13, 48, 21, 167, DateTimeKind.Utc).AddTicks(7159), 6.3499999999999996 },
                    { 65, 1, new DateTime(2022, 9, 10, 13, 47, 21, 167, DateTimeKind.Utc).AddTicks(7162), 6.3399999999999999 },
                    { 66, 1, new DateTime(2022, 9, 10, 13, 46, 21, 167, DateTimeKind.Utc).AddTicks(7165), 6.3300000000000001 },
                    { 67, 1, new DateTime(2022, 9, 10, 13, 45, 21, 167, DateTimeKind.Utc).AddTicks(7168), 6.3200000000000003 },
                    { 68, 1, new DateTime(2022, 9, 10, 13, 44, 21, 167, DateTimeKind.Utc).AddTicks(7171), 6.3099999999999996 },
                    { 69, 1, new DateTime(2022, 9, 10, 13, 43, 21, 167, DateTimeKind.Utc).AddTicks(7174), 6.2999999999999998 },
                    { 70, 1, new DateTime(2022, 9, 10, 13, 42, 21, 167, DateTimeKind.Utc).AddTicks(7177), 6.29 },
                    { 71, 1, new DateTime(2022, 9, 10, 13, 41, 21, 167, DateTimeKind.Utc).AddTicks(7181), 6.2800000000000002 },
                    { 72, 1, new DateTime(2022, 9, 10, 13, 40, 21, 167, DateTimeKind.Utc).AddTicks(7184), 6.2699999999999996 },
                    { 73, 1, new DateTime(2022, 9, 10, 13, 39, 21, 167, DateTimeKind.Utc).AddTicks(7187), 6.2599999999999998 },
                    { 74, 1, new DateTime(2022, 9, 10, 13, 38, 21, 167, DateTimeKind.Utc).AddTicks(7190), 6.25 },
                    { 75, 1, new DateTime(2022, 9, 10, 13, 37, 21, 167, DateTimeKind.Utc).AddTicks(7193), 6.2400000000000002 },
                    { 76, 1, new DateTime(2022, 9, 10, 13, 36, 21, 167, DateTimeKind.Utc).AddTicks(7197), 6.2300000000000004 },
                    { 77, 1, new DateTime(2022, 9, 10, 13, 35, 21, 167, DateTimeKind.Utc).AddTicks(7200), 6.2199999999999998 },
                    { 78, 1, new DateTime(2022, 9, 10, 13, 34, 21, 167, DateTimeKind.Utc).AddTicks(7203), 6.21 },
                    { 79, 1, new DateTime(2022, 9, 10, 13, 33, 21, 167, DateTimeKind.Utc).AddTicks(7206), 6.2000000000000002 },
                    { 80, 1, new DateTime(2022, 9, 10, 13, 32, 21, 167, DateTimeKind.Utc).AddTicks(7209), 6.1899999999999995 },
                    { 81, 1, new DateTime(2022, 9, 10, 13, 31, 21, 167, DateTimeKind.Utc).AddTicks(7213), 6.1799999999999997 },
                    { 82, 1, new DateTime(2022, 9, 10, 13, 30, 21, 167, DateTimeKind.Utc).AddTicks(7216), 6.1699999999999999 },
                    { 83, 1, new DateTime(2022, 9, 10, 13, 29, 21, 167, DateTimeKind.Utc).AddTicks(7219), 6.1600000000000001 },
                    { 84, 1, new DateTime(2022, 9, 10, 13, 28, 21, 167, DateTimeKind.Utc).AddTicks(7222), 6.1500000000000004 },
                    { 85, 1, new DateTime(2022, 9, 10, 13, 27, 21, 167, DateTimeKind.Utc).AddTicks(7225), 6.1399999999999997 },
                    { 86, 1, new DateTime(2022, 9, 10, 13, 26, 21, 167, DateTimeKind.Utc).AddTicks(7228), 6.1299999999999999 },
                    { 87, 1, new DateTime(2022, 9, 10, 13, 25, 21, 167, DateTimeKind.Utc).AddTicks(7231), 6.1200000000000001 },
                    { 88, 1, new DateTime(2022, 9, 10, 13, 24, 21, 167, DateTimeKind.Utc).AddTicks(7235), 6.1100000000000003 },
                    { 89, 1, new DateTime(2022, 9, 10, 13, 23, 21, 167, DateTimeKind.Utc).AddTicks(7238), 6.0999999999999996 },
                    { 90, 1, new DateTime(2022, 9, 10, 13, 22, 21, 167, DateTimeKind.Utc).AddTicks(7241), 6.0899999999999999 },
                    { 91, 1, new DateTime(2022, 9, 10, 13, 21, 21, 167, DateTimeKind.Utc).AddTicks(7244), 6.0800000000000001 },
                    { 92, 1, new DateTime(2022, 9, 10, 13, 20, 21, 167, DateTimeKind.Utc).AddTicks(7247), 6.0700000000000003 },
                    { 93, 1, new DateTime(2022, 9, 10, 13, 19, 21, 167, DateTimeKind.Utc).AddTicks(7250), 6.0599999999999996 },
                    { 94, 1, new DateTime(2022, 9, 10, 13, 18, 21, 167, DateTimeKind.Utc).AddTicks(7253), 6.0499999999999998 },
                    { 95, 1, new DateTime(2022, 9, 10, 13, 17, 21, 167, DateTimeKind.Utc).AddTicks(7256), 6.04 },
                    { 96, 1, new DateTime(2022, 9, 10, 13, 16, 21, 167, DateTimeKind.Utc).AddTicks(7260), 6.0300000000000002 },
                    { 97, 1, new DateTime(2022, 9, 10, 13, 15, 21, 167, DateTimeKind.Utc).AddTicks(7263), 6.0199999999999996 },
                    { 98, 1, new DateTime(2022, 9, 10, 13, 14, 21, 167, DateTimeKind.Utc).AddTicks(7266), 6.0099999999999998 },
                    { 99, 1, new DateTime(2022, 9, 10, 13, 13, 21, 167, DateTimeKind.Utc).AddTicks(7269), 6.0 },
                    { 100, 1, new DateTime(2022, 9, 10, 13, 12, 21, 167, DateTimeKind.Utc).AddTicks(7272), 5.9900000000000002 },
                    { 101, 2, new DateTime(2022, 9, 10, 13, 11, 21, 168, DateTimeKind.Utc).AddTicks(7838), 5.9800000000000004 },
                    { 102, 2, new DateTime(2022, 9, 10, 13, 10, 21, 168, DateTimeKind.Utc).AddTicks(7898), 5.9699999999999998 },
                    { 103, 2, new DateTime(2022, 9, 10, 13, 9, 21, 168, DateTimeKind.Utc).AddTicks(7903), 5.96 },
                    { 104, 2, new DateTime(2022, 9, 10, 13, 8, 21, 168, DateTimeKind.Utc).AddTicks(7907), 5.9500000000000002 },
                    { 105, 2, new DateTime(2022, 9, 10, 13, 7, 21, 168, DateTimeKind.Utc).AddTicks(7910), 5.9399999999999995 },
                    { 106, 2, new DateTime(2022, 9, 10, 13, 6, 21, 168, DateTimeKind.Utc).AddTicks(7914), 5.9299999999999997 },
                    { 107, 2, new DateTime(2022, 9, 10, 13, 5, 21, 168, DateTimeKind.Utc).AddTicks(7917), 5.9199999999999999 },
                    { 108, 2, new DateTime(2022, 9, 10, 13, 4, 21, 168, DateTimeKind.Utc).AddTicks(7920), 5.9100000000000001 },
                    { 109, 2, new DateTime(2022, 9, 10, 13, 3, 21, 168, DateTimeKind.Utc).AddTicks(7923), 5.9000000000000004 },
                    { 110, 2, new DateTime(2022, 9, 10, 13, 2, 21, 168, DateTimeKind.Utc).AddTicks(7926), 5.8899999999999997 },
                    { 111, 2, new DateTime(2022, 9, 10, 13, 1, 21, 168, DateTimeKind.Utc).AddTicks(7929), 5.8799999999999999 },
                    { 112, 2, new DateTime(2022, 9, 10, 13, 0, 21, 168, DateTimeKind.Utc).AddTicks(7933), 5.8700000000000001 },
                    { 113, 2, new DateTime(2022, 9, 10, 12, 59, 21, 168, DateTimeKind.Utc).AddTicks(7936), 5.8599999999999994 },
                    { 114, 2, new DateTime(2022, 9, 10, 12, 58, 21, 168, DateTimeKind.Utc).AddTicks(7939), 5.8499999999999996 },
                    { 115, 2, new DateTime(2022, 9, 10, 12, 57, 21, 168, DateTimeKind.Utc).AddTicks(7942), 5.8399999999999999 },
                    { 116, 2, new DateTime(2022, 9, 10, 12, 56, 21, 168, DateTimeKind.Utc).AddTicks(7945), 5.8300000000000001 },
                    { 117, 2, new DateTime(2022, 9, 10, 12, 55, 21, 168, DateTimeKind.Utc).AddTicks(7949), 5.8200000000000003 },
                    { 118, 2, new DateTime(2022, 9, 10, 12, 54, 21, 168, DateTimeKind.Utc).AddTicks(7952), 5.8100000000000005 },
                    { 119, 2, new DateTime(2022, 9, 10, 12, 53, 21, 168, DateTimeKind.Utc).AddTicks(7955), 5.7999999999999998 },
                    { 120, 2, new DateTime(2022, 9, 10, 12, 52, 21, 168, DateTimeKind.Utc).AddTicks(7958), 5.79 },
                    { 121, 2, new DateTime(2022, 9, 10, 12, 51, 21, 168, DateTimeKind.Utc).AddTicks(7961), 5.7800000000000002 },
                    { 122, 2, new DateTime(2022, 9, 10, 12, 50, 21, 168, DateTimeKind.Utc).AddTicks(7964), 5.7699999999999996 },
                    { 123, 2, new DateTime(2022, 9, 10, 12, 49, 21, 168, DateTimeKind.Utc).AddTicks(7967), 5.7599999999999998 },
                    { 124, 2, new DateTime(2022, 9, 10, 12, 48, 21, 168, DateTimeKind.Utc).AddTicks(7970), 5.75 },
                    { 125, 2, new DateTime(2022, 9, 10, 12, 47, 21, 168, DateTimeKind.Utc).AddTicks(7973), 5.7400000000000002 },
                    { 126, 2, new DateTime(2022, 9, 10, 12, 46, 21, 168, DateTimeKind.Utc).AddTicks(7976), 5.7300000000000004 },
                    { 127, 2, new DateTime(2022, 9, 10, 12, 45, 21, 168, DateTimeKind.Utc).AddTicks(7980), 5.7199999999999998 },
                    { 128, 2, new DateTime(2022, 9, 10, 12, 44, 21, 168, DateTimeKind.Utc).AddTicks(7983), 5.71 },
                    { 129, 2, new DateTime(2022, 9, 10, 12, 43, 21, 168, DateTimeKind.Utc).AddTicks(7986), 5.7000000000000002 },
                    { 130, 2, new DateTime(2022, 9, 10, 12, 42, 21, 168, DateTimeKind.Utc).AddTicks(7989), 5.6899999999999995 },
                    { 131, 2, new DateTime(2022, 9, 10, 12, 41, 21, 168, DateTimeKind.Utc).AddTicks(7992), 5.6799999999999997 },
                    { 132, 2, new DateTime(2022, 9, 10, 12, 40, 21, 168, DateTimeKind.Utc).AddTicks(7995), 5.6699999999999999 },
                    { 133, 2, new DateTime(2022, 9, 10, 12, 39, 21, 168, DateTimeKind.Utc).AddTicks(7998), 5.6600000000000001 },
                    { 134, 2, new DateTime(2022, 9, 10, 12, 38, 21, 168, DateTimeKind.Utc).AddTicks(8001), 5.6500000000000004 },
                    { 135, 2, new DateTime(2022, 9, 10, 12, 37, 21, 168, DateTimeKind.Utc).AddTicks(8004), 5.6399999999999997 },
                    { 136, 2, new DateTime(2022, 9, 10, 12, 36, 21, 168, DateTimeKind.Utc).AddTicks(8007), 5.6299999999999999 },
                    { 137, 2, new DateTime(2022, 9, 10, 12, 35, 21, 168, DateTimeKind.Utc).AddTicks(8010), 5.6200000000000001 },
                    { 138, 2, new DateTime(2022, 9, 10, 12, 34, 21, 168, DateTimeKind.Utc).AddTicks(8014), 5.6099999999999994 },
                    { 139, 2, new DateTime(2022, 9, 10, 12, 33, 21, 168, DateTimeKind.Utc).AddTicks(8017), 5.5999999999999996 },
                    { 140, 2, new DateTime(2022, 9, 10, 12, 32, 21, 168, DateTimeKind.Utc).AddTicks(8020), 5.5899999999999999 },
                    { 141, 2, new DateTime(2022, 9, 10, 12, 31, 21, 168, DateTimeKind.Utc).AddTicks(8023), 5.5800000000000001 },
                    { 142, 2, new DateTime(2022, 9, 10, 12, 30, 21, 168, DateTimeKind.Utc).AddTicks(8026), 5.5700000000000003 },
                    { 143, 2, new DateTime(2022, 9, 10, 12, 29, 21, 168, DateTimeKind.Utc).AddTicks(8029), 5.5600000000000005 },
                    { 144, 2, new DateTime(2022, 9, 10, 12, 28, 21, 168, DateTimeKind.Utc).AddTicks(8032), 5.5499999999999998 },
                    { 145, 2, new DateTime(2022, 9, 10, 12, 27, 21, 168, DateTimeKind.Utc).AddTicks(8035), 5.54 },
                    { 146, 2, new DateTime(2022, 9, 10, 12, 26, 21, 168, DateTimeKind.Utc).AddTicks(8038), 5.5300000000000002 },
                    { 147, 2, new DateTime(2022, 9, 10, 12, 25, 21, 168, DateTimeKind.Utc).AddTicks(8042), 5.5199999999999996 },
                    { 148, 2, new DateTime(2022, 9, 10, 12, 24, 21, 168, DateTimeKind.Utc).AddTicks(8045), 5.5099999999999998 },
                    { 149, 2, new DateTime(2022, 9, 10, 12, 23, 21, 168, DateTimeKind.Utc).AddTicks(8048), 5.5 },
                    { 150, 2, new DateTime(2022, 9, 10, 12, 22, 21, 168, DateTimeKind.Utc).AddTicks(8051), 5.4900000000000002 },
                    { 151, 2, new DateTime(2022, 9, 10, 12, 21, 21, 168, DateTimeKind.Utc).AddTicks(8054), 5.4800000000000004 },
                    { 152, 2, new DateTime(2022, 9, 10, 12, 20, 21, 168, DateTimeKind.Utc).AddTicks(8057), 5.4699999999999998 },
                    { 153, 2, new DateTime(2022, 9, 10, 12, 19, 21, 168, DateTimeKind.Utc).AddTicks(8065), 5.46 },
                    { 154, 2, new DateTime(2022, 9, 10, 12, 18, 21, 168, DateTimeKind.Utc).AddTicks(8069), 5.4500000000000002 },
                    { 155, 2, new DateTime(2022, 9, 10, 12, 17, 21, 168, DateTimeKind.Utc).AddTicks(8072), 5.4399999999999995 },
                    { 156, 2, new DateTime(2022, 9, 10, 12, 16, 21, 168, DateTimeKind.Utc).AddTicks(8075), 5.4299999999999997 },
                    { 157, 2, new DateTime(2022, 9, 10, 12, 15, 21, 168, DateTimeKind.Utc).AddTicks(8078), 5.4199999999999999 },
                    { 158, 2, new DateTime(2022, 9, 10, 12, 14, 21, 168, DateTimeKind.Utc).AddTicks(8081), 5.4100000000000001 },
                    { 159, 2, new DateTime(2022, 9, 10, 12, 13, 21, 168, DateTimeKind.Utc).AddTicks(8084), 5.4000000000000004 },
                    { 160, 2, new DateTime(2022, 9, 10, 12, 12, 21, 168, DateTimeKind.Utc).AddTicks(8088), 5.3899999999999997 },
                    { 161, 2, new DateTime(2022, 9, 10, 12, 11, 21, 168, DateTimeKind.Utc).AddTicks(8091), 5.3799999999999999 },
                    { 162, 2, new DateTime(2022, 9, 10, 12, 10, 21, 168, DateTimeKind.Utc).AddTicks(8094), 5.3700000000000001 },
                    { 163, 2, new DateTime(2022, 9, 10, 12, 9, 21, 168, DateTimeKind.Utc).AddTicks(8097), 5.3599999999999994 },
                    { 164, 2, new DateTime(2022, 9, 10, 12, 8, 21, 168, DateTimeKind.Utc).AddTicks(8101), 5.3499999999999996 },
                    { 165, 2, new DateTime(2022, 9, 10, 12, 7, 21, 168, DateTimeKind.Utc).AddTicks(8104), 5.3399999999999999 },
                    { 166, 2, new DateTime(2022, 9, 10, 12, 6, 21, 168, DateTimeKind.Utc).AddTicks(8107), 5.3300000000000001 },
                    { 167, 2, new DateTime(2022, 9, 10, 12, 5, 21, 168, DateTimeKind.Utc).AddTicks(8110), 5.3200000000000003 },
                    { 168, 2, new DateTime(2022, 9, 10, 12, 4, 21, 168, DateTimeKind.Utc).AddTicks(8114), 5.3100000000000005 },
                    { 169, 2, new DateTime(2022, 9, 10, 12, 3, 21, 168, DateTimeKind.Utc).AddTicks(8117), 5.2999999999999998 },
                    { 170, 2, new DateTime(2022, 9, 10, 12, 2, 21, 168, DateTimeKind.Utc).AddTicks(8120), 5.29 },
                    { 171, 2, new DateTime(2022, 9, 10, 12, 1, 21, 168, DateTimeKind.Utc).AddTicks(8123), 5.2800000000000002 },
                    { 172, 2, new DateTime(2022, 9, 10, 12, 0, 21, 168, DateTimeKind.Utc).AddTicks(8127), 5.2699999999999996 },
                    { 173, 2, new DateTime(2022, 9, 10, 11, 59, 21, 168, DateTimeKind.Utc).AddTicks(8130), 5.2599999999999998 },
                    { 174, 2, new DateTime(2022, 9, 10, 11, 58, 21, 168, DateTimeKind.Utc).AddTicks(8133), 5.25 },
                    { 175, 2, new DateTime(2022, 9, 10, 11, 57, 21, 168, DateTimeKind.Utc).AddTicks(8136), 5.2400000000000002 },
                    { 176, 2, new DateTime(2022, 9, 10, 11, 56, 21, 168, DateTimeKind.Utc).AddTicks(8139), 5.2300000000000004 },
                    { 177, 2, new DateTime(2022, 9, 10, 11, 55, 21, 168, DateTimeKind.Utc).AddTicks(8142), 5.2199999999999998 },
                    { 178, 2, new DateTime(2022, 9, 10, 11, 54, 21, 168, DateTimeKind.Utc).AddTicks(8145), 5.21 },
                    { 179, 2, new DateTime(2022, 9, 10, 11, 53, 21, 168, DateTimeKind.Utc).AddTicks(8148), 5.2000000000000002 },
                    { 180, 2, new DateTime(2022, 9, 10, 11, 52, 21, 168, DateTimeKind.Utc).AddTicks(8152), 5.1899999999999995 },
                    { 181, 2, new DateTime(2022, 9, 10, 11, 51, 21, 168, DateTimeKind.Utc).AddTicks(8155), 5.1799999999999997 },
                    { 182, 2, new DateTime(2022, 9, 10, 11, 50, 21, 168, DateTimeKind.Utc).AddTicks(8158), 5.1699999999999999 },
                    { 183, 2, new DateTime(2022, 9, 10, 11, 49, 21, 168, DateTimeKind.Utc).AddTicks(8161), 5.1600000000000001 },
                    { 184, 2, new DateTime(2022, 9, 10, 11, 48, 21, 168, DateTimeKind.Utc).AddTicks(8164), 5.1500000000000004 },
                    { 185, 2, new DateTime(2022, 9, 10, 11, 47, 21, 168, DateTimeKind.Utc).AddTicks(8167), 5.1399999999999997 },
                    { 186, 2, new DateTime(2022, 9, 10, 11, 46, 21, 168, DateTimeKind.Utc).AddTicks(8170), 5.1299999999999999 },
                    { 187, 2, new DateTime(2022, 9, 10, 11, 45, 21, 168, DateTimeKind.Utc).AddTicks(8173), 5.1200000000000001 },
                    { 188, 2, new DateTime(2022, 9, 10, 11, 44, 21, 168, DateTimeKind.Utc).AddTicks(8177), 5.1099999999999994 },
                    { 189, 2, new DateTime(2022, 9, 10, 11, 43, 21, 168, DateTimeKind.Utc).AddTicks(8180), 5.0999999999999996 },
                    { 190, 2, new DateTime(2022, 9, 10, 11, 42, 21, 168, DateTimeKind.Utc).AddTicks(8183), 5.0899999999999999 },
                    { 191, 2, new DateTime(2022, 9, 10, 11, 41, 21, 168, DateTimeKind.Utc).AddTicks(8186), 5.0800000000000001 },
                    { 192, 2, new DateTime(2022, 9, 10, 11, 40, 21, 168, DateTimeKind.Utc).AddTicks(8189), 5.0700000000000003 },
                    { 193, 2, new DateTime(2022, 9, 10, 11, 39, 21, 168, DateTimeKind.Utc).AddTicks(8193), 5.0600000000000005 },
                    { 194, 2, new DateTime(2022, 9, 10, 11, 38, 21, 168, DateTimeKind.Utc).AddTicks(8196), 5.0499999999999998 },
                    { 195, 2, new DateTime(2022, 9, 10, 11, 37, 21, 168, DateTimeKind.Utc).AddTicks(8199), 5.04 },
                    { 196, 2, new DateTime(2022, 9, 10, 11, 36, 21, 168, DateTimeKind.Utc).AddTicks(8202), 5.0300000000000002 },
                    { 197, 2, new DateTime(2022, 9, 10, 11, 35, 21, 168, DateTimeKind.Utc).AddTicks(8205), 5.0199999999999996 },
                    { 198, 2, new DateTime(2022, 9, 10, 11, 34, 21, 168, DateTimeKind.Utc).AddTicks(8208), 5.0099999999999998 },
                    { 199, 2, new DateTime(2022, 9, 10, 11, 33, 21, 168, DateTimeKind.Utc).AddTicks(8211), 5.0 },
                    { 200, 2, new DateTime(2022, 9, 10, 11, 32, 21, 168, DateTimeKind.Utc).AddTicks(8215), 4.9900000000000002 },
                    { 201, 3, new DateTime(2022, 9, 10, 11, 31, 21, 169, DateTimeKind.Utc).AddTicks(8438), 4.9800000000000004 },
                    { 202, 3, new DateTime(2022, 9, 10, 11, 30, 21, 169, DateTimeKind.Utc).AddTicks(8493), 4.9699999999999998 },
                    { 203, 3, new DateTime(2022, 9, 10, 11, 29, 21, 169, DateTimeKind.Utc).AddTicks(8498), 4.96 },
                    { 204, 3, new DateTime(2022, 9, 10, 11, 28, 21, 169, DateTimeKind.Utc).AddTicks(8502), 4.9500000000000002 },
                    { 205, 3, new DateTime(2022, 9, 10, 11, 27, 21, 169, DateTimeKind.Utc).AddTicks(8505), 4.9399999999999995 },
                    { 206, 3, new DateTime(2022, 9, 10, 11, 26, 21, 169, DateTimeKind.Utc).AddTicks(8508), 4.9299999999999997 },
                    { 207, 3, new DateTime(2022, 9, 10, 11, 25, 21, 169, DateTimeKind.Utc).AddTicks(8512), 4.9199999999999999 },
                    { 208, 3, new DateTime(2022, 9, 10, 11, 24, 21, 169, DateTimeKind.Utc).AddTicks(8516), 4.9100000000000001 },
                    { 209, 3, new DateTime(2022, 9, 10, 11, 23, 21, 169, DateTimeKind.Utc).AddTicks(8519), 4.9000000000000004 },
                    { 210, 3, new DateTime(2022, 9, 10, 11, 22, 21, 169, DateTimeKind.Utc).AddTicks(8522), 4.8900000000000006 },
                    { 211, 3, new DateTime(2022, 9, 10, 11, 21, 21, 169, DateTimeKind.Utc).AddTicks(8526), 4.8799999999999999 },
                    { 212, 3, new DateTime(2022, 9, 10, 11, 20, 21, 169, DateTimeKind.Utc).AddTicks(8529), 4.8700000000000001 },
                    { 213, 3, new DateTime(2022, 9, 10, 11, 19, 21, 169, DateTimeKind.Utc).AddTicks(8532), 4.8599999999999994 },
                    { 214, 3, new DateTime(2022, 9, 10, 11, 18, 21, 169, DateTimeKind.Utc).AddTicks(8535), 4.8499999999999996 },
                    { 215, 3, new DateTime(2022, 9, 10, 11, 17, 21, 169, DateTimeKind.Utc).AddTicks(8539), 4.8399999999999999 },
                    { 216, 3, new DateTime(2022, 9, 10, 11, 16, 21, 169, DateTimeKind.Utc).AddTicks(8542), 4.8300000000000001 },
                    { 217, 3, new DateTime(2022, 9, 10, 11, 15, 21, 169, DateTimeKind.Utc).AddTicks(8545), 4.8200000000000003 },
                    { 218, 3, new DateTime(2022, 9, 10, 11, 14, 21, 169, DateTimeKind.Utc).AddTicks(8548), 4.8100000000000005 },
                    { 219, 3, new DateTime(2022, 9, 10, 11, 13, 21, 169, DateTimeKind.Utc).AddTicks(8552), 4.7999999999999998 },
                    { 220, 3, new DateTime(2022, 9, 10, 11, 12, 21, 169, DateTimeKind.Utc).AddTicks(8555), 4.79 },
                    { 221, 3, new DateTime(2022, 9, 10, 11, 11, 21, 169, DateTimeKind.Utc).AddTicks(8558), 4.7799999999999994 },
                    { 222, 3, new DateTime(2022, 9, 10, 11, 10, 21, 169, DateTimeKind.Utc).AddTicks(8562), 4.7699999999999996 },
                    { 223, 3, new DateTime(2022, 9, 10, 11, 9, 21, 169, DateTimeKind.Utc).AddTicks(8565), 4.7599999999999998 },
                    { 224, 3, new DateTime(2022, 9, 10, 11, 8, 21, 169, DateTimeKind.Utc).AddTicks(8568), 4.75 },
                    { 225, 3, new DateTime(2022, 9, 10, 11, 7, 21, 169, DateTimeKind.Utc).AddTicks(8571), 4.7400000000000002 },
                    { 226, 3, new DateTime(2022, 9, 10, 11, 6, 21, 169, DateTimeKind.Utc).AddTicks(8574), 4.7300000000000004 },
                    { 227, 3, new DateTime(2022, 9, 10, 11, 5, 21, 169, DateTimeKind.Utc).AddTicks(8577), 4.7199999999999998 },
                    { 228, 3, new DateTime(2022, 9, 10, 11, 4, 21, 169, DateTimeKind.Utc).AddTicks(8581), 4.71 },
                    { 229, 3, new DateTime(2022, 9, 10, 11, 3, 21, 169, DateTimeKind.Utc).AddTicks(8584), 4.6999999999999993 },
                    { 230, 3, new DateTime(2022, 9, 10, 11, 2, 21, 169, DateTimeKind.Utc).AddTicks(8587), 4.6899999999999995 },
                    { 231, 3, new DateTime(2022, 9, 10, 11, 1, 21, 169, DateTimeKind.Utc).AddTicks(8590), 4.6799999999999997 },
                    { 232, 3, new DateTime(2022, 9, 10, 11, 0, 21, 169, DateTimeKind.Utc).AddTicks(8593), 4.6699999999999999 },
                    { 233, 3, new DateTime(2022, 9, 10, 10, 59, 21, 169, DateTimeKind.Utc).AddTicks(8596), 4.6600000000000001 },
                    { 234, 3, new DateTime(2022, 9, 10, 10, 58, 21, 169, DateTimeKind.Utc).AddTicks(8599), 4.6500000000000004 },
                    { 235, 3, new DateTime(2022, 9, 10, 10, 57, 21, 169, DateTimeKind.Utc).AddTicks(8603), 4.6400000000000006 },
                    { 236, 3, new DateTime(2022, 9, 10, 10, 56, 21, 169, DateTimeKind.Utc).AddTicks(8606), 4.6299999999999999 },
                    { 237, 3, new DateTime(2022, 9, 10, 10, 55, 21, 169, DateTimeKind.Utc).AddTicks(8609), 4.6200000000000001 },
                    { 238, 3, new DateTime(2022, 9, 10, 10, 54, 21, 169, DateTimeKind.Utc).AddTicks(8612), 4.6099999999999994 },
                    { 239, 3, new DateTime(2022, 9, 10, 10, 53, 21, 169, DateTimeKind.Utc).AddTicks(8615), 4.5999999999999996 },
                    { 240, 3, new DateTime(2022, 9, 10, 10, 52, 21, 169, DateTimeKind.Utc).AddTicks(8618), 4.5899999999999999 },
                    { 241, 3, new DateTime(2022, 9, 10, 10, 51, 21, 169, DateTimeKind.Utc).AddTicks(8626), 4.5800000000000001 },
                    { 242, 3, new DateTime(2022, 9, 10, 10, 50, 21, 169, DateTimeKind.Utc).AddTicks(8630), 4.5700000000000003 },
                    { 243, 3, new DateTime(2022, 9, 10, 10, 49, 21, 169, DateTimeKind.Utc).AddTicks(8633), 4.5600000000000005 },
                    { 244, 3, new DateTime(2022, 9, 10, 10, 48, 21, 169, DateTimeKind.Utc).AddTicks(8636), 4.5499999999999998 },
                    { 245, 3, new DateTime(2022, 9, 10, 10, 47, 21, 169, DateTimeKind.Utc).AddTicks(8639), 4.54 },
                    { 246, 3, new DateTime(2022, 9, 10, 10, 46, 21, 169, DateTimeKind.Utc).AddTicks(8642), 4.5299999999999994 },
                    { 247, 3, new DateTime(2022, 9, 10, 10, 45, 21, 169, DateTimeKind.Utc).AddTicks(8645), 4.5199999999999996 },
                    { 248, 3, new DateTime(2022, 9, 10, 10, 44, 21, 169, DateTimeKind.Utc).AddTicks(8648), 4.5099999999999998 },
                    { 249, 3, new DateTime(2022, 9, 10, 10, 43, 21, 169, DateTimeKind.Utc).AddTicks(8652), 4.5 },
                    { 250, 3, new DateTime(2022, 9, 10, 10, 42, 21, 169, DateTimeKind.Utc).AddTicks(8655), 4.4900000000000002 },
                    { 251, 3, new DateTime(2022, 9, 10, 10, 41, 21, 169, DateTimeKind.Utc).AddTicks(8658), 4.4800000000000004 },
                    { 252, 3, new DateTime(2022, 9, 10, 10, 40, 21, 169, DateTimeKind.Utc).AddTicks(8661), 4.4699999999999998 },
                    { 253, 3, new DateTime(2022, 9, 10, 10, 39, 21, 169, DateTimeKind.Utc).AddTicks(8664), 4.46 },
                    { 254, 3, new DateTime(2022, 9, 10, 10, 38, 21, 169, DateTimeKind.Utc).AddTicks(8667), 4.4499999999999993 },
                    { 255, 3, new DateTime(2022, 9, 10, 10, 37, 21, 169, DateTimeKind.Utc).AddTicks(8671), 4.4399999999999995 },
                    { 256, 3, new DateTime(2022, 9, 10, 10, 36, 21, 169, DateTimeKind.Utc).AddTicks(8674), 4.4299999999999997 },
                    { 257, 3, new DateTime(2022, 9, 10, 10, 35, 21, 169, DateTimeKind.Utc).AddTicks(8677), 4.4199999999999999 },
                    { 258, 3, new DateTime(2022, 9, 10, 10, 34, 21, 169, DateTimeKind.Utc).AddTicks(8680), 4.4100000000000001 },
                    { 259, 3, new DateTime(2022, 9, 10, 10, 33, 21, 169, DateTimeKind.Utc).AddTicks(8683), 4.4000000000000004 },
                    { 260, 3, new DateTime(2022, 9, 10, 10, 32, 21, 169, DateTimeKind.Utc).AddTicks(8686), 4.3900000000000006 },
                    { 261, 3, new DateTime(2022, 9, 10, 10, 31, 21, 169, DateTimeKind.Utc).AddTicks(8689), 4.3799999999999999 },
                    { 262, 3, new DateTime(2022, 9, 10, 10, 30, 21, 169, DateTimeKind.Utc).AddTicks(8693), 4.3700000000000001 },
                    { 263, 3, new DateTime(2022, 9, 10, 10, 29, 21, 169, DateTimeKind.Utc).AddTicks(8696), 4.3599999999999994 },
                    { 264, 3, new DateTime(2022, 9, 10, 10, 28, 21, 169, DateTimeKind.Utc).AddTicks(8699), 4.3499999999999996 },
                    { 265, 3, new DateTime(2022, 9, 10, 10, 27, 21, 169, DateTimeKind.Utc).AddTicks(8702), 4.3399999999999999 },
                    { 266, 3, new DateTime(2022, 9, 10, 10, 26, 21, 169, DateTimeKind.Utc).AddTicks(8705), 4.3300000000000001 },
                    { 267, 3, new DateTime(2022, 9, 10, 10, 25, 21, 169, DateTimeKind.Utc).AddTicks(8708), 4.3200000000000003 },
                    { 268, 3, new DateTime(2022, 9, 10, 10, 24, 21, 169, DateTimeKind.Utc).AddTicks(8711), 4.3100000000000005 },
                    { 269, 3, new DateTime(2022, 9, 10, 10, 23, 21, 169, DateTimeKind.Utc).AddTicks(8714), 4.2999999999999998 },
                    { 270, 3, new DateTime(2022, 9, 10, 10, 22, 21, 169, DateTimeKind.Utc).AddTicks(8717), 4.29 },
                    { 271, 3, new DateTime(2022, 9, 10, 10, 21, 21, 169, DateTimeKind.Utc).AddTicks(8721), 4.2799999999999994 },
                    { 272, 3, new DateTime(2022, 9, 10, 10, 20, 21, 169, DateTimeKind.Utc).AddTicks(8724), 4.2699999999999996 },
                    { 273, 3, new DateTime(2022, 9, 10, 10, 19, 21, 169, DateTimeKind.Utc).AddTicks(8727), 4.2599999999999998 },
                    { 274, 3, new DateTime(2022, 9, 10, 10, 18, 21, 169, DateTimeKind.Utc).AddTicks(8730), 4.25 },
                    { 275, 3, new DateTime(2022, 9, 10, 10, 17, 21, 169, DateTimeKind.Utc).AddTicks(8733), 4.2400000000000002 },
                    { 276, 3, new DateTime(2022, 9, 10, 10, 16, 21, 169, DateTimeKind.Utc).AddTicks(8736), 4.2300000000000004 },
                    { 277, 3, new DateTime(2022, 9, 10, 10, 15, 21, 169, DateTimeKind.Utc).AddTicks(8739), 4.2199999999999998 },
                    { 278, 3, new DateTime(2022, 9, 10, 10, 14, 21, 169, DateTimeKind.Utc).AddTicks(8742), 4.21 },
                    { 279, 3, new DateTime(2022, 9, 10, 10, 13, 21, 169, DateTimeKind.Utc).AddTicks(8745), 4.1999999999999993 },
                    { 280, 3, new DateTime(2022, 9, 10, 10, 12, 21, 169, DateTimeKind.Utc).AddTicks(8748), 4.1899999999999995 },
                    { 281, 3, new DateTime(2022, 9, 10, 10, 11, 21, 169, DateTimeKind.Utc).AddTicks(8752), 4.1799999999999997 },
                    { 282, 3, new DateTime(2022, 9, 10, 10, 10, 21, 169, DateTimeKind.Utc).AddTicks(8755), 4.1699999999999999 },
                    { 283, 3, new DateTime(2022, 9, 10, 10, 9, 21, 169, DateTimeKind.Utc).AddTicks(8758), 4.1600000000000001 },
                    { 284, 3, new DateTime(2022, 9, 10, 10, 8, 21, 169, DateTimeKind.Utc).AddTicks(8761), 4.1500000000000004 },
                    { 285, 3, new DateTime(2022, 9, 10, 10, 7, 21, 169, DateTimeKind.Utc).AddTicks(8765), 4.1400000000000006 },
                    { 286, 3, new DateTime(2022, 9, 10, 10, 6, 21, 169, DateTimeKind.Utc).AddTicks(8768), 4.1299999999999999 },
                    { 287, 3, new DateTime(2022, 9, 10, 10, 5, 21, 169, DateTimeKind.Utc).AddTicks(8771), 4.1200000000000001 },
                    { 288, 3, new DateTime(2022, 9, 10, 10, 4, 21, 169, DateTimeKind.Utc).AddTicks(8774), 4.1099999999999994 },
                    { 289, 3, new DateTime(2022, 9, 10, 10, 3, 21, 169, DateTimeKind.Utc).AddTicks(8777), 4.0999999999999996 },
                    { 290, 3, new DateTime(2022, 9, 10, 10, 2, 21, 169, DateTimeKind.Utc).AddTicks(8780), 4.0899999999999999 },
                    { 291, 3, new DateTime(2022, 9, 10, 10, 1, 21, 169, DateTimeKind.Utc).AddTicks(8783), 4.0800000000000001 },
                    { 292, 3, new DateTime(2022, 9, 10, 10, 0, 21, 169, DateTimeKind.Utc).AddTicks(8787), 4.0700000000000003 },
                    { 293, 3, new DateTime(2022, 9, 10, 9, 59, 21, 169, DateTimeKind.Utc).AddTicks(8790), 4.0600000000000005 },
                    { 294, 3, new DateTime(2022, 9, 10, 9, 58, 21, 169, DateTimeKind.Utc).AddTicks(8793), 4.0499999999999998 },
                    { 295, 3, new DateTime(2022, 9, 10, 9, 57, 21, 169, DateTimeKind.Utc).AddTicks(8796), 4.04 },
                    { 296, 3, new DateTime(2022, 9, 10, 9, 56, 21, 169, DateTimeKind.Utc).AddTicks(8799), 4.0299999999999994 },
                    { 297, 3, new DateTime(2022, 9, 10, 9, 55, 21, 169, DateTimeKind.Utc).AddTicks(8802), 4.0199999999999996 },
                    { 298, 3, new DateTime(2022, 9, 10, 9, 54, 21, 169, DateTimeKind.Utc).AddTicks(8806), 4.0099999999999998 },
                    { 299, 3, new DateTime(2022, 9, 10, 9, 53, 21, 169, DateTimeKind.Utc).AddTicks(8809), 4.0 },
                    { 300, 3, new DateTime(2022, 9, 10, 9, 52, 21, 169, DateTimeKind.Utc).AddTicks(8812), 3.9899999999999998 }
                });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Spinkafurt");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "New Retha");

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Pricestad");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 53, 21, 147, DateTimeKind.Utc).AddTicks(9686), "OYg4UNLSlVE4nuXUSxWkcdWySUcVbdzlC45a7GoV9xE=", "tzgZOev6ipcnOqGXqDgkrDhcvWaXURmR05KNWRTHyhQ=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 53, 21, 153, DateTimeKind.Utc).AddTicks(4621), "nJcxFletmPl6MgT9UGZqbiEXbejPyLo0DHCebYd9Udc=", "9FVpho6sc8SSy7zFc3FxvA2DKs3du69XJipT7R1l58U=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 10, 14, 53, 21, 158, DateTimeKind.Utc).AddTicks(9149), "ubhn+g06jjMAbyavl8ypLWE4qiRS+19hTf2WFgtPgn0=", "hhtFPVGl/WZpVUhoTBvoGzGYMLdiJRxV2ZhEof/2ljw=" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 5.5, "aut", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 6.5, "eius", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentAmount", "Name", "UpdatedAt" },
                values: new object[] { 7.5, "ipsa", new DateTime(2022, 8, 30, 15, 5, 34, 855, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 345.03636019303673, 9.8000000000000007, 15m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6417), 9.8589646757488207 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 725.57673256897465, 9.6999999999999993, 32m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6480), 6.3880405985366568 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Density", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 289.04669457533259, 9.5999999999999996, 14m, new DateTime(2022, 8, 30, 15, 5, 34, 860, DateTimeKind.Utc).AddTicks(6489), 3.0308851721844454 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 617.59000086729463, 2, 9.5, 25m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7769), 7.1451265360034881 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 892.08277253755057, 2, 9.4000000000000004, 29m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7826), 0.57624244099814037 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 71.316363453127536, 2, 9.3000000000000007, 5m, new DateTime(2022, 8, 30, 15, 5, 34, 861, DateTimeKind.Utc).AddTicks(7835), 7.3647142820276335 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 314.54952581083728, 3, 9.1999999999999993, 28m, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8430), 0.64874006092619285 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 921.47745679263755, 3, 9.0999999999999996, 25m, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8486), 6.3970933074926268 });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Density", "FuelTankId", "Height", "Temperature", "TransactionTime", "Volume" },
                values: new object[] { 672.11698748635581, 3, 9.0, 21m, new DateTime(2022, 8, 30, 15, 5, 34, 862, DateTimeKind.Utc).AddTicks(8494), 8.3835532734381903 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2357), 9.8000000000000007 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2419), 9.6999999999999993 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TransactionTime", "Value" },
                values: new object[] { new DateTime(2022, 8, 30, 15, 5, 34, 857, DateTimeKind.Utc).AddTicks(2424), 9.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4778), 9.5 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4837), 9.4000000000000004 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 2, new DateTime(2022, 8, 30, 15, 5, 34, 858, DateTimeKind.Utc).AddTicks(4843), 9.3000000000000007 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5098), 9.1999999999999993 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5152), 9.0999999999999996 });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FuelTankId", "TransactionTime", "Value" },
                values: new object[] { 3, new DateTime(2022, 8, 30, 15, 5, 34, 859, DateTimeKind.Utc).AddTicks(5157), 9.0 });

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
    }
}
