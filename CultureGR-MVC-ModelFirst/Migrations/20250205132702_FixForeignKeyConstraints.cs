using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureGR_MVC_ModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class FixForeignKeyConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Museums_CategoriesMuseums_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_Collections_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_TimePeriods_Id",
                table: "Museums");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_CategoriesMuseums_Id",
                table: "Museums",
                column: "Id",
                principalTable: "CategoriesMuseums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_Collections_Id",
                table: "Museums",
                column: "Id",
                principalTable: "Collections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_TimePeriods_Id",
                table: "Museums",
                column: "Id",
                principalTable: "TimePeriods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Museums_CategoriesMuseums_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_Collections_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_TimePeriods_Id",
                table: "Museums");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_CategoriesMuseums_Id",
                table: "Museums",
                column: "Id",
                principalTable: "CategoriesMuseums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_Collections_Id",
                table: "Museums",
                column: "Id",
                principalTable: "Collections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_TimePeriods_Id",
                table: "Museums",
                column: "Id",
                principalTable: "TimePeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
