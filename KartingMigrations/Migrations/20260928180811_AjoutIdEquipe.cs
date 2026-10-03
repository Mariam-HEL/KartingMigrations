using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KartingMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AjoutIdEquipe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDEquipe",
                table: "Pilotes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDEquipe",
                table: "Pilotes");
        }
    }
}
