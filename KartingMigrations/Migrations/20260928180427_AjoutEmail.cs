using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KartingMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AjoutEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Pilotes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Pilotes");
        }
    }
}
