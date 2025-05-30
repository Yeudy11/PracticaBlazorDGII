using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp2.Migrations
{
    /// <inheritdoc />
    public partial class AddedStatusesNameForTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contribuyentes_Estatus_EstatusId",
                table: "Contribuyentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estatus",
                table: "Estatus");

            migrationBuilder.RenameTable(
                name: "Estatus",
                newName: "Estatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estatuses",
                table: "Estatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contribuyentes_Estatuses_EstatusId",
                table: "Contribuyentes",
                column: "EstatusId",
                principalTable: "Estatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contribuyentes_Estatuses_EstatusId",
                table: "Contribuyentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estatuses",
                table: "Estatuses");

            migrationBuilder.RenameTable(
                name: "Estatuses",
                newName: "Estatus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estatus",
                table: "Estatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contribuyentes_Estatus_EstatusId",
                table: "Contribuyentes",
                column: "EstatusId",
                principalTable: "Estatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
