using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.DataAccess.Migrations
{
    public partial class nullableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserGroups",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genders",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new byte[] { 81, 232, 157, 69, 93, 95, 194, 20, 98, 237, 226, 102, 141, 63, 141, 36, 79, 252, 191, 8, 124, 160, 49, 192, 87, 44, 27, 237, 205, 15, 243, 23, 7, 51, 9, 101, 214, 153, 207, 137, 243, 246, 254, 218, 74, 69, 170, 132, 28, 31, 133, 9, 52, 39, 46, 74, 168, 114, 214, 105, 198, 79, 122, 141 }, new byte[] { 112, 115, 68, 231, 55, 225, 143, 84, 207, 250, 210, 168, 1, 149, 217, 82, 59, 224, 101, 130, 218, 227, 47, 179, 198, 135, 128, 39, 252, 191, 150, 50, 187, 110, 209, 221, 88, 160, 32, 192, 53, 5, 167, 179, 10, 153, 144, 180, 135, 132, 213, 46, 25, 67, 143, 249, 132, 182, 27, 2, 167, 199, 230, 93, 140, 170, 124, 249, 31, 87, 255, 6, 87, 207, 132, 30, 21, 197, 6, 178, 165, 195, 240, 81, 138, 66, 65, 19, 16, 70, 61, 249, 7, 75, 112, 47, 121, 29, 188, 39, 54, 125, 164, 196, 133, 206, 51, 62, 66, 130, 53, 196, 79, 135, 74, 242, 202, 191, 164, 144, 231, 128, 47, 130, 15, 101, 15, 232 }, null });

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

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "UserGroups",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genders",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GetDate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GetDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GetDate()");

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

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
