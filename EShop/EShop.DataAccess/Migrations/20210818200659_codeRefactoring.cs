using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.DataAccess.Migrations
{
    public partial class codeRefactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genders",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new byte[] { 81, 131, 242, 10, 202, 100, 29, 103, 144, 69, 69, 158, 166, 1, 42, 133, 128, 4, 164, 199, 17, 76, 185, 255, 0, 18, 73, 209, 117, 142, 172, 207, 200, 21, 61, 79, 37, 12, 213, 26, 107, 152, 230, 39, 184, 47, 164, 175, 199, 9, 22, 223, 70, 252, 118, 208, 148, 91, 36, 232, 109, 35, 248, 100 }, new byte[] { 198, 12, 19, 100, 225, 78, 79, 40, 122, 218, 104, 203, 92, 63, 3, 50, 133, 25, 104, 88, 13, 21, 82, 145, 196, 15, 1, 148, 123, 10, 225, 175, 21, 76, 217, 28, 124, 119, 48, 36, 2, 223, 201, 103, 10, 4, 11, 204, 49, 36, 4, 224, 116, 215, 82, 117, 78, 54, 122, 73, 15, 207, 215, 167, 221, 244, 117, 245, 82, 221, 117, 167, 106, 166, 209, 143, 0, 191, 203, 170, 35, 173, 198, 77, 223, 144, 105, 69, 180, 223, 1, 186, 7, 84, 51, 169, 82, 193, 71, 220, 5, 230, 89, 200, 175, 58, 72, 184, 111, 112, 187, 208, 160, 150, 145, 14, 186, 216, 206, 46, 76, 122, 34, 254, 75, 76, 241, 124 }, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new byte[] { 243, 83, 140, 162, 174, 101, 76, 241, 76, 246, 75, 191, 112, 92, 234, 186, 45, 178, 46, 6, 93, 24, 186, 149, 72, 252, 84, 252, 226, 30, 81, 147, 146, 81, 51, 200, 44, 88, 149, 1, 200, 183, 178, 164, 157, 100, 56, 60, 153, 188, 164, 105, 93, 35, 138, 140, 41, 138, 61, 197, 198, 114, 39, 133 }, new byte[] { 68, 227, 84, 99, 222, 138, 239, 184, 86, 10, 31, 172, 206, 182, 73, 251, 212, 52, 55, 214, 172, 130, 70, 119, 4, 60, 139, 34, 72, 150, 111, 208, 238, 119, 56, 116, 137, 140, 70, 65, 157, 205, 174, 228, 213, 166, 12, 80, 0, 166, 32, 165, 182, 72, 79, 93, 23, 84, 48, 40, 54, 245, 157, 82, 25, 110, 125, 220, 193, 247, 171, 53, 194, 81, 174, 113, 46, 172, 118, 42, 236, 111, 142, 133, 66, 218, 250, 149, 137, 197, 244, 72, 159, 28, 96, 90, 179, 214, 96, 76, 224, 104, 235, 64, 130, 217, 100, 245, 98, 150, 170, 41, 126, 191, 203, 209, 63, 132, 78, 110, 8, 255, 131, 74, 239, 121, 88, 216 }, null });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: null);
        }
    }
}
