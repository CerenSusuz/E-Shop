using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.DataAccess.Migrations
{
    public partial class dbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "space(0)"),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GetDate()"),
                    CreatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)"),
                    UpdatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "space(0)"),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GetDate()"),
                    CreatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)"),
                    UpdatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "space(0)"),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "space(0)"),
                    Gsm = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "space(0)"),
                    Email = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValueSql: "space(0)"),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsSuperVisor = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserGroupId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GetDate()"),
                    CreatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)"),
                    UpdatedUser = table.Column<string>(type: "nvarchar(61)", maxLength: 61, nullable: false, defaultValueSql: "space(0)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_UserGroups_UserGroupId",
                        column: x => x.UserGroupId,
                        principalTable: "UserGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Kadın" },
                    { 2, "Erkek" }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Personel" },
                    { 2, "Son kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedUser", "Email", "FirstName", "GenderId", "Gsm", "IsSuperVisor", "LastName", "PasswordHash", "PasswordSalt", "UserGroupId" },
                values: new object[] { 1, "Migration", "ceren199704@hotmail.com", "Ceren", 1, "5541172005", true, "Susuz", new byte[] { 106, 7, 4, 40, 14, 106, 76, 13, 10, 74, 9, 235, 176, 182, 181, 101, 36, 237, 120, 4, 20, 68, 4, 153, 237, 154, 1, 91, 4, 4, 153, 177, 194, 7, 221, 67, 66, 105, 80, 50, 223, 221, 167, 211, 75, 238, 15, 13, 205, 110, 14, 148, 99, 236, 241, 216, 190, 191, 164, 84, 19, 23, 5, 151 }, new byte[] { 96, 87, 101, 83, 135, 232, 141, 13, 111, 192, 56, 249, 125, 79, 14, 148, 231, 146, 96, 222, 38, 187, 169, 72, 71, 211, 247, 146, 211, 18, 2, 25, 174, 27, 67, 247, 35, 247, 43, 29, 187, 225, 115, 98, 71, 42, 10, 185, 87, 55, 164, 30, 99, 136, 245, 111, 219, 15, 58, 99, 235, 160, 13, 39, 78, 202, 164, 184, 72, 40, 211, 40, 32, 175, 23, 182, 61, 100, 226, 218, 159, 11, 159, 81, 161, 68, 197, 248, 253, 131, 22, 143, 156, 249, 222, 53, 230, 93, 169, 145, 153, 81, 222, 185, 59, 189, 49, 91, 228, 136, 26, 35, 27, 217, 149, 91, 55, 199, 223, 37, 145, 28, 169, 96, 40, 131, 210, 179 }, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Email",
                table: "Accounts",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_FirstName_LastName",
                table: "Accounts",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_GenderId",
                table: "Accounts",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Gsm",
                table: "Accounts",
                column: "Gsm");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_UserGroupId",
                table: "Accounts",
                column: "UserGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_Description",
                table: "Genders",
                column: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_Description",
                table: "UserGroups",
                column: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "UserGroups");
        }
    }
}
