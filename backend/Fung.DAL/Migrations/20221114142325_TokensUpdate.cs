using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fung.DAL.Migrations
{
    public partial class TokensUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.CreateTable(
                name: "Tokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tokens_Users_UserId",
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
                values: new object[] { "iusto", new DateTime(2022, 11, 14, 14, 23, 24, 793, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "atque", new DateTime(2022, 11, 14, 14, 23, 24, 793, DateTimeKind.Utc).AddTicks(7426) });

            migrationBuilder.UpdateData(
                table: "FuelTanks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "UpdatedAt" },
                values: new object[] { "cum", new DateTime(2022, 11, 14, 14, 23, 24, 793, DateTimeKind.Utc).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(7836), 13.141796899714841, 25.0, new DateTime(2022, 11, 14, 14, 21, 24, 805, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8145), 848.22611985739866, 17.0, new DateTime(2022, 11, 14, 14, 20, 24, 805, DateTimeKind.Utc).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8158), 208.35085648492824, 12.0, new DateTime(2022, 11, 14, 14, 19, 24, 805, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8166), 453.25511418735431, 14.0, new DateTime(2022, 11, 14, 14, 18, 24, 805, DateTimeKind.Utc).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8173), 305.2537120209542, 22.0, new DateTime(2022, 11, 14, 14, 17, 24, 805, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8184), 648.96126502225036, 1.0, new DateTime(2022, 11, 14, 14, 16, 24, 805, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8190), 836.40583917606784, 21.0, new DateTime(2022, 11, 14, 14, 15, 24, 805, DateTimeKind.Utc).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8196), 702.376649794537, 25.0, new DateTime(2022, 11, 14, 14, 14, 24, 805, DateTimeKind.Utc).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8202), 962.43500262600332, 20.0, new DateTime(2022, 11, 14, 14, 13, 24, 805, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8208), 157.8163331089294, 38.0, new DateTime(2022, 11, 14, 14, 12, 24, 805, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8214), 223.49518281715984, 5.0, new DateTime(2022, 11, 14, 14, 11, 24, 805, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8219), 641.58472436186605, 37.0, new DateTime(2022, 11, 14, 14, 10, 24, 805, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8225), 171.43110097898517, 9.0, new DateTime(2022, 11, 14, 14, 9, 24, 805, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8231), 329.63553602664052, 5.0, new DateTime(2022, 11, 14, 14, 8, 24, 805, DateTimeKind.Utc).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8237), 839.25912233754832, 20.0, new DateTime(2022, 11, 14, 14, 7, 24, 805, DateTimeKind.Utc).AddTicks(8241) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8243), 220.29410510099046, 37.0, new DateTime(2022, 11, 14, 14, 6, 24, 805, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8249), 118.09676296213323, 29.0, new DateTime(2022, 11, 14, 14, 5, 24, 805, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8255), 191.62707788645338, 30.0, new DateTime(2022, 11, 14, 14, 4, 24, 805, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8261), 112.48628650023996, 9.0, new DateTime(2022, 11, 14, 14, 3, 24, 805, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8267), 515.51611208159227, new DateTime(2022, 11, 14, 14, 2, 24, 805, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8273), 177.28425732212216, 15.0, new DateTime(2022, 11, 14, 14, 1, 24, 805, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8279), 581.56136155814363, 33.0, new DateTime(2022, 11, 14, 14, 0, 24, 805, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8284), 489.58166187121788, 38.0, new DateTime(2022, 11, 14, 13, 59, 24, 805, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8290), 265.19873797422446, 20.0, new DateTime(2022, 11, 14, 13, 58, 24, 805, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8296), 414.46972112761438, 5.0, new DateTime(2022, 11, 14, 13, 57, 24, 805, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8302), 605.41817708356371, 33.0, new DateTime(2022, 11, 14, 13, 56, 24, 805, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8308), 666.26629533023765, 5.0, new DateTime(2022, 11, 14, 13, 55, 24, 805, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8314), 202.66572081107248, 6.0, new DateTime(2022, 11, 14, 13, 54, 24, 805, DateTimeKind.Utc).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8319), 924.3957066374154, 35.0, new DateTime(2022, 11, 14, 13, 53, 24, 805, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8325), 700.18462385936061, 35.0, new DateTime(2022, 11, 14, 13, 52, 24, 805, DateTimeKind.Utc).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8331), 526.50622525328436, 30.0, new DateTime(2022, 11, 14, 13, 51, 24, 805, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8337), 291.8474845860768, 7.0, new DateTime(2022, 11, 14, 13, 50, 24, 805, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8343), 772.08466517619763, 10.0, new DateTime(2022, 11, 14, 13, 49, 24, 805, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8349), 451.17887659776966, 34.0, new DateTime(2022, 11, 14, 13, 48, 24, 805, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8355), 836.91773268894769, 26.0, new DateTime(2022, 11, 14, 13, 47, 24, 805, DateTimeKind.Utc).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8361), 937.07458158652082, 15.0, new DateTime(2022, 11, 14, 13, 46, 24, 805, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8366), 332.30668959462685, 12.0, new DateTime(2022, 11, 14, 13, 45, 24, 805, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8372), 189.85272002879182, 12.0, new DateTime(2022, 11, 14, 13, 44, 24, 805, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8378), 531.08879351563974, 23.0, new DateTime(2022, 11, 14, 13, 43, 24, 805, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8388), 159.95308670527498, 14.0, new DateTime(2022, 11, 14, 13, 42, 24, 805, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8394), 256.77531525616394, 22.0, new DateTime(2022, 11, 14, 13, 41, 24, 805, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8400), 324.96958649731175, 16.0, new DateTime(2022, 11, 14, 13, 40, 24, 805, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8406), 329.26050767613003, 37.0, new DateTime(2022, 11, 14, 13, 39, 24, 805, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8412), 614.96951474250852, 12.0, new DateTime(2022, 11, 14, 13, 38, 24, 805, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8418), 736.30585600308336, 34.0, new DateTime(2022, 11, 14, 13, 37, 24, 805, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8424), 707.76999820979256, 29.0, new DateTime(2022, 11, 14, 13, 36, 24, 805, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8430), 988.36304066799551, 22.0, new DateTime(2022, 11, 14, 13, 35, 24, 805, DateTimeKind.Utc).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8435), 206.43417058733959, 19.0, new DateTime(2022, 11, 14, 13, 34, 24, 805, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8441), 330.9339094137809, 32.0, new DateTime(2022, 11, 14, 13, 33, 24, 805, DateTimeKind.Utc).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8447), 671.04867448008827, 10.0, new DateTime(2022, 11, 14, 13, 32, 24, 805, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8453), 911.91543302110983, 8.0, new DateTime(2022, 11, 14, 13, 31, 24, 805, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8459), 927.35416247505634, 1.0, new DateTime(2022, 11, 14, 13, 30, 24, 805, DateTimeKind.Utc).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8465), 414.1768316114576, 4.0, new DateTime(2022, 11, 14, 13, 29, 24, 805, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8471), 680.85159974825751, 27.0, new DateTime(2022, 11, 14, 13, 28, 24, 805, DateTimeKind.Utc).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8476), 178.32322216469919, 18.0, new DateTime(2022, 11, 14, 13, 27, 24, 805, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8482), 472.65845357937843, 4.0, new DateTime(2022, 11, 14, 13, 26, 24, 805, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8488), 377.8444735780032, 18.0, new DateTime(2022, 11, 14, 13, 25, 24, 805, DateTimeKind.Utc).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8494), 79.678371926479528, 4.0, new DateTime(2022, 11, 14, 13, 24, 24, 805, DateTimeKind.Utc).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8499), 399.5942764798437, 29.0, new DateTime(2022, 11, 14, 13, 23, 24, 805, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8505), 769.29996324826618, 10.0, new DateTime(2022, 11, 14, 13, 22, 24, 805, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8511), 708.97672031043987, 26.0, new DateTime(2022, 11, 14, 13, 21, 24, 805, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8517), 941.21827600207041, 11.0, new DateTime(2022, 11, 14, 13, 20, 24, 805, DateTimeKind.Utc).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8523), 996.78359353795145, 11.0, new DateTime(2022, 11, 14, 13, 19, 24, 805, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8529), 88.587014325350211, 28.0, new DateTime(2022, 11, 14, 13, 18, 24, 805, DateTimeKind.Utc).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8534), 421.7294030325541, 23.0, new DateTime(2022, 11, 14, 13, 17, 24, 805, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8540), 69.024826408147334, 34.0, new DateTime(2022, 11, 14, 13, 16, 24, 805, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8546), 690.77058751082632, 16.0, new DateTime(2022, 11, 14, 13, 15, 24, 805, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8552), 306.57245260310651, 16.0, new DateTime(2022, 11, 14, 13, 14, 24, 805, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8558), 384.27731203103122, 11.0, new DateTime(2022, 11, 14, 13, 13, 24, 805, DateTimeKind.Utc).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8564), 547.84001537058623, 7.0, new DateTime(2022, 11, 14, 13, 12, 24, 805, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8569), 860.02164519823339, 13.0, new DateTime(2022, 11, 14, 13, 11, 24, 805, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8575), 168.07014013222343, 33.0, new DateTime(2022, 11, 14, 13, 10, 24, 805, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8581), 524.80555927653131, 13.0, new DateTime(2022, 11, 14, 13, 9, 24, 805, DateTimeKind.Utc).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8591), 1.7426992834219668, 30.0, new DateTime(2022, 11, 14, 13, 8, 24, 805, DateTimeKind.Utc).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8597), 969.67570857854435, 8.0, new DateTime(2022, 11, 14, 13, 7, 24, 805, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8602), 722.527969518379, 3.0, new DateTime(2022, 11, 14, 13, 6, 24, 805, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8608), 62.402994533955592, 24.0, new DateTime(2022, 11, 14, 13, 5, 24, 805, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8614), 652.25695926231958, 19.0, new DateTime(2022, 11, 14, 13, 4, 24, 805, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8620), 725.49988803714609, 31.0, new DateTime(2022, 11, 14, 13, 3, 24, 805, DateTimeKind.Utc).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8626), 559.16347287220685, 33.0, new DateTime(2022, 11, 14, 13, 2, 24, 805, DateTimeKind.Utc).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8631), 778.30531068264361, 9.0, new DateTime(2022, 11, 14, 13, 1, 24, 805, DateTimeKind.Utc).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8637), 504.26634077704637, 38.0, new DateTime(2022, 11, 14, 13, 0, 24, 805, DateTimeKind.Utc).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8643), 449.36690090432808, 9.0, new DateTime(2022, 11, 14, 12, 59, 24, 805, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8649), 379.43939563901483, 12.0, new DateTime(2022, 11, 14, 12, 58, 24, 805, DateTimeKind.Utc).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8655), 736.79901425472713, 30.0, new DateTime(2022, 11, 14, 12, 57, 24, 805, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8661), 971.02678215506319, 21.0, new DateTime(2022, 11, 14, 12, 56, 24, 805, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8667), 336.33412409177652, 23.0, new DateTime(2022, 11, 14, 12, 55, 24, 805, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8672), 196.5337794844726, 28.0, new DateTime(2022, 11, 14, 12, 54, 24, 805, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8678), 641.98597215824395, 29.0, new DateTime(2022, 11, 14, 12, 53, 24, 805, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8684), 435.48754593161834, 24.0, new DateTime(2022, 11, 14, 12, 52, 24, 805, DateTimeKind.Utc).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8690), 259.99482494228033, 26.0, new DateTime(2022, 11, 14, 12, 51, 24, 805, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8696), 381.73624552297593, 4.0, new DateTime(2022, 11, 14, 12, 50, 24, 805, DateTimeKind.Utc).AddTicks(8699) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8702), 573.33228577834745, 5.0, new DateTime(2022, 11, 14, 12, 49, 24, 805, DateTimeKind.Utc).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8707), 229.2150879964282, 8.0, new DateTime(2022, 11, 14, 12, 48, 24, 805, DateTimeKind.Utc).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8713), 421.25186822798912, 22.0, new DateTime(2022, 11, 14, 12, 47, 24, 805, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8719), 96.769710301901185, 18.0, new DateTime(2022, 11, 14, 12, 46, 24, 805, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8725), 334.64571817050859, 19.0, new DateTime(2022, 11, 14, 12, 45, 24, 805, DateTimeKind.Utc).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8731), 417.13572925622935, 8.0, new DateTime(2022, 11, 14, 12, 44, 24, 805, DateTimeKind.Utc).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8737), 917.23833797747113, new DateTime(2022, 11, 14, 12, 43, 24, 805, DateTimeKind.Utc).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 805, DateTimeKind.Utc).AddTicks(8743), 569.92873960625707, 40.0, new DateTime(2022, 11, 14, 12, 42, 24, 805, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 806, DateTimeKind.Utc).AddTicks(9762), 349.73869999625896, 26.0, new DateTime(2022, 11, 14, 12, 41, 24, 806, DateTimeKind.Utc).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(30), 178.61359962148072, 31.0, new DateTime(2022, 11, 14, 12, 40, 24, 807, DateTimeKind.Utc).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(41), 652.61150807495164, 33.0, new DateTime(2022, 11, 14, 12, 39, 24, 807, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(49), 905.78125275344053, 13.0, new DateTime(2022, 11, 14, 12, 38, 24, 807, DateTimeKind.Utc).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(57), 264.83982560250331, 39.0, new DateTime(2022, 11, 14, 12, 37, 24, 807, DateTimeKind.Utc).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(63), 997.40760714838223, 40.0, new DateTime(2022, 11, 14, 12, 36, 24, 807, DateTimeKind.Utc).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(69), 346.6311721034466, 19.0, new DateTime(2022, 11, 14, 12, 35, 24, 807, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(75), 910.34339223297945, 20.0, new DateTime(2022, 11, 14, 12, 34, 24, 807, DateTimeKind.Utc).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(80), 368.24561684317661, 10.0, new DateTime(2022, 11, 14, 12, 33, 24, 807, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(86), 725.39417079782129, 30.0, new DateTime(2022, 11, 14, 12, 32, 24, 807, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(92), 893.91551803639481, 39.0, new DateTime(2022, 11, 14, 12, 31, 24, 807, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(97), 130.08101087597012, 9.0, new DateTime(2022, 11, 14, 12, 30, 24, 807, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(103), 763.42445058925387, 2.0, new DateTime(2022, 11, 14, 12, 29, 24, 807, DateTimeKind.Utc).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(108), 122.0683378862546, 1.0, new DateTime(2022, 11, 14, 12, 28, 24, 807, DateTimeKind.Utc).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(114), 729.24409354298518, 11.0, new DateTime(2022, 11, 14, 12, 27, 24, 807, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(120), 175.0807716807532, 33.0, new DateTime(2022, 11, 14, 12, 26, 24, 807, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(125), 460.98074141493652, 1.0, new DateTime(2022, 11, 14, 12, 25, 24, 807, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(132), 412.02111618740258, 15.0, new DateTime(2022, 11, 14, 12, 24, 24, 807, DateTimeKind.Utc).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(147), 420.5148728778928, 2.0, new DateTime(2022, 11, 14, 12, 23, 24, 807, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(152), 418.13431732452176, 27.0, new DateTime(2022, 11, 14, 12, 22, 24, 807, DateTimeKind.Utc).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(158), 215.64282839920901, 5.0, new DateTime(2022, 11, 14, 12, 21, 24, 807, DateTimeKind.Utc).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(164), 549.27796401996522, 10.0, new DateTime(2022, 11, 14, 12, 20, 24, 807, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(169), 864.00429715991208, 36.0, new DateTime(2022, 11, 14, 12, 19, 24, 807, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(175), 153.35206784915823, 34.0, new DateTime(2022, 11, 14, 12, 18, 24, 807, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(180), 299.37035401888465, 8.0, new DateTime(2022, 11, 14, 12, 17, 24, 807, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(186), 722.02699818093242, 37.0, new DateTime(2022, 11, 14, 12, 16, 24, 807, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(197), 548.91536882961032, 13.0, new DateTime(2022, 11, 14, 12, 15, 24, 807, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(202), 615.97395111899459, 11.0, new DateTime(2022, 11, 14, 12, 14, 24, 807, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(208), 835.79840861266996, 19.0, new DateTime(2022, 11, 14, 12, 13, 24, 807, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(213), 445.44439618487297, 17.0, new DateTime(2022, 11, 14, 12, 12, 24, 807, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(219), 477.94372809861704, 19.0, new DateTime(2022, 11, 14, 12, 11, 24, 807, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(224), 571.61858641285369, 23.0, new DateTime(2022, 11, 14, 12, 10, 24, 807, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(230), 623.85176483318651, 34.0, new DateTime(2022, 11, 14, 12, 9, 24, 807, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(235), 257.23110248345813, 16.0, new DateTime(2022, 11, 14, 12, 8, 24, 807, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(241), 65.620112580354601, 5.0, new DateTime(2022, 11, 14, 12, 7, 24, 807, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(246), 752.48929673544171, 2.0, new DateTime(2022, 11, 14, 12, 6, 24, 807, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(252), 537.35891649259349, 12.0, new DateTime(2022, 11, 14, 12, 5, 24, 807, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(257), 329.46546069595195, 33.0, new DateTime(2022, 11, 14, 12, 4, 24, 807, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(263), 420.47075600646735, 38.0, new DateTime(2022, 11, 14, 12, 3, 24, 807, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(268), 314.68948812593686, 12.0, new DateTime(2022, 11, 14, 12, 2, 24, 807, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(274), 163.91383675143001, 22.0, new DateTime(2022, 11, 14, 12, 1, 24, 807, DateTimeKind.Utc).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(279), 142.83308825692831, 27.0, new DateTime(2022, 11, 14, 12, 0, 24, 807, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(285), 168.19770848102678, 9.0, new DateTime(2022, 11, 14, 11, 59, 24, 807, DateTimeKind.Utc).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(290), 3.8114730994719404, 25.0, new DateTime(2022, 11, 14, 11, 58, 24, 807, DateTimeKind.Utc).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(296), 582.33193777874271, 21.0, new DateTime(2022, 11, 14, 11, 57, 24, 807, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(301), 450.4360595526876, 33.0, new DateTime(2022, 11, 14, 11, 56, 24, 807, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(307), 801.22219889548512, 6.0, new DateTime(2022, 11, 14, 11, 55, 24, 807, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(312), 112.37650628600049, 40.0, new DateTime(2022, 11, 14, 11, 54, 24, 807, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(318), 529.93878074673478, 28.0, new DateTime(2022, 11, 14, 11, 53, 24, 807, DateTimeKind.Utc).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(324), 215.33739190398825, 16.0, new DateTime(2022, 11, 14, 11, 52, 24, 807, DateTimeKind.Utc).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(329), 553.94587402858406, 12.0, new DateTime(2022, 11, 14, 11, 51, 24, 807, DateTimeKind.Utc).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(334), 398.17845237594139, 34.0, new DateTime(2022, 11, 14, 11, 50, 24, 807, DateTimeKind.Utc).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(340), 745.73658916172963, 24.0, new DateTime(2022, 11, 14, 11, 49, 24, 807, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(346), 396.8641349006009, 27.0, new DateTime(2022, 11, 14, 11, 48, 24, 807, DateTimeKind.Utc).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(351), 594.15941248142656, 29.0, new DateTime(2022, 11, 14, 11, 47, 24, 807, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(357), 227.1957921132196, 17.0, new DateTime(2022, 11, 14, 11, 46, 24, 807, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(362), 255.94312815278209, 17.0, new DateTime(2022, 11, 14, 11, 45, 24, 807, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(368), 713.26841593676647, 14.0, new DateTime(2022, 11, 14, 11, 44, 24, 807, DateTimeKind.Utc).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(373), 694.76321042407699, 34.0, new DateTime(2022, 11, 14, 11, 43, 24, 807, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(379), 744.94995144849076, 28.0, new DateTime(2022, 11, 14, 11, 42, 24, 807, DateTimeKind.Utc).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(389), 448.5905629557443, 31.0, new DateTime(2022, 11, 14, 11, 41, 24, 807, DateTimeKind.Utc).AddTicks(393) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(395), 589.52247007348058, 12.0, new DateTime(2022, 11, 14, 11, 40, 24, 807, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(400), 109.33947150766043, 36.0, new DateTime(2022, 11, 14, 11, 39, 24, 807, DateTimeKind.Utc).AddTicks(403) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(405), 691.01179278388247, 7.0, new DateTime(2022, 11, 14, 11, 38, 24, 807, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(411), 468.88546534226492, new DateTime(2022, 11, 14, 11, 37, 24, 807, DateTimeKind.Utc).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(416), 257.37410452579468, 5.0, new DateTime(2022, 11, 14, 11, 36, 24, 807, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(422), 673.31611956080769, 7.0, new DateTime(2022, 11, 14, 11, 35, 24, 807, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(427), 86.83294111281792, 39.0, new DateTime(2022, 11, 14, 11, 34, 24, 807, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(433), 618.0665805182125, 18.0, new DateTime(2022, 11, 14, 11, 33, 24, 807, DateTimeKind.Utc).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(439), 623.1152341172841, 14.0, new DateTime(2022, 11, 14, 11, 32, 24, 807, DateTimeKind.Utc).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(444), 47.571428436404496, 31.0, new DateTime(2022, 11, 14, 11, 31, 24, 807, DateTimeKind.Utc).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(450), 456.59469248424921, 10.0, new DateTime(2022, 11, 14, 11, 30, 24, 807, DateTimeKind.Utc).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(456), 216.35264504738171, 16.0, new DateTime(2022, 11, 14, 11, 29, 24, 807, DateTimeKind.Utc).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(461), 271.37596613739044, 31.0, new DateTime(2022, 11, 14, 11, 28, 24, 807, DateTimeKind.Utc).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(467), 227.57714842000289, 10.0, new DateTime(2022, 11, 14, 11, 27, 24, 807, DateTimeKind.Utc).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(473), 354.91819037554717, 34.0, new DateTime(2022, 11, 14, 11, 26, 24, 807, DateTimeKind.Utc).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(478), 411.6141934505103, 40.0, new DateTime(2022, 11, 14, 11, 25, 24, 807, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(484), 642.8404068050794, 40.0, new DateTime(2022, 11, 14, 11, 24, 24, 807, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(489), 179.61417127605216, 27.0, new DateTime(2022, 11, 14, 11, 23, 24, 807, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(495), 970.75594094727762, 32.0, new DateTime(2022, 11, 14, 11, 22, 24, 807, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(500), 306.9626594264555, 5.0, new DateTime(2022, 11, 14, 11, 21, 24, 807, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(506), 172.45149355821832, 1.0, new DateTime(2022, 11, 14, 11, 20, 24, 807, DateTimeKind.Utc).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(511), 755.56600227018271, 28.0, new DateTime(2022, 11, 14, 11, 19, 24, 807, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(517), 727.98768265795957, 21.0, new DateTime(2022, 11, 14, 11, 18, 24, 807, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(522), 293.8767327183981, 28.0, new DateTime(2022, 11, 14, 11, 17, 24, 807, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(528), 569.29964340360345, 10.0, new DateTime(2022, 11, 14, 11, 16, 24, 807, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(533), 769.82630197194601, 21.0, new DateTime(2022, 11, 14, 11, 15, 24, 807, DateTimeKind.Utc).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(539), 935.19204435720349, 38.0, new DateTime(2022, 11, 14, 11, 14, 24, 807, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(544), 161.3282581736425, 1.0, new DateTime(2022, 11, 14, 11, 13, 24, 807, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(549), 265.40383811994286, 29.0, new DateTime(2022, 11, 14, 11, 12, 24, 807, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(555), 113.30013469332134, 28.0, new DateTime(2022, 11, 14, 11, 11, 24, 807, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(560), 687.11583609114905, 2.0, new DateTime(2022, 11, 14, 11, 10, 24, 807, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(566), 249.93430734217347, 6.0, new DateTime(2022, 11, 14, 11, 9, 24, 807, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(571), 390.23977032854526, 0.0, new DateTime(2022, 11, 14, 11, 8, 24, 807, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(581), 736.49638623627288, 20.0, new DateTime(2022, 11, 14, 11, 7, 24, 807, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(587), 659.95051204869003, 26.0, new DateTime(2022, 11, 14, 11, 6, 24, 807, DateTimeKind.Utc).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(592), 149.04687114520644, 12.0, new DateTime(2022, 11, 14, 11, 5, 24, 807, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(598), 419.04865827821169, 23.0, new DateTime(2022, 11, 14, 11, 4, 24, 807, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(603), 94.722094822458075, 16.0, new DateTime(2022, 11, 14, 11, 3, 24, 807, DateTimeKind.Utc).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 807, DateTimeKind.Utc).AddTicks(609), 201.02134925175031, 8.0, new DateTime(2022, 11, 14, 11, 2, 24, 807, DateTimeKind.Utc).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1624), 496.31226937817365, 9.0, new DateTime(2022, 11, 14, 11, 1, 24, 808, DateTimeKind.Utc).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1887), 588.06840139266183, 16.0, new DateTime(2022, 11, 14, 11, 0, 24, 808, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1899), 466.51098865517923, 8.0, new DateTime(2022, 11, 14, 10, 59, 24, 808, DateTimeKind.Utc).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1907), 334.89674506085811, 34.0, new DateTime(2022, 11, 14, 10, 58, 24, 808, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1914), 338.62003935329068, 36.0, new DateTime(2022, 11, 14, 10, 57, 24, 808, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1919), 591.12731449789646, 38.0, new DateTime(2022, 11, 14, 10, 56, 24, 808, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1925), 460.38458981534757, 4.0, new DateTime(2022, 11, 14, 10, 55, 24, 808, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1931), 835.46926584835865, 10.0, new DateTime(2022, 11, 14, 10, 54, 24, 808, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1937), 909.8851023532095, 17.0, new DateTime(2022, 11, 14, 10, 53, 24, 808, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1943), 839.24244561448791, 4.0, new DateTime(2022, 11, 14, 10, 52, 24, 808, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1949), 48.865870585122259, 25.0, new DateTime(2022, 11, 14, 10, 51, 24, 808, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1954), 748.60056750907563, 14.0, new DateTime(2022, 11, 14, 10, 50, 24, 808, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1960), 115.30670263428988, 31.0, new DateTime(2022, 11, 14, 10, 49, 24, 808, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1966), 668.74340707734245, 32.0, new DateTime(2022, 11, 14, 10, 48, 24, 808, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1971), 516.91488197115495, 35.0, new DateTime(2022, 11, 14, 10, 47, 24, 808, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1977), 952.80918471292102, 13.0, new DateTime(2022, 11, 14, 10, 46, 24, 808, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1982), 897.4528375465278, 20.0, new DateTime(2022, 11, 14, 10, 45, 24, 808, DateTimeKind.Utc).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1988), 724.28040572321856, 13.0, new DateTime(2022, 11, 14, 10, 44, 24, 808, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(1994), 216.03298460375277, 38.0, new DateTime(2022, 11, 14, 10, 43, 24, 808, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2000), 333.74429809651662, 16.0, new DateTime(2022, 11, 14, 10, 42, 24, 808, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2006), 454.58939572935839, 37.0, new DateTime(2022, 11, 14, 10, 41, 24, 808, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2011), 96.169332348812191, 13.0, new DateTime(2022, 11, 14, 10, 40, 24, 808, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2017), 932.91747446633065, 6.0, new DateTime(2022, 11, 14, 10, 39, 24, 808, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2023), 656.99698181197721, 4.0, new DateTime(2022, 11, 14, 10, 38, 24, 808, DateTimeKind.Utc).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2028), 835.31248025322361, 22.0, new DateTime(2022, 11, 14, 10, 37, 24, 808, DateTimeKind.Utc).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2034), 336.60439445086263, 34.0, new DateTime(2022, 11, 14, 10, 36, 24, 808, DateTimeKind.Utc).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2039), 741.48872395249941, 5.0, new DateTime(2022, 11, 14, 10, 35, 24, 808, DateTimeKind.Utc).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2045), 863.48704677461285, 28.0, new DateTime(2022, 11, 14, 10, 34, 24, 808, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2050), 286.5610673711293, 20.0, new DateTime(2022, 11, 14, 10, 33, 24, 808, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2056), 422.49295005536788, 26.0, new DateTime(2022, 11, 14, 10, 32, 24, 808, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2061), 915.74696140596404, 38.0, new DateTime(2022, 11, 14, 10, 31, 24, 808, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2067), 124.88979398338074, 27.0, new DateTime(2022, 11, 14, 10, 30, 24, 808, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2072), 878.13107742740544, 10.0, new DateTime(2022, 11, 14, 10, 29, 24, 808, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2078), 38.914888424058105, 35.0, new DateTime(2022, 11, 14, 10, 28, 24, 808, DateTimeKind.Utc).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2089), 996.69326272842625, 24.0, new DateTime(2022, 11, 14, 10, 27, 24, 808, DateTimeKind.Utc).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2095), 155.939237797722, 40.0, new DateTime(2022, 11, 14, 10, 26, 24, 808, DateTimeKind.Utc).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2100), 327.66708322930384, 31.0, new DateTime(2022, 11, 14, 10, 25, 24, 808, DateTimeKind.Utc).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2106), 209.20483093389385, 4.0, new DateTime(2022, 11, 14, 10, 24, 24, 808, DateTimeKind.Utc).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2111), 376.61511122883053, 4.0, new DateTime(2022, 11, 14, 10, 23, 24, 808, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2117), 30.910021409488952, 4.0, new DateTime(2022, 11, 14, 10, 22, 24, 808, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2123), 861.73052637794808, 12.0, new DateTime(2022, 11, 14, 10, 21, 24, 808, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2128), 343.85276353896876, 19.0, new DateTime(2022, 11, 14, 10, 20, 24, 808, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2134), 308.52692066360953, 33.0, new DateTime(2022, 11, 14, 10, 19, 24, 808, DateTimeKind.Utc).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2139), 22.804106459575756, 18.0, new DateTime(2022, 11, 14, 10, 18, 24, 808, DateTimeKind.Utc).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2145), 243.11716961611575, 32.0, new DateTime(2022, 11, 14, 10, 17, 24, 808, DateTimeKind.Utc).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2151), 329.34614443786512, 33.0, new DateTime(2022, 11, 14, 10, 16, 24, 808, DateTimeKind.Utc).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2157), 165.513334484355, 21.0, new DateTime(2022, 11, 14, 10, 15, 24, 808, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2162), 48.880184441080551, 21.0, new DateTime(2022, 11, 14, 10, 14, 24, 808, DateTimeKind.Utc).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2168), 60.005682795162606, 13.0, new DateTime(2022, 11, 14, 10, 13, 24, 808, DateTimeKind.Utc).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2174), 164.25987948131416, 32.0, new DateTime(2022, 11, 14, 10, 12, 24, 808, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2179), 727.25318264066186, 9.0, new DateTime(2022, 11, 14, 10, 11, 24, 808, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2185), 610.47691007556432, 11.0, new DateTime(2022, 11, 14, 10, 10, 24, 808, DateTimeKind.Utc).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2191), 300.51356442922219, 17.0, new DateTime(2022, 11, 14, 10, 9, 24, 808, DateTimeKind.Utc).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2196), 170.74205212964355, 26.0, new DateTime(2022, 11, 14, 10, 8, 24, 808, DateTimeKind.Utc).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2202), 802.68285049970461, 4.0, new DateTime(2022, 11, 14, 10, 7, 24, 808, DateTimeKind.Utc).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2208), 671.05141899590433, 24.0, new DateTime(2022, 11, 14, 10, 6, 24, 808, DateTimeKind.Utc).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2213), 802.65692277129665, 0.0, new DateTime(2022, 11, 14, 10, 5, 24, 808, DateTimeKind.Utc).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2218), 296.17075646741097, 19.0, new DateTime(2022, 11, 14, 10, 4, 24, 808, DateTimeKind.Utc).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2224), 18.905830109621103, 26.0, new DateTime(2022, 11, 14, 10, 3, 24, 808, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2230), 895.10987294544634, 30.0, new DateTime(2022, 11, 14, 10, 2, 24, 808, DateTimeKind.Utc).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2235), 57.149154278061552, 27.0, new DateTime(2022, 11, 14, 10, 1, 24, 808, DateTimeKind.Utc).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2241), 596.18400462339878, 31.0, new DateTime(2022, 11, 14, 10, 0, 24, 808, DateTimeKind.Utc).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2246), 223.27464382645411, 6.0, new DateTime(2022, 11, 14, 9, 59, 24, 808, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2252), 880.85471034551881, 0.0, new DateTime(2022, 11, 14, 9, 58, 24, 808, DateTimeKind.Utc).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2257), 164.14785739523941, 1.0, new DateTime(2022, 11, 14, 9, 57, 24, 808, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2263), 291.21879769332492, 32.0, new DateTime(2022, 11, 14, 9, 56, 24, 808, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2269), 885.17175406842307, 4.0, new DateTime(2022, 11, 14, 9, 55, 24, 808, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2274), 543.78764421055678, 34.0, new DateTime(2022, 11, 14, 9, 54, 24, 808, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2284), 917.39036610298717, 26.0, new DateTime(2022, 11, 14, 9, 53, 24, 808, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2290), 511.54346126776238, 17.0, new DateTime(2022, 11, 14, 9, 52, 24, 808, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2296), 379.72912006471137, 4.0, new DateTime(2022, 11, 14, 9, 51, 24, 808, DateTimeKind.Utc).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2301), 377.23777085790357, 24.0, new DateTime(2022, 11, 14, 9, 50, 24, 808, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2307), 828.56440881218441, 10.0, new DateTime(2022, 11, 14, 9, 49, 24, 808, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2312), 892.39110428242839, 14.0, new DateTime(2022, 11, 14, 9, 48, 24, 808, DateTimeKind.Utc).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2318), 687.50618208339495, 34.0, new DateTime(2022, 11, 14, 9, 47, 24, 808, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2324), 237.24690069972698, 36.0, new DateTime(2022, 11, 14, 9, 46, 24, 808, DateTimeKind.Utc).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2329), 657.81061277270612, 11.0, new DateTime(2022, 11, 14, 9, 45, 24, 808, DateTimeKind.Utc).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2335), 489.93813632433523, 37.0, new DateTime(2022, 11, 14, 9, 44, 24, 808, DateTimeKind.Utc).AddTicks(2338) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2340), 732.89036190387924, 14.0, new DateTime(2022, 11, 14, 9, 43, 24, 808, DateTimeKind.Utc).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2346), 21.125294155360798, 6.0, new DateTime(2022, 11, 14, 9, 42, 24, 808, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2351), 461.80202795502726, 26.0, new DateTime(2022, 11, 14, 9, 41, 24, 808, DateTimeKind.Utc).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2357), 49.43221243145701, 16.0, new DateTime(2022, 11, 14, 9, 40, 24, 808, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2363), 513.17527110740241, 11.0, new DateTime(2022, 11, 14, 9, 39, 24, 808, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2369), 153.85705340044842, 17.0, new DateTime(2022, 11, 14, 9, 38, 24, 808, DateTimeKind.Utc).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2374), 861.94644933515826, 37.0, new DateTime(2022, 11, 14, 9, 37, 24, 808, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2380), 403.30679559272534, 38.0, new DateTime(2022, 11, 14, 9, 36, 24, 808, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2385), 647.61258980331866, 13.0, new DateTime(2022, 11, 14, 9, 35, 24, 808, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2391), 312.06116679144611, 12.0, new DateTime(2022, 11, 14, 9, 34, 24, 808, DateTimeKind.Utc).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2397), 568.82442412707894, 5.0, new DateTime(2022, 11, 14, 9, 33, 24, 808, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2402), 681.50825701436247, 1.0, new DateTime(2022, 11, 14, 9, 32, 24, 808, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2408), 90.494351688772952, 6.0, new DateTime(2022, 11, 14, 9, 31, 24, 808, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2413), 228.24623805323174, 32.0, new DateTime(2022, 11, 14, 9, 30, 24, 808, DateTimeKind.Utc).AddTicks(2417) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2419), 276.81576191047606, 6.0, new DateTime(2022, 11, 14, 9, 29, 24, 808, DateTimeKind.Utc).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2424), 167.06955005749924, 0.0, new DateTime(2022, 11, 14, 9, 28, 24, 808, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2430), 89.149416168338718, 28.0, new DateTime(2022, 11, 14, 9, 27, 24, 808, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2436), 561.97675622640213, 18.0, new DateTime(2022, 11, 14, 9, 26, 24, 808, DateTimeKind.Utc).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2441), 576.07747952926752, 12.0, new DateTime(2022, 11, 14, 9, 25, 24, 808, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2447), 501.41607994035729, 26.0, new DateTime(2022, 11, 14, 9, 24, 24, 808, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2452), 563.8701630752588, 10.0, new DateTime(2022, 11, 14, 9, 23, 24, 808, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "LevelIndicatorTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "Density", "Temperature", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 808, DateTimeKind.Utc).AddTicks(2458), 84.58790908729253, 8.0, new DateTime(2022, 11, 14, 9, 22, 24, 808, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4218), new DateTime(2022, 11, 14, 14, 21, 24, 795, DateTimeKind.Utc).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4436), new DateTime(2022, 11, 14, 14, 20, 24, 795, DateTimeKind.Utc).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4444), new DateTime(2022, 11, 14, 14, 19, 24, 795, DateTimeKind.Utc).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4449), new DateTime(2022, 11, 14, 14, 18, 24, 795, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4453), new DateTime(2022, 11, 14, 14, 17, 24, 795, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4456), new DateTime(2022, 11, 14, 14, 16, 24, 795, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4461), new DateTime(2022, 11, 14, 14, 15, 24, 795, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4464), new DateTime(2022, 11, 14, 14, 14, 24, 795, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4468), new DateTime(2022, 11, 14, 14, 13, 24, 795, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4472), new DateTime(2022, 11, 14, 14, 12, 24, 795, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4475), new DateTime(2022, 11, 14, 14, 11, 24, 795, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4479), new DateTime(2022, 11, 14, 14, 10, 24, 795, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4483), new DateTime(2022, 11, 14, 14, 9, 24, 795, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4486), new DateTime(2022, 11, 14, 14, 8, 24, 795, DateTimeKind.Utc).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4490), new DateTime(2022, 11, 14, 14, 7, 24, 795, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4494), new DateTime(2022, 11, 14, 14, 6, 24, 795, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4497), new DateTime(2022, 11, 14, 14, 5, 24, 795, DateTimeKind.Utc).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4501), new DateTime(2022, 11, 14, 14, 4, 24, 795, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4504), new DateTime(2022, 11, 14, 14, 3, 24, 795, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4508), new DateTime(2022, 11, 14, 14, 2, 24, 795, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4511), new DateTime(2022, 11, 14, 14, 1, 24, 795, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4515), new DateTime(2022, 11, 14, 14, 0, 24, 795, DateTimeKind.Utc).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4519), new DateTime(2022, 11, 14, 13, 59, 24, 795, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4522), new DateTime(2022, 11, 14, 13, 58, 24, 795, DateTimeKind.Utc).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4526), new DateTime(2022, 11, 14, 13, 57, 24, 795, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4529), new DateTime(2022, 11, 14, 13, 56, 24, 795, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4533), new DateTime(2022, 11, 14, 13, 55, 24, 795, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4536), new DateTime(2022, 11, 14, 13, 54, 24, 795, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4540), new DateTime(2022, 11, 14, 13, 53, 24, 795, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4543), new DateTime(2022, 11, 14, 13, 52, 24, 795, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4547), new DateTime(2022, 11, 14, 13, 51, 24, 795, DateTimeKind.Utc).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4551), new DateTime(2022, 11, 14, 13, 50, 24, 795, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4554), new DateTime(2022, 11, 14, 13, 49, 24, 795, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4558), new DateTime(2022, 11, 14, 13, 48, 24, 795, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4561), new DateTime(2022, 11, 14, 13, 47, 24, 795, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4565), new DateTime(2022, 11, 14, 13, 46, 24, 795, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4568), new DateTime(2022, 11, 14, 13, 45, 24, 795, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4572), new DateTime(2022, 11, 14, 13, 44, 24, 795, DateTimeKind.Utc).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4576), new DateTime(2022, 11, 14, 13, 43, 24, 795, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4579), new DateTime(2022, 11, 14, 13, 42, 24, 795, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4583), new DateTime(2022, 11, 14, 13, 41, 24, 795, DateTimeKind.Utc).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4586), new DateTime(2022, 11, 14, 13, 40, 24, 795, DateTimeKind.Utc).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4590), new DateTime(2022, 11, 14, 13, 39, 24, 795, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4593), new DateTime(2022, 11, 14, 13, 38, 24, 795, DateTimeKind.Utc).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4620), new DateTime(2022, 11, 14, 13, 37, 24, 795, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4623), new DateTime(2022, 11, 14, 13, 36, 24, 795, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4627), new DateTime(2022, 11, 14, 13, 35, 24, 795, DateTimeKind.Utc).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4630), new DateTime(2022, 11, 14, 13, 34, 24, 795, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4634), new DateTime(2022, 11, 14, 13, 33, 24, 795, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4637), new DateTime(2022, 11, 14, 13, 32, 24, 795, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4641), new DateTime(2022, 11, 14, 13, 31, 24, 795, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4645), new DateTime(2022, 11, 14, 13, 30, 24, 795, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4648), new DateTime(2022, 11, 14, 13, 29, 24, 795, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4652), new DateTime(2022, 11, 14, 13, 28, 24, 795, DateTimeKind.Utc).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4656), new DateTime(2022, 11, 14, 13, 27, 24, 795, DateTimeKind.Utc).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4659), new DateTime(2022, 11, 14, 13, 26, 24, 795, DateTimeKind.Utc).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4663), new DateTime(2022, 11, 14, 13, 25, 24, 795, DateTimeKind.Utc).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4666), new DateTime(2022, 11, 14, 13, 24, 24, 795, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4670), new DateTime(2022, 11, 14, 13, 23, 24, 795, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4674), new DateTime(2022, 11, 14, 13, 22, 24, 795, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4677), new DateTime(2022, 11, 14, 13, 21, 24, 795, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4681), new DateTime(2022, 11, 14, 13, 20, 24, 795, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4684), new DateTime(2022, 11, 14, 13, 19, 24, 795, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4688), new DateTime(2022, 11, 14, 13, 18, 24, 795, DateTimeKind.Utc).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4691), new DateTime(2022, 11, 14, 13, 17, 24, 795, DateTimeKind.Utc).AddTicks(4693) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4695), new DateTime(2022, 11, 14, 13, 16, 24, 795, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4698), new DateTime(2022, 11, 14, 13, 15, 24, 795, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4702), new DateTime(2022, 11, 14, 13, 14, 24, 795, DateTimeKind.Utc).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4705), new DateTime(2022, 11, 14, 13, 13, 24, 795, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4709), new DateTime(2022, 11, 14, 13, 12, 24, 795, DateTimeKind.Utc).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4712), new DateTime(2022, 11, 14, 13, 11, 24, 795, DateTimeKind.Utc).AddTicks(4714) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4716), new DateTime(2022, 11, 14, 13, 10, 24, 795, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4719), new DateTime(2022, 11, 14, 13, 9, 24, 795, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4723), new DateTime(2022, 11, 14, 13, 8, 24, 795, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4726), new DateTime(2022, 11, 14, 13, 7, 24, 795, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4730), new DateTime(2022, 11, 14, 13, 6, 24, 795, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4734), new DateTime(2022, 11, 14, 13, 5, 24, 795, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4737), new DateTime(2022, 11, 14, 13, 4, 24, 795, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4741), new DateTime(2022, 11, 14, 13, 3, 24, 795, DateTimeKind.Utc).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4744), new DateTime(2022, 11, 14, 13, 2, 24, 795, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4748), new DateTime(2022, 11, 14, 13, 1, 24, 795, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4751), new DateTime(2022, 11, 14, 13, 0, 24, 795, DateTimeKind.Utc).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4755), new DateTime(2022, 11, 14, 12, 59, 24, 795, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4758), new DateTime(2022, 11, 14, 12, 58, 24, 795, DateTimeKind.Utc).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4762), new DateTime(2022, 11, 14, 12, 57, 24, 795, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4765), new DateTime(2022, 11, 14, 12, 56, 24, 795, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4769), new DateTime(2022, 11, 14, 12, 55, 24, 795, DateTimeKind.Utc).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4773), new DateTime(2022, 11, 14, 12, 54, 24, 795, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4776), new DateTime(2022, 11, 14, 12, 53, 24, 795, DateTimeKind.Utc).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4780), new DateTime(2022, 11, 14, 12, 52, 24, 795, DateTimeKind.Utc).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4783), new DateTime(2022, 11, 14, 12, 51, 24, 795, DateTimeKind.Utc).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4787), new DateTime(2022, 11, 14, 12, 50, 24, 795, DateTimeKind.Utc).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4790), new DateTime(2022, 11, 14, 12, 49, 24, 795, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4794), new DateTime(2022, 11, 14, 12, 48, 24, 795, DateTimeKind.Utc).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4797), new DateTime(2022, 11, 14, 12, 47, 24, 795, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4801), new DateTime(2022, 11, 14, 12, 46, 24, 795, DateTimeKind.Utc).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4805), new DateTime(2022, 11, 14, 12, 45, 24, 795, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4808), new DateTime(2022, 11, 14, 12, 44, 24, 795, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4812), new DateTime(2022, 11, 14, 12, 43, 24, 795, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 795, DateTimeKind.Utc).AddTicks(4816), new DateTime(2022, 11, 14, 12, 42, 24, 795, DateTimeKind.Utc).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(499), new DateTime(2022, 11, 14, 12, 41, 24, 797, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(675), new DateTime(2022, 11, 14, 12, 40, 24, 797, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(683), new DateTime(2022, 11, 14, 12, 39, 24, 797, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(688), new DateTime(2022, 11, 14, 12, 38, 24, 797, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(716), new DateTime(2022, 11, 14, 12, 37, 24, 797, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(721), new DateTime(2022, 11, 14, 12, 36, 24, 797, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(724), new DateTime(2022, 11, 14, 12, 35, 24, 797, DateTimeKind.Utc).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(729), new DateTime(2022, 11, 14, 12, 34, 24, 797, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(732), new DateTime(2022, 11, 14, 12, 33, 24, 797, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(736), new DateTime(2022, 11, 14, 12, 32, 24, 797, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(741), new DateTime(2022, 11, 14, 12, 31, 24, 797, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(744), new DateTime(2022, 11, 14, 12, 30, 24, 797, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(748), new DateTime(2022, 11, 14, 12, 29, 24, 797, DateTimeKind.Utc).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(752), new DateTime(2022, 11, 14, 12, 28, 24, 797, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(756), new DateTime(2022, 11, 14, 12, 27, 24, 797, DateTimeKind.Utc).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(760), new DateTime(2022, 11, 14, 12, 26, 24, 797, DateTimeKind.Utc).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(763), new DateTime(2022, 11, 14, 12, 25, 24, 797, DateTimeKind.Utc).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(767), new DateTime(2022, 11, 14, 12, 24, 24, 797, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(771), new DateTime(2022, 11, 14, 12, 23, 24, 797, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(774), new DateTime(2022, 11, 14, 12, 22, 24, 797, DateTimeKind.Utc).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(778), new DateTime(2022, 11, 14, 12, 21, 24, 797, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(782), new DateTime(2022, 11, 14, 12, 20, 24, 797, DateTimeKind.Utc).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(785), new DateTime(2022, 11, 14, 12, 19, 24, 797, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(789), new DateTime(2022, 11, 14, 12, 18, 24, 797, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(793), new DateTime(2022, 11, 14, 12, 17, 24, 797, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(796), new DateTime(2022, 11, 14, 12, 16, 24, 797, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(800), new DateTime(2022, 11, 14, 12, 15, 24, 797, DateTimeKind.Utc).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(803), new DateTime(2022, 11, 14, 12, 14, 24, 797, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(807), new DateTime(2022, 11, 14, 12, 13, 24, 797, DateTimeKind.Utc).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(811), new DateTime(2022, 11, 14, 12, 12, 24, 797, DateTimeKind.Utc).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(814), new DateTime(2022, 11, 14, 12, 11, 24, 797, DateTimeKind.Utc).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(818), new DateTime(2022, 11, 14, 12, 10, 24, 797, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(822), new DateTime(2022, 11, 14, 12, 9, 24, 797, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(825), new DateTime(2022, 11, 14, 12, 8, 24, 797, DateTimeKind.Utc).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(829), new DateTime(2022, 11, 14, 12, 7, 24, 797, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(833), new DateTime(2022, 11, 14, 12, 6, 24, 797, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(836), new DateTime(2022, 11, 14, 12, 5, 24, 797, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(840), new DateTime(2022, 11, 14, 12, 4, 24, 797, DateTimeKind.Utc).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(843), new DateTime(2022, 11, 14, 12, 3, 24, 797, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(847), new DateTime(2022, 11, 14, 12, 2, 24, 797, DateTimeKind.Utc).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(851), new DateTime(2022, 11, 14, 12, 1, 24, 797, DateTimeKind.Utc).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(855), new DateTime(2022, 11, 14, 12, 0, 24, 797, DateTimeKind.Utc).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(858), new DateTime(2022, 11, 14, 11, 59, 24, 797, DateTimeKind.Utc).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(862), new DateTime(2022, 11, 14, 11, 58, 24, 797, DateTimeKind.Utc).AddTicks(864) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(866), new DateTime(2022, 11, 14, 11, 57, 24, 797, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(869), new DateTime(2022, 11, 14, 11, 56, 24, 797, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(873), new DateTime(2022, 11, 14, 11, 55, 24, 797, DateTimeKind.Utc).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(876), new DateTime(2022, 11, 14, 11, 54, 24, 797, DateTimeKind.Utc).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(880), new DateTime(2022, 11, 14, 11, 53, 24, 797, DateTimeKind.Utc).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(884), new DateTime(2022, 11, 14, 11, 52, 24, 797, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(888), new DateTime(2022, 11, 14, 11, 51, 24, 797, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(891), new DateTime(2022, 11, 14, 11, 50, 24, 797, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(895), new DateTime(2022, 11, 14, 11, 49, 24, 797, DateTimeKind.Utc).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(899), new DateTime(2022, 11, 14, 11, 48, 24, 797, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(902), new DateTime(2022, 11, 14, 11, 47, 24, 797, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(906), new DateTime(2022, 11, 14, 11, 46, 24, 797, DateTimeKind.Utc).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(910), new DateTime(2022, 11, 14, 11, 45, 24, 797, DateTimeKind.Utc).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(913), new DateTime(2022, 11, 14, 11, 44, 24, 797, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(917), new DateTime(2022, 11, 14, 11, 43, 24, 797, DateTimeKind.Utc).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(920), new DateTime(2022, 11, 14, 11, 42, 24, 797, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(924), new DateTime(2022, 11, 14, 11, 41, 24, 797, DateTimeKind.Utc).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(948), new DateTime(2022, 11, 14, 11, 40, 24, 797, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(952), new DateTime(2022, 11, 14, 11, 39, 24, 797, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(956), new DateTime(2022, 11, 14, 11, 38, 24, 797, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(960), new DateTime(2022, 11, 14, 11, 37, 24, 797, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(963), new DateTime(2022, 11, 14, 11, 36, 24, 797, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(967), new DateTime(2022, 11, 14, 11, 35, 24, 797, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(971), new DateTime(2022, 11, 14, 11, 34, 24, 797, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(975), new DateTime(2022, 11, 14, 11, 33, 24, 797, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(978), new DateTime(2022, 11, 14, 11, 32, 24, 797, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(982), new DateTime(2022, 11, 14, 11, 31, 24, 797, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(986), new DateTime(2022, 11, 14, 11, 30, 24, 797, DateTimeKind.Utc).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(989), new DateTime(2022, 11, 14, 11, 29, 24, 797, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(993), new DateTime(2022, 11, 14, 11, 28, 24, 797, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(997), new DateTime(2022, 11, 14, 11, 27, 24, 797, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1000), new DateTime(2022, 11, 14, 11, 26, 24, 797, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1004), new DateTime(2022, 11, 14, 11, 25, 24, 797, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1008), new DateTime(2022, 11, 14, 11, 24, 24, 797, DateTimeKind.Utc).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1012), new DateTime(2022, 11, 14, 11, 23, 24, 797, DateTimeKind.Utc).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1015), new DateTime(2022, 11, 14, 11, 22, 24, 797, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1019), new DateTime(2022, 11, 14, 11, 21, 24, 797, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1022), new DateTime(2022, 11, 14, 11, 20, 24, 797, DateTimeKind.Utc).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1026), new DateTime(2022, 11, 14, 11, 19, 24, 797, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1030), new DateTime(2022, 11, 14, 11, 18, 24, 797, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1034), new DateTime(2022, 11, 14, 11, 17, 24, 797, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1037), new DateTime(2022, 11, 14, 11, 16, 24, 797, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1041), new DateTime(2022, 11, 14, 11, 15, 24, 797, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1044), new DateTime(2022, 11, 14, 11, 14, 24, 797, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1048), new DateTime(2022, 11, 14, 11, 13, 24, 797, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1052), new DateTime(2022, 11, 14, 11, 12, 24, 797, DateTimeKind.Utc).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1056), new DateTime(2022, 11, 14, 11, 11, 24, 797, DateTimeKind.Utc).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1059), new DateTime(2022, 11, 14, 11, 10, 24, 797, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1063), new DateTime(2022, 11, 14, 11, 9, 24, 797, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1067), new DateTime(2022, 11, 14, 11, 8, 24, 797, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1070), new DateTime(2022, 11, 14, 11, 7, 24, 797, DateTimeKind.Utc).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1074), new DateTime(2022, 11, 14, 11, 6, 24, 797, DateTimeKind.Utc).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1078), new DateTime(2022, 11, 14, 11, 5, 24, 797, DateTimeKind.Utc).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1081), new DateTime(2022, 11, 14, 11, 4, 24, 797, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1085), new DateTime(2022, 11, 14, 11, 3, 24, 797, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 797, DateTimeKind.Utc).AddTicks(1088), new DateTime(2022, 11, 14, 11, 2, 24, 797, DateTimeKind.Utc).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5207), new DateTime(2022, 11, 14, 11, 1, 24, 804, DateTimeKind.Utc).AddTicks(5418) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5487), new DateTime(2022, 11, 14, 11, 0, 24, 804, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5496), new DateTime(2022, 11, 14, 10, 59, 24, 804, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5501), new DateTime(2022, 11, 14, 10, 58, 24, 804, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5505), new DateTime(2022, 11, 14, 10, 57, 24, 804, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5509), new DateTime(2022, 11, 14, 10, 56, 24, 804, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5518), new DateTime(2022, 11, 14, 10, 55, 24, 804, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5523), new DateTime(2022, 11, 14, 10, 54, 24, 804, DateTimeKind.Utc).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5527), new DateTime(2022, 11, 14, 10, 53, 24, 804, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5530), new DateTime(2022, 11, 14, 10, 52, 24, 804, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5534), new DateTime(2022, 11, 14, 10, 51, 24, 804, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5538), new DateTime(2022, 11, 14, 10, 50, 24, 804, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5542), new DateTime(2022, 11, 14, 10, 49, 24, 804, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5546), new DateTime(2022, 11, 14, 10, 48, 24, 804, DateTimeKind.Utc).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5550), new DateTime(2022, 11, 14, 10, 47, 24, 804, DateTimeKind.Utc).AddTicks(5551) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5553), new DateTime(2022, 11, 14, 10, 46, 24, 804, DateTimeKind.Utc).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5557), new DateTime(2022, 11, 14, 10, 45, 24, 804, DateTimeKind.Utc).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5561), new DateTime(2022, 11, 14, 10, 44, 24, 804, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5564), new DateTime(2022, 11, 14, 10, 43, 24, 804, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5568), new DateTime(2022, 11, 14, 10, 42, 24, 804, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5572), new DateTime(2022, 11, 14, 10, 41, 24, 804, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5575), new DateTime(2022, 11, 14, 10, 40, 24, 804, DateTimeKind.Utc).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5579), new DateTime(2022, 11, 14, 10, 39, 24, 804, DateTimeKind.Utc).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5583), new DateTime(2022, 11, 14, 10, 38, 24, 804, DateTimeKind.Utc).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5586), new DateTime(2022, 11, 14, 10, 37, 24, 804, DateTimeKind.Utc).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5590), new DateTime(2022, 11, 14, 10, 36, 24, 804, DateTimeKind.Utc).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5593), new DateTime(2022, 11, 14, 10, 35, 24, 804, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5597), new DateTime(2022, 11, 14, 10, 34, 24, 804, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5601), new DateTime(2022, 11, 14, 10, 33, 24, 804, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5604), new DateTime(2022, 11, 14, 10, 32, 24, 804, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5608), new DateTime(2022, 11, 14, 10, 31, 24, 804, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5612), new DateTime(2022, 11, 14, 10, 30, 24, 804, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5616), new DateTime(2022, 11, 14, 10, 29, 24, 804, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5619), new DateTime(2022, 11, 14, 10, 28, 24, 804, DateTimeKind.Utc).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5623), new DateTime(2022, 11, 14, 10, 27, 24, 804, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5627), new DateTime(2022, 11, 14, 10, 26, 24, 804, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5631), new DateTime(2022, 11, 14, 10, 25, 24, 804, DateTimeKind.Utc).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5635), new DateTime(2022, 11, 14, 10, 24, 24, 804, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5638), new DateTime(2022, 11, 14, 10, 23, 24, 804, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5642), new DateTime(2022, 11, 14, 10, 22, 24, 804, DateTimeKind.Utc).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5646), new DateTime(2022, 11, 14, 10, 21, 24, 804, DateTimeKind.Utc).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5650), new DateTime(2022, 11, 14, 10, 20, 24, 804, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5653), new DateTime(2022, 11, 14, 10, 19, 24, 804, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5657), new DateTime(2022, 11, 14, 10, 18, 24, 804, DateTimeKind.Utc).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5661), new DateTime(2022, 11, 14, 10, 17, 24, 804, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5664), new DateTime(2022, 11, 14, 10, 16, 24, 804, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5668), new DateTime(2022, 11, 14, 10, 15, 24, 804, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5672), new DateTime(2022, 11, 14, 10, 14, 24, 804, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5675), new DateTime(2022, 11, 14, 10, 13, 24, 804, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5679), new DateTime(2022, 11, 14, 10, 12, 24, 804, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5683), new DateTime(2022, 11, 14, 10, 11, 24, 804, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5687), new DateTime(2022, 11, 14, 10, 10, 24, 804, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5690), new DateTime(2022, 11, 14, 10, 9, 24, 804, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5694), new DateTime(2022, 11, 14, 10, 8, 24, 804, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5698), new DateTime(2022, 11, 14, 10, 7, 24, 804, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5702), new DateTime(2022, 11, 14, 10, 6, 24, 804, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5705), new DateTime(2022, 11, 14, 10, 5, 24, 804, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5709), new DateTime(2022, 11, 14, 10, 4, 24, 804, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5713), new DateTime(2022, 11, 14, 10, 3, 24, 804, DateTimeKind.Utc).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5716), new DateTime(2022, 11, 14, 10, 2, 24, 804, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5720), new DateTime(2022, 11, 14, 10, 1, 24, 804, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5724), new DateTime(2022, 11, 14, 10, 0, 24, 804, DateTimeKind.Utc).AddTicks(5726) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5728), new DateTime(2022, 11, 14, 9, 59, 24, 804, DateTimeKind.Utc).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5735), new DateTime(2022, 11, 14, 9, 58, 24, 804, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5739), new DateTime(2022, 11, 14, 9, 57, 24, 804, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5743), new DateTime(2022, 11, 14, 9, 56, 24, 804, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5747), new DateTime(2022, 11, 14, 9, 55, 24, 804, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5751), new DateTime(2022, 11, 14, 9, 54, 24, 804, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5755), new DateTime(2022, 11, 14, 9, 53, 24, 804, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5758), new DateTime(2022, 11, 14, 9, 52, 24, 804, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5762), new DateTime(2022, 11, 14, 9, 51, 24, 804, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5766), new DateTime(2022, 11, 14, 9, 50, 24, 804, DateTimeKind.Utc).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5770), new DateTime(2022, 11, 14, 9, 49, 24, 804, DateTimeKind.Utc).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5773), new DateTime(2022, 11, 14, 9, 48, 24, 804, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5777), new DateTime(2022, 11, 14, 9, 47, 24, 804, DateTimeKind.Utc).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5781), new DateTime(2022, 11, 14, 9, 46, 24, 804, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5785), new DateTime(2022, 11, 14, 9, 45, 24, 804, DateTimeKind.Utc).AddTicks(5786) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5788), new DateTime(2022, 11, 14, 9, 44, 24, 804, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5792), new DateTime(2022, 11, 14, 9, 43, 24, 804, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5796), new DateTime(2022, 11, 14, 9, 42, 24, 804, DateTimeKind.Utc).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5799), new DateTime(2022, 11, 14, 9, 41, 24, 804, DateTimeKind.Utc).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5803), new DateTime(2022, 11, 14, 9, 40, 24, 804, DateTimeKind.Utc).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5807), new DateTime(2022, 11, 14, 9, 39, 24, 804, DateTimeKind.Utc).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5810), new DateTime(2022, 11, 14, 9, 38, 24, 804, DateTimeKind.Utc).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5814), new DateTime(2022, 11, 14, 9, 37, 24, 804, DateTimeKind.Utc).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5817), new DateTime(2022, 11, 14, 9, 36, 24, 804, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5821), new DateTime(2022, 11, 14, 9, 35, 24, 804, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5825), new DateTime(2022, 11, 14, 9, 34, 24, 804, DateTimeKind.Utc).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5829), new DateTime(2022, 11, 14, 9, 33, 24, 804, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5832), new DateTime(2022, 11, 14, 9, 32, 24, 804, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5836), new DateTime(2022, 11, 14, 9, 31, 24, 804, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5840), new DateTime(2022, 11, 14, 9, 30, 24, 804, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5844), new DateTime(2022, 11, 14, 9, 29, 24, 804, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5847), new DateTime(2022, 11, 14, 9, 28, 24, 804, DateTimeKind.Utc).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5851), new DateTime(2022, 11, 14, 9, 27, 24, 804, DateTimeKind.Utc).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5855), new DateTime(2022, 11, 14, 9, 26, 24, 804, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5858), new DateTime(2022, 11, 14, 9, 25, 24, 804, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5862), new DateTime(2022, 11, 14, 9, 24, 24, 804, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5866), new DateTime(2022, 11, 14, 9, 23, 24, 804, DateTimeKind.Utc).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "RemainingTransactions",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CeatedAt", "TransactionTime" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 804, DateTimeKind.Utc).AddTicks(5870), new DateTime(2022, 11, 14, 9, 22, 24, 804, DateTimeKind.Utc).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Token" },
                values: new object[] { "Baileyland", "7a7dc9e4-42ca-4c88-80dd-fa3d50fff0b2" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Token" },
                values: new object[] { "South Arch", "b3759bef-09ab-4916-b7a4-d0bf9f76de64" });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Token" },
                values: new object[] { "Ullrichstad", "9621c564-5974-4138-9bc4-3daaaecc22dc" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 773, DateTimeKind.Utc).AddTicks(816), "ES9eKgtK5lvMmTlAywhlrBez+2CNigQyGoiZ4tuda+k=", "blerGDIMs+rYQeYCK9UDupy5Uv69Rkz5TYnMPLn9Iao=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 778, DateTimeKind.Utc).AddTicks(5190), "IsjRvdq6EoTXHiBCVoLwN3RUX5C/LZ475Gepfd5TqVk=", "gBPi9W3OJL0Is0UfbQlsbnk5HlGU7d0sWb5FqCSyQaA=" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Password", "Salt" },
                values: new object[] { new DateTime(2022, 11, 14, 14, 23, 24, 783, DateTimeKind.Utc).AddTicks(9575), "2zQZbfMf9VIVHWqY/jcBHgDKcXKHE6db6/aoZehL7UQ=", "BHV08YpSGozM+i/HqZHfPJlI9miymFKuO6aX6gmXYFg=" });

            migrationBuilder.CreateIndex(
                name: "IX_Tokens_UserId",
                table: "Tokens",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tokens");

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
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
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(765), 521.31906282992657, new DateTime(2022, 9, 23, 10, 26, 45, 605, DateTimeKind.Utc).AddTicks(769) });

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
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 605, DateTimeKind.Utc).AddTicks(1242), 239.16011797252347, new DateTime(2022, 9, 23, 9, 7, 45, 605, DateTimeKind.Utc).AddTicks(1245) });

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
                columns: new[] { "CeatedAt", "Density", "TransactionTime" },
                values: new object[] { new DateTime(2022, 9, 23, 10, 47, 45, 606, DateTimeKind.Utc).AddTicks(3214), 332.28623162373981, new DateTime(2022, 9, 23, 8, 1, 45, 606, DateTimeKind.Utc).AddTicks(3218) });

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
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");
        }
    }
}
