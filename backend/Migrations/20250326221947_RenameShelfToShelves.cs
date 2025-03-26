using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class RenameShelfToShelves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelf_WarehouseSections_WarehouseSectionId",
                table: "Shelf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelf",
                table: "Shelf");

            migrationBuilder.RenameTable(
                name: "Shelf",
                newName: "Shelves");

            migrationBuilder.RenameIndex(
                name: "IX_Shelf_WarehouseSectionId",
                table: "Shelves",
                newName: "IX_Shelves_WarehouseSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelves",
                table: "Shelves",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelves_WarehouseSections_WarehouseSectionId",
                table: "Shelves",
                column: "WarehouseSectionId",
                principalTable: "WarehouseSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shelves_WarehouseSections_WarehouseSectionId",
                table: "Shelves");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelves",
                table: "Shelves");

            migrationBuilder.RenameTable(
                name: "Shelves",
                newName: "Shelf");

            migrationBuilder.RenameIndex(
                name: "IX_Shelves_WarehouseSectionId",
                table: "Shelf",
                newName: "IX_Shelf_WarehouseSectionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelf",
                table: "Shelf",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shelf_WarehouseSections_WarehouseSectionId",
                table: "Shelf",
                column: "WarehouseSectionId",
                principalTable: "WarehouseSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
