using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurentAPI.Migrations
{
    public partial class IntitialRestaurant2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Menus_MenuId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Menus_MenuId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MenuId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_MenuId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Ingredients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MenuId",
                table: "Orders",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MenuId",
                table: "Ingredients",
                column: "MenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Menus_MenuId",
                table: "Ingredients",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Menus_MenuId",
                table: "Orders",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "MenuId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
