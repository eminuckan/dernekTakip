using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dernek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipFeeEntity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipFeeEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentEntity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MemberId = table.Column<string>(type: "varchar(255)", nullable: false),
                    MembershipFeeId = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentEntity_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentEntity_MembershipFeeEntity_MembershipFeeId",
                        column: x => x.MembershipFeeId,
                        principalTable: "MembershipFeeEntity",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentEntity_MemberId",
                table: "PaymentEntity",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentEntity_MembershipFeeId",
                table: "PaymentEntity",
                column: "MembershipFeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentEntity");

            migrationBuilder.DropTable(
                name: "MembershipFeeEntity");
        }
    }
}
