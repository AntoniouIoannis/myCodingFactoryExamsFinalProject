using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CultureGR_MVC_ModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class InitialBuiltCulture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorianArchPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorianArchPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorianMonuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorianMonuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistorianMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorianMuseums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HistorianArchPlacesId = table.Column<int>(type: "int", nullable: true),
                    HistorianMonumentsId = table.Column<int>(type: "int", nullable: true),
                    HistorianMuseumsId = table.Column<int>(type: "int", nullable: true),
                    SubscriberId = table.Column<int>(type: "int", nullable: true),
                    WriterArchPlacesId = table.Column<int>(type: "int", nullable: true),
                    WriterMonumentsId = table.Column<int>(type: "int", nullable: true),
                    WriterMuseumsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_HistorianArchPlaces_HistorianArchPlacesId",
                        column: x => x.HistorianArchPlacesId,
                        principalTable: "HistorianArchPlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_HistorianMonuments_HistorianMonumentsId",
                        column: x => x.HistorianMonumentsId,
                        principalTable: "HistorianMonuments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_HistorianMuseums_HistorianMuseumsId",
                        column: x => x.HistorianMuseumsId,
                        principalTable: "HistorianMuseums",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    RePassword = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: true),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Records_RecordId",
                        column: x => x.RecordId,
                        principalTable: "Records",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RePassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Banned = table.Column<bool>(type: "bit", nullable: false),
                    UserRole = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscribers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriterArchPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterArchPlaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WriterArchPlaces_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriterMonuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterMonuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WriterMonuments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriterMuseums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EditorialTeam = table.Column<int>(type: "int", maxLength: 255, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkPhoneNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    InsertedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterMuseums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WriterMuseums_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorianArchPlaces_EditorialTeam",
                table: "HistorianArchPlaces",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianArchPlaces_UserId",
                table: "HistorianArchPlaces",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorianArchPlaces_Username",
                table: "HistorianArchPlaces",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianArchPlaces_WorkPhoneNumber",
                table: "HistorianArchPlaces",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMonuments_EditorialTeam",
                table: "HistorianMonuments",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMonuments_UserId",
                table: "HistorianMonuments",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMonuments_Username",
                table: "HistorianMonuments",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMonuments_WorkPhoneNumber",
                table: "HistorianMonuments",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMuseums_EditorialTeam",
                table: "HistorianMuseums",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMuseums_UserId",
                table: "HistorianMuseums",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMuseums_Username",
                table: "HistorianMuseums",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_HistorianMuseums_WorkPhoneNumber",
                table: "HistorianMuseums",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Records_Description",
                table: "Records",
                column: "Descr");

            migrationBuilder.CreateIndex(
                name: "IX_Records_HistorianArchPlacesId",
                table: "Records",
                column: "HistorianArchPlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_HistorianMonumentsId",
                table: "Records",
                column: "HistorianMonumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_HistorianMuseumsId",
                table: "Records",
                column: "HistorianMuseumsId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_SubscriberId",
                table: "Records",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_WriterArchPlacesId",
                table: "Records",
                column: "WriterArchPlacesId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_WriterMonumentsId",
                table: "Records",
                column: "WriterMonumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_WriterMuseumsId",
                table: "Records",
                column: "WriterMuseumsId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_Banned",
                table: "Subscribers",
                column: "Banned");

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_Firstname",
                table: "Subscribers",
                column: "Firstname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_Lastname",
                table: "Subscribers",
                column: "Lastname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_UserId",
                table: "Subscribers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_Username",
                table: "Subscribers",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RecordId",
                table: "Users",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterArchPlaces_EditorialTeam",
                table: "WriterArchPlaces",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_WriterArchPlaces_UserId",
                table: "WriterArchPlaces",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterArchPlaces_WorkPhoneNumber",
                table: "WriterArchPlaces",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterMonuments_EditorialTeam",
                table: "WriterMonuments",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_WriterMonuments_UserId",
                table: "WriterMonuments",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterMonuments_WorkPhoneNumber",
                table: "WriterMonuments",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterMuseums_EditorialTeam",
                table: "WriterMuseums",
                column: "EditorialTeam");

            migrationBuilder.CreateIndex(
                name: "IX_WriterMuseums_UserId",
                table: "WriterMuseums",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriterMuseums_WorkPhoneNumber",
                table: "WriterMuseums",
                column: "WorkPhoneNumber",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorianArchPlaces_Users_UserId",
                table: "HistorianArchPlaces",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorianMonuments_Users_UserId",
                table: "HistorianMonuments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistorianMuseums_Users_UserId",
                table: "HistorianMuseums",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Subscribers_SubscriberId",
                table: "Records",
                column: "SubscriberId",
                principalTable: "Subscribers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_WriterArchPlaces_WriterArchPlacesId",
                table: "Records",
                column: "WriterArchPlacesId",
                principalTable: "WriterArchPlaces",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_WriterMonuments_WriterMonumentsId",
                table: "Records",
                column: "WriterMonumentsId",
                principalTable: "WriterMonuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_WriterMuseums_WriterMuseumsId",
                table: "Records",
                column: "WriterMuseumsId",
                principalTable: "WriterMuseums",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistorianArchPlaces_Users_UserId",
                table: "HistorianArchPlaces");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorianMonuments_Users_UserId",
                table: "HistorianMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_HistorianMuseums_Users_UserId",
                table: "HistorianMuseums");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_Users_UserId",
                table: "Subscribers");

            migrationBuilder.DropForeignKey(
                name: "FK_WriterArchPlaces_Users_UserId",
                table: "WriterArchPlaces");

            migrationBuilder.DropForeignKey(
                name: "FK_WriterMonuments_Users_UserId",
                table: "WriterMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_WriterMuseums_Users_UserId",
                table: "WriterMuseums");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "HistorianArchPlaces");

            migrationBuilder.DropTable(
                name: "HistorianMonuments");

            migrationBuilder.DropTable(
                name: "HistorianMuseums");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "WriterArchPlaces");

            migrationBuilder.DropTable(
                name: "WriterMonuments");

            migrationBuilder.DropTable(
                name: "WriterMuseums");
        }
    }
}
