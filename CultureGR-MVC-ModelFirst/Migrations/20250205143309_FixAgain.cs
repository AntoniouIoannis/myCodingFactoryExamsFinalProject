using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureGR_MVC_ModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class FixAgain : Migration
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

            migrationBuilder.AlterColumn<string>(
                name: "mus_region",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_phone",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_open",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_name",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_desc",
                table: "Museums",
                type: "nvarchar(MAX)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_coordinate",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "mus_avg_rate",
                table: "Museums",
                type: "decimal(3,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "mus_address",
                table: "Museums",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Museums",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_category_Id",
                table: "Museums",
                column: "category_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_collection_Id",
                table: "Museums",
                column: "collection_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_timeperiod_Id",
                table: "Museums",
                column: "timeperiod_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_CategoriesMuseums_category_Id",
                table: "Museums",
                column: "category_Id",
                principalTable: "CategoriesMuseums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_Collections_collection_Id",
                table: "Museums",
                column: "collection_Id",
                principalTable: "Collections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Museums_TimePeriods_timeperiod_Id",
                table: "Museums",
                column: "timeperiod_Id",
                principalTable: "TimePeriods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Museums_CategoriesMuseums_category_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_Collections_collection_Id",
                table: "Museums");

            migrationBuilder.DropForeignKey(
                name: "FK_Museums_TimePeriods_timeperiod_Id",
                table: "Museums");

            migrationBuilder.DropIndex(
                name: "IX_Museums_category_Id",
                table: "Museums");

            migrationBuilder.DropIndex(
                name: "IX_Museums_collection_Id",
                table: "Museums");

            migrationBuilder.DropIndex(
                name: "IX_Museums_timeperiod_Id",
                table: "Museums");

            migrationBuilder.AlterColumn<string>(
                name: "mus_region",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "mus_phone",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "mus_open",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "mus_name",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "mus_desc",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_coordinate",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<double>(
                name: "mus_avg_rate",
                table: "Museums",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,2)");

            migrationBuilder.AlterColumn<string>(
                name: "mus_address",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Museums",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
    }
}
