using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureGR_MVC_ModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class SecondFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Identity",
                table: "Users",
                type: "int",
                maxLength: 255,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkPhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ArchaeologicalSiteId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryMuseumId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CollectionId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExcavationId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertedAt",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MonumentId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MuseumId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TextEditorId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimePeriodId",
                table: "Records",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArchaeologicalSites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchaeologicalSites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchaeologicalSites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoriesMuseums_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    collectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Excavations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Region = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excavations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Excavations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monumentName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    monumentDesc = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    monumentLocation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monuments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextEditor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ΕditorialΤeam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextEditor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextEditor_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimePeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    periodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    periodStartEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    periodDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimePeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimePeriods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Museums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    mus_region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_coordinate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mus_open = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_Id = table.Column<int>(type: "int", nullable: false),
                    collection_Id = table.Column<int>(type: "int", nullable: false),
                    timeperiod_Id = table.Column<int>(type: "int", nullable: false),
                    mus_avg_rate = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Museums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Museums_CategoriesMuseums_Id",
                        column: x => x.Id,
                        principalTable: "CategoriesMuseums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Museums_Collections_Id",
                        column: x => x.Id,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Museums_TimePeriods_Id",
                        column: x => x.Id,
                        principalTable: "TimePeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Museums_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_ArchaeologicalSiteId",
                table: "Records",
                column: "ArchaeologicalSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CategoryMuseumId",
                table: "Records",
                column: "CategoryMuseumId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CollectionId",
                table: "Records",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_ExcavationId",
                table: "Records",
                column: "ExcavationId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_MonumentId",
                table: "Records",
                column: "MonumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_MuseumId",
                table: "Records",
                column: "MuseumId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_TextEditorId",
                table: "Records",
                column: "TextEditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_TimePeriodId",
                table: "Records",
                column: "TimePeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_ArchaeologicalSites_UserId",
                table: "ArchaeologicalSites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesMuseums_UserId",
                table: "CategoriesMuseums",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_UserId",
                table: "Collections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Excavations_UserId",
                table: "Excavations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_UserId",
                table: "Monuments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Museums_UserId",
                table: "Museums",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TextEditor_UserId",
                table: "TextEditor",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimePeriods_UserId",
                table: "TimePeriods",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_ArchaeologicalSites_ArchaeologicalSiteId",
                table: "Records",
                column: "ArchaeologicalSiteId",
                principalTable: "ArchaeologicalSites",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_CategoriesMuseums_CategoryMuseumId",
                table: "Records",
                column: "CategoryMuseumId",
                principalTable: "CategoriesMuseums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Collections_CollectionId",
                table: "Records",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Excavations_ExcavationId",
                table: "Records",
                column: "ExcavationId",
                principalTable: "Excavations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Monuments_MonumentId",
                table: "Records",
                column: "MonumentId",
                principalTable: "Monuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Museums_MuseumId",
                table: "Records",
                column: "MuseumId",
                principalTable: "Museums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_TextEditor_TextEditorId",
                table: "Records",
                column: "TextEditorId",
                principalTable: "TextEditor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_TimePeriods_TimePeriodId",
                table: "Records",
                column: "TimePeriodId",
                principalTable: "TimePeriods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_ArchaeologicalSites_ArchaeologicalSiteId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_CategoriesMuseums_CategoryMuseumId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Collections_CollectionId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Excavations_ExcavationId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Monuments_MonumentId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Museums_MuseumId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_TextEditor_TextEditorId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_TimePeriods_TimePeriodId",
                table: "Records");

            migrationBuilder.DropTable(
                name: "ArchaeologicalSites");

            migrationBuilder.DropTable(
                name: "Excavations");

            migrationBuilder.DropTable(
                name: "Monuments");

            migrationBuilder.DropTable(
                name: "Museums");

            migrationBuilder.DropTable(
                name: "TextEditor");

            migrationBuilder.DropTable(
                name: "CategoriesMuseums");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "TimePeriods");

            migrationBuilder.DropIndex(
                name: "IX_Records_ArchaeologicalSiteId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_CategoryMuseumId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_CollectionId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_ExcavationId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_MonumentId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_MuseumId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_TextEditorId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_TimePeriodId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "Identity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkPhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ArchaeologicalSiteId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CategoryMuseumId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "CollectionId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ExcavationId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "InsertedAt",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "MonumentId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "MuseumId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "TextEditorId",
                table: "Records");

            migrationBuilder.DropColumn(
                name: "TimePeriodId",
                table: "Records");
        }
    }
}
