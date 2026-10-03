using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KartingMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AjoutLicence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "licence",
                table: "Pilotes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "licence",
                table: "Pilotes");
        }
    }
}
