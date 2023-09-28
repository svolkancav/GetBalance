using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetBalance.DAL.Migrations
{
    public partial class volkanFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainingLevel",
                table: "UserDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainingLevel",
                table: "UserDetails");
        }
    }
}
