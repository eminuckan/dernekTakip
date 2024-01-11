using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dernek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberFees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Month = table.Column<int>(type: "integer", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "longchar", nullable: false),
                    Surname = table.Column<string>(type: "longchar", nullable: false),
                    Email = table.Column<string>(type: "longchar", nullable: false),
                    City = table.Column<int>(type: "integer", nullable: false),
                    BloodType = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MemberId = table.Column<string>(type: "varchar(255)", nullable: false),
                    MembershipFeeId = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_MemberFees_MembershipFeeId",
                        column: x => x.MembershipFeeId,
                        principalTable: "MemberFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MemberFees",
                columns: new[] { "Id", "CreatedAt", "Fee", "Month" },
                values: new object[,]
                {
                    { "017925ad-95ca-4673-ab6f-22b8299c2065", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 5 },
                    { "1e5985a7-ae26-405d-baff-4a0480d535c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 4 },
                    { "23ecff19-5105-475d-b665-bb8d4e0b62c6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 8 },
                    { "3109ade9-71a8-47e7-8c32-4e92dd33dddf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 11 },
                    { "37624a70-748f-42b2-80dd-3a8543809ab7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 2 },
                    { "6656ed48-f06f-44a4-9394-f997127a98d4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 7 },
                    { "74ac134b-d377-4aa2-8dce-03ef61fb18ac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 6 },
                    { "a8196656-59be-415d-9344-00dd4bd015f1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 12 },
                    { "ade06a56-da56-4ca4-af75-0d6f16e5f51d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 3 },
                    { "c2ad7868-fca1-427b-9c29-12f8643d74d0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 1 },
                    { "d0bcd558-650a-4284-84c1-db86962a12d7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 9 },
                    { "f590f5fa-acf9-4d70-9d5f-a9da39a21412", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MemberId",
                table: "Payments",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MembershipFeeId",
                table: "Payments",
                column: "MembershipFeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "MemberFees");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
