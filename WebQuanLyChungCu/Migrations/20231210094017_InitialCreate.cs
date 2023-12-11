using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebQuanLyChungCu.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ward = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: true),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: true),
                    AccNumber = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDay = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Relationships",
                columns: table => new
                {
                    RelationshipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationshipName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relationships", x => x.RelationshipId);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceFee = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "InFo",
                columns: table => new
                {
                    InfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Sex = table.Column<byte>(type: "tinyint", nullable: true),
                    CMND_CCCD = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InFo", x => x.InfoId);
                    table.ForeignKey(
                        name: "FK_InFo_Address",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: true),
                    ApartmentCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ApartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: true),
                    StartDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_CanHo_ChungCu",
                        column: x => x.BuildingId,
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    Avartar = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    RelationshipId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Account_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_InFo",
                        column: x => x.InfoId,
                        principalTable: "InFo",
                        principalColumn: "InfoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Relationships_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationships",
                        principalColumn: "RelationshipId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Account_Role",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_Service",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<DateTime>(type: "date", nullable: true),
                    EndDay = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_Service", x => new { x.ApartmentId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_Apartment_Service_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId");
                    table.ForeignKey(
                        name: "FK_Apartment_Service_Service",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    StartDay = table.Column<DateTime>(type: "date", nullable: true),
                    EndDay = table.Column<DateTime>(type: "date", nullable: true),
                    Monthly_rent = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Deposit = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contract_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId");
                });

            migrationBuilder.CreateTable(
                name: "ElectricMeter",
                columns: table => new
                {
                    ElectricMeterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "date", nullable: true),
                    Code = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DeadingDate = table.Column<DateTime>(type: "date", nullable: true),
                    NumberOne = table.Column<double>(type: "float", nullable: true),
                    NumberEnd = table.Column<double>(type: "float", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricMeter", x => x.ElectricMeterId);
                    table.ForeignKey(
                        name: "FK_ElectricMeter_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId");
                });

            migrationBuilder.CreateTable(
                name: "ResidentsRequired",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDay = table.Column<DateTime>(type: "date", nullable: true),
                    FixDay = table.Column<DateTime>(type: "date", nullable: true),
                    Pending = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentsRequired", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_ResidentsRequired_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revenue",
                columns: table => new
                {
                    RevenueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Pay = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Debt = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ServiceFee = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    CodeVoucher = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ReceivingMoney = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    DayCreat = table.Column<DateTime>(type: "date", nullable: true),
                    DayPay = table.Column<DateTime>(type: "date", nullable: true),
                    Payments = table.Column<byte>(type: "tinyint", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue", x => x.RevenueId);
                    table.ForeignKey(
                        name: "FK_Revenue_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterMeter",
                columns: table => new
                {
                    WaterMeterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "date", nullable: true),
                    Code = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DeadingDate = table.Column<DateTime>(type: "date", nullable: true),
                    NumberOne = table.Column<double>(type: "float", nullable: true),
                    NumberEnd = table.Column<double>(type: "float", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterMeter", x => x.WaterMeterId);
                    table.ForeignKey(
                        name: "FK_WaterMeter_Apartment",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    HistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: true),
                    Day = table.Column<DateTime>(type: "date", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<byte>(type: "tinyint", nullable: true),
                    Screen = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.HistoryId);
                    table.ForeignKey(
                        name: "FK_History_Account",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_ApartmentId",
                table: "Account",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_InfoId",
                table: "Account",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_RelationshipId",
                table: "Account",
                column: "RelationshipId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_RoleId",
                table: "Account",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_BuildingId",
                table: "Apartment",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_Service_ServiceId",
                table: "Apartment_Service",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_ApartmentId",
                table: "Contract",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricMeter_ApartmentId",
                table: "ElectricMeter",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_History_AccountId",
                table: "History",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_InFo_AddressId",
                table: "InFo",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentsRequired_ApartmentId",
                table: "ResidentsRequired",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Revenue_ApartmentId",
                table: "Revenue",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterMeter_ApartmentId",
                table: "WaterMeter",
                column: "ApartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartment_Service");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "ElectricMeter");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "ResidentsRequired");

            migrationBuilder.DropTable(
                name: "Revenue");

            migrationBuilder.DropTable(
                name: "WaterMeter");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "InFo");

            migrationBuilder.DropTable(
                name: "Relationships");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
