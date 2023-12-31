using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi_site.Migrations
{
    public partial class AddCategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expiring = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreePatrol = table.Column<int>(type: "int", nullable: false),
                    HigherPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverBonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverDeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HigherPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverDeals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverPunishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitRate = table.Column<double>(type: "float", nullable: false),
                    LessPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverPunishments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Expiring = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreeOrders = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerDeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerDeals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassengerPunishments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExitRate = table.Column<double>(type: "float", nullable: false),
                    HigherPayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerPunishments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisteredDrivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PunismentId = table.Column<int>(type: "int", nullable: true),
                    BonusId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredDrivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisteredDrivers_DriverBonuses_BonusId",
                        column: x => x.BonusId,
                        principalTable: "DriverBonuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisteredDrivers_DriverDeals_DealId",
                        column: x => x.DealId,
                        principalTable: "DriverDeals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisteredDrivers_DriverPunishments_PunismentId",
                        column: x => x.PunismentId,
                        principalTable: "DriverPunishments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegisteredPassengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PunishmentId = table.Column<int>(type: "int", nullable: true),
                    BonusId = table.Column<int>(type: "int", nullable: true),
                    DealId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredPassengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisteredPassengers_PassengerBonuses_BonusId",
                        column: x => x.BonusId,
                        principalTable: "PassengerBonuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisteredPassengers_PassengerDeals_DealId",
                        column: x => x.DealId,
                        principalTable: "PassengerDeals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisteredPassengers_PassengerPunishments_PunishmentId",
                        column: x => x.PunishmentId,
                        principalTable: "PassengerPunishments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    StartPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_RegisteredDrivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "RegisteredDrivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_RegisteredPassengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "RegisteredPassengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DriverId",
                table: "Orders",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PassengerId",
                table: "Orders",
                column: "PassengerId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredDrivers_BonusId",
                table: "RegisteredDrivers",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredDrivers_DealId",
                table: "RegisteredDrivers",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredDrivers_PunismentId",
                table: "RegisteredDrivers",
                column: "PunismentId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredPassengers_BonusId",
                table: "RegisteredPassengers",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredPassengers_DealId",
                table: "RegisteredPassengers",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredPassengers_PunishmentId",
                table: "RegisteredPassengers",
                column: "PunishmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RegisteredDrivers");

            migrationBuilder.DropTable(
                name: "RegisteredPassengers");

            migrationBuilder.DropTable(
                name: "DriverBonuses");

            migrationBuilder.DropTable(
                name: "DriverDeals");

            migrationBuilder.DropTable(
                name: "DriverPunishments");

            migrationBuilder.DropTable(
                name: "PassengerBonuses");

            migrationBuilder.DropTable(
                name: "PassengerDeals");

            migrationBuilder.DropTable(
                name: "PassengerPunishments");
        }
    }
}
