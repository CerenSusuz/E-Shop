using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
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
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                columns: new[] { "Id", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Kadın", null },
                    { 2, "Erkek", null }
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
                columns: new[] { "Id", "CreatedUser", "Email", "FirstName", "GenderId", "Gsm", "IsSuperVisor", "LastName", "PasswordHash", "PasswordSalt", "UpdatedAt", "UserGroupId" },
                values: new object[] { 1, "Migration", "ceren199704@hotmail.com", "Ceren", null, "5541172005", true, "Susuz", new byte[] { 243, 83, 140, 162, 174, 101, 76, 241, 76, 246, 75, 191, 112, 92, 234, 186, 45, 178, 46, 6, 93, 24, 186, 149, 72, 252, 84, 252, 226, 30, 81, 147, 146, 81, 51, 200, 44, 88, 149, 1, 200, 183, 178, 164, 157, 100, 56, 60, 153, 188, 164, 105, 93, 35, 138, 140, 41, 138, 61, 197, 198, 114, 39, 133 }, new byte[] { 68, 227, 84, 99, 222, 138, 239, 184, 86, 10, 31, 172, 206, 182, 73, 251, 212, 52, 55, 214, 172, 130, 70, 119, 4, 60, 139, 34, 72, 150, 111, 208, 238, 119, 56, 116, 137, 140, 70, 65, 157, 205, 174, 228, 213, 166, 12, 80, 0, 166, 32, 165, 182, 72, 79, 93, 23, 84, 48, 40, 54, 245, 157, 82, 25, 110, 125, 220, 193, 247, 171, 53, 194, 81, 174, 113, 46, 172, 118, 42, 236, 111, 142, 133, 66, 218, 250, 149, 137, 197, 244, 72, 159, 28, 96, 90, 179, 214, 96, 76, 224, 104, 235, 64, 130, 217, 100, 245, 98, 150, 170, 41, 126, 191, 203, 209, 63, 132, 78, 110, 8, 255, 131, 74, 239, 121, 88, 216 }, null, 1 });

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
