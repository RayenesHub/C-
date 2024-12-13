using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class rouri2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "Clients",
                newName: "coordonnes_tel");

            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Clients",
                newName: "coordonnes_prenom");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Clients",
                newName: "coordonnes_nom");

            migrationBuilder.RenameColumn(
                name: "Adresse",
                table: "Clients",
                newName: "coordonnes_Adresse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "coordonnes_tel",
                table: "Clients",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "coordonnes_prenom",
                table: "Clients",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "coordonnes_nom",
                table: "Clients",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "coordonnes_Adresse",
                table: "Clients",
                newName: "Adresse");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
