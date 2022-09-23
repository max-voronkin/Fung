using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class Settings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Temperature",
                table: "LevelIndicatorTransactions",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    HeightUnit = table.Column<int>(type: "integer", nullable: false),
                    VolumeUnit = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "itaque", new DateTime(2022, 9, 23, 10, 47, 45, 597, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "omnis", new DateTime(2022, 9, 23, 10, 47, 45, 597, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "dolor", new DateTime(2022, 9, 23, 10, 47, 45, 597, DateTimeKind.Utc).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(384), 91.172811211897027, 17.0, new DateTime(2022, 9, 23, 10, 45, 45, 605, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(640), 932.13903385610206, 36.0, new DateTime(2022, 9, 23, 10, 44, 45, 605, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(654), 28.159822288482793, 37.0, new DateTime(2022, 9, 23, 10, 43, 45, 605, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(663), 191.80739290579251, 30.0, new DateTime(2022, 9, 23, 10, 42, 45, 605, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(670), 254.68749243599476, 18.0, new DateTime(2022, 9, 23, 10, 41, 45, 605, DateTimeKind.Utc).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(676), 542.64558249536242, 33.0, new DateTime(2022, 9, 23, 10, 40, 45, 605, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(682), 445.53302902021119, 11.0, new DateTime(2022, 9, 23, 10, 39, 45, 605, DateTimeKind.Utc).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(688), 911.36030520981274, 40.0, new DateTime(2022, 9, 23, 10, 38, 45, 605, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(695), 172.70984349122608, 19.0, new DateTime(2022, 9, 23, 10, 37, 45, 605, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(700), 316.90716565393495, 31.0, new DateTime(2022, 9, 23, 10, 36, 45, 605, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(707), 591.90346443921851, 9.0, new DateTime(2022, 9, 23, 10, 35, 45, 605, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(713), 67.075482380466127, 28.0, new DateTime(2022, 9, 23, 10, 34, 45, 605, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(719), 172.26631868001107, 19.0, new DateTime(2022, 9, 23, 10, 33, 45, 605, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(724), 889.18752454897856, 10.0, new DateTime(2022, 9, 23, 10, 32, 45, 605, DateTimeKind.Utc).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(730), 778.5937758164896, 33.0, new DateTime(2022, 9, 23, 10, 31, 45, 605, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(740), 682.99631728422105, 32.0, new DateTime(2022, 9, 23, 10, 30, 45, 605, DateTimeKind.Utc).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(747), 178.61265745599962, 22.0, new DateTime(2022, 9, 23, 10, 29, 45, 605, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(753), 303.09112267580485, 26.0, new DateTime(2022, 9, 23, 10, 28, 45, 605, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(759), 499.00736519182544, 19.0, new DateTime(2022, 9, 23, 10, 27, 45, 605, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(765), 521.31906282992657, 20.0, new DateTime(2022, 9, 23, 10, 26, 45, 605, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(771), 798.09491564003565, 33.0, new DateTime(2022, 9, 23, 10, 25, 45, 605, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(777), 584.89217940230003, 23.0, new DateTime(2022, 9, 23, 10, 24, 45, 605, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(783), 141.41662532961629, 5.0, new DateTime(2022, 9, 23, 10, 23, 45, 605, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(788), 385.63809845081573, 24.0, new DateTime(2022, 9, 23, 10, 22, 45, 605, DateTimeKind.Utc).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(794), 158.170826158057, 24.0, new DateTime(2022, 9, 23, 10, 21, 45, 605, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(800), 113.08988251927165, 21.0, new DateTime(2022, 9, 23, 10, 20, 45, 605, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(806), 177.45190101619988, 13.0, new DateTime(2022, 9, 23, 10, 19, 45, 605, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(812), 296.76175942866934, 32.0, new DateTime(2022, 9, 23, 10, 18, 45, 605, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(818), 312.17019500837159, 31.0, new DateTime(2022, 9, 23, 10, 17, 45, 605, DateTimeKind.Utc).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(823), 658.3851336482245, 6.0, new DateTime(2022, 9, 23, 10, 16, 45, 605, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(829), 863.67141407591771, 20.0, new DateTime(2022, 9, 23, 10, 15, 45, 605, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(835), 206.61872198590424, 20.0, new DateTime(2022, 9, 23, 10, 14, 45, 605, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(841), 271.99673252676172, 2.0, new DateTime(2022, 9, 23, 10, 13, 45, 605, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(847), 748.07242084581299, 0.0, new DateTime(2022, 9, 23, 10, 12, 45, 605, DateTimeKind.Utc).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(853), 309.27222444989832, 6.0, new DateTime(2022, 9, 23, 10, 11, 45, 605, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(859), 594.5377230301882, 14.0, new DateTime(2022, 9, 23, 10, 10, 45, 605, DateTimeKind.Utc).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(865), 465.52973854998891, 22.0, new DateTime(2022, 9, 23, 10, 9, 45, 605, DateTimeKind.Utc).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(871), 152.45582081083674, 2.0, new DateTime(2022, 9, 23, 10, 8, 45, 605, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(876), 819.28089009494147, 31.0, new DateTime(2022, 9, 23, 10, 7, 45, 605, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(882), 328.64339201832149, 7.0, new DateTime(2022, 9, 23, 10, 6, 45, 605, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(888), 834.3794219879635, 6.0, new DateTime(2022, 9, 23, 10, 5, 45, 605, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(894), 107.05722793798212, 38.0, new DateTime(2022, 9, 23, 10, 4, 45, 605, DateTimeKind.Utc).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(900), 961.45698073285655, 2.0, new DateTime(2022, 9, 23, 10, 3, 45, 605, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(906), 190.60553200362784, 13.0, new DateTime(2022, 9, 23, 10, 2, 45, 605, DateTimeKind.Utc).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(912), 51.395118340617607, 10.0, new DateTime(2022, 9, 23, 10, 1, 45, 605, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(918), 187.50666880564148, 10.0, new DateTime(2022, 9, 23, 10, 0, 45, 605, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(924), 486.53765881438591, 8.0, new DateTime(2022, 9, 23, 9, 59, 45, 605, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(929), 889.3231938712828, 14.0, new DateTime(2022, 9, 23, 9, 58, 45, 605, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(935), 795.26619204158135, 19.0, new DateTime(2022, 9, 23, 9, 57, 45, 605, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(945), 522.59837665789075, 5.0, new DateTime(2022, 9, 23, 9, 56, 45, 605, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(952), 648.91185509042452, 23.0, new DateTime(2022, 9, 23, 9, 55, 45, 605, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(958), 130.10746899943615, 6.0, new DateTime(2022, 9, 23, 9, 54, 45, 605, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(964), 879.23781598613095, 35.0, new DateTime(2022, 9, 23, 9, 53, 45, 605, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(970), 750.98377502927008, 15.0, new DateTime(2022, 9, 23, 9, 52, 45, 605, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(976), 824.74407090191517, 19.0, new DateTime(2022, 9, 23, 9, 51, 45, 605, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(982), 95.021765738096505, 36.0, new DateTime(2022, 9, 23, 9, 50, 45, 605, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(988), 154.45814225319333, 31.0, new DateTime(2022, 9, 23, 9, 49, 45, 605, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(994), 985.9302914038085, 38.0, new DateTime(2022, 9, 23, 9, 48, 45, 605, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(999), 960.58642587335873, 13.0, new DateTime(2022, 9, 23, 9, 47, 45, 605, DateTimeKind.Utc).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1005), 349.31154049696954, 9.0, new DateTime(2022, 9, 23, 9, 46, 45, 605, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1011), 798.48675932292053, 17.0, new DateTime(2022, 9, 23, 9, 45, 45, 605, DateTimeKind.Utc).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1017), 728.75447444365102, 0.0, new DateTime(2022, 9, 23, 9, 44, 45, 605, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1023), 626.63768781842464, 2.0, new DateTime(2022, 9, 23, 9, 43, 45, 605, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1029), 424.75226414888812, 33.0, new DateTime(2022, 9, 23, 9, 42, 45, 605, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1035), 43.701564827233305, 25.0, new DateTime(2022, 9, 23, 9, 41, 45, 605, DateTimeKind.Utc).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1040), 113.67955296647104, 26.0, new DateTime(2022, 9, 23, 9, 40, 45, 605, DateTimeKind.Utc).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1046), 498.70535995455344, 4.0, new DateTime(2022, 9, 23, 9, 39, 45, 605, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1052), 291.28484372512941, 8.0, new DateTime(2022, 9, 23, 9, 38, 45, 605, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1059), 984.64707231503326, 22.0, new DateTime(2022, 9, 23, 9, 37, 45, 605, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1064), 992.35807751009759, 24.0, new DateTime(2022, 9, 23, 9, 36, 45, 605, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1070), 860.81348537780684, 21.0, new DateTime(2022, 9, 23, 9, 35, 45, 605, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1076), 928.56178516725515, 18.0, new DateTime(2022, 9, 23, 9, 34, 45, 605, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1082), 343.15745743905899, 34.0, new DateTime(2022, 9, 23, 9, 33, 45, 605, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1088), 478.58595085449804, 37.0, new DateTime(2022, 9, 23, 9, 32, 45, 605, DateTimeKind.Utc).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1094), 667.64177639153195, 0.0, new DateTime(2022, 9, 23, 9, 31, 45, 605, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1100), 928.59459934013955, 12.0, new DateTime(2022, 9, 23, 9, 30, 45, 605, DateTimeKind.Utc).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1105), 1.1664408168420293, 32.0, new DateTime(2022, 9, 23, 9, 29, 45, 605, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1111), 995.61918734039534, 38.0, new DateTime(2022, 9, 23, 9, 28, 45, 605, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1117), 577.3953766547645, 25.0, new DateTime(2022, 9, 23, 9, 27, 45, 605, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1123), 499.95110101560556, 16.0, new DateTime(2022, 9, 23, 9, 26, 45, 605, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1130), 998.24509768496864, 35.0, new DateTime(2022, 9, 23, 9, 25, 45, 605, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1135), 556.52176084994812, 20.0, new DateTime(2022, 9, 23, 9, 24, 45, 605, DateTimeKind.Utc).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1142), 885.50194260193086, 38.0, new DateTime(2022, 9, 23, 9, 23, 45, 605, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1152), 355.65342102786479, 20.0, new DateTime(2022, 9, 23, 9, 22, 45, 605, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1159), 140.73430044024516, 13.0, new DateTime(2022, 9, 23, 9, 21, 45, 605, DateTimeKind.Utc).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1165), 543.10262501825707, 20.0, new DateTime(2022, 9, 23, 9, 20, 45, 605, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1171), 187.09350638371779, 16.0, new DateTime(2022, 9, 23, 9, 19, 45, 605, DateTimeKind.Utc).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1177), 496.97119259583513, 36.0, new DateTime(2022, 9, 23, 9, 18, 45, 605, DateTimeKind.Utc).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1183), 832.10893839682069, 14.0, new DateTime(2022, 9, 23, 9, 17, 45, 605, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1189), 50.252403111753942, 28.0, new DateTime(2022, 9, 23, 9, 16, 45, 605, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1195), 538.94549228697201, 18.0, new DateTime(2022, 9, 23, 9, 15, 45, 605, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1200), 27.664082992444605, 40.0, new DateTime(2022, 9, 23, 9, 14, 45, 605, DateTimeKind.Utc).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1206), 742.22426263692626, 7.0, new DateTime(2022, 9, 23, 9, 13, 45, 605, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1212), 958.90184445331431, 27.0, new DateTime(2022, 9, 23, 9, 12, 45, 605, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1218), 838.9109905773073, 13.0, new DateTime(2022, 9, 23, 9, 11, 45, 605, DateTimeKind.Utc).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1224), 500.61198518435123, 10.0, new DateTime(2022, 9, 23, 9, 10, 45, 605, DateTimeKind.Utc).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1230), 771.61594127208753, 32.0, new DateTime(2022, 9, 23, 9, 9, 45, 605, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1236), 854.20529246750368, 17.0, new DateTime(2022, 9, 23, 9, 8, 45, 605, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1242), 239.16011797252347, 18.0, new DateTime(2022, 9, 23, 9, 7, 45, 605, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1248), 444.50720593787395, 23.0, new DateTime(2022, 9, 23, 9, 6, 45, 605, DateTimeKind.Utc).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2547), 199.90670419314327, 32.0, new DateTime(2022, 9, 23, 9, 5, 45, 606, DateTimeKind.Utc).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2786), 801.89058094151687, 19.0, new DateTime(2022, 9, 23, 9, 4, 45, 606, DateTimeKind.Utc).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2798), 214.6438202094262, 8.0, new DateTime(2022, 9, 23, 9, 3, 45, 606, DateTimeKind.Utc).AddTicks(2831) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2834), 396.16722229601896, 0.0, new DateTime(2022, 9, 23, 9, 2, 45, 606, DateTimeKind.Utc).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2842), 58.301141308248596, 3.0, new DateTime(2022, 9, 23, 9, 1, 45, 606, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2849), 27.397413783081582, 30.0, new DateTime(2022, 9, 23, 9, 0, 45, 606, DateTimeKind.Utc).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2855), 204.95881258871151, 10.0, new DateTime(2022, 9, 23, 8, 59, 45, 606, DateTimeKind.Utc).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2861), 433.7694159967366, 22.0, new DateTime(2022, 9, 23, 8, 58, 45, 606, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2867), 917.09696979670139, 26.0, new DateTime(2022, 9, 23, 8, 57, 45, 606, DateTimeKind.Utc).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2873), 809.70593863309966, 38.0, new DateTime(2022, 9, 23, 8, 56, 45, 606, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2879), 710.13520355243327, 35.0, new DateTime(2022, 9, 23, 8, 55, 45, 606, DateTimeKind.Utc).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2885), 287.65091986568558, 8.0, new DateTime(2022, 9, 23, 8, 54, 45, 606, DateTimeKind.Utc).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2891), 163.15361515477156, 19.0, new DateTime(2022, 9, 23, 8, 53, 45, 606, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2896), 954.16160919713877, 26.0, new DateTime(2022, 9, 23, 8, 52, 45, 606, DateTimeKind.Utc).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2902), 117.1386267555703, 2.0, new DateTime(2022, 9, 23, 8, 51, 45, 606, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2908), 770.48546128717658, 14.0, new DateTime(2022, 9, 23, 8, 50, 45, 606, DateTimeKind.Utc).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2914), 302.72612311895017, 20.0, new DateTime(2022, 9, 23, 8, 49, 45, 606, DateTimeKind.Utc).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2920), 643.4329625726906, 7.0, new DateTime(2022, 9, 23, 8, 48, 45, 606, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2926), 629.75386912042563, 40.0, new DateTime(2022, 9, 23, 8, 47, 45, 606, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2932), 822.78290021371686, 23.0, new DateTime(2022, 9, 23, 8, 46, 45, 606, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2937), 596.0121938589956, 7.0, new DateTime(2022, 9, 23, 8, 45, 45, 606, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2943), 436.42699260788487, 34.0, new DateTime(2022, 9, 23, 8, 44, 45, 606, DateTimeKind.Utc).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2949), 790.37634108044153, 34.0, new DateTime(2022, 9, 23, 8, 43, 45, 606, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2954), 465.46875791279774, 30.0, new DateTime(2022, 9, 23, 8, 42, 45, 606, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2960), 965.96138381350409, 23.0, new DateTime(2022, 9, 23, 8, 41, 45, 606, DateTimeKind.Utc).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2966), 774.38236125637593, 2.0, new DateTime(2022, 9, 23, 8, 40, 45, 606, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2972), 794.40049170661814, 27.0, new DateTime(2022, 9, 23, 8, 39, 45, 606, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2977), 439.19884620195126, 31.0, new DateTime(2022, 9, 23, 8, 38, 45, 606, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2983), 893.08528956948635, 32.0, new DateTime(2022, 9, 23, 8, 37, 45, 606, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2989), 954.10472894021723, 27.0, new DateTime(2022, 9, 23, 8, 36, 45, 606, DateTimeKind.Utc).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(2995), 115.22371859949587, 38.0, new DateTime(2022, 9, 23, 8, 35, 45, 606, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3001), 105.35362725971143, 1.0, new DateTime(2022, 9, 23, 8, 34, 45, 606, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3007), 379.86473443941429, 29.0, new DateTime(2022, 9, 23, 8, 33, 45, 606, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3013), 10.000199226981143, 38.0, new DateTime(2022, 9, 23, 8, 32, 45, 606, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3018), 957.15750480391318, 11.0, new DateTime(2022, 9, 23, 8, 31, 45, 606, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3024), 374.7453332113264, 38.0, new DateTime(2022, 9, 23, 8, 30, 45, 606, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3029), 338.80590429227897, 29.0, new DateTime(2022, 9, 23, 8, 29, 45, 606, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3060), 327.8349708709365, 2.0, new DateTime(2022, 9, 23, 8, 28, 45, 606, DateTimeKind.Utc).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3066), 217.92838770114165, 21.0, new DateTime(2022, 9, 23, 8, 27, 45, 606, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3072), 134.69222181681994, 20.0, new DateTime(2022, 9, 23, 8, 26, 45, 606, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3077), 23.641802308252302, 8.0, new DateTime(2022, 9, 23, 8, 25, 45, 606, DateTimeKind.Utc).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3083), 127.41350334836898, 9.0, new DateTime(2022, 9, 23, 8, 24, 45, 606, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3089), 524.26257081763299, 3.0, new DateTime(2022, 9, 23, 8, 23, 45, 606, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3094), 543.88956984121012, 37.0, new DateTime(2022, 9, 23, 8, 22, 45, 606, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3100), 72.925002657423192, 17.0, new DateTime(2022, 9, 23, 8, 21, 45, 606, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3106), 755.33702917124765, 35.0, new DateTime(2022, 9, 23, 8, 20, 45, 606, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3112), 602.47316716513228, 38.0, new DateTime(2022, 9, 23, 8, 19, 45, 606, DateTimeKind.Utc).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3117), 170.48884137446606, 13.0, new DateTime(2022, 9, 23, 8, 18, 45, 606, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3123), 340.58338537450072, 2.0, new DateTime(2022, 9, 23, 8, 17, 45, 606, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3129), 685.63726618708074, 22.0, new DateTime(2022, 9, 23, 8, 16, 45, 606, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3134), 978.2547836828345, 29.0, new DateTime(2022, 9, 23, 8, 15, 45, 606, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3140), 385.56889275923891, 26.0, new DateTime(2022, 9, 23, 8, 14, 45, 606, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3146), 269.02677948698573, 19.0, new DateTime(2022, 9, 23, 8, 13, 45, 606, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3151), 209.59689016861637, 34.0, new DateTime(2022, 9, 23, 8, 12, 45, 606, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3157), 974.23985301012476, 34.0, new DateTime(2022, 9, 23, 8, 11, 45, 606, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3163), 527.01576164734922, 6.0, new DateTime(2022, 9, 23, 8, 10, 45, 606, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3168), 680.69998999308802, 38.0, new DateTime(2022, 9, 23, 8, 9, 45, 606, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3174), 326.73028863412856, 19.0, new DateTime(2022, 9, 23, 8, 8, 45, 606, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3180), 422.64120251624428, 11.0, new DateTime(2022, 9, 23, 8, 7, 45, 606, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3185), 252.73627848033942, 13.0, new DateTime(2022, 9, 23, 8, 6, 45, 606, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3191), 520.34125183736546, 9.0, new DateTime(2022, 9, 23, 8, 5, 45, 606, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3197), 161.34873655683379, 23.0, new DateTime(2022, 9, 23, 8, 4, 45, 606, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3203), 206.02710379588939, 25.0, new DateTime(2022, 9, 23, 8, 3, 45, 606, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3209), 939.36262272460499, 30.0, new DateTime(2022, 9, 23, 8, 2, 45, 606, DateTimeKind.Utc).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3214), 332.28623162373981, 27.0, new DateTime(2022, 9, 23, 8, 1, 45, 606, DateTimeKind.Utc).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3220), 958.77090825493258, 29.0, new DateTime(2022, 9, 23, 8, 0, 45, 606, DateTimeKind.Utc).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3226), 428.92674908502249, 10.0, new DateTime(2022, 9, 23, 7, 59, 45, 606, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3232), 437.41523101532243, 16.0, new DateTime(2022, 9, 23, 7, 58, 45, 606, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3238), 664.48047467106562, 3.0, new DateTime(2022, 9, 23, 7, 57, 45, 606, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3243), 16.718550085964566, 27.0, new DateTime(2022, 9, 23, 7, 56, 45, 606, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3249), 125.73752225036239, 11.0, new DateTime(2022, 9, 23, 7, 55, 45, 606, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3293), 927.42440543043824, 35.0, new DateTime(2022, 9, 23, 7, 54, 45, 606, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3300), 796.18135058005998, 7.0, new DateTime(2022, 9, 23, 7, 53, 45, 606, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3306), 269.29779589066015, 7.0, new DateTime(2022, 9, 23, 7, 52, 45, 606, DateTimeKind.Utc).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3312), 988.75545846409568, 17.0, new DateTime(2022, 9, 23, 7, 51, 45, 606, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3318), 897.26807492946989, 40.0, new DateTime(2022, 9, 23, 7, 50, 45, 606, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3323), 796.56337544538587, 16.0, new DateTime(2022, 9, 23, 7, 49, 45, 606, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3329), 326.83100641983265, 34.0, new DateTime(2022, 9, 23, 7, 48, 45, 606, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3335), 472.57683526757421, 32.0, new DateTime(2022, 9, 23, 7, 47, 45, 606, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3341), 476.24441902772554, 5.0, new DateTime(2022, 9, 23, 7, 46, 45, 606, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3347), 252.72935665933838, 34.0, new DateTime(2022, 9, 23, 7, 45, 45, 606, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3353), 881.11481624361238, 34.0, new DateTime(2022, 9, 23, 7, 44, 45, 606, DateTimeKind.Utc).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3359), 27.11829495514262, 26.0, new DateTime(2022, 9, 23, 7, 43, 45, 606, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3364), 571.17793821817008, 31.0, new DateTime(2022, 9, 23, 7, 42, 45, 606, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3370), 58.478978987947848, 25.0, new DateTime(2022, 9, 23, 7, 41, 45, 606, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3376), 738.57224865486319, 8.0, new DateTime(2022, 9, 23, 7, 40, 45, 606, DateTimeKind.Utc).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3382), 24.104209061510229, 22.0, new DateTime(2022, 9, 23, 7, 39, 45, 606, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3388), 32.826636726367767, 40.0, new DateTime(2022, 9, 23, 7, 38, 45, 606, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3394), 8.3282544894980326, 14.0, new DateTime(2022, 9, 23, 7, 37, 45, 606, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3400), 721.95929743871125, 3.0, new DateTime(2022, 9, 23, 7, 36, 45, 606, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3405), 41.718070779184323, 22.0, new DateTime(2022, 9, 23, 7, 35, 45, 606, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3411), 982.46586169029501, 24.0, new DateTime(2022, 9, 23, 7, 34, 45, 606, DateTimeKind.Utc).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3417), 686.40110846132325, 31.0, new DateTime(2022, 9, 23, 7, 33, 45, 606, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3423), 968.99307277076707, 16.0, new DateTime(2022, 9, 23, 7, 32, 45, 606, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3429), 898.25414070286206, 30.0, new DateTime(2022, 9, 23, 7, 31, 45, 606, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3434), 753.83139562944734, 23.0, new DateTime(2022, 9, 23, 7, 30, 45, 606, DateTimeKind.Utc).AddTicks(3438) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3440), 490.0367017490662, 40.0, new DateTime(2022, 9, 23, 7, 29, 45, 606, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3446), 320.72848422317099, 0.0, new DateTime(2022, 9, 23, 7, 28, 45, 606, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3452), 612.86786820270049, 40.0, new DateTime(2022, 9, 23, 7, 27, 45, 606, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3458), 647.13402561065391, 21.0, new DateTime(2022, 9, 23, 7, 26, 45, 606, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6296), 149.72683875669924, 21.0, new DateTime(2022, 9, 23, 7, 25, 45, 607, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6560), 637.84380490956221, 22.0, new DateTime(2022, 9, 23, 7, 24, 45, 607, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6573), 93.91446993496244, 25.0, new DateTime(2022, 9, 23, 7, 23, 45, 607, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6581), 903.75887060439527, 0.0, new DateTime(2022, 9, 23, 7, 22, 45, 607, DateTimeKind.Utc).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6587), 469.4593424849345, 8.0, new DateTime(2022, 9, 23, 7, 21, 45, 607, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6593), 351.58777634890004, 25.0, new DateTime(2022, 9, 23, 7, 20, 45, 607, DateTimeKind.Utc).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6598), 316.40588891228896, 37.0, new DateTime(2022, 9, 23, 7, 19, 45, 607, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6604), 895.56929508932558, 20.0, new DateTime(2022, 9, 23, 7, 18, 45, 607, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6610), 634.01783499588157, 5.0, new DateTime(2022, 9, 23, 7, 17, 45, 607, DateTimeKind.Utc).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6616), 41.37615317884147, 38.0, new DateTime(2022, 9, 23, 7, 16, 45, 607, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6622), 208.97611180230024, 11.0, new DateTime(2022, 9, 23, 7, 15, 45, 607, DateTimeKind.Utc).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6628), 620.58174390530814, 15.0, new DateTime(2022, 9, 23, 7, 14, 45, 607, DateTimeKind.Utc).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6634), 727.52057188331389, 3.0, new DateTime(2022, 9, 23, 7, 13, 45, 607, DateTimeKind.Utc).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6640), 945.29239931077075, 2.0, new DateTime(2022, 9, 23, 7, 12, 45, 607, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6645), 44.44635770756156, 34.0, new DateTime(2022, 9, 23, 7, 11, 45, 607, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6651), 508.38862532166615, 15.0, new DateTime(2022, 9, 23, 7, 10, 45, 607, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6657), 244.60188144112328, 14.0, new DateTime(2022, 9, 23, 7, 9, 45, 607, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6662), 125.93851950227852, 37.0, new DateTime(2022, 9, 23, 7, 8, 45, 607, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6668), 841.99243640353518, 6.0, new DateTime(2022, 9, 23, 7, 7, 45, 607, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6674), 474.26601695394055, 37.0, new DateTime(2022, 9, 23, 7, 6, 45, 607, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6680), 365.41930970937699, 19.0, new DateTime(2022, 9, 23, 7, 5, 45, 607, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6712), 653.53415770186211, 11.0, new DateTime(2022, 9, 23, 7, 4, 45, 607, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6718), 315.78539882999513, 27.0, new DateTime(2022, 9, 23, 7, 3, 45, 607, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6724), 128.67527362687525, 3.0, new DateTime(2022, 9, 23, 7, 2, 45, 607, DateTimeKind.Utc).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6731), 635.14068897300479, 3.0, new DateTime(2022, 9, 23, 7, 1, 45, 607, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6737), 433.2763738588755, 4.0, new DateTime(2022, 9, 23, 7, 0, 45, 607, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6743), 617.08838526059856, 13.0, new DateTime(2022, 9, 23, 6, 59, 45, 607, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6749), 51.267108024053428, 5.0, new DateTime(2022, 9, 23, 6, 58, 45, 607, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6755), 706.28529894405983, 23.0, new DateTime(2022, 9, 23, 6, 57, 45, 607, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6761), 923.71980630719406, 33.0, new DateTime(2022, 9, 23, 6, 56, 45, 607, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6767), 736.99587270624295, 24.0, new DateTime(2022, 9, 23, 6, 55, 45, 607, DateTimeKind.Utc).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6772), 838.64561812239754, 20.0, new DateTime(2022, 9, 23, 6, 54, 45, 607, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6778), 365.52209265498249, 8.0, new DateTime(2022, 9, 23, 6, 53, 45, 607, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6784), 398.74416733894748, 23.0, new DateTime(2022, 9, 23, 6, 52, 45, 607, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6790), 754.46615918494376, 3.0, new DateTime(2022, 9, 23, 6, 51, 45, 607, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6796), 817.83206072583209, 33.0, new DateTime(2022, 9, 23, 6, 50, 45, 607, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6802), 170.43778624598582, 35.0, new DateTime(2022, 9, 23, 6, 49, 45, 607, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6808), 306.2430620434983, 9.0, new DateTime(2022, 9, 23, 6, 48, 45, 607, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6814), 50.887068050757819, 38.0, new DateTime(2022, 9, 23, 6, 47, 45, 607, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6820), 531.53293848905605, 21.0, new DateTime(2022, 9, 23, 6, 46, 45, 607, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6826), 479.27285558631019, 38.0, new DateTime(2022, 9, 23, 6, 45, 45, 607, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6832), 964.29894625804775, 28.0, new DateTime(2022, 9, 23, 6, 44, 45, 607, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6838), 483.27868182375147, 20.0, new DateTime(2022, 9, 23, 6, 43, 45, 607, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6843), 711.33808462853926, 3.0, new DateTime(2022, 9, 23, 6, 42, 45, 607, DateTimeKind.Utc).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6849), 977.78451854962793, 34.0, new DateTime(2022, 9, 23, 6, 41, 45, 607, DateTimeKind.Utc).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6855), 980.84238132617793, 32.0, new DateTime(2022, 9, 23, 6, 40, 45, 607, DateTimeKind.Utc).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6861), 439.61852991561966, 20.0, new DateTime(2022, 9, 23, 6, 39, 45, 607, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6867), 273.80368676961166, 20.0, new DateTime(2022, 9, 23, 6, 38, 45, 607, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6873), 208.17354802777953, 32.0, new DateTime(2022, 9, 23, 6, 37, 45, 607, DateTimeKind.Utc).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6879), 715.07517966464366, 28.0, new DateTime(2022, 9, 23, 6, 36, 45, 607, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6885), 47.140900693316333, 40.0, new DateTime(2022, 9, 23, 6, 35, 45, 607, DateTimeKind.Utc).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6891), 763.39415214518976, 17.0, new DateTime(2022, 9, 23, 6, 34, 45, 607, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6896), 582.26964988823659, 40.0, new DateTime(2022, 9, 23, 6, 33, 45, 607, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6902), 623.75639083001886, 20.0, new DateTime(2022, 9, 23, 6, 32, 45, 607, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6908), 874.91934152708893, 35.0, new DateTime(2022, 9, 23, 6, 31, 45, 607, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6939), 633.60776551022877, 15.0, new DateTime(2022, 9, 23, 6, 30, 45, 607, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6945), 23.433899162077054, 39.0, new DateTime(2022, 9, 23, 6, 29, 45, 607, DateTimeKind.Utc).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6951), 118.34810620314906, 14.0, new DateTime(2022, 9, 23, 6, 28, 45, 607, DateTimeKind.Utc).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6957), 723.36722382275252, 34.0, new DateTime(2022, 9, 23, 6, 27, 45, 607, DateTimeKind.Utc).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6963), 273.48964714229737, 6.0, new DateTime(2022, 9, 23, 6, 26, 45, 607, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6969), 624.4471776335115, 2.0, new DateTime(2022, 9, 23, 6, 25, 45, 607, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6975), 113.78977133593915, 5.0, new DateTime(2022, 9, 23, 6, 24, 45, 607, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6981), 183.2105667965196, 12.0, new DateTime(2022, 9, 23, 6, 23, 45, 607, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6987), 361.71796236517639, 25.0, new DateTime(2022, 9, 23, 6, 22, 45, 607, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6993), 433.38953628211317, 8.0, new DateTime(2022, 9, 23, 6, 21, 45, 607, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(6999), 379.99200540237553, 7.0, new DateTime(2022, 9, 23, 6, 20, 45, 607, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7005), 472.02861593742296, 25.0, new DateTime(2022, 9, 23, 6, 19, 45, 607, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7011), 740.32295830883186, 32.0, new DateTime(2022, 9, 23, 6, 18, 45, 607, DateTimeKind.Utc).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7017), 519.22072553560702, 27.0, new DateTime(2022, 9, 23, 6, 17, 45, 607, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7022), 367.74642799851722, 4.0, new DateTime(2022, 9, 23, 6, 16, 45, 607, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7028), 179.69226237487823, 15.0, new DateTime(2022, 9, 23, 6, 15, 45, 607, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7034), 619.18625908234822, 6.0, new DateTime(2022, 9, 23, 6, 14, 45, 607, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7040), 446.13814527319261, 40.0, new DateTime(2022, 9, 23, 6, 13, 45, 607, DateTimeKind.Utc).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7046), 772.54728264228572, 23.0, new DateTime(2022, 9, 23, 6, 12, 45, 607, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7052), 534.53503431016566, 15.0, new DateTime(2022, 9, 23, 6, 11, 45, 607, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7058), 195.41655483165454, 17.0, new DateTime(2022, 9, 23, 6, 10, 45, 607, DateTimeKind.Utc).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7064), 622.52447885393212, 38.0, new DateTime(2022, 9, 23, 6, 9, 45, 607, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7070), 749.3102631923598, 19.0, new DateTime(2022, 9, 23, 6, 8, 45, 607, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7076), 181.56016156852615, 8.0, new DateTime(2022, 9, 23, 6, 7, 45, 607, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7082), 520.25632064445279, 17.0, new DateTime(2022, 9, 23, 6, 6, 45, 607, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7088), 786.49093442524565, 9.0, new DateTime(2022, 9, 23, 6, 5, 45, 607, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7093), 396.89570082738999, 21.0, new DateTime(2022, 9, 23, 6, 4, 45, 607, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7099), 803.2829812593958, 34.0, new DateTime(2022, 9, 23, 6, 3, 45, 607, DateTimeKind.Utc).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7106), 244.66464762788377, 24.0, new DateTime(2022, 9, 23, 6, 2, 45, 607, DateTimeKind.Utc).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7112), 546.69511715671842, 12.0, new DateTime(2022, 9, 23, 6, 1, 45, 607, DateTimeKind.Utc).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7117), 843.4111714765661, 31.0, new DateTime(2022, 9, 23, 6, 0, 45, 607, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7123), 945.99034181377374, 18.0, new DateTime(2022, 9, 23, 5, 59, 45, 607, DateTimeKind.Utc).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7129), 607.9242689612073, 27.0, new DateTime(2022, 9, 23, 5, 58, 45, 607, DateTimeKind.Utc).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7135), 554.53037474688472, 18.0, new DateTime(2022, 9, 23, 5, 57, 45, 607, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7163), 12.237949687330495, 36.0, new DateTime(2022, 9, 23, 5, 56, 45, 607, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7170), 21.867850901185925, 20.0, new DateTime(2022, 9, 23, 5, 55, 45, 607, DateTimeKind.Utc).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7176), 416.70487518436761, 29.0, new DateTime(2022, 9, 23, 5, 54, 45, 607, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7183), 449.25352438988972, 34.0, new DateTime(2022, 9, 23, 5, 53, 45, 607, DateTimeKind.Utc).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7189), 192.59207998448446, 5.0, new DateTime(2022, 9, 23, 5, 52, 45, 607, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7195), 975.01691238355136, 37.0, new DateTime(2022, 9, 23, 5, 51, 45, 607, DateTimeKind.Utc).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7201), 862.70480117569014, 33.0, new DateTime(2022, 9, 23, 5, 50, 45, 607, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7207), 848.99155995224464, 39.0, new DateTime(2022, 9, 23, 5, 49, 45, 607, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7213), 287.53235580026472, 34.0, new DateTime(2022, 9, 23, 5, 48, 45, 607, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7219), 76.905745503373481, 1.0, new DateTime(2022, 9, 23, 5, 47, 45, 607, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 607, DateTimeKind.Utc).AddTicks(7225), 777.23547020887349, 14.0, new DateTime(2022, 9, 23, 5, 46, 45, 607, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8323), new DateTime(2022, 9, 23, 10, 45, 45, 600, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8777), new DateTime(2022, 9, 23, 10, 44, 45, 600, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8787), new DateTime(2022, 9, 23, 10, 43, 45, 600, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8793), new DateTime(2022, 9, 23, 10, 42, 45, 600, DateTimeKind.Utc).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8799), new DateTime(2022, 9, 23, 10, 41, 45, 600, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8806), new DateTime(2022, 9, 23, 10, 40, 45, 600, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8812), new DateTime(2022, 9, 23, 10, 39, 45, 600, DateTimeKind.Utc).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8817), new DateTime(2022, 9, 23, 10, 38, 45, 600, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8823), new DateTime(2022, 9, 23, 10, 37, 45, 600, DateTimeKind.Utc).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8829), new DateTime(2022, 9, 23, 10, 36, 45, 600, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8913), new DateTime(2022, 9, 23, 10, 35, 45, 600, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8920), new DateTime(2022, 9, 23, 10, 34, 45, 600, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8926), new DateTime(2022, 9, 23, 10, 33, 45, 600, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8932), new DateTime(2022, 9, 23, 10, 32, 45, 600, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8938), new DateTime(2022, 9, 23, 10, 31, 45, 600, DateTimeKind.Utc).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8944), new DateTime(2022, 9, 23, 10, 30, 45, 600, DateTimeKind.Utc).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8950), new DateTime(2022, 9, 23, 10, 29, 45, 600, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8956), new DateTime(2022, 9, 23, 10, 28, 45, 600, DateTimeKind.Utc).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8962), new DateTime(2022, 9, 23, 10, 27, 45, 600, DateTimeKind.Utc).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8968), new DateTime(2022, 9, 23, 10, 26, 45, 600, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8974), new DateTime(2022, 9, 23, 10, 25, 45, 600, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8980), new DateTime(2022, 9, 23, 10, 24, 45, 600, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8990), new DateTime(2022, 9, 23, 10, 23, 45, 600, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(8996), new DateTime(2022, 9, 23, 10, 22, 45, 600, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9002), new DateTime(2022, 9, 23, 10, 21, 45, 600, DateTimeKind.Utc).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9008), new DateTime(2022, 9, 23, 10, 20, 45, 600, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9014), new DateTime(2022, 9, 23, 10, 19, 45, 600, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9020), new DateTime(2022, 9, 23, 10, 18, 45, 600, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9026), new DateTime(2022, 9, 23, 10, 17, 45, 600, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9032), new DateTime(2022, 9, 23, 10, 16, 45, 600, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9038), new DateTime(2022, 9, 23, 10, 15, 45, 600, DateTimeKind.Utc).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9044), new DateTime(2022, 9, 23, 10, 14, 45, 600, DateTimeKind.Utc).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9050), new DateTime(2022, 9, 23, 10, 13, 45, 600, DateTimeKind.Utc).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9056), new DateTime(2022, 9, 23, 10, 12, 45, 600, DateTimeKind.Utc).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9062), new DateTime(2022, 9, 23, 10, 11, 45, 600, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9068), new DateTime(2022, 9, 23, 10, 10, 45, 600, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9074), new DateTime(2022, 9, 23, 10, 9, 45, 600, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9080), new DateTime(2022, 9, 23, 10, 8, 45, 600, DateTimeKind.Utc).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9086), new DateTime(2022, 9, 23, 10, 7, 45, 600, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9092), new DateTime(2022, 9, 23, 10, 6, 45, 600, DateTimeKind.Utc).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9098), new DateTime(2022, 9, 23, 10, 5, 45, 600, DateTimeKind.Utc).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9104), new DateTime(2022, 9, 23, 10, 4, 45, 600, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9110), new DateTime(2022, 9, 23, 10, 3, 45, 600, DateTimeKind.Utc).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9116), new DateTime(2022, 9, 23, 10, 2, 45, 600, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9122), new DateTime(2022, 9, 23, 10, 1, 45, 600, DateTimeKind.Utc).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9127), new DateTime(2022, 9, 23, 10, 0, 45, 600, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9134), new DateTime(2022, 9, 23, 9, 59, 45, 600, DateTimeKind.Utc).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9140), new DateTime(2022, 9, 23, 9, 58, 45, 600, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9146), new DateTime(2022, 9, 23, 9, 57, 45, 600, DateTimeKind.Utc).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9152), new DateTime(2022, 9, 23, 9, 56, 45, 600, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9160), new DateTime(2022, 9, 23, 9, 55, 45, 600, DateTimeKind.Utc).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9166), new DateTime(2022, 9, 23, 9, 54, 45, 600, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9172), new DateTime(2022, 9, 23, 9, 53, 45, 600, DateTimeKind.Utc).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9178), new DateTime(2022, 9, 23, 9, 52, 45, 600, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9184), new DateTime(2022, 9, 23, 9, 51, 45, 600, DateTimeKind.Utc).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9190), new DateTime(2022, 9, 23, 9, 50, 45, 600, DateTimeKind.Utc).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9196), new DateTime(2022, 9, 23, 9, 49, 45, 600, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9202), new DateTime(2022, 9, 23, 9, 48, 45, 600, DateTimeKind.Utc).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9208), new DateTime(2022, 9, 23, 9, 47, 45, 600, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9213), new DateTime(2022, 9, 23, 9, 46, 45, 600, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9219), new DateTime(2022, 9, 23, 9, 45, 45, 600, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9225), new DateTime(2022, 9, 23, 9, 44, 45, 600, DateTimeKind.Utc).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9232), new DateTime(2022, 9, 23, 9, 43, 45, 600, DateTimeKind.Utc).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9238), new DateTime(2022, 9, 23, 9, 42, 45, 600, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9244), new DateTime(2022, 9, 23, 9, 41, 45, 600, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9250), new DateTime(2022, 9, 23, 9, 40, 45, 600, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9256), new DateTime(2022, 9, 23, 9, 39, 45, 600, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9290), new DateTime(2022, 9, 23, 9, 38, 45, 600, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9296), new DateTime(2022, 9, 23, 9, 37, 45, 600, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9302), new DateTime(2022, 9, 23, 9, 36, 45, 600, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9308), new DateTime(2022, 9, 23, 9, 35, 45, 600, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9314), new DateTime(2022, 9, 23, 9, 34, 45, 600, DateTimeKind.Utc).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9320), new DateTime(2022, 9, 23, 9, 33, 45, 600, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9326), new DateTime(2022, 9, 23, 9, 32, 45, 600, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9332), new DateTime(2022, 9, 23, 9, 31, 45, 600, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9338), new DateTime(2022, 9, 23, 9, 30, 45, 600, DateTimeKind.Utc).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9344), new DateTime(2022, 9, 23, 9, 29, 45, 600, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9350), new DateTime(2022, 9, 23, 9, 28, 45, 600, DateTimeKind.Utc).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9358), new DateTime(2022, 9, 23, 9, 27, 45, 600, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9364), new DateTime(2022, 9, 23, 9, 26, 45, 600, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9371), new DateTime(2022, 9, 23, 9, 25, 45, 600, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9377), new DateTime(2022, 9, 23, 9, 24, 45, 600, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9382), new DateTime(2022, 9, 23, 9, 23, 45, 600, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9388), new DateTime(2022, 9, 23, 9, 22, 45, 600, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9394), new DateTime(2022, 9, 23, 9, 21, 45, 600, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9400), new DateTime(2022, 9, 23, 9, 20, 45, 600, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9406), new DateTime(2022, 9, 23, 9, 19, 45, 600, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9413), new DateTime(2022, 9, 23, 9, 18, 45, 600, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9419), new DateTime(2022, 9, 23, 9, 17, 45, 600, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9425), new DateTime(2022, 9, 23, 9, 16, 45, 600, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9431), new DateTime(2022, 9, 23, 9, 15, 45, 600, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9437), new DateTime(2022, 9, 23, 9, 14, 45, 600, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9442), new DateTime(2022, 9, 23, 9, 13, 45, 600, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9448), new DateTime(2022, 9, 23, 9, 12, 45, 600, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9454), new DateTime(2022, 9, 23, 9, 11, 45, 600, DateTimeKind.Utc).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9460), new DateTime(2022, 9, 23, 9, 10, 45, 600, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9466), new DateTime(2022, 9, 23, 9, 9, 45, 600, DateTimeKind.Utc).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9473), new DateTime(2022, 9, 23, 9, 8, 45, 600, DateTimeKind.Utc).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9479), new DateTime(2022, 9, 23, 9, 7, 45, 600, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 600, DateTimeKind.Utc).AddTicks(9484), new DateTime(2022, 9, 23, 9, 6, 45, 600, DateTimeKind.Utc).AddTicks(9487) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7337), new DateTime(2022, 9, 23, 9, 5, 45, 602, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7533), new DateTime(2022, 9, 23, 9, 4, 45, 602, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7541), new DateTime(2022, 9, 23, 9, 3, 45, 602, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7545), new DateTime(2022, 9, 23, 9, 2, 45, 602, DateTimeKind.Utc).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7550), new DateTime(2022, 9, 23, 9, 1, 45, 602, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7553), new DateTime(2022, 9, 23, 9, 0, 45, 602, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7558), new DateTime(2022, 9, 23, 8, 59, 45, 602, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7562), new DateTime(2022, 9, 23, 8, 58, 45, 602, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7566), new DateTime(2022, 9, 23, 8, 57, 45, 602, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7570), new DateTime(2022, 9, 23, 8, 56, 45, 602, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7574), new DateTime(2022, 9, 23, 8, 55, 45, 602, DateTimeKind.Utc).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7577), new DateTime(2022, 9, 23, 8, 54, 45, 602, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7581), new DateTime(2022, 9, 23, 8, 53, 45, 602, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7585), new DateTime(2022, 9, 23, 8, 52, 45, 602, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7589), new DateTime(2022, 9, 23, 8, 51, 45, 602, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7593), new DateTime(2022, 9, 23, 8, 50, 45, 602, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7597), new DateTime(2022, 9, 23, 8, 49, 45, 602, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7601), new DateTime(2022, 9, 23, 8, 48, 45, 602, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7605), new DateTime(2022, 9, 23, 8, 47, 45, 602, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7609), new DateTime(2022, 9, 23, 8, 46, 45, 602, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7612), new DateTime(2022, 9, 23, 8, 45, 45, 602, DateTimeKind.Utc).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7616), new DateTime(2022, 9, 23, 8, 44, 45, 602, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7620), new DateTime(2022, 9, 23, 8, 43, 45, 602, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7624), new DateTime(2022, 9, 23, 8, 42, 45, 602, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7628), new DateTime(2022, 9, 23, 8, 41, 45, 602, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7632), new DateTime(2022, 9, 23, 8, 40, 45, 602, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7657), new DateTime(2022, 9, 23, 8, 39, 45, 602, DateTimeKind.Utc).AddTicks(7659) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7662), new DateTime(2022, 9, 23, 8, 38, 45, 602, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7665), new DateTime(2022, 9, 23, 8, 37, 45, 602, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7669), new DateTime(2022, 9, 23, 8, 36, 45, 602, DateTimeKind.Utc).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7673), new DateTime(2022, 9, 23, 8, 35, 45, 602, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7677), new DateTime(2022, 9, 23, 8, 34, 45, 602, DateTimeKind.Utc).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7681), new DateTime(2022, 9, 23, 8, 33, 45, 602, DateTimeKind.Utc).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7685), new DateTime(2022, 9, 23, 8, 32, 45, 602, DateTimeKind.Utc).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7689), new DateTime(2022, 9, 23, 8, 31, 45, 602, DateTimeKind.Utc).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7693), new DateTime(2022, 9, 23, 8, 30, 45, 602, DateTimeKind.Utc).AddTicks(7694) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7697), new DateTime(2022, 9, 23, 8, 29, 45, 602, DateTimeKind.Utc).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7701), new DateTime(2022, 9, 23, 8, 28, 45, 602, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7705), new DateTime(2022, 9, 23, 8, 27, 45, 602, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7709), new DateTime(2022, 9, 23, 8, 26, 45, 602, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7712), new DateTime(2022, 9, 23, 8, 25, 45, 602, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7716), new DateTime(2022, 9, 23, 8, 24, 45, 602, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7720), new DateTime(2022, 9, 23, 8, 23, 45, 602, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7724), new DateTime(2022, 9, 23, 8, 22, 45, 602, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7728), new DateTime(2022, 9, 23, 8, 21, 45, 602, DateTimeKind.Utc).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7732), new DateTime(2022, 9, 23, 8, 20, 45, 602, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7736), new DateTime(2022, 9, 23, 8, 19, 45, 602, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7740), new DateTime(2022, 9, 23, 8, 18, 45, 602, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7744), new DateTime(2022, 9, 23, 8, 17, 45, 602, DateTimeKind.Utc).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7748), new DateTime(2022, 9, 23, 8, 16, 45, 602, DateTimeKind.Utc).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7752), new DateTime(2022, 9, 23, 8, 15, 45, 602, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7755), new DateTime(2022, 9, 23, 8, 14, 45, 602, DateTimeKind.Utc).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7759), new DateTime(2022, 9, 23, 8, 13, 45, 602, DateTimeKind.Utc).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7763), new DateTime(2022, 9, 23, 8, 12, 45, 602, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7767), new DateTime(2022, 9, 23, 8, 11, 45, 602, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7771), new DateTime(2022, 9, 23, 8, 10, 45, 602, DateTimeKind.Utc).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7775), new DateTime(2022, 9, 23, 8, 9, 45, 602, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7779), new DateTime(2022, 9, 23, 8, 8, 45, 602, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7783), new DateTime(2022, 9, 23, 8, 7, 45, 602, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7787), new DateTime(2022, 9, 23, 8, 6, 45, 602, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7790), new DateTime(2022, 9, 23, 8, 5, 45, 602, DateTimeKind.Utc).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7794), new DateTime(2022, 9, 23, 8, 4, 45, 602, DateTimeKind.Utc).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7798), new DateTime(2022, 9, 23, 8, 3, 45, 602, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7802), new DateTime(2022, 9, 23, 8, 2, 45, 602, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7806), new DateTime(2022, 9, 23, 8, 1, 45, 602, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7810), new DateTime(2022, 9, 23, 8, 0, 45, 602, DateTimeKind.Utc).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7814), new DateTime(2022, 9, 23, 7, 59, 45, 602, DateTimeKind.Utc).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7818), new DateTime(2022, 9, 23, 7, 58, 45, 602, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7822), new DateTime(2022, 9, 23, 7, 57, 45, 602, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7826), new DateTime(2022, 9, 23, 7, 56, 45, 602, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7830), new DateTime(2022, 9, 23, 7, 55, 45, 602, DateTimeKind.Utc).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7834), new DateTime(2022, 9, 23, 7, 54, 45, 602, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7838), new DateTime(2022, 9, 23, 7, 53, 45, 602, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7842), new DateTime(2022, 9, 23, 7, 52, 45, 602, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7846), new DateTime(2022, 9, 23, 7, 51, 45, 602, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7850), new DateTime(2022, 9, 23, 7, 50, 45, 602, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7854), new DateTime(2022, 9, 23, 7, 49, 45, 602, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7857), new DateTime(2022, 9, 23, 7, 48, 45, 602, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7861), new DateTime(2022, 9, 23, 7, 47, 45, 602, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7865), new DateTime(2022, 9, 23, 7, 46, 45, 602, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7869), new DateTime(2022, 9, 23, 7, 45, 45, 602, DateTimeKind.Utc).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7873), new DateTime(2022, 9, 23, 7, 44, 45, 602, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7880), new DateTime(2022, 9, 23, 7, 43, 45, 602, DateTimeKind.Utc).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7884), new DateTime(2022, 9, 23, 7, 42, 45, 602, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7888), new DateTime(2022, 9, 23, 7, 41, 45, 602, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7892), new DateTime(2022, 9, 23, 7, 40, 45, 602, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7896), new DateTime(2022, 9, 23, 7, 39, 45, 602, DateTimeKind.Utc).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7899), new DateTime(2022, 9, 23, 7, 38, 45, 602, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7903), new DateTime(2022, 9, 23, 7, 37, 45, 602, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7907), new DateTime(2022, 9, 23, 7, 36, 45, 602, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7911), new DateTime(2022, 9, 23, 7, 35, 45, 602, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7915), new DateTime(2022, 9, 23, 7, 34, 45, 602, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7919), new DateTime(2022, 9, 23, 7, 33, 45, 602, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7923), new DateTime(2022, 9, 23, 7, 32, 45, 602, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7927), new DateTime(2022, 9, 23, 7, 31, 45, 602, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7931), new DateTime(2022, 9, 23, 7, 30, 45, 602, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7935), new DateTime(2022, 9, 23, 7, 29, 45, 602, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7938), new DateTime(2022, 9, 23, 7, 28, 45, 602, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7942), new DateTime(2022, 9, 23, 7, 27, 45, 602, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 602, DateTimeKind.Utc).AddTicks(7946), new DateTime(2022, 9, 23, 7, 26, 45, 602, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(8787), new DateTime(2022, 9, 23, 7, 25, 45, 603, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(8982), new DateTime(2022, 9, 23, 7, 24, 45, 603, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(8990), new DateTime(2022, 9, 23, 7, 23, 45, 603, DateTimeKind.Utc).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(8995), new DateTime(2022, 9, 23, 7, 22, 45, 603, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(8999), new DateTime(2022, 9, 23, 7, 21, 45, 603, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9003), new DateTime(2022, 9, 23, 7, 20, 45, 603, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9007), new DateTime(2022, 9, 23, 7, 19, 45, 603, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9011), new DateTime(2022, 9, 23, 7, 18, 45, 603, DateTimeKind.Utc).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9015), new DateTime(2022, 9, 23, 7, 17, 45, 603, DateTimeKind.Utc).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9019), new DateTime(2022, 9, 23, 7, 16, 45, 603, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9023), new DateTime(2022, 9, 23, 7, 15, 45, 603, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9026), new DateTime(2022, 9, 23, 7, 14, 45, 603, DateTimeKind.Utc).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9030), new DateTime(2022, 9, 23, 7, 13, 45, 603, DateTimeKind.Utc).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9034), new DateTime(2022, 9, 23, 7, 12, 45, 603, DateTimeKind.Utc).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9038), new DateTime(2022, 9, 23, 7, 11, 45, 603, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9042), new DateTime(2022, 9, 23, 7, 10, 45, 603, DateTimeKind.Utc).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9046), new DateTime(2022, 9, 23, 7, 9, 45, 603, DateTimeKind.Utc).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9050), new DateTime(2022, 9, 23, 7, 8, 45, 603, DateTimeKind.Utc).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9054), new DateTime(2022, 9, 23, 7, 7, 45, 603, DateTimeKind.Utc).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9058), new DateTime(2022, 9, 23, 7, 6, 45, 603, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9062), new DateTime(2022, 9, 23, 7, 5, 45, 603, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9066), new DateTime(2022, 9, 23, 7, 4, 45, 603, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9070), new DateTime(2022, 9, 23, 7, 3, 45, 603, DateTimeKind.Utc).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9074), new DateTime(2022, 9, 23, 7, 2, 45, 603, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9078), new DateTime(2022, 9, 23, 7, 1, 45, 603, DateTimeKind.Utc).AddTicks(9079) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9081), new DateTime(2022, 9, 23, 7, 0, 45, 603, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9085), new DateTime(2022, 9, 23, 6, 59, 45, 603, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9089), new DateTime(2022, 9, 23, 6, 58, 45, 603, DateTimeKind.Utc).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9093), new DateTime(2022, 9, 23, 6, 57, 45, 603, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9097), new DateTime(2022, 9, 23, 6, 56, 45, 603, DateTimeKind.Utc).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9101), new DateTime(2022, 9, 23, 6, 55, 45, 603, DateTimeKind.Utc).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9105), new DateTime(2022, 9, 23, 6, 54, 45, 603, DateTimeKind.Utc).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9108), new DateTime(2022, 9, 23, 6, 53, 45, 603, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9113), new DateTime(2022, 9, 23, 6, 52, 45, 603, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9117), new DateTime(2022, 9, 23, 6, 51, 45, 603, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9120), new DateTime(2022, 9, 23, 6, 50, 45, 603, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9124), new DateTime(2022, 9, 23, 6, 49, 45, 603, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9128), new DateTime(2022, 9, 23, 6, 48, 45, 603, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9132), new DateTime(2022, 9, 23, 6, 47, 45, 603, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9136), new DateTime(2022, 9, 23, 6, 46, 45, 603, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9140), new DateTime(2022, 9, 23, 6, 45, 45, 603, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9144), new DateTime(2022, 9, 23, 6, 44, 45, 603, DateTimeKind.Utc).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9148), new DateTime(2022, 9, 23, 6, 43, 45, 603, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9152), new DateTime(2022, 9, 23, 6, 42, 45, 603, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9156), new DateTime(2022, 9, 23, 6, 41, 45, 603, DateTimeKind.Utc).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9160), new DateTime(2022, 9, 23, 6, 40, 45, 603, DateTimeKind.Utc).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9164), new DateTime(2022, 9, 23, 6, 39, 45, 603, DateTimeKind.Utc).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9168), new DateTime(2022, 9, 23, 6, 38, 45, 603, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9172), new DateTime(2022, 9, 23, 6, 37, 45, 603, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9176), new DateTime(2022, 9, 23, 6, 36, 45, 603, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9180), new DateTime(2022, 9, 23, 6, 35, 45, 603, DateTimeKind.Utc).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9187), new DateTime(2022, 9, 23, 6, 34, 45, 603, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9192), new DateTime(2022, 9, 23, 6, 33, 45, 603, DateTimeKind.Utc).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9196), new DateTime(2022, 9, 23, 6, 32, 45, 603, DateTimeKind.Utc).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9200), new DateTime(2022, 9, 23, 6, 31, 45, 603, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9204), new DateTime(2022, 9, 23, 6, 30, 45, 603, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9208), new DateTime(2022, 9, 23, 6, 29, 45, 603, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9212), new DateTime(2022, 9, 23, 6, 28, 45, 603, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9216), new DateTime(2022, 9, 23, 6, 27, 45, 603, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9220), new DateTime(2022, 9, 23, 6, 26, 45, 603, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9224), new DateTime(2022, 9, 23, 6, 25, 45, 603, DateTimeKind.Utc).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9228), new DateTime(2022, 9, 23, 6, 24, 45, 603, DateTimeKind.Utc).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9232), new DateTime(2022, 9, 23, 6, 23, 45, 603, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9235), new DateTime(2022, 9, 23, 6, 22, 45, 603, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9239), new DateTime(2022, 9, 23, 6, 21, 45, 603, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9243), new DateTime(2022, 9, 23, 6, 20, 45, 603, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9247), new DateTime(2022, 9, 23, 6, 19, 45, 603, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9251), new DateTime(2022, 9, 23, 6, 18, 45, 603, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9255), new DateTime(2022, 9, 23, 6, 17, 45, 603, DateTimeKind.Utc).AddTicks(9256) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9259), new DateTime(2022, 9, 23, 6, 16, 45, 603, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9262), new DateTime(2022, 9, 23, 6, 15, 45, 603, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9266), new DateTime(2022, 9, 23, 6, 14, 45, 603, DateTimeKind.Utc).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9270), new DateTime(2022, 9, 23, 6, 13, 45, 603, DateTimeKind.Utc).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9274), new DateTime(2022, 9, 23, 6, 12, 45, 603, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9278), new DateTime(2022, 9, 23, 6, 11, 45, 603, DateTimeKind.Utc).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9282), new DateTime(2022, 9, 23, 6, 10, 45, 603, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9286), new DateTime(2022, 9, 23, 6, 9, 45, 603, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9290), new DateTime(2022, 9, 23, 6, 8, 45, 603, DateTimeKind.Utc).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9294), new DateTime(2022, 9, 23, 6, 7, 45, 603, DateTimeKind.Utc).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9298), new DateTime(2022, 9, 23, 6, 6, 45, 603, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9302), new DateTime(2022, 9, 23, 6, 5, 45, 603, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9305), new DateTime(2022, 9, 23, 6, 4, 45, 603, DateTimeKind.Utc).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9309), new DateTime(2022, 9, 23, 6, 3, 45, 603, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9313), new DateTime(2022, 9, 23, 6, 2, 45, 603, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9317), new DateTime(2022, 9, 23, 6, 1, 45, 603, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9321), new DateTime(2022, 9, 23, 6, 0, 45, 603, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9325), new DateTime(2022, 9, 23, 5, 59, 45, 603, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9329), new DateTime(2022, 9, 23, 5, 58, 45, 603, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9333), new DateTime(2022, 9, 23, 5, 57, 45, 603, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9336), new DateTime(2022, 9, 23, 5, 56, 45, 603, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9340), new DateTime(2022, 9, 23, 5, 55, 45, 603, DateTimeKind.Utc).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9344), new DateTime(2022, 9, 23, 5, 54, 45, 603, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9348), new DateTime(2022, 9, 23, 5, 53, 45, 603, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9352), new DateTime(2022, 9, 23, 5, 52, 45, 603, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9356), new DateTime(2022, 9, 23, 5, 51, 45, 603, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9359), new DateTime(2022, 9, 23, 5, 50, 45, 603, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9363), new DateTime(2022, 9, 23, 5, 49, 45, 603, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9367), new DateTime(2022, 9, 23, 5, 48, 45, 603, DateTimeKind.Utc).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9371), new DateTime(2022, 9, 23, 5, 47, 45, 603, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 603, DateTimeKind.Utc).AddTicks(9375), new DateTime(2022, 9, 23, 5, 46, 45, 603, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "HeightUnit", "UserId", "VolumeUnit" },
                values: new object[,]
                {
                    { 1, 0, 1, 0 },
                    { 2, 0, 2, 0 },
                    { 3, 0, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Token" },
                values: new object[] { "West Stuartberg", "80faffe5-d628-4563-a15c-587bb377a6d4" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Token" },
                values: new object[] { "Ullrichborough", "754a6b2a-36e3-4039-bfba-b8cabd47ac10" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Token" },
                values: new object[] { "Lake Sadie", "f102881b-c392-42fd-8d50-ef78a0a3f4cd" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 573, DateTimeKind.Utc).AddTicks(2128), "Fc+AXWg/SfPgnjtd2acJ3gADkT07101JEFQ+H4mJ/oE=", "ztux7SpwXUIOXcjre4ZsS/qkYm+aL1O/rEJMezsCv2g=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 579, DateTimeKind.Utc).AddTicks(3883), "IqM4yAOjbHwXLA0IeAIJcvb+PIAUC59aQ4rQ6OYiNnM=", "L1zYIcHuwu0SDyJAtTUMbDRc5bE3Z6zH+I126TA/TKY=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 586, DateTimeKind.Utc).AddTicks(4957), "mZnVihIAQHYy8/EaBn/AqursqHFel/BrIMBHFK0cavw=", "wvv8aWlbnWKNlsyfRfrTRBAdP/AIX8ct4JOOiTyFA8A=" });

            migrationBuilder.CreateIndex(
                name: "IX_Settings_UserId",
                table: "Settings",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.AlterColumn<decimal>(
                name: "Temperature",
                table: "LevelIndicatorTransactions",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

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
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3585), 194.3542242223314, 5m, new DateTime(2022, 9, 15, 9, 38, 35, 870, DateTimeKind.Utc).AddTicks(3589) });

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
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 870, DateTimeKind.Utc).AddTicks(3846), 330.3836322888892, 34m, new DateTime(2022, 9, 15, 8, 56, 35, 870, DateTimeKind.Utc).AddTicks(3850) });

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
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 871, DateTimeKind.Utc).AddTicks(5758), 278.97856882717878, 9m, new DateTime(2022, 9, 15, 8, 8, 35, 871, DateTimeKind.Utc).AddTicks(5762) });

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
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8664), 445.04026935751693, 39m, new DateTime(2022, 9, 15, 6, 23, 35, 872, DateTimeKind.Utc).AddTicks(8667) });

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
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 15, 10, 16, 35, 872, DateTimeKind.Utc).AddTicks(8849), 192.04657147411197, 17m, new DateTime(2022, 9, 15, 5, 52, 35, 872, DateTimeKind.Utc).AddTicks(8853) });

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
        }
    }
}
