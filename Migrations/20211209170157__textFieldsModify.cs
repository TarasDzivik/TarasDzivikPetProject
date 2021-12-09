using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class _textFieldsModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a7ec824f-d205-41c1-8b3c-c0455cf0a497");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cf9fdda-51c8-462d-b43b-3de83bff0b91", "AQAAAAEAACcQAAAAEBTrTIJGu56YOebU2FN4JVRJcosaW+IAMoaUwdaHR+B9GLfRlmg6p4m+1onWAWOBvQ==" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Loan Calculator", "PageLoanCalculator" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "Назва сторінки (Заголовок)",
                value: "Main");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf163a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Rent page", "PageRentVehicle" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Buy page", "PageBuyVehicle" });

            migrationBuilder.InsertData(
                table: "ElementsBase",
                columns: new[] { "Id", "Discriminator", "SEO Метатег Description", "SEO Метатег Keywords", "SEO Метатег Title", "Subtitle", "Назва сторінки (Заголовок)", "Титульна картинка", "CodeWord" },
                values: new object[] { new Guid("4aa76b4c-c59d-409a-84c1-06e6487a137a"), "TextField", null, null, null, null, "Contacts", null, "PageContacts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76b4c-c59d-409a-84c1-06e6487a137a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "19a1f370-76fb-41dc-982a-f3593b24e8df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c489a7b-8c95-4abc-8c89-6dc5cc095679", "AQAAAAEAACcQAAAAEHjtZerY9n8mIvalqcYiyUvH5E+O3sMgM9toY8DToCLm1GwsJUX8x3xU5nT88S34Yg==" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Loan Calculator", "LoanCalculator" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "Назва сторінки (Заголовок)",
                value: "Main");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf163a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Rent page", "RentVehicle" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                columns: new[] { "Назва сторінки (Заголовок)", "CodeWord" },
                values: new object[] { "Buy page", "BuyVehicle" });
        }
    }
}
