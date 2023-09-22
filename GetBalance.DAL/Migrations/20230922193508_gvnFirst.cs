using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetBalance.DAL.Migrations
{
    public partial class gvnFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "UserDetails",
                newName: "CurrentWeight");

            migrationBuilder.CreateTable(
                name: "UserTargets",
                columns: table => new
                {
                    UserTargetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingWeight = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    TargetWeight = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityLevel = table.Column<int>(type: "int", nullable: false),
                    TargetCalorie = table.Column<short>(type: "smallint", maxLength: 5, nullable: false),
                    TargetCarbPercentage = table.Column<byte>(type: "tinyint", maxLength: 3, nullable: false),
                    TargetProteinPercentage = table.Column<byte>(type: "tinyint", maxLength: 3, nullable: false),
                    TargetFatPercentage = table.Column<byte>(type: "tinyint", maxLength: 3, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTargets", x => x.UserTargetId);
                    table.ForeignKey(
                        name: "FK_UserTargets_UserDetails_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTargets_UserDetailId",
                table: "UserTargets",
                column: "UserDetailId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTargets");

            migrationBuilder.RenameColumn(
                name: "CurrentWeight",
                table: "UserDetails",
                newName: "Weight");
        }
    }
}
