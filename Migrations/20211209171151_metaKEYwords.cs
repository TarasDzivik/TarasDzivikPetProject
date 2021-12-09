using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class metaKEYwords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "09fb9c5f-cb5b-4dca-ac30-41b2404a1a67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1e727c3-71e2-45fe-9188-f48aca13870d", "AQAAAAEAACcQAAAAEPRt+HyCWYthgSb3Zh1Dkzra/N9Nh5J8BZonJVfpAKJ4JbvUAPNUwnD48GDy18gQQQ==" });

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "Назва сторінки (Заголовок)",
                value: "Loan Calculator");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76b4c-c59d-409a-84c1-06e6487a137a"),
                column: "Назва сторінки (Заголовок)",
                value: "Contacts");

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
                column: "Назва сторінки (Заголовок)",
                value: "Rent page");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "Назва сторінки (Заголовок)",
                value: "Buy page");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "Назва сторінки (Заголовок)",
                value: "Loan Calculator");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("4aa76b4c-c59d-409a-84c1-06e6487a137a"),
                column: "Назва сторінки (Заголовок)",
                value: "Contacts");

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
                column: "Назва сторінки (Заголовок)",
                value: "Rent page");

            migrationBuilder.UpdateData(
                table: "ElementsBase",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "Назва сторінки (Заголовок)",
                value: "Buy page");
        }
    }
}
