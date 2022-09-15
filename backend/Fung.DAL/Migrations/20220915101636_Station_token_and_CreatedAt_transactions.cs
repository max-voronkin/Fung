using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class Station_token_and_CreatedAt_transactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Stations",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CeatedAt",
                table: "RemainingTransactions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CeatedAt",
                table: "LevelIndicatorTransactions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "rerum", new DateTime(2022, 9, 15, 10, 16, 35, 865, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "deserunt", new DateTime(2022, 9, 15, 10, 16, 35, 865, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "voluptas", new DateTime(2022, 9, 15, 10, 16, 35, 865, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3039), 987.36023641094766, 29m, new DateTime(2022, 9, 15, 10, 14, 35, 870, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3356), 604.52310974225611, 6m, new DateTime(2022, 9, 15, 10, 13, 35, 870, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3369), 632.54673694225721, 2m, new DateTime(2022, 9, 15, 10, 12, 35, 870, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3378), 520.83931269317497, 28m, new DateTime(2022, 9, 15, 10, 11, 35, 870, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3385), 562.50769909710448, 30m, new DateTime(2022, 9, 15, 10, 10, 35, 870, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3391), 700.77701711758539, 21m, new DateTime(2022, 9, 15, 10, 9, 35, 870, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3397), 479.46401614720071, 30m, new DateTime(2022, 9, 15, 10, 8, 35, 870, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3403), 660.36174305556187, 13m, new DateTime(2022, 9, 15, 10, 7, 35, 870, DateTimeKind.Utc).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3414), 312.27869707881052, 11m, new DateTime(2022, 9, 15, 10, 6, 35, 870, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3420), 268.44556086031832, 6m, new DateTime(2022, 9, 15, 10, 5, 35, 870, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3426), 242.61564902026956, 9m, new DateTime(2022, 9, 15, 10, 4, 35, 870, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3432), 132.85202764983885, 0m, new DateTime(2022, 9, 15, 10, 3, 35, 870, DateTimeKind.Utc).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3438), 508.50104164237388, 29m, new DateTime(2022, 9, 15, 10, 2, 35, 870, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3445), 506.84218846579563, 17m, new DateTime(2022, 9, 15, 10, 1, 35, 870, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3451), 627.96439587898283, 30m, new DateTime(2022, 9, 15, 10, 0, 35, 870, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3457), 256.47286209134467, 28m, new DateTime(2022, 9, 15, 9, 59, 35, 870, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3463), 891.42911496430668, 18m, new DateTime(2022, 9, 15, 9, 58, 35, 870, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3469), 745.68903174151092, 3m, new DateTime(2022, 9, 15, 9, 57, 35, 870, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3475), 930.2916293309479, 23m, new DateTime(2022, 9, 15, 9, 56, 35, 870, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3481), 555.7751456064459, 8m, new DateTime(2022, 9, 15, 9, 55, 35, 870, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3488), 840.80917382636653, 3m, new DateTime(2022, 9, 15, 9, 54, 35, 870, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3494), 340.47284050697789, 28m, new DateTime(2022, 9, 15, 9, 53, 35, 870, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3500), 702.85913166704711, 25m, new DateTime(2022, 9, 15, 9, 52, 35, 870, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3506), 34.756332817137078, 37m, new DateTime(2022, 9, 15, 9, 51, 35, 870, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3512), 217.13952576086416, 2m, new DateTime(2022, 9, 15, 9, 50, 35, 870, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3518), 136.29470992907844, 10m, new DateTime(2022, 9, 15, 9, 49, 35, 870, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3524), 546.09840287586962, 12m, new DateTime(2022, 9, 15, 9, 48, 35, 870, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3530), 26.658148806645965, 4m, new DateTime(2022, 9, 15, 9, 47, 35, 870, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3536), 606.48068072437627, 31m, new DateTime(2022, 9, 15, 9, 46, 35, 870, DateTimeKind.Utc).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3542), 169.33512807461136, 3m, new DateTime(2022, 9, 15, 9, 45, 35, 870, DateTimeKind.Utc).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3548), 119.32774761013843, 9m, new DateTime(2022, 9, 15, 9, 44, 35, 870, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3554), 292.74886498989582, 5m, new DateTime(2022, 9, 15, 9, 43, 35, 870, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3560), 902.35647124534705, 16m, new DateTime(2022, 9, 15, 9, 42, 35, 870, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3567), 962.16284415780444, 6m, new DateTime(2022, 9, 15, 9, 41, 35, 870, DateTimeKind.Utc).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3573), 246.80834939517038, 37m, new DateTime(2022, 9, 15, 9, 40, 35, 870, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3579), 639.11406097635836, 17m, new DateTime(2022, 9, 15, 9, 39, 35, 870, DateTimeKind.Utc).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3585), 194.3542242223314, new DateTime(2022, 9, 15, 9, 38, 35, 870, DateTimeKind.Utc).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3591), 143.96354618961982, 39m, new DateTime(2022, 9, 15, 9, 37, 35, 870, DateTimeKind.Utc).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3597), 781.91901748967405, 27m, new DateTime(2022, 9, 15, 9, 36, 35, 870, DateTimeKind.Utc).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3603), 224.14314163481475, 40m, new DateTime(2022, 9, 15, 9, 35, 35, 870, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3617), 665.98558351509325, 36m, new DateTime(2022, 9, 15, 9, 34, 35, 870, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3623), 326.42333141737123, 19m, new DateTime(2022, 9, 15, 9, 33, 35, 870, DateTimeKind.Utc).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3629), 74.480521529055707, 26m, new DateTime(2022, 9, 15, 9, 32, 35, 870, DateTimeKind.Utc).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3635), 840.58260038853405, 25m, new DateTime(2022, 9, 15, 9, 31, 35, 870, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3641), 256.06773167566433, 19m, new DateTime(2022, 9, 15, 9, 30, 35, 870, DateTimeKind.Utc).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3647), 699.02943484394746, 4m, new DateTime(2022, 9, 15, 9, 29, 35, 870, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3652), 968.27337075770401, 15m, new DateTime(2022, 9, 15, 9, 28, 35, 870, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3658), 166.00005718606403, 18m, new DateTime(2022, 9, 15, 9, 27, 35, 870, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3664), 85.302085983782973, 17m, new DateTime(2022, 9, 15, 9, 26, 35, 870, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3670), 438.78724352503076, 19m, new DateTime(2022, 9, 15, 9, 25, 35, 870, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3676), 665.8508245853501, 32m, new DateTime(2022, 9, 15, 9, 24, 35, 870, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3682), 889.24341625015541, 34m, new DateTime(2022, 9, 15, 9, 23, 35, 870, DateTimeKind.Utc).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3688), 174.04163947501138, 21m, new DateTime(2022, 9, 15, 9, 22, 35, 870, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3694), 646.85103171988703, 35m, new DateTime(2022, 9, 15, 9, 21, 35, 870, DateTimeKind.Utc).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3700), 610.64886862703179, 6m, new DateTime(2022, 9, 15, 9, 20, 35, 870, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3706), 213.18025556476005, 37m, new DateTime(2022, 9, 15, 9, 19, 35, 870, DateTimeKind.Utc).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3712), 854.92744111331638, 13m, new DateTime(2022, 9, 15, 9, 18, 35, 870, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3717), 837.85292240163119, 2m, new DateTime(2022, 9, 15, 9, 17, 35, 870, DateTimeKind.Utc).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3723), 770.30942983499449, 15m, new DateTime(2022, 9, 15, 9, 16, 35, 870, DateTimeKind.Utc).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3729), 693.55872473218108, 33m, new DateTime(2022, 9, 15, 9, 15, 35, 870, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3735), 357.53111491571622, 33m, new DateTime(2022, 9, 15, 9, 14, 35, 870, DateTimeKind.Utc).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3741), 225.25712803550758, 2m, new DateTime(2022, 9, 15, 9, 13, 35, 870, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3747), 222.33305607569542, 36m, new DateTime(2022, 9, 15, 9, 12, 35, 870, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3752), 319.88885106465369, 9m, new DateTime(2022, 9, 15, 9, 11, 35, 870, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3758), 495.15262727861256, 8m, new DateTime(2022, 9, 15, 9, 10, 35, 870, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3764), 913.4711709604278, 23m, new DateTime(2022, 9, 15, 9, 9, 35, 870, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3770), 178.4768366898123, 27m, new DateTime(2022, 9, 15, 9, 8, 35, 870, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3776), 681.89761257325245, 37m, new DateTime(2022, 9, 15, 9, 7, 35, 870, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3782), 81.352060320387778, 18m, new DateTime(2022, 9, 15, 9, 6, 35, 870, DateTimeKind.Utc).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3788), 461.82291470119128, 5m, new DateTime(2022, 9, 15, 9, 5, 35, 870, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3794), 826.97067767671842, 9m, new DateTime(2022, 9, 15, 9, 4, 35, 870, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3800), 60.868214662308958, 14m, new DateTime(2022, 9, 15, 9, 3, 35, 870, DateTimeKind.Utc).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3810), 910.38584642427452, 36m, new DateTime(2022, 9, 15, 9, 2, 35, 870, DateTimeKind.Utc).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3816), 260.67278331777896, 10m, new DateTime(2022, 9, 15, 9, 1, 35, 870, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3822), 67.854868564017906, 20m, new DateTime(2022, 9, 15, 9, 0, 35, 870, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3827), 325.68984973687498, 17m, new DateTime(2022, 9, 15, 8, 59, 35, 870, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3834), 715.55688417107194, 38m, new DateTime(2022, 9, 15, 8, 58, 35, 870, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3840), 847.70383281175441, 30m, new DateTime(2022, 9, 15, 8, 57, 35, 870, DateTimeKind.Utc).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3846), 330.3836322888892, new DateTime(2022, 9, 15, 8, 56, 35, 870, DateTimeKind.Utc).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3852), 662.48667637397193, 10m, new DateTime(2022, 9, 15, 8, 55, 35, 870, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3858), 420.47110805219921, 21m, new DateTime(2022, 9, 15, 8, 54, 35, 870, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3864), 205.12136781957057, 9m, new DateTime(2022, 9, 15, 8, 53, 35, 870, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3870), 847.49226194818823, 39m, new DateTime(2022, 9, 15, 8, 52, 35, 870, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3875), 867.69815537852855, 26m, new DateTime(2022, 9, 15, 8, 51, 35, 870, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3881), 958.11306640262751, 0m, new DateTime(2022, 9, 15, 8, 50, 35, 870, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3887), 728.29345699931582, 25m, new DateTime(2022, 9, 15, 8, 49, 35, 870, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3893), 814.37019475483783, 13m, new DateTime(2022, 9, 15, 8, 48, 35, 870, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3899), 226.64444719683297, 19m, new DateTime(2022, 9, 15, 8, 47, 35, 870, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3905), 35.92083187713191, 39m, new DateTime(2022, 9, 15, 8, 46, 35, 870, DateTimeKind.Utc).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3911), 412.93779923034469, 35m, new DateTime(2022, 9, 15, 8, 45, 35, 870, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3917), 301.58015956661723, 10m, new DateTime(2022, 9, 15, 8, 44, 35, 870, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3923), 442.5743021151286, 21m, new DateTime(2022, 9, 15, 8, 43, 35, 870, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3928), 109.05317693034122, 24m, new DateTime(2022, 9, 15, 8, 42, 35, 870, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3934), 926.01263701713845, 25m, new DateTime(2022, 9, 15, 8, 41, 35, 870, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3940), 753.05626000383427, 16m, new DateTime(2022, 9, 15, 8, 40, 35, 870, DateTimeKind.Utc).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3946), 145.57935142610688, 38m, new DateTime(2022, 9, 15, 8, 39, 35, 870, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3952), 839.47012544990616, 14m, new DateTime(2022, 9, 15, 8, 38, 35, 870, DateTimeKind.Utc).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3957), 973.2566395047711, 0m, new DateTime(2022, 9, 15, 8, 37, 35, 870, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3963), 378.45562120749486, 12m, new DateTime(2022, 9, 15, 8, 36, 35, 870, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3969), 209.67963767808573, 8m, new DateTime(2022, 9, 15, 8, 35, 35, 870, DateTimeKind.Utc).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5322), 818.01844796770536, 6m, new DateTime(2022, 9, 15, 8, 34, 35, 871, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5588), 747.19818719791385, 40m, new DateTime(2022, 9, 15, 8, 33, 35, 871, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5602), 291.65880218317596, 17m, new DateTime(2022, 9, 15, 8, 32, 35, 871, DateTimeKind.Utc).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5610), 786.87952138775609, 33m, new DateTime(2022, 9, 15, 8, 31, 35, 871, DateTimeKind.Utc).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5617), 67.987000906578274, 13m, new DateTime(2022, 9, 15, 8, 30, 35, 871, DateTimeKind.Utc).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5624), 178.77292233695474, 19m, new DateTime(2022, 9, 15, 8, 29, 35, 871, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5630), 271.5604802174654, 1m, new DateTime(2022, 9, 15, 8, 28, 35, 871, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5637), 367.37696509072236, 15m, new DateTime(2022, 9, 15, 8, 27, 35, 871, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5642), 330.89969563228073, 9m, new DateTime(2022, 9, 15, 8, 26, 35, 871, DateTimeKind.Utc).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5648), 724.24742790488767, 32m, new DateTime(2022, 9, 15, 8, 25, 35, 871, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5655), 864.13598629989929, 39m, new DateTime(2022, 9, 15, 8, 24, 35, 871, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5661), 199.30261919345605, 16m, new DateTime(2022, 9, 15, 8, 23, 35, 871, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5667), 426.3626855378406, 10m, new DateTime(2022, 9, 15, 8, 22, 35, 871, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5673), 794.30503752605307, 32m, new DateTime(2022, 9, 15, 8, 21, 35, 871, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5679), 448.39303009139786, 4m, new DateTime(2022, 9, 15, 8, 20, 35, 871, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5685), 382.17883378075715, 33m, new DateTime(2022, 9, 15, 8, 19, 35, 871, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5691), 274.09088462643206, 19m, new DateTime(2022, 9, 15, 8, 18, 35, 871, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5697), 540.419663775559, 28m, new DateTime(2022, 9, 15, 8, 17, 35, 871, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5703), 313.28830387843152, 20m, new DateTime(2022, 9, 15, 8, 16, 35, 871, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5709), 630.78520994552764, 38m, new DateTime(2022, 9, 15, 8, 15, 35, 871, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5715), 421.20568126932454, 31m, new DateTime(2022, 9, 15, 8, 14, 35, 871, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5721), 759.59027458967159, 37m, new DateTime(2022, 9, 15, 8, 13, 35, 871, DateTimeKind.Utc).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5733), 665.30574299902037, 23m, new DateTime(2022, 9, 15, 8, 12, 35, 871, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5740), 17.103861564036205, 12m, new DateTime(2022, 9, 15, 8, 11, 35, 871, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5746), 736.15014335301066, 40m, new DateTime(2022, 9, 15, 8, 10, 35, 871, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5752), 276.00372802649844, 27m, new DateTime(2022, 9, 15, 8, 9, 35, 871, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5758), 278.97856882717878, new DateTime(2022, 9, 15, 8, 8, 35, 871, DateTimeKind.Utc).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5764), 592.04389870677289, 28m, new DateTime(2022, 9, 15, 8, 7, 35, 871, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5770), 992.50433112490202, 5m, new DateTime(2022, 9, 15, 8, 6, 35, 871, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5776), 39.425411081650871, 30m, new DateTime(2022, 9, 15, 8, 5, 35, 871, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5783), 358.11211059334738, 30m, new DateTime(2022, 9, 15, 8, 4, 35, 871, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5789), 604.68198983976959, 18m, new DateTime(2022, 9, 15, 8, 3, 35, 871, DateTimeKind.Utc).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5795), 385.64150159679701, 14m, new DateTime(2022, 9, 15, 8, 2, 35, 871, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5801), 353.88150469817515, 6m, new DateTime(2022, 9, 15, 8, 1, 35, 871, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5807), 77.04730153559413, 7m, new DateTime(2022, 9, 15, 8, 0, 35, 871, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5813), 181.44389268627125, 7m, new DateTime(2022, 9, 15, 7, 59, 35, 871, DateTimeKind.Utc).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5819), 361.13234386217817, 32m, new DateTime(2022, 9, 15, 7, 58, 35, 871, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5825), 684.11070335563545, 8m, new DateTime(2022, 9, 15, 7, 57, 35, 871, DateTimeKind.Utc).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5831), 117.15931325951168, 20m, new DateTime(2022, 9, 15, 7, 56, 35, 871, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5837), 599.90547753693841, 33m, new DateTime(2022, 9, 15, 7, 55, 35, 871, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5843), 254.52016439582513, 24m, new DateTime(2022, 9, 15, 7, 54, 35, 871, DateTimeKind.Utc).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5849), 900.76692755614908, 8m, new DateTime(2022, 9, 15, 7, 53, 35, 871, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5855), 117.18660373155754, 18m, new DateTime(2022, 9, 15, 7, 52, 35, 871, DateTimeKind.Utc).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5862), 79.618090390717882, 28m, new DateTime(2022, 9, 15, 7, 51, 35, 871, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5867), 627.26012452316922, 18m, new DateTime(2022, 9, 15, 7, 50, 35, 871, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5873), 814.62959349190555, 6m, new DateTime(2022, 9, 15, 7, 49, 35, 871, DateTimeKind.Utc).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5879), 701.38294576636144, 26m, new DateTime(2022, 9, 15, 7, 48, 35, 871, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5885), 35.005619471369819, 24m, new DateTime(2022, 9, 15, 7, 47, 35, 871, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5891), 188.1740666752857, 17m, new DateTime(2022, 9, 15, 7, 46, 35, 871, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5897), 50.512095821511508, 10m, new DateTime(2022, 9, 15, 7, 45, 35, 871, DateTimeKind.Utc).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5903), 739.46407844046769, 36m, new DateTime(2022, 9, 15, 7, 44, 35, 871, DateTimeKind.Utc).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5909), 0.44235670948944428, 9m, new DateTime(2022, 9, 15, 7, 43, 35, 871, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5915), 736.12099194158429, 21m, new DateTime(2022, 9, 15, 7, 42, 35, 871, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5921), 682.43104239581533, 25m, new DateTime(2022, 9, 15, 7, 41, 35, 871, DateTimeKind.Utc).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5931), 251.44711959743648, 32m, new DateTime(2022, 9, 15, 7, 40, 35, 871, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5937), 284.97682455135754, 19m, new DateTime(2022, 9, 15, 7, 39, 35, 871, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5943), 696.54149221175021, 37m, new DateTime(2022, 9, 15, 7, 38, 35, 871, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5949), 602.73061441293737, 22m, new DateTime(2022, 9, 15, 7, 37, 35, 871, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5955), 259.08215413281653, 22m, new DateTime(2022, 9, 15, 7, 36, 35, 871, DateTimeKind.Utc).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5961), 532.72483576310117, 22m, new DateTime(2022, 9, 15, 7, 35, 35, 871, DateTimeKind.Utc).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5967), 246.03503939952475, 21m, new DateTime(2022, 9, 15, 7, 34, 35, 871, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5972), 958.03071430237821, 32m, new DateTime(2022, 9, 15, 7, 33, 35, 871, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5978), 948.70786112693884, 17m, new DateTime(2022, 9, 15, 7, 32, 35, 871, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5984), 377.09548171459096, 22m, new DateTime(2022, 9, 15, 7, 31, 35, 871, DateTimeKind.Utc).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5990), 916.17456222010662, 12m, new DateTime(2022, 9, 15, 7, 30, 35, 871, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5996), 555.81794756002262, 21m, new DateTime(2022, 9, 15, 7, 29, 35, 871, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6002), 196.13915230772062, 14m, new DateTime(2022, 9, 15, 7, 28, 35, 871, DateTimeKind.Utc).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6009), 606.88464063134984, 10m, new DateTime(2022, 9, 15, 7, 27, 35, 871, DateTimeKind.Utc).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6014), 667.17491292193233, 22m, new DateTime(2022, 9, 15, 7, 26, 35, 871, DateTimeKind.Utc).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6020), 889.2688263166109, 10m, new DateTime(2022, 9, 15, 7, 25, 35, 871, DateTimeKind.Utc).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6026), 186.66609594188398, 29m, new DateTime(2022, 9, 15, 7, 24, 35, 871, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6032), 22.438210492032429, 40m, new DateTime(2022, 9, 15, 7, 23, 35, 871, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6038), 156.21441755216881, 20m, new DateTime(2022, 9, 15, 7, 22, 35, 871, DateTimeKind.Utc).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6044), 636.30993998468296, 32m, new DateTime(2022, 9, 15, 7, 21, 35, 871, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6050), 607.47913094592025, 23m, new DateTime(2022, 9, 15, 7, 20, 35, 871, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6056), 619.54497444612184, 25m, new DateTime(2022, 9, 15, 7, 19, 35, 871, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6062), 210.55790534732921, 12m, new DateTime(2022, 9, 15, 7, 18, 35, 871, DateTimeKind.Utc).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6068), 656.29426030451566, 23m, new DateTime(2022, 9, 15, 7, 17, 35, 871, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6074), 69.008541708924128, 30m, new DateTime(2022, 9, 15, 7, 16, 35, 871, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6079), 497.40701318100309, 10m, new DateTime(2022, 9, 15, 7, 15, 35, 871, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6085), 449.16889043073962, 23m, new DateTime(2022, 9, 15, 7, 14, 35, 871, DateTimeKind.Utc).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6091), 698.44815447242968, 5m, new DateTime(2022, 9, 15, 7, 13, 35, 871, DateTimeKind.Utc).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6097), 880.14992563797045, 15m, new DateTime(2022, 9, 15, 7, 12, 35, 871, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6103), 552.94757384224579, 6m, new DateTime(2022, 9, 15, 7, 11, 35, 871, DateTimeKind.Utc).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6109), 115.94144295909526, 29m, new DateTime(2022, 9, 15, 7, 10, 35, 871, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6115), 605.41426311010503, 38m, new DateTime(2022, 9, 15, 7, 9, 35, 871, DateTimeKind.Utc).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6127), 772.80841677935507, 17m, new DateTime(2022, 9, 15, 7, 8, 35, 871, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6133), 852.74762984334461, 14m, new DateTime(2022, 9, 15, 7, 7, 35, 871, DateTimeKind.Utc).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6139), 27.988603487487108, 32m, new DateTime(2022, 9, 15, 7, 6, 35, 871, DateTimeKind.Utc).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6146), 830.06769280895526, 12m, new DateTime(2022, 9, 15, 7, 5, 35, 871, DateTimeKind.Utc).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6151), 396.72758878119129, 19m, new DateTime(2022, 9, 15, 7, 4, 35, 871, DateTimeKind.Utc).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6158), 876.97931485861295, 5m, new DateTime(2022, 9, 15, 7, 3, 35, 871, DateTimeKind.Utc).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6163), 971.07110426855888, 15m, new DateTime(2022, 9, 15, 7, 2, 35, 871, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6169), 940.1390408216032, 13m, new DateTime(2022, 9, 15, 7, 1, 35, 871, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6175), 952.12955838056348, 17m, new DateTime(2022, 9, 15, 7, 0, 35, 871, DateTimeKind.Utc).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6181), 913.27242836188623, 4m, new DateTime(2022, 9, 15, 6, 59, 35, 871, DateTimeKind.Utc).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6187), 358.47494437118974, 25m, new DateTime(2022, 9, 15, 6, 58, 35, 871, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6193), 571.45529988446515, 5m, new DateTime(2022, 9, 15, 6, 57, 35, 871, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6199), 391.12456881305889, 37m, new DateTime(2022, 9, 15, 6, 56, 35, 871, DateTimeKind.Utc).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(6205), 193.53044244749506, 20m, new DateTime(2022, 9, 15, 6, 55, 35, 871, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8177), 41.837453704781758, 7m, new DateTime(2022, 9, 15, 6, 54, 35, 872, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8470), 24.699574554602364, 21m, new DateTime(2022, 9, 15, 6, 53, 35, 872, DateTimeKind.Utc).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8485), 767.02497602867209, 5m, new DateTime(2022, 9, 15, 6, 52, 35, 872, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8494), 707.79835716206844, 2m, new DateTime(2022, 9, 15, 6, 51, 35, 872, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8501), 880.49703528127509, 9m, new DateTime(2022, 9, 15, 6, 50, 35, 872, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8509), 609.61258853760035, 6m, new DateTime(2022, 9, 15, 6, 49, 35, 872, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8514), 962.55597750833965, 25m, new DateTime(2022, 9, 15, 6, 48, 35, 872, DateTimeKind.Utc).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8521), 270.56478727401367, 8m, new DateTime(2022, 9, 15, 6, 47, 35, 872, DateTimeKind.Utc).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8527), 732.74237661640609, 5m, new DateTime(2022, 9, 15, 6, 46, 35, 872, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8533), 21.88666028312991, 29m, new DateTime(2022, 9, 15, 6, 45, 35, 872, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8539), 540.10582849551827, 28m, new DateTime(2022, 9, 15, 6, 44, 35, 872, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8545), 494.23026555937042, 33m, new DateTime(2022, 9, 15, 6, 43, 35, 872, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8551), 274.04201045653195, 22m, new DateTime(2022, 9, 15, 6, 42, 35, 872, DateTimeKind.Utc).AddTicks(8555) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8557), 70.893836482373132, 33m, new DateTime(2022, 9, 15, 6, 41, 35, 872, DateTimeKind.Utc).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8563), 684.38525166422608, 23m, new DateTime(2022, 9, 15, 6, 40, 35, 872, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8569), 445.649915052751, 18m, new DateTime(2022, 9, 15, 6, 39, 35, 872, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8575), 627.94395455218501, 9m, new DateTime(2022, 9, 15, 6, 38, 35, 872, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8581), 74.506279951172317, 22m, new DateTime(2022, 9, 15, 6, 37, 35, 872, DateTimeKind.Utc).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8587), 136.42452944965987, 7m, new DateTime(2022, 9, 15, 6, 36, 35, 872, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8593), 113.36156707364486, 39m, new DateTime(2022, 9, 15, 6, 35, 35, 872, DateTimeKind.Utc).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8599), 412.00006175217976, 1m, new DateTime(2022, 9, 15, 6, 34, 35, 872, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8604), 7.928438364858903, 21m, new DateTime(2022, 9, 15, 6, 33, 35, 872, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8611), 394.58586660137973, 25m, new DateTime(2022, 9, 15, 6, 32, 35, 872, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8616), 114.06443700795855, 24m, new DateTime(2022, 9, 15, 6, 31, 35, 872, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8622), 927.5126774626309, 18m, new DateTime(2022, 9, 15, 6, 30, 35, 872, DateTimeKind.Utc).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8628), 40.692750166469452, 2m, new DateTime(2022, 9, 15, 6, 29, 35, 872, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8634), 31.06385736483297, 14m, new DateTime(2022, 9, 15, 6, 28, 35, 872, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8640), 209.83635496689013, 11m, new DateTime(2022, 9, 15, 6, 27, 35, 872, DateTimeKind.Utc).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8646), 560.62839723407262, 9m, new DateTime(2022, 9, 15, 6, 26, 35, 872, DateTimeKind.Utc).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8652), 384.91761434344409, 16m, new DateTime(2022, 9, 15, 6, 25, 35, 872, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8658), 824.8316863462336, 1m, new DateTime(2022, 9, 15, 6, 24, 35, 872, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8664), 445.04026935751693, new DateTime(2022, 9, 15, 6, 23, 35, 872, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8669), 426.35989274333895, 33m, new DateTime(2022, 9, 15, 6, 22, 35, 872, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8680), 863.13332593262828, 0m, new DateTime(2022, 9, 15, 6, 21, 35, 872, DateTimeKind.Utc).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8686), 980.1912446307997, 6m, new DateTime(2022, 9, 15, 6, 20, 35, 872, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8692), 596.10425587333407, 38m, new DateTime(2022, 9, 15, 6, 19, 35, 872, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8698), 68.838207017243747, 35m, new DateTime(2022, 9, 15, 6, 18, 35, 872, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8704), 884.54692384350346, 4m, new DateTime(2022, 9, 15, 6, 17, 35, 872, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8710), 805.42926081457654, 13m, new DateTime(2022, 9, 15, 6, 16, 35, 872, DateTimeKind.Utc).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8716), 210.12570101551054, 1m, new DateTime(2022, 9, 15, 6, 15, 35, 872, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8722), 557.7366693750738, 19m, new DateTime(2022, 9, 15, 6, 14, 35, 872, DateTimeKind.Utc).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8727), 743.90501156176231, 18m, new DateTime(2022, 9, 15, 6, 13, 35, 872, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8733), 535.4446873201731, 18m, new DateTime(2022, 9, 15, 6, 12, 35, 872, DateTimeKind.Utc).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8739), 803.65936554766301, 16m, new DateTime(2022, 9, 15, 6, 11, 35, 872, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8745), 817.76736627782384, 1m, new DateTime(2022, 9, 15, 6, 10, 35, 872, DateTimeKind.Utc).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8751), 857.49395756639694, 35m, new DateTime(2022, 9, 15, 6, 9, 35, 872, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8757), 230.19923193640446, 6m, new DateTime(2022, 9, 15, 6, 8, 35, 872, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8762), 328.43053626163334, 12m, new DateTime(2022, 9, 15, 6, 7, 35, 872, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8768), 348.46635582316543, 16m, new DateTime(2022, 9, 15, 6, 6, 35, 872, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8774), 60.430277018606702, 31m, new DateTime(2022, 9, 15, 6, 5, 35, 872, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8780), 858.37109768749508, 4m, new DateTime(2022, 9, 15, 6, 4, 35, 872, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8785), 981.02376069329159, 9m, new DateTime(2022, 9, 15, 6, 3, 35, 872, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8791), 546.36201980170392, 26m, new DateTime(2022, 9, 15, 6, 2, 35, 872, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8797), 160.79472191267297, 5m, new DateTime(2022, 9, 15, 6, 1, 35, 872, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8803), 3.1619096299757565, 37m, new DateTime(2022, 9, 15, 6, 0, 35, 872, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8808), 875.94684540684273, 16m, new DateTime(2022, 9, 15, 5, 59, 35, 872, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8814), 145.90525350284511, 29m, new DateTime(2022, 9, 15, 5, 58, 35, 872, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8820), 210.58778100350395, 18m, new DateTime(2022, 9, 15, 5, 57, 35, 872, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8826), 284.24779172846905, 16m, new DateTime(2022, 9, 15, 5, 56, 35, 872, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8832), 352.04431861313924, 14m, new DateTime(2022, 9, 15, 5, 55, 35, 872, DateTimeKind.Utc).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8838), 561.47659725590211, 34m, new DateTime(2022, 9, 15, 5, 54, 35, 872, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8844), 243.06417131428461, 17m, new DateTime(2022, 9, 15, 5, 53, 35, 872, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8849), 192.04657147411197, new DateTime(2022, 9, 15, 5, 52, 35, 872, DateTimeKind.Utc).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8855), 216.52627009950544, 17m, new DateTime(2022, 9, 15, 5, 51, 35, 872, DateTimeKind.Utc).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8861), 36.607573647535084, 30m, new DateTime(2022, 9, 15, 5, 50, 35, 872, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8871), 330.87863088122913, 26m, new DateTime(2022, 9, 15, 5, 49, 35, 872, DateTimeKind.Utc).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8877), 585.04328281277071, 23m, new DateTime(2022, 9, 15, 5, 48, 35, 872, DateTimeKind.Utc).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8883), 765.78092028870174, 2m, new DateTime(2022, 9, 15, 5, 47, 35, 872, DateTimeKind.Utc).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8889), 403.58267257058378, 18m, new DateTime(2022, 9, 15, 5, 46, 35, 872, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8894), 98.807893139638111, 29m, new DateTime(2022, 9, 15, 5, 45, 35, 872, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8900), 544.50765627575004, 10m, new DateTime(2022, 9, 15, 5, 44, 35, 872, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8906), 368.24875672400248, 28m, new DateTime(2022, 9, 15, 5, 43, 35, 872, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8912), 771.44936236296803, 29m, new DateTime(2022, 9, 15, 5, 42, 35, 872, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8918), 897.10016242550489, 26m, new DateTime(2022, 9, 15, 5, 41, 35, 872, DateTimeKind.Utc).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8924), 381.80083661676679, 21m, new DateTime(2022, 9, 15, 5, 40, 35, 872, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8930), 702.6458829213642, 7m, new DateTime(2022, 9, 15, 5, 39, 35, 872, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8935), 294.6739164897246, 18m, new DateTime(2022, 9, 15, 5, 38, 35, 872, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8941), 557.0606765920478, 16m, new DateTime(2022, 9, 15, 5, 37, 35, 872, DateTimeKind.Utc).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8947), 823.04308302060895, 18m, new DateTime(2022, 9, 15, 5, 36, 35, 872, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8953), 40.649742318045526, 7m, new DateTime(2022, 9, 15, 5, 35, 35, 872, DateTimeKind.Utc).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8959), 420.57761216932056, 31m, new DateTime(2022, 9, 15, 5, 34, 35, 872, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8965), 796.00819400758701, 12m, new DateTime(2022, 9, 15, 5, 33, 35, 872, DateTimeKind.Utc).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8970), 691.33898312311953, 22m, new DateTime(2022, 9, 15, 5, 32, 35, 872, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8976), 556.7279031890929, 15m, new DateTime(2022, 9, 15, 5, 31, 35, 872, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8982), 976.36152443957587, 7m, new DateTime(2022, 9, 15, 5, 30, 35, 872, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8988), 322.88698139241825, 27m, new DateTime(2022, 9, 15, 5, 29, 35, 872, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8994), 96.833772413461361, 25m, new DateTime(2022, 9, 15, 5, 28, 35, 872, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9000), 475.90500746622564, 15m, new DateTime(2022, 9, 15, 5, 27, 35, 872, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9006), 238.92455641576515, 21m, new DateTime(2022, 9, 15, 5, 26, 35, 872, DateTimeKind.Utc).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9011), 431.84461562515742, 38m, new DateTime(2022, 9, 15, 5, 25, 35, 872, DateTimeKind.Utc).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9017), 385.14570574680539, 25m, new DateTime(2022, 9, 15, 5, 24, 35, 872, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9023), 878.65408271265164, 3m, new DateTime(2022, 9, 15, 5, 23, 35, 872, DateTimeKind.Utc).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9029), 509.13959126170028, 33m, new DateTime(2022, 9, 15, 5, 22, 35, 872, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9034), 32.100119469670283, 21m, new DateTime(2022, 9, 15, 5, 21, 35, 872, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9040), 268.51557150675808, 7m, new DateTime(2022, 9, 15, 5, 20, 35, 872, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9046), 331.14875144218979, 11m, new DateTime(2022, 9, 15, 5, 19, 35, 872, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9052), 166.93050858879033, 23m, new DateTime(2022, 9, 15, 5, 18, 35, 872, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9062), 11.982610013650529, 30m, new DateTime(2022, 9, 15, 5, 17, 35, 872, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9068), 310.09925848624988, 34m, new DateTime(2022, 9, 15, 5, 16, 35, 872, DateTimeKind.Utc).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(9074), 505.45399642927333, 19m, new DateTime(2022, 9, 15, 5, 15, 35, 872, DateTimeKind.Utc).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8236), new DateTime(2022, 9, 15, 10, 14, 35, 866, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8412), new DateTime(2022, 9, 15, 10, 13, 35, 866, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8421), new DateTime(2022, 9, 15, 10, 12, 35, 866, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8425), new DateTime(2022, 9, 15, 10, 11, 35, 866, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8430), new DateTime(2022, 9, 15, 10, 10, 35, 866, DateTimeKind.Utc).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8434), new DateTime(2022, 9, 15, 10, 9, 35, 866, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8438), new DateTime(2022, 9, 15, 10, 8, 35, 866, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8442), new DateTime(2022, 9, 15, 10, 7, 35, 866, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8446), new DateTime(2022, 9, 15, 10, 6, 35, 866, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8450), new DateTime(2022, 9, 15, 10, 5, 35, 866, DateTimeKind.Utc).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8454), new DateTime(2022, 9, 15, 10, 4, 35, 866, DateTimeKind.Utc).AddTicks(8456) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8458), new DateTime(2022, 9, 15, 10, 3, 35, 866, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8462), new DateTime(2022, 9, 15, 10, 2, 35, 866, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8466), new DateTime(2022, 9, 15, 10, 1, 35, 866, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8470), new DateTime(2022, 9, 15, 10, 0, 35, 866, DateTimeKind.Utc).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8474), new DateTime(2022, 9, 15, 9, 59, 35, 866, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8477), new DateTime(2022, 9, 15, 9, 58, 35, 866, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8481), new DateTime(2022, 9, 15, 9, 57, 35, 866, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8485), new DateTime(2022, 9, 15, 9, 56, 35, 866, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8489), new DateTime(2022, 9, 15, 9, 55, 35, 866, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8492), new DateTime(2022, 9, 15, 9, 54, 35, 866, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8496), new DateTime(2022, 9, 15, 9, 53, 35, 866, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8500), new DateTime(2022, 9, 15, 9, 52, 35, 866, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8504), new DateTime(2022, 9, 15, 9, 51, 35, 866, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8508), new DateTime(2022, 9, 15, 9, 50, 35, 866, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8512), new DateTime(2022, 9, 15, 9, 49, 35, 866, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8515), new DateTime(2022, 9, 15, 9, 48, 35, 866, DateTimeKind.Utc).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8519), new DateTime(2022, 9, 15, 9, 47, 35, 866, DateTimeKind.Utc).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8528), new DateTime(2022, 9, 15, 9, 46, 35, 866, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8532), new DateTime(2022, 9, 15, 9, 45, 35, 866, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8536), new DateTime(2022, 9, 15, 9, 44, 35, 866, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8539), new DateTime(2022, 9, 15, 9, 43, 35, 866, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8543), new DateTime(2022, 9, 15, 9, 42, 35, 866, DateTimeKind.Utc).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8547), new DateTime(2022, 9, 15, 9, 41, 35, 866, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8551), new DateTime(2022, 9, 15, 9, 40, 35, 866, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8555), new DateTime(2022, 9, 15, 9, 39, 35, 866, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8558), new DateTime(2022, 9, 15, 9, 38, 35, 866, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8562), new DateTime(2022, 9, 15, 9, 37, 35, 866, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8566), new DateTime(2022, 9, 15, 9, 36, 35, 866, DateTimeKind.Utc).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8570), new DateTime(2022, 9, 15, 9, 35, 35, 866, DateTimeKind.Utc).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8574), new DateTime(2022, 9, 15, 9, 34, 35, 866, DateTimeKind.Utc).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8577), new DateTime(2022, 9, 15, 9, 33, 35, 866, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8581), new DateTime(2022, 9, 15, 9, 32, 35, 866, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8585), new DateTime(2022, 9, 15, 9, 31, 35, 866, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8589), new DateTime(2022, 9, 15, 9, 30, 35, 866, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8592), new DateTime(2022, 9, 15, 9, 29, 35, 866, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8596), new DateTime(2022, 9, 15, 9, 28, 35, 866, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8600), new DateTime(2022, 9, 15, 9, 27, 35, 866, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8604), new DateTime(2022, 9, 15, 9, 26, 35, 866, DateTimeKind.Utc).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8608), new DateTime(2022, 9, 15, 9, 25, 35, 866, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8611), new DateTime(2022, 9, 15, 9, 24, 35, 866, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8615), new DateTime(2022, 9, 15, 9, 23, 35, 866, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8619), new DateTime(2022, 9, 15, 9, 22, 35, 866, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8623), new DateTime(2022, 9, 15, 9, 21, 35, 866, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8627), new DateTime(2022, 9, 15, 9, 20, 35, 866, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8630), new DateTime(2022, 9, 15, 9, 19, 35, 866, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8634), new DateTime(2022, 9, 15, 9, 18, 35, 866, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8638), new DateTime(2022, 9, 15, 9, 17, 35, 866, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8642), new DateTime(2022, 9, 15, 9, 16, 35, 866, DateTimeKind.Utc).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8646), new DateTime(2022, 9, 15, 9, 15, 35, 866, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8649), new DateTime(2022, 9, 15, 9, 14, 35, 866, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8653), new DateTime(2022, 9, 15, 9, 13, 35, 866, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8657), new DateTime(2022, 9, 15, 9, 12, 35, 866, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8661), new DateTime(2022, 9, 15, 9, 11, 35, 866, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8665), new DateTime(2022, 9, 15, 9, 10, 35, 866, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8669), new DateTime(2022, 9, 15, 9, 9, 35, 866, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8672), new DateTime(2022, 9, 15, 9, 8, 35, 866, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8676), new DateTime(2022, 9, 15, 9, 7, 35, 866, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8680), new DateTime(2022, 9, 15, 9, 6, 35, 866, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8684), new DateTime(2022, 9, 15, 9, 5, 35, 866, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8687), new DateTime(2022, 9, 15, 9, 4, 35, 866, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8691), new DateTime(2022, 9, 15, 9, 3, 35, 866, DateTimeKind.Utc).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8695), new DateTime(2022, 9, 15, 9, 2, 35, 866, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8699), new DateTime(2022, 9, 15, 9, 1, 35, 866, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8702), new DateTime(2022, 9, 15, 9, 0, 35, 866, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8706), new DateTime(2022, 9, 15, 8, 59, 35, 866, DateTimeKind.Utc).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8710), new DateTime(2022, 9, 15, 8, 58, 35, 866, DateTimeKind.Utc).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8714), new DateTime(2022, 9, 15, 8, 57, 35, 866, DateTimeKind.Utc).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8718), new DateTime(2022, 9, 15, 8, 56, 35, 866, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8722), new DateTime(2022, 9, 15, 8, 55, 35, 866, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8725), new DateTime(2022, 9, 15, 8, 54, 35, 866, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8729), new DateTime(2022, 9, 15, 8, 53, 35, 866, DateTimeKind.Utc).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8733), new DateTime(2022, 9, 15, 8, 52, 35, 866, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8737), new DateTime(2022, 9, 15, 8, 51, 35, 866, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8741), new DateTime(2022, 9, 15, 8, 50, 35, 866, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8749), new DateTime(2022, 9, 15, 8, 49, 35, 866, DateTimeKind.Utc).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8753), new DateTime(2022, 9, 15, 8, 48, 35, 866, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8756), new DateTime(2022, 9, 15, 8, 47, 35, 866, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8760), new DateTime(2022, 9, 15, 8, 46, 35, 866, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8764), new DateTime(2022, 9, 15, 8, 45, 35, 866, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8768), new DateTime(2022, 9, 15, 8, 44, 35, 866, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8772), new DateTime(2022, 9, 15, 8, 43, 35, 866, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8776), new DateTime(2022, 9, 15, 8, 42, 35, 866, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8779), new DateTime(2022, 9, 15, 8, 41, 35, 866, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8783), new DateTime(2022, 9, 15, 8, 40, 35, 866, DateTimeKind.Utc).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8787), new DateTime(2022, 9, 15, 8, 39, 35, 866, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8791), new DateTime(2022, 9, 15, 8, 38, 35, 866, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8794), new DateTime(2022, 9, 15, 8, 37, 35, 866, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8798), new DateTime(2022, 9, 15, 8, 36, 35, 866, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 866, DateTimeKind.Utc).AddTicks(8802), new DateTime(2022, 9, 15, 8, 35, 35, 866, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9718), new DateTime(2022, 9, 15, 8, 34, 35, 867, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9884), new DateTime(2022, 9, 15, 8, 33, 35, 867, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9892), new DateTime(2022, 9, 15, 8, 32, 35, 867, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9896), new DateTime(2022, 9, 15, 8, 31, 35, 867, DateTimeKind.Utc).AddTicks(9898) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9900), new DateTime(2022, 9, 15, 8, 30, 35, 867, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9904), new DateTime(2022, 9, 15, 8, 29, 35, 867, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9908), new DateTime(2022, 9, 15, 8, 28, 35, 867, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9912), new DateTime(2022, 9, 15, 8, 27, 35, 867, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9916), new DateTime(2022, 9, 15, 8, 26, 35, 867, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9920), new DateTime(2022, 9, 15, 8, 25, 35, 867, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9924), new DateTime(2022, 9, 15, 8, 24, 35, 867, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9933), new DateTime(2022, 9, 15, 8, 23, 35, 867, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9938), new DateTime(2022, 9, 15, 8, 22, 35, 867, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9942), new DateTime(2022, 9, 15, 8, 21, 35, 867, DateTimeKind.Utc).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9946), new DateTime(2022, 9, 15, 8, 20, 35, 867, DateTimeKind.Utc).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9950), new DateTime(2022, 9, 15, 8, 19, 35, 867, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9953), new DateTime(2022, 9, 15, 8, 18, 35, 867, DateTimeKind.Utc).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9957), new DateTime(2022, 9, 15, 8, 17, 35, 867, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9961), new DateTime(2022, 9, 15, 8, 16, 35, 867, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9965), new DateTime(2022, 9, 15, 8, 15, 35, 867, DateTimeKind.Utc).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9969), new DateTime(2022, 9, 15, 8, 14, 35, 867, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9972), new DateTime(2022, 9, 15, 8, 13, 35, 867, DateTimeKind.Utc).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9976), new DateTime(2022, 9, 15, 8, 12, 35, 867, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9980), new DateTime(2022, 9, 15, 8, 11, 35, 867, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9984), new DateTime(2022, 9, 15, 8, 10, 35, 867, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9987), new DateTime(2022, 9, 15, 8, 9, 35, 867, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9991), new DateTime(2022, 9, 15, 8, 8, 35, 867, DateTimeKind.Utc).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9995), new DateTime(2022, 9, 15, 8, 7, 35, 867, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 867, DateTimeKind.Utc).AddTicks(9999), new DateTime(2022, 9, 15, 8, 6, 35, 868, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(2), new DateTime(2022, 9, 15, 8, 5, 35, 868, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(6), new DateTime(2022, 9, 15, 8, 4, 35, 868, DateTimeKind.Utc).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(10), new DateTime(2022, 9, 15, 8, 3, 35, 868, DateTimeKind.Utc).AddTicks(11) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(13), new DateTime(2022, 9, 15, 8, 2, 35, 868, DateTimeKind.Utc).AddTicks(15) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(17), new DateTime(2022, 9, 15, 8, 1, 35, 868, DateTimeKind.Utc).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(21), new DateTime(2022, 9, 15, 8, 0, 35, 868, DateTimeKind.Utc).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(25), new DateTime(2022, 9, 15, 7, 59, 35, 868, DateTimeKind.Utc).AddTicks(26) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(28), new DateTime(2022, 9, 15, 7, 58, 35, 868, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(32), new DateTime(2022, 9, 15, 7, 57, 35, 868, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(36), new DateTime(2022, 9, 15, 7, 56, 35, 868, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(39), new DateTime(2022, 9, 15, 7, 55, 35, 868, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(43), new DateTime(2022, 9, 15, 7, 54, 35, 868, DateTimeKind.Utc).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(47), new DateTime(2022, 9, 15, 7, 53, 35, 868, DateTimeKind.Utc).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(51), new DateTime(2022, 9, 15, 7, 52, 35, 868, DateTimeKind.Utc).AddTicks(52) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(54), new DateTime(2022, 9, 15, 7, 51, 35, 868, DateTimeKind.Utc).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(58), new DateTime(2022, 9, 15, 7, 50, 35, 868, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(62), new DateTime(2022, 9, 15, 7, 49, 35, 868, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(66), new DateTime(2022, 9, 15, 7, 48, 35, 868, DateTimeKind.Utc).AddTicks(68) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(70), new DateTime(2022, 9, 15, 7, 47, 35, 868, DateTimeKind.Utc).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(73), new DateTime(2022, 9, 15, 7, 46, 35, 868, DateTimeKind.Utc).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(77), new DateTime(2022, 9, 15, 7, 45, 35, 868, DateTimeKind.Utc).AddTicks(79) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(81), new DateTime(2022, 9, 15, 7, 44, 35, 868, DateTimeKind.Utc).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(85), new DateTime(2022, 9, 15, 7, 43, 35, 868, DateTimeKind.Utc).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(89), new DateTime(2022, 9, 15, 7, 42, 35, 868, DateTimeKind.Utc).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(92), new DateTime(2022, 9, 15, 7, 41, 35, 868, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(96), new DateTime(2022, 9, 15, 7, 40, 35, 868, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(100), new DateTime(2022, 9, 15, 7, 39, 35, 868, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(104), new DateTime(2022, 9, 15, 7, 38, 35, 868, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(107), new DateTime(2022, 9, 15, 7, 37, 35, 868, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(111), new DateTime(2022, 9, 15, 7, 36, 35, 868, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(115), new DateTime(2022, 9, 15, 7, 35, 35, 868, DateTimeKind.Utc).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(118), new DateTime(2022, 9, 15, 7, 34, 35, 868, DateTimeKind.Utc).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(122), new DateTime(2022, 9, 15, 7, 33, 35, 868, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(126), new DateTime(2022, 9, 15, 7, 32, 35, 868, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(130), new DateTime(2022, 9, 15, 7, 31, 35, 868, DateTimeKind.Utc).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(133), new DateTime(2022, 9, 15, 7, 30, 35, 868, DateTimeKind.Utc).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(137), new DateTime(2022, 9, 15, 7, 29, 35, 868, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(141), new DateTime(2022, 9, 15, 7, 28, 35, 868, DateTimeKind.Utc).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(145), new DateTime(2022, 9, 15, 7, 27, 35, 868, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(153), new DateTime(2022, 9, 15, 7, 26, 35, 868, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(157), new DateTime(2022, 9, 15, 7, 25, 35, 868, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(160), new DateTime(2022, 9, 15, 7, 24, 35, 868, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(164), new DateTime(2022, 9, 15, 7, 23, 35, 868, DateTimeKind.Utc).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(168), new DateTime(2022, 9, 15, 7, 22, 35, 868, DateTimeKind.Utc).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(172), new DateTime(2022, 9, 15, 7, 21, 35, 868, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(175), new DateTime(2022, 9, 15, 7, 20, 35, 868, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(179), new DateTime(2022, 9, 15, 7, 19, 35, 868, DateTimeKind.Utc).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(183), new DateTime(2022, 9, 15, 7, 18, 35, 868, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(187), new DateTime(2022, 9, 15, 7, 17, 35, 868, DateTimeKind.Utc).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(190), new DateTime(2022, 9, 15, 7, 16, 35, 868, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(194), new DateTime(2022, 9, 15, 7, 15, 35, 868, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(198), new DateTime(2022, 9, 15, 7, 14, 35, 868, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(202), new DateTime(2022, 9, 15, 7, 13, 35, 868, DateTimeKind.Utc).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(205), new DateTime(2022, 9, 15, 7, 12, 35, 868, DateTimeKind.Utc).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(209), new DateTime(2022, 9, 15, 7, 11, 35, 868, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(213), new DateTime(2022, 9, 15, 7, 10, 35, 868, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(217), new DateTime(2022, 9, 15, 7, 9, 35, 868, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(220), new DateTime(2022, 9, 15, 7, 8, 35, 868, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(224), new DateTime(2022, 9, 15, 7, 7, 35, 868, DateTimeKind.Utc).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(228), new DateTime(2022, 9, 15, 7, 6, 35, 868, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(232), new DateTime(2022, 9, 15, 7, 5, 35, 868, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(236), new DateTime(2022, 9, 15, 7, 4, 35, 868, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(240), new DateTime(2022, 9, 15, 7, 3, 35, 868, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(243), new DateTime(2022, 9, 15, 7, 2, 35, 868, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(247), new DateTime(2022, 9, 15, 7, 1, 35, 868, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(251), new DateTime(2022, 9, 15, 7, 0, 35, 868, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(255), new DateTime(2022, 9, 15, 6, 59, 35, 868, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(258), new DateTime(2022, 9, 15, 6, 58, 35, 868, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(262), new DateTime(2022, 9, 15, 6, 57, 35, 868, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(266), new DateTime(2022, 9, 15, 6, 56, 35, 868, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 868, DateTimeKind.Utc).AddTicks(269), new DateTime(2022, 9, 15, 6, 55, 35, 868, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1120), new DateTime(2022, 9, 15, 6, 54, 35, 869, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1290), new DateTime(2022, 9, 15, 6, 53, 35, 869, DateTimeKind.Utc).AddTicks(1294) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1298), new DateTime(2022, 9, 15, 6, 52, 35, 869, DateTimeKind.Utc).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1303), new DateTime(2022, 9, 15, 6, 51, 35, 869, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1307), new DateTime(2022, 9, 15, 6, 50, 35, 869, DateTimeKind.Utc).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1311), new DateTime(2022, 9, 15, 6, 49, 35, 869, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1315), new DateTime(2022, 9, 15, 6, 48, 35, 869, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1319), new DateTime(2022, 9, 15, 6, 47, 35, 869, DateTimeKind.Utc).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1323), new DateTime(2022, 9, 15, 6, 46, 35, 869, DateTimeKind.Utc).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1326), new DateTime(2022, 9, 15, 6, 45, 35, 869, DateTimeKind.Utc).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1330), new DateTime(2022, 9, 15, 6, 44, 35, 869, DateTimeKind.Utc).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1334), new DateTime(2022, 9, 15, 6, 43, 35, 869, DateTimeKind.Utc).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1338), new DateTime(2022, 9, 15, 6, 42, 35, 869, DateTimeKind.Utc).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1342), new DateTime(2022, 9, 15, 6, 41, 35, 869, DateTimeKind.Utc).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1346), new DateTime(2022, 9, 15, 6, 40, 35, 869, DateTimeKind.Utc).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1349), new DateTime(2022, 9, 15, 6, 39, 35, 869, DateTimeKind.Utc).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1353), new DateTime(2022, 9, 15, 6, 38, 35, 869, DateTimeKind.Utc).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1357), new DateTime(2022, 9, 15, 6, 37, 35, 869, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1361), new DateTime(2022, 9, 15, 6, 36, 35, 869, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1365), new DateTime(2022, 9, 15, 6, 35, 35, 869, DateTimeKind.Utc).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1368), new DateTime(2022, 9, 15, 6, 34, 35, 869, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1372), new DateTime(2022, 9, 15, 6, 33, 35, 869, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1376), new DateTime(2022, 9, 15, 6, 32, 35, 869, DateTimeKind.Utc).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1380), new DateTime(2022, 9, 15, 6, 31, 35, 869, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1383), new DateTime(2022, 9, 15, 6, 30, 35, 869, DateTimeKind.Utc).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1387), new DateTime(2022, 9, 15, 6, 29, 35, 869, DateTimeKind.Utc).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1391), new DateTime(2022, 9, 15, 6, 28, 35, 869, DateTimeKind.Utc).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1395), new DateTime(2022, 9, 15, 6, 27, 35, 869, DateTimeKind.Utc).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1398), new DateTime(2022, 9, 15, 6, 26, 35, 869, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1402), new DateTime(2022, 9, 15, 6, 25, 35, 869, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1406), new DateTime(2022, 9, 15, 6, 24, 35, 869, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1410), new DateTime(2022, 9, 15, 6, 23, 35, 869, DateTimeKind.Utc).AddTicks(1411) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1413), new DateTime(2022, 9, 15, 6, 22, 35, 869, DateTimeKind.Utc).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1417), new DateTime(2022, 9, 15, 6, 21, 35, 869, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1421), new DateTime(2022, 9, 15, 6, 20, 35, 869, DateTimeKind.Utc).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1424), new DateTime(2022, 9, 15, 6, 19, 35, 869, DateTimeKind.Utc).AddTicks(1426) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1428), new DateTime(2022, 9, 15, 6, 18, 35, 869, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1432), new DateTime(2022, 9, 15, 6, 17, 35, 869, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1436), new DateTime(2022, 9, 15, 6, 16, 35, 869, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1439), new DateTime(2022, 9, 15, 6, 15, 35, 869, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1443), new DateTime(2022, 9, 15, 6, 14, 35, 869, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1446), new DateTime(2022, 9, 15, 6, 13, 35, 869, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1450), new DateTime(2022, 9, 15, 6, 12, 35, 869, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1454), new DateTime(2022, 9, 15, 6, 11, 35, 869, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1458), new DateTime(2022, 9, 15, 6, 10, 35, 869, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1462), new DateTime(2022, 9, 15, 6, 9, 35, 869, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1470), new DateTime(2022, 9, 15, 6, 8, 35, 869, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1474), new DateTime(2022, 9, 15, 6, 7, 35, 869, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1478), new DateTime(2022, 9, 15, 6, 6, 35, 869, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1482), new DateTime(2022, 9, 15, 6, 5, 35, 869, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1485), new DateTime(2022, 9, 15, 6, 4, 35, 869, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1489), new DateTime(2022, 9, 15, 6, 3, 35, 869, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1493), new DateTime(2022, 9, 15, 6, 2, 35, 869, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1496), new DateTime(2022, 9, 15, 6, 1, 35, 869, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1500), new DateTime(2022, 9, 15, 6, 0, 35, 869, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1504), new DateTime(2022, 9, 15, 5, 59, 35, 869, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1508), new DateTime(2022, 9, 15, 5, 58, 35, 869, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1512), new DateTime(2022, 9, 15, 5, 57, 35, 869, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1516), new DateTime(2022, 9, 15, 5, 56, 35, 869, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1519), new DateTime(2022, 9, 15, 5, 55, 35, 869, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1523), new DateTime(2022, 9, 15, 5, 54, 35, 869, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1527), new DateTime(2022, 9, 15, 5, 53, 35, 869, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1531), new DateTime(2022, 9, 15, 5, 52, 35, 869, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1534), new DateTime(2022, 9, 15, 5, 51, 35, 869, DateTimeKind.Utc).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1538), new DateTime(2022, 9, 15, 5, 50, 35, 869, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1542), new DateTime(2022, 9, 15, 5, 49, 35, 869, DateTimeKind.Utc).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1546), new DateTime(2022, 9, 15, 5, 48, 35, 869, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1549), new DateTime(2022, 9, 15, 5, 47, 35, 869, DateTimeKind.Utc).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1553), new DateTime(2022, 9, 15, 5, 46, 35, 869, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1557), new DateTime(2022, 9, 15, 5, 45, 35, 869, DateTimeKind.Utc).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1561), new DateTime(2022, 9, 15, 5, 44, 35, 869, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1565), new DateTime(2022, 9, 15, 5, 43, 35, 869, DateTimeKind.Utc).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1568), new DateTime(2022, 9, 15, 5, 42, 35, 869, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1572), new DateTime(2022, 9, 15, 5, 41, 35, 869, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1576), new DateTime(2022, 9, 15, 5, 40, 35, 869, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1580), new DateTime(2022, 9, 15, 5, 39, 35, 869, DateTimeKind.Utc).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1583), new DateTime(2022, 9, 15, 5, 38, 35, 869, DateTimeKind.Utc).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1587), new DateTime(2022, 9, 15, 5, 37, 35, 869, DateTimeKind.Utc).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1591), new DateTime(2022, 9, 15, 5, 36, 35, 869, DateTimeKind.Utc).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1594), new DateTime(2022, 9, 15, 5, 35, 35, 869, DateTimeKind.Utc).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1598), new DateTime(2022, 9, 15, 5, 34, 35, 869, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1602), new DateTime(2022, 9, 15, 5, 33, 35, 869, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1606), new DateTime(2022, 9, 15, 5, 32, 35, 869, DateTimeKind.Utc).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1610), new DateTime(2022, 9, 15, 5, 31, 35, 869, DateTimeKind.Utc).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1614), new DateTime(2022, 9, 15, 5, 30, 35, 869, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1617), new DateTime(2022, 9, 15, 5, 29, 35, 869, DateTimeKind.Utc).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1621), new DateTime(2022, 9, 15, 5, 28, 35, 869, DateTimeKind.Utc).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1625), new DateTime(2022, 9, 15, 5, 27, 35, 869, DateTimeKind.Utc).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1628), new DateTime(2022, 9, 15, 5, 26, 35, 869, DateTimeKind.Utc).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1632), new DateTime(2022, 9, 15, 5, 25, 35, 869, DateTimeKind.Utc).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1636), new DateTime(2022, 9, 15, 5, 24, 35, 869, DateTimeKind.Utc).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1640), new DateTime(2022, 9, 15, 5, 23, 35, 869, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1644), new DateTime(2022, 9, 15, 5, 22, 35, 869, DateTimeKind.Utc).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1647), new DateTime(2022, 9, 15, 5, 21, 35, 869, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1651), new DateTime(2022, 9, 15, 5, 20, 35, 869, DateTimeKind.Utc).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1655), new DateTime(2022, 9, 15, 5, 19, 35, 869, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1658), new DateTime(2022, 9, 15, 5, 18, 35, 869, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1662), new DateTime(2022, 9, 15, 5, 17, 35, 869, DateTimeKind.Utc).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1666), new DateTime(2022, 9, 15, 5, 16, 35, 869, DateTimeKind.Utc).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 869, DateTimeKind.Utc).AddTicks(1669), new DateTime(2022, 9, 15, 5, 15, 35, 869, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Token" },
                values: new object[] { "Ronaldofort", "f253023f-4b26-4f3a-bd52-a877a9d5b2ad" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Token" },
                values: new object[] { "East Kathlynport", "4af5ecbb-e3a6-44fc-89a4-c61dfdc412ab" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Token" },
                values: new object[] { "New Lauryn", "ad21f08d-7a0e-4570-b850-f5cb8e564254" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 846, DateTimeKind.Utc).AddTicks(6258), "OJZ5qe4lQmfLNihkCI+a13DL5uzTO7C4dIiwWl5fOxg=", "eP2iN4SaKRi1n/vQgzqw96IjbH/sMY9s4xXc+wgGveY=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 852, DateTimeKind.Utc).AddTicks(593), "HPcu46LW181aS30TdWRDOYWAr3wA77hhsllo9IPutvA=", "6bb7owkSSvg2cdwWmBhPfGgbBTeaW3cc+SpYF8VlZsA=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 857, DateTimeKind.Utc).AddTicks(5140), "Ysxvyw/SOHyQWsXdrvyKr5bHCqxyHpGEg21M5DGSfaw=", "d8I5CVdrbrCeYF4efqBmA1WCvjORwXPstlrR4O7K+fw=" });

            migrationBuilder.CreateIndex(
                name: "IX_Stations_Token",
                table: "Stations",
                column: "Token",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Stations_Token",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "CeatedAt",
                table: "RemainingTransactions");

            migrationBuilder.DropColumn(
                name: "CeatedAt",
                table: "LevelIndicatorTransactions");

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "sunt", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "vel", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "rerum", new DateTime(2022, 9, 10, 14, 53, 21, 166, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 396.65958222741403, 12m, new DateTime(2022, 9, 10, 14, 51, 21, 170, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 440.90813046573652, 25m, new DateTime(2022, 9, 10, 14, 50, 21, 170, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 833.54116836059825, 3m, new DateTime(2022, 9, 10, 14, 49, 21, 170, DateTimeKind.Utc).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 769.00047985526794, 20m, new DateTime(2022, 9, 10, 14, 48, 21, 170, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 238.87834390045415, 20m, new DateTime(2022, 9, 10, 14, 47, 21, 170, DateTimeKind.Utc).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 148.71939231724195, 8m, new DateTime(2022, 9, 10, 14, 46, 21, 170, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 999.90955935576631, 31m, new DateTime(2022, 9, 10, 14, 45, 21, 170, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 795.2613207320577, 16m, new DateTime(2022, 9, 10, 14, 44, 21, 170, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 737.58461485871874, 37m, new DateTime(2022, 9, 10, 14, 43, 21, 170, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 89.186114237091658, 20m, new DateTime(2022, 9, 10, 14, 42, 21, 170, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 282.89071333201832, 2m, new DateTime(2022, 9, 10, 14, 41, 21, 170, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 367.52767377049622, 33m, new DateTime(2022, 9, 10, 14, 40, 21, 170, DateTimeKind.Utc).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 357.59304657454396, 27m, new DateTime(2022, 9, 10, 14, 39, 21, 170, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 149.92150483153222, 24m, new DateTime(2022, 9, 10, 14, 38, 21, 170, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 847.69706280402079, 37m, new DateTime(2022, 9, 10, 14, 37, 21, 170, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 111.46599970320426, 12m, new DateTime(2022, 9, 10, 14, 36, 21, 170, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 992.4364621225119, 9m, new DateTime(2022, 9, 10, 14, 35, 21, 170, DateTimeKind.Utc).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 957.59600364252856, 33m, new DateTime(2022, 9, 10, 14, 34, 21, 170, DateTimeKind.Utc).AddTicks(9266) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 129.04084713336206, 10m, new DateTime(2022, 9, 10, 14, 33, 21, 170, DateTimeKind.Utc).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 298.63325822575962, 14m, new DateTime(2022, 9, 10, 14, 32, 21, 170, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 862.38328260216053, 16m, new DateTime(2022, 9, 10, 14, 31, 21, 170, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 146.24300253614965, 1m, new DateTime(2022, 9, 10, 14, 30, 21, 170, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 834.95229142076312, 35m, new DateTime(2022, 9, 10, 14, 29, 21, 170, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 526.34269299873552, 10m, new DateTime(2022, 9, 10, 14, 28, 21, 170, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 650.31759039335009, 34m, new DateTime(2022, 9, 10, 14, 27, 21, 170, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 386.91294119160312, 26m, new DateTime(2022, 9, 10, 14, 26, 21, 170, DateTimeKind.Utc).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 79.016989871412036, 31m, new DateTime(2022, 9, 10, 14, 25, 21, 170, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 519.40183451185283, 30m, new DateTime(2022, 9, 10, 14, 24, 21, 170, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 449.23905904357696, 6m, new DateTime(2022, 9, 10, 14, 23, 21, 170, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 986.0905978811453, 32m, new DateTime(2022, 9, 10, 14, 22, 21, 170, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 79.30974032023552, 30m, new DateTime(2022, 9, 10, 14, 21, 21, 170, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 824.66165938353731, 15m, new DateTime(2022, 9, 10, 14, 20, 21, 170, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 331.78077953447729, 1m, new DateTime(2022, 9, 10, 14, 19, 21, 170, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 319.55529459340215, 39m, new DateTime(2022, 9, 10, 14, 18, 21, 170, DateTimeKind.Utc).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 4.7155146783863788, 16m, new DateTime(2022, 9, 10, 14, 17, 21, 170, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 708.80435495536153, 7m, new DateTime(2022, 9, 10, 14, 16, 21, 170, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Density", "TransactionTime" },
                values: new object[] { 79.805969645274416, new DateTime(2022, 9, 10, 14, 15, 21, 170, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 905.04495752054322, 9m, new DateTime(2022, 9, 10, 14, 14, 21, 170, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 548.45265923217812, 5m, new DateTime(2022, 9, 10, 14, 13, 21, 170, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 157.0851325092888, 31m, new DateTime(2022, 9, 10, 14, 12, 21, 170, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 868.73813255793152, 19m, new DateTime(2022, 9, 10, 14, 11, 21, 170, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 457.26118817005914, 40m, new DateTime(2022, 9, 10, 14, 10, 21, 170, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 92.149334194461701, 32m, new DateTime(2022, 9, 10, 14, 9, 21, 170, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 720.36721420198307, 16m, new DateTime(2022, 9, 10, 14, 8, 21, 170, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 946.86971676924691, 7m, new DateTime(2022, 9, 10, 14, 7, 21, 170, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 172.82523298003895, 5m, new DateTime(2022, 9, 10, 14, 6, 21, 170, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 980.40732211351929, 12m, new DateTime(2022, 9, 10, 14, 5, 21, 170, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 704.58750360926297, 2m, new DateTime(2022, 9, 10, 14, 4, 21, 170, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 949.43276015873107, 21m, new DateTime(2022, 9, 10, 14, 3, 21, 170, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 710.88254245402095, 5m, new DateTime(2022, 9, 10, 14, 2, 21, 170, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 125.16242527814525, 17m, new DateTime(2022, 9, 10, 14, 1, 21, 170, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 485.55629560021987, 1m, new DateTime(2022, 9, 10, 14, 0, 21, 170, DateTimeKind.Utc).AddTicks(9448) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 330.29741719885709, 11m, new DateTime(2022, 9, 10, 13, 59, 21, 170, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 735.7444571246433, 40m, new DateTime(2022, 9, 10, 13, 58, 21, 170, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 334.72515938791338, 30m, new DateTime(2022, 9, 10, 13, 57, 21, 170, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 423.22877513999026, 2m, new DateTime(2022, 9, 10, 13, 56, 21, 170, DateTimeKind.Utc).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 112.37175669453103, 6m, new DateTime(2022, 9, 10, 13, 55, 21, 170, DateTimeKind.Utc).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 859.31165320561354, 3m, new DateTime(2022, 9, 10, 13, 54, 21, 170, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 331.18057632390509, 5m, new DateTime(2022, 9, 10, 13, 53, 21, 170, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 590.47603399975571, 29m, new DateTime(2022, 9, 10, 13, 52, 21, 170, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 171.41659151344047, 24m, new DateTime(2022, 9, 10, 13, 51, 21, 170, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 797.27459087502029, 25m, new DateTime(2022, 9, 10, 13, 50, 21, 170, DateTimeKind.Utc).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 536.67223994203948, 12m, new DateTime(2022, 9, 10, 13, 49, 21, 170, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 716.94666893181113, 0m, new DateTime(2022, 9, 10, 13, 48, 21, 170, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 881.94129344685439, 30m, new DateTime(2022, 9, 10, 13, 47, 21, 170, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 154.04293476103558, 28m, new DateTime(2022, 9, 10, 13, 46, 21, 170, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 686.69675400233461, 29m, new DateTime(2022, 9, 10, 13, 45, 21, 170, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 687.95109742702755, 12m, new DateTime(2022, 9, 10, 13, 44, 21, 170, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 168.47617503953671, 34m, new DateTime(2022, 9, 10, 13, 43, 21, 170, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 614.18442907534234, 3m, new DateTime(2022, 9, 10, 13, 42, 21, 170, DateTimeKind.Utc).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 478.35853863734934, 39m, new DateTime(2022, 9, 10, 13, 41, 21, 170, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 104.22572969446919, 34m, new DateTime(2022, 9, 10, 13, 40, 21, 170, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 768.09638329495544, 4m, new DateTime(2022, 9, 10, 13, 39, 21, 170, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 555.99110114994005, 25m, new DateTime(2022, 9, 10, 13, 38, 21, 170, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 823.49482636380594, 15m, new DateTime(2022, 9, 10, 13, 37, 21, 170, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 72.359183040417108, 8m, new DateTime(2022, 9, 10, 13, 36, 21, 170, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 911.30922588594751, 15m, new DateTime(2022, 9, 10, 13, 35, 21, 170, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 391.20972109333371, 35m, new DateTime(2022, 9, 10, 13, 34, 21, 170, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Density", "TransactionTime" },
                values: new object[] { 705.40118343424888, new DateTime(2022, 9, 10, 13, 33, 21, 170, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 313.67860862921339, 39m, new DateTime(2022, 9, 10, 13, 32, 21, 170, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 134.89646228094065, 12m, new DateTime(2022, 9, 10, 13, 31, 21, 170, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 744.36575477948406, 0m, new DateTime(2022, 9, 10, 13, 30, 21, 170, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 690.84530256670644, 15m, new DateTime(2022, 9, 10, 13, 29, 21, 170, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 887.81134498723202, 19m, new DateTime(2022, 9, 10, 13, 28, 21, 170, DateTimeKind.Utc).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 142.43908597276956, 20m, new DateTime(2022, 9, 10, 13, 27, 21, 170, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 906.01319452285543, 22m, new DateTime(2022, 9, 10, 13, 26, 21, 170, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 930.99356695432039, 11m, new DateTime(2022, 9, 10, 13, 25, 21, 170, DateTimeKind.Utc).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 733.94748560546532, 29m, new DateTime(2022, 9, 10, 13, 24, 21, 170, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 86.455755983890995, 40m, new DateTime(2022, 9, 10, 13, 23, 21, 170, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 249.10449674714553, 2m, new DateTime(2022, 9, 10, 13, 22, 21, 170, DateTimeKind.Utc).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 837.67520040334603, 33m, new DateTime(2022, 9, 10, 13, 21, 21, 170, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 886.01660520494909, 2m, new DateTime(2022, 9, 10, 13, 20, 21, 170, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 981.34672387327203, 5m, new DateTime(2022, 9, 10, 13, 19, 21, 170, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 566.10325181185999, 38m, new DateTime(2022, 9, 10, 13, 18, 21, 170, DateTimeKind.Utc).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 996.77957049476163, 17m, new DateTime(2022, 9, 10, 13, 17, 21, 170, DateTimeKind.Utc).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 576.17426291549737, 0m, new DateTime(2022, 9, 10, 13, 16, 21, 170, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 392.40868800101703, 17m, new DateTime(2022, 9, 10, 13, 15, 21, 170, DateTimeKind.Utc).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 207.55742270487698, 5m, new DateTime(2022, 9, 10, 13, 14, 21, 170, DateTimeKind.Utc).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 91.77294264494374, 11m, new DateTime(2022, 9, 10, 13, 13, 21, 170, DateTimeKind.Utc).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 786.16532551983198, 40m, new DateTime(2022, 9, 10, 13, 12, 21, 170, DateTimeKind.Utc).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 662.71814043754853, 0m, new DateTime(2022, 9, 10, 13, 11, 21, 172, DateTimeKind.Utc).AddTicks(852) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 383.42285363666639, 39m, new DateTime(2022, 9, 10, 13, 10, 21, 172, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 99.464239666798846, 40m, new DateTime(2022, 9, 10, 13, 9, 21, 172, DateTimeKind.Utc).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 876.0353164684243, 16m, new DateTime(2022, 9, 10, 13, 8, 21, 172, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 8.1411140169755924, 0m, new DateTime(2022, 9, 10, 13, 7, 21, 172, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 253.91762988949353, 3m, new DateTime(2022, 9, 10, 13, 6, 21, 172, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 353.05267349140769, 29m, new DateTime(2022, 9, 10, 13, 5, 21, 172, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 232.2124316002141, 28m, new DateTime(2022, 9, 10, 13, 4, 21, 172, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 144.66547790686411, 7m, new DateTime(2022, 9, 10, 13, 3, 21, 172, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 176.88573704731502, 5m, new DateTime(2022, 9, 10, 13, 2, 21, 172, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 10.653306899520153, 7m, new DateTime(2022, 9, 10, 13, 1, 21, 172, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 886.32593783660195, 3m, new DateTime(2022, 9, 10, 13, 0, 21, 172, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 833.20190098791034, 35m, new DateTime(2022, 9, 10, 12, 59, 21, 172, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 898.92862738833594, 29m, new DateTime(2022, 9, 10, 12, 58, 21, 172, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 502.38769434467622, 38m, new DateTime(2022, 9, 10, 12, 57, 21, 172, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 998.23558337758152, 11m, new DateTime(2022, 9, 10, 12, 56, 21, 172, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 194.71689144050586, 23m, new DateTime(2022, 9, 10, 12, 55, 21, 172, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 489.64644114400704, 36m, new DateTime(2022, 9, 10, 12, 54, 21, 172, DateTimeKind.Utc).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 349.7809914721206, 6m, new DateTime(2022, 9, 10, 12, 53, 21, 172, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 924.53106993459892, 40m, new DateTime(2022, 9, 10, 12, 52, 21, 172, DateTimeKind.Utc).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 840.30861907324811, 25m, new DateTime(2022, 9, 10, 12, 51, 21, 172, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 239.74645340284252, 3m, new DateTime(2022, 9, 10, 12, 50, 21, 172, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 169.77582044625152, 10m, new DateTime(2022, 9, 10, 12, 49, 21, 172, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 443.31330696425755, 29m, new DateTime(2022, 9, 10, 12, 48, 21, 172, DateTimeKind.Utc).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 512.09723256420318, 24m, new DateTime(2022, 9, 10, 12, 47, 21, 172, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 321.27438215788652, 23m, new DateTime(2022, 9, 10, 12, 46, 21, 172, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Density", "TransactionTime" },
                values: new object[] { 956.5002026707931, new DateTime(2022, 9, 10, 12, 45, 21, 172, DateTimeKind.Utc).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 633.4134208238429, 1m, new DateTime(2022, 9, 10, 12, 44, 21, 172, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 793.49629455433501, 34m, new DateTime(2022, 9, 10, 12, 43, 21, 172, DateTimeKind.Utc).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 288.28970653285677, 1m, new DateTime(2022, 9, 10, 12, 42, 21, 172, DateTimeKind.Utc).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 513.31738395020216, 32m, new DateTime(2022, 9, 10, 12, 41, 21, 172, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 82.258932265989344, 35m, new DateTime(2022, 9, 10, 12, 40, 21, 172, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 119.93579625002249, 18m, new DateTime(2022, 9, 10, 12, 39, 21, 172, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 994.13348644613745, 2m, new DateTime(2022, 9, 10, 12, 38, 21, 172, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 668.53540743808696, 27m, new DateTime(2022, 9, 10, 12, 37, 21, 172, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 415.083202733429, 25m, new DateTime(2022, 9, 10, 12, 36, 21, 172, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 703.48864794318808, 39m, new DateTime(2022, 9, 10, 12, 35, 21, 172, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 307.94465106209998, 28m, new DateTime(2022, 9, 10, 12, 34, 21, 172, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 926.82977753849218, 26m, new DateTime(2022, 9, 10, 12, 33, 21, 172, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 787.11021003093651, 2m, new DateTime(2022, 9, 10, 12, 32, 21, 172, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 673.6379224466059, 22m, new DateTime(2022, 9, 10, 12, 31, 21, 172, DateTimeKind.Utc).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 497.25315666163715, 11m, new DateTime(2022, 9, 10, 12, 30, 21, 172, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 874.89703066044319, 12m, new DateTime(2022, 9, 10, 12, 29, 21, 172, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 580.02090427896496, 0m, new DateTime(2022, 9, 10, 12, 28, 21, 172, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 224.60013176466398, 12m, new DateTime(2022, 9, 10, 12, 27, 21, 172, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 362.57195401654695, 20m, new DateTime(2022, 9, 10, 12, 26, 21, 172, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 83.960162216302095, 40m, new DateTime(2022, 9, 10, 12, 25, 21, 172, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 768.34165978279975, 6m, new DateTime(2022, 9, 10, 12, 24, 21, 172, DateTimeKind.Utc).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 429.22480742956373, 38m, new DateTime(2022, 9, 10, 12, 23, 21, 172, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 878.51186983133869, 15m, new DateTime(2022, 9, 10, 12, 22, 21, 172, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 473.22149670423318, 38m, new DateTime(2022, 9, 10, 12, 21, 21, 172, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 581.21604475858874, 27m, new DateTime(2022, 9, 10, 12, 20, 21, 172, DateTimeKind.Utc).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 426.2788617980259, 35m, new DateTime(2022, 9, 10, 12, 19, 21, 172, DateTimeKind.Utc).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 465.33095090542463, 35m, new DateTime(2022, 9, 10, 12, 18, 21, 172, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 404.41406267247027, 5m, new DateTime(2022, 9, 10, 12, 17, 21, 172, DateTimeKind.Utc).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 663.78790714756701, 21m, new DateTime(2022, 9, 10, 12, 16, 21, 172, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 300.55622938118051, 23m, new DateTime(2022, 9, 10, 12, 15, 21, 172, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 691.05194832518566, 18m, new DateTime(2022, 9, 10, 12, 14, 21, 172, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 8.4742690892756212, 28m, new DateTime(2022, 9, 10, 12, 13, 21, 172, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 642.09516271045754, 26m, new DateTime(2022, 9, 10, 12, 12, 21, 172, DateTimeKind.Utc).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 752.03093602168008, 18m, new DateTime(2022, 9, 10, 12, 11, 21, 172, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 177.99164256673106, 13m, new DateTime(2022, 9, 10, 12, 10, 21, 172, DateTimeKind.Utc).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 965.27317514679021, 19m, new DateTime(2022, 9, 10, 12, 9, 21, 172, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 810.59558529634262, 8m, new DateTime(2022, 9, 10, 12, 8, 21, 172, DateTimeKind.Utc).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 207.24654897786755, 31m, new DateTime(2022, 9, 10, 12, 7, 21, 172, DateTimeKind.Utc).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 970.21154124415193, 8m, new DateTime(2022, 9, 10, 12, 6, 21, 172, DateTimeKind.Utc).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 560.94302564668556, 29m, new DateTime(2022, 9, 10, 12, 5, 21, 172, DateTimeKind.Utc).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 641.36970305441241, 3m, new DateTime(2022, 9, 10, 12, 4, 21, 172, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 833.05856617112318, 1m, new DateTime(2022, 9, 10, 12, 3, 21, 172, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 574.80624178078324, 4m, new DateTime(2022, 9, 10, 12, 2, 21, 172, DateTimeKind.Utc).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 608.05944771284737, 5m, new DateTime(2022, 9, 10, 12, 1, 21, 172, DateTimeKind.Utc).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 149.08980652916713, 31m, new DateTime(2022, 9, 10, 12, 0, 21, 172, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 662.59907058812348, 29m, new DateTime(2022, 9, 10, 11, 59, 21, 172, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 436.97147922073367, 7m, new DateTime(2022, 9, 10, 11, 58, 21, 172, DateTimeKind.Utc).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 807.85466372512883, 3m, new DateTime(2022, 9, 10, 11, 57, 21, 172, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 228.81334003310226, 38m, new DateTime(2022, 9, 10, 11, 56, 21, 172, DateTimeKind.Utc).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 613.17934775671074, 16m, new DateTime(2022, 9, 10, 11, 55, 21, 172, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 958.81622542676587, 27m, new DateTime(2022, 9, 10, 11, 54, 21, 172, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 326.97331055241062, 37m, new DateTime(2022, 9, 10, 11, 53, 21, 172, DateTimeKind.Utc).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 208.62537827614759, 27m, new DateTime(2022, 9, 10, 11, 52, 21, 172, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 929.80650166564453, 19m, new DateTime(2022, 9, 10, 11, 51, 21, 172, DateTimeKind.Utc).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 248.18829662793684, 6m, new DateTime(2022, 9, 10, 11, 50, 21, 172, DateTimeKind.Utc).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 340.63001110334091, 11m, new DateTime(2022, 9, 10, 11, 49, 21, 172, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 350.51667367045371, 0m, new DateTime(2022, 9, 10, 11, 48, 21, 172, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 392.88058745302123, 38m, new DateTime(2022, 9, 10, 11, 47, 21, 172, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 385.30885425724068, 20m, new DateTime(2022, 9, 10, 11, 46, 21, 172, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 162.415116166171, 22m, new DateTime(2022, 9, 10, 11, 45, 21, 172, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 529.0386733218337, 29m, new DateTime(2022, 9, 10, 11, 44, 21, 172, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 435.30747288645199, 8m, new DateTime(2022, 9, 10, 11, 43, 21, 172, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 864.64030921087556, 33m, new DateTime(2022, 9, 10, 11, 42, 21, 172, DateTimeKind.Utc).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 3.1589005785817026, 5m, new DateTime(2022, 9, 10, 11, 41, 21, 172, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 423.13609843239874, 30m, new DateTime(2022, 9, 10, 11, 40, 21, 172, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 584.36703032324272, 10m, new DateTime(2022, 9, 10, 11, 39, 21, 172, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 93.872607705967511, 24m, new DateTime(2022, 9, 10, 11, 38, 21, 172, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 649.58443031521676, 24m, new DateTime(2022, 9, 10, 11, 37, 21, 172, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 533.6709182981898, 7m, new DateTime(2022, 9, 10, 11, 36, 21, 172, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 452.74153541501238, 21m, new DateTime(2022, 9, 10, 11, 35, 21, 172, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 436.64159906758437, 20m, new DateTime(2022, 9, 10, 11, 34, 21, 172, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 173.00840315066714, 30m, new DateTime(2022, 9, 10, 11, 33, 21, 172, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 583.3091273854526, 5m, new DateTime(2022, 9, 10, 11, 32, 21, 172, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 305.07243586246977, 32m, new DateTime(2022, 9, 10, 11, 31, 21, 173, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 811.78579575523759, 34m, new DateTime(2022, 9, 10, 11, 30, 21, 173, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 382.79294739991309, 21m, new DateTime(2022, 9, 10, 11, 29, 21, 173, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 607.96018174473011, 3m, new DateTime(2022, 9, 10, 11, 28, 21, 173, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 541.34330729144858, 0m, new DateTime(2022, 9, 10, 11, 27, 21, 173, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 735.68120594661639, 34m, new DateTime(2022, 9, 10, 11, 26, 21, 173, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 503.85426856054926, 2m, new DateTime(2022, 9, 10, 11, 25, 21, 173, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 68.317690088738331, 40m, new DateTime(2022, 9, 10, 11, 24, 21, 173, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 559.04317821458801, 32m, new DateTime(2022, 9, 10, 11, 23, 21, 173, DateTimeKind.Utc).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 557.98246133551265, 34m, new DateTime(2022, 9, 10, 11, 22, 21, 173, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 556.26745355543858, 11m, new DateTime(2022, 9, 10, 11, 21, 21, 173, DateTimeKind.Utc).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 931.11683948810548, 16m, new DateTime(2022, 9, 10, 11, 20, 21, 173, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 889.22316180585653, 5m, new DateTime(2022, 9, 10, 11, 19, 21, 173, DateTimeKind.Utc).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 968.7943167178272, 6m, new DateTime(2022, 9, 10, 11, 18, 21, 173, DateTimeKind.Utc).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 458.12910575306631, 32m, new DateTime(2022, 9, 10, 11, 17, 21, 173, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 359.75785319917674, 15m, new DateTime(2022, 9, 10, 11, 16, 21, 173, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 540.08936067338675, 23m, new DateTime(2022, 9, 10, 11, 15, 21, 173, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 975.48730123435018, 31m, new DateTime(2022, 9, 10, 11, 14, 21, 173, DateTimeKind.Utc).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 323.34840274303889, 36m, new DateTime(2022, 9, 10, 11, 13, 21, 173, DateTimeKind.Utc).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 185.75447367123411, 29m, new DateTime(2022, 9, 10, 11, 12, 21, 173, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 507.81824506561259, 28m, new DateTime(2022, 9, 10, 11, 11, 21, 173, DateTimeKind.Utc).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 794.72895697297179, 20m, new DateTime(2022, 9, 10, 11, 10, 21, 173, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 272.5693002897205, 14m, new DateTime(2022, 9, 10, 11, 9, 21, 173, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 833.80183137387951, 22m, new DateTime(2022, 9, 10, 11, 8, 21, 173, DateTimeKind.Utc).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 665.20433224907242, 15m, new DateTime(2022, 9, 10, 11, 7, 21, 173, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 409.54793552060084, 1m, new DateTime(2022, 9, 10, 11, 6, 21, 173, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 80.89548493374987, 6m, new DateTime(2022, 9, 10, 11, 5, 21, 173, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 911.74231329750944, 14m, new DateTime(2022, 9, 10, 11, 4, 21, 173, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 696.94464458147274, 0m, new DateTime(2022, 9, 10, 11, 3, 21, 173, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 314.68667914273442, 18m, new DateTime(2022, 9, 10, 11, 2, 21, 173, DateTimeKind.Utc).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 629.29113390550401, 34m, new DateTime(2022, 9, 10, 11, 1, 21, 173, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Density", "TransactionTime" },
                values: new object[] { 237.00269654118833, new DateTime(2022, 9, 10, 11, 0, 21, 173, DateTimeKind.Utc).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 728.3994857444892, 12m, new DateTime(2022, 9, 10, 10, 59, 21, 173, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 194.43476467433996, 28m, new DateTime(2022, 9, 10, 10, 58, 21, 173, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 287.26307591169621, 22m, new DateTime(2022, 9, 10, 10, 57, 21, 173, DateTimeKind.Utc).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 815.2679781556061, 25m, new DateTime(2022, 9, 10, 10, 56, 21, 173, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 524.58779793908843, 2m, new DateTime(2022, 9, 10, 10, 55, 21, 173, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 82.072430556996977, 29m, new DateTime(2022, 9, 10, 10, 54, 21, 173, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 446.64194648650636, 8m, new DateTime(2022, 9, 10, 10, 53, 21, 173, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 197.67438253279579, 29m, new DateTime(2022, 9, 10, 10, 52, 21, 173, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 954.6753971432513, 27m, new DateTime(2022, 9, 10, 10, 51, 21, 173, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 385.51868580701574, 35m, new DateTime(2022, 9, 10, 10, 50, 21, 173, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 169.66211847786471, 26m, new DateTime(2022, 9, 10, 10, 49, 21, 173, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 67.76828172223837, 3m, new DateTime(2022, 9, 10, 10, 48, 21, 173, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 538.52060275176325, 8m, new DateTime(2022, 9, 10, 10, 47, 21, 173, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 852.14245499139543, 26m, new DateTime(2022, 9, 10, 10, 46, 21, 173, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 815.74558824487826, 8m, new DateTime(2022, 9, 10, 10, 45, 21, 173, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 767.97967339164813, 39m, new DateTime(2022, 9, 10, 10, 44, 21, 173, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 478.32111804560242, 19m, new DateTime(2022, 9, 10, 10, 43, 21, 173, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 208.66554161783412, 32m, new DateTime(2022, 9, 10, 10, 42, 21, 173, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 809.86479160191789, 28m, new DateTime(2022, 9, 10, 10, 41, 21, 173, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 872.70510113869534, 30m, new DateTime(2022, 9, 10, 10, 40, 21, 173, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 738.34450333844256, 22m, new DateTime(2022, 9, 10, 10, 39, 21, 173, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 603.92672454210106, 11m, new DateTime(2022, 9, 10, 10, 38, 21, 173, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 924.92070984685904, 26m, new DateTime(2022, 9, 10, 10, 37, 21, 173, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 292.46595423576537, 31m, new DateTime(2022, 9, 10, 10, 36, 21, 173, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 659.34427380864918, 7m, new DateTime(2022, 9, 10, 10, 35, 21, 173, DateTimeKind.Utc).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 308.41780558227629, 30m, new DateTime(2022, 9, 10, 10, 34, 21, 173, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 968.6266936452954, 23m, new DateTime(2022, 9, 10, 10, 33, 21, 173, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 53.434211611123381, 7m, new DateTime(2022, 9, 10, 10, 32, 21, 173, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 386.36793339778251, 29m, new DateTime(2022, 9, 10, 10, 31, 21, 173, DateTimeKind.Utc).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 106.75832682339237, 29m, new DateTime(2022, 9, 10, 10, 30, 21, 173, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Density", "TransactionTime" },
                values: new object[] { 16.987232828552411, new DateTime(2022, 9, 10, 10, 29, 21, 173, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 428.09828008864162, 40m, new DateTime(2022, 9, 10, 10, 28, 21, 173, DateTimeKind.Utc).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 691.10631300217074, 37m, new DateTime(2022, 9, 10, 10, 27, 21, 173, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 186.31979814067878, 34m, new DateTime(2022, 9, 10, 10, 26, 21, 173, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 723.96217616980198, 26m, new DateTime(2022, 9, 10, 10, 25, 21, 173, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 97.081515775100712, 0m, new DateTime(2022, 9, 10, 10, 24, 21, 173, DateTimeKind.Utc).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 202.26704654037397, 31m, new DateTime(2022, 9, 10, 10, 23, 21, 173, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 974.68874085204368, 23m, new DateTime(2022, 9, 10, 10, 22, 21, 173, DateTimeKind.Utc).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 712.16260859642352, 26m, new DateTime(2022, 9, 10, 10, 21, 21, 173, DateTimeKind.Utc).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 190.5773450331474, 10m, new DateTime(2022, 9, 10, 10, 20, 21, 173, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 679.96015162788092, 20m, new DateTime(2022, 9, 10, 10, 19, 21, 173, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 359.36422058235252, 29m, new DateTime(2022, 9, 10, 10, 18, 21, 173, DateTimeKind.Utc).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 994.92184528844894, 30m, new DateTime(2022, 9, 10, 10, 17, 21, 173, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 916.91956785214416, 33m, new DateTime(2022, 9, 10, 10, 16, 21, 173, DateTimeKind.Utc).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 813.37777348210784, 12m, new DateTime(2022, 9, 10, 10, 15, 21, 173, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 804.23339405187244, 19m, new DateTime(2022, 9, 10, 10, 14, 21, 173, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 618.08936247960196, 21m, new DateTime(2022, 9, 10, 10, 13, 21, 173, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 100.62995379879824, 11m, new DateTime(2022, 9, 10, 10, 12, 21, 173, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 29.470566296898483, 17m, new DateTime(2022, 9, 10, 10, 11, 21, 173, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 608.33438735945288, 34m, new DateTime(2022, 9, 10, 10, 10, 21, 173, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 993.35462783876608, 27m, new DateTime(2022, 9, 10, 10, 9, 21, 173, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 311.20608738649116, 40m, new DateTime(2022, 9, 10, 10, 8, 21, 173, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 768.84725117663061, 0m, new DateTime(2022, 9, 10, 10, 7, 21, 173, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 716.74473191289371, 38m, new DateTime(2022, 9, 10, 10, 6, 21, 173, DateTimeKind.Utc).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 639.68682506418475, 6m, new DateTime(2022, 9, 10, 10, 5, 21, 173, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 376.20297272123082, 18m, new DateTime(2022, 9, 10, 10, 4, 21, 173, DateTimeKind.Utc).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 500.90378480975119, 7m, new DateTime(2022, 9, 10, 10, 3, 21, 173, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 971.58085377811824, 34m, new DateTime(2022, 9, 10, 10, 2, 21, 173, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 671.47670457574361, 36m, new DateTime(2022, 9, 10, 10, 1, 21, 173, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 308.85832270301216, 1m, new DateTime(2022, 9, 10, 10, 0, 21, 173, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 363.03964701120594, 16m, new DateTime(2022, 9, 10, 9, 59, 21, 173, DateTimeKind.Utc).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 333.7085745985998, 36m, new DateTime(2022, 9, 10, 9, 58, 21, 173, DateTimeKind.Utc).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 22.124920372337154, 12m, new DateTime(2022, 9, 10, 9, 57, 21, 173, DateTimeKind.Utc).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 694.05904128508371, 2m, new DateTime(2022, 9, 10, 9, 56, 21, 173, DateTimeKind.Utc).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 223.63657495206402, 38m, new DateTime(2022, 9, 10, 9, 55, 21, 173, DateTimeKind.Utc).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 346.8828312722315, 21m, new DateTime(2022, 9, 10, 9, 54, 21, 173, DateTimeKind.Utc).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 72.683303064525418, 18m, new DateTime(2022, 9, 10, 9, 53, 21, 173, DateTimeKind.Utc).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "Density", "Temperature", "TransactionTime" },
                values: new object[] { 774.75977336582162, 34m, new DateTime(2022, 9, 10, 9, 52, 21, 173, DateTimeKind.Utc).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 51, 21, 167, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 50, 21, 167, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 49, 21, 167, DateTimeKind.Utc).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 48, 21, 167, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 47, 21, 167, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 46, 21, 167, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 45, 21, 167, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 44, 21, 167, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 43, 21, 167, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 10,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 42, 21, 167, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 11,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 41, 21, 167, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 12,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 40, 21, 167, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 13,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 39, 21, 167, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 14,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 38, 21, 167, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 15,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 37, 21, 167, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 16,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 36, 21, 167, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 17,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 35, 21, 167, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 18,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 34, 21, 167, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 19,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 33, 21, 167, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 20,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 32, 21, 167, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 21,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 31, 21, 167, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 22,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 30, 21, 167, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 23,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 29, 21, 167, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 24,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 28, 21, 167, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 25,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 27, 21, 167, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 26,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 26, 21, 167, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 27,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 25, 21, 167, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 28,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 24, 21, 167, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 29,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 23, 21, 167, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 30,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 22, 21, 167, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 31,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 21, 21, 167, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 32,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 20, 21, 167, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 33,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 19, 21, 167, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 34,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 18, 21, 167, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 35,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 17, 21, 167, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 36,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 16, 21, 167, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 37,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 15, 21, 167, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 38,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 14, 21, 167, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 39,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 13, 21, 167, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 40,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 12, 21, 167, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 41,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 11, 21, 167, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 42,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 10, 21, 167, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 43,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 9, 21, 167, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 44,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 8, 21, 167, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 45,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 7, 21, 167, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 46,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 6, 21, 167, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 47,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 5, 21, 167, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 48,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 4, 21, 167, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 49,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 3, 21, 167, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 50,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 2, 21, 167, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 51,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 1, 21, 167, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 52,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 14, 0, 21, 167, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 53,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 59, 21, 167, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 54,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 58, 21, 167, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 55,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 57, 21, 167, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 56,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 56, 21, 167, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 57,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 55, 21, 167, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 58,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 54, 21, 167, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 59,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 53, 21, 167, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 60,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 52, 21, 167, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 61,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 51, 21, 167, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 62,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 50, 21, 167, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 63,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 49, 21, 167, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 64,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 48, 21, 167, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 65,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 47, 21, 167, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 66,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 46, 21, 167, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 67,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 45, 21, 167, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 68,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 44, 21, 167, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 69,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 43, 21, 167, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 70,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 42, 21, 167, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 71,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 41, 21, 167, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 72,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 40, 21, 167, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 73,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 39, 21, 167, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 74,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 38, 21, 167, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 75,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 37, 21, 167, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 76,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 36, 21, 167, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 77,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 35, 21, 167, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 78,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 34, 21, 167, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 79,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 33, 21, 167, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 80,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 32, 21, 167, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 81,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 31, 21, 167, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 82,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 30, 21, 167, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 83,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 29, 21, 167, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 84,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 28, 21, 167, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 85,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 27, 21, 167, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 86,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 26, 21, 167, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 87,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 25, 21, 167, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 88,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 24, 21, 167, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 89,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 23, 21, 167, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 90,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 22, 21, 167, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 91,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 21, 21, 167, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 92,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 20, 21, 167, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 93,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 19, 21, 167, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 94,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 18, 21, 167, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 95,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 17, 21, 167, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 96,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 16, 21, 167, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 97,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 15, 21, 167, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 98,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 14, 21, 167, DateTimeKind.Utc).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 99,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 13, 21, 167, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 100,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 12, 21, 167, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 101,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 11, 21, 168, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 102,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 10, 21, 168, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 103,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 9, 21, 168, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 104,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 8, 21, 168, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 105,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 7, 21, 168, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 106,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 6, 21, 168, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 107,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 5, 21, 168, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 108,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 4, 21, 168, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 109,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 3, 21, 168, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 110,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 2, 21, 168, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 111,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 1, 21, 168, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 112,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 13, 0, 21, 168, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 113,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 59, 21, 168, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 114,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 58, 21, 168, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 115,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 57, 21, 168, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 116,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 56, 21, 168, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 117,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 55, 21, 168, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 118,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 54, 21, 168, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 119,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 53, 21, 168, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 120,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 52, 21, 168, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 121,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 51, 21, 168, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 122,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 50, 21, 168, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 123,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 49, 21, 168, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 124,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 48, 21, 168, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 125,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 47, 21, 168, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 126,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 46, 21, 168, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 127,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 45, 21, 168, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 128,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 44, 21, 168, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 129,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 43, 21, 168, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 130,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 42, 21, 168, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 131,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 41, 21, 168, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 132,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 40, 21, 168, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 133,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 39, 21, 168, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 134,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 38, 21, 168, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 135,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 37, 21, 168, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 136,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 36, 21, 168, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 137,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 35, 21, 168, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 138,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 34, 21, 168, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 139,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 33, 21, 168, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 140,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 32, 21, 168, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 141,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 31, 21, 168, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 142,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 30, 21, 168, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 143,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 29, 21, 168, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 144,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 28, 21, 168, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 145,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 27, 21, 168, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 146,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 26, 21, 168, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 147,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 25, 21, 168, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 148,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 24, 21, 168, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 149,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 23, 21, 168, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 150,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 22, 21, 168, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 151,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 21, 21, 168, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 152,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 20, 21, 168, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 153,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 19, 21, 168, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 154,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 18, 21, 168, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 155,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 17, 21, 168, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 156,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 16, 21, 168, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 157,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 15, 21, 168, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 158,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 14, 21, 168, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 159,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 13, 21, 168, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 160,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 12, 21, 168, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 161,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 11, 21, 168, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 162,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 10, 21, 168, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 163,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 9, 21, 168, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 164,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 8, 21, 168, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 165,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 7, 21, 168, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 166,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 6, 21, 168, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 167,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 5, 21, 168, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 168,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 4, 21, 168, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 169,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 3, 21, 168, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 170,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 2, 21, 168, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 171,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 1, 21, 168, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 172,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 12, 0, 21, 168, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 173,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 59, 21, 168, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 174,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 58, 21, 168, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 175,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 57, 21, 168, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 176,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 56, 21, 168, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 177,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 55, 21, 168, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 178,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 54, 21, 168, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 179,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 53, 21, 168, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 180,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 52, 21, 168, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 181,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 51, 21, 168, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 182,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 50, 21, 168, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 183,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 49, 21, 168, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 184,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 48, 21, 168, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 185,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 47, 21, 168, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 186,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 46, 21, 168, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 187,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 45, 21, 168, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 188,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 44, 21, 168, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 189,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 43, 21, 168, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 190,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 42, 21, 168, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 191,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 41, 21, 168, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 192,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 40, 21, 168, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 193,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 39, 21, 168, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 194,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 38, 21, 168, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 195,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 37, 21, 168, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 196,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 36, 21, 168, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 197,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 35, 21, 168, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 198,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 34, 21, 168, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 199,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 33, 21, 168, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 200,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 32, 21, 168, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 201,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 31, 21, 169, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 202,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 30, 21, 169, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 203,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 29, 21, 169, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 204,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 28, 21, 169, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 205,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 27, 21, 169, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 206,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 26, 21, 169, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 207,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 25, 21, 169, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 208,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 24, 21, 169, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 209,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 23, 21, 169, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 210,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 22, 21, 169, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 211,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 21, 21, 169, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 212,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 20, 21, 169, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 213,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 19, 21, 169, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 214,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 18, 21, 169, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 215,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 17, 21, 169, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 216,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 16, 21, 169, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 217,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 15, 21, 169, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 218,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 14, 21, 169, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 219,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 13, 21, 169, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 220,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 12, 21, 169, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 221,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 11, 21, 169, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 222,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 10, 21, 169, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 223,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 9, 21, 169, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 224,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 8, 21, 169, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 225,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 7, 21, 169, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 226,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 6, 21, 169, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 227,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 5, 21, 169, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 228,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 4, 21, 169, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 229,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 3, 21, 169, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 230,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 2, 21, 169, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 231,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 1, 21, 169, DateTimeKind.Utc).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 232,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 11, 0, 21, 169, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 233,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 59, 21, 169, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 234,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 58, 21, 169, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 235,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 57, 21, 169, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 236,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 56, 21, 169, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 237,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 55, 21, 169, DateTimeKind.Utc).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 238,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 54, 21, 169, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 239,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 53, 21, 169, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 240,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 52, 21, 169, DateTimeKind.Utc).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 241,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 51, 21, 169, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 242,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 50, 21, 169, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 243,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 49, 21, 169, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 244,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 48, 21, 169, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 245,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 47, 21, 169, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 246,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 46, 21, 169, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 247,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 45, 21, 169, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 248,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 44, 21, 169, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 249,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 43, 21, 169, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 250,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 42, 21, 169, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 251,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 41, 21, 169, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 252,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 40, 21, 169, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 253,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 39, 21, 169, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 254,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 38, 21, 169, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 255,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 37, 21, 169, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 256,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 36, 21, 169, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 257,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 35, 21, 169, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 258,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 34, 21, 169, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 259,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 33, 21, 169, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 260,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 32, 21, 169, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 261,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 31, 21, 169, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 262,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 30, 21, 169, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 263,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 29, 21, 169, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 264,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 28, 21, 169, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 265,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 27, 21, 169, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 266,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 26, 21, 169, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 267,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 25, 21, 169, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 268,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 24, 21, 169, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 269,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 23, 21, 169, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 270,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 22, 21, 169, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 271,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 21, 21, 169, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 272,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 20, 21, 169, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 273,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 19, 21, 169, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 274,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 18, 21, 169, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 275,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 17, 21, 169, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 276,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 16, 21, 169, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 277,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 15, 21, 169, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 278,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 14, 21, 169, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 279,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 13, 21, 169, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 280,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 12, 21, 169, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 281,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 11, 21, 169, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 282,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 10, 21, 169, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 283,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 9, 21, 169, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 284,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 8, 21, 169, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 285,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 7, 21, 169, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 286,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 6, 21, 169, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 287,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 5, 21, 169, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 288,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 4, 21, 169, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 289,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 3, 21, 169, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 290,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 2, 21, 169, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 291,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 1, 21, 169, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 292,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 10, 0, 21, 169, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 293,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 59, 21, 169, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 294,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 58, 21, 169, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 295,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 57, 21, 169, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 296,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 56, 21, 169, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 297,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 55, 21, 169, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 298,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 54, 21, 169, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 299,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 53, 21, 169, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 300,
                column: "TransactionTime",
                value: new DateTime(2022, 9, 10, 9, 52, 21, 169, DateTimeKind.Utc).AddTicks(8812));

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
    }
}
