using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetBalance.DAL.Migrations
{
    public partial class osmanfirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Foods");
        }
    }
}
