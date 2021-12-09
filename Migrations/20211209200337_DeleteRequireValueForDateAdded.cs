using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class DeleteRequireValueForDateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "6a73c96b-275b-420f-a931-8462dce13f25");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78114d81-672e-4f05-bfcc-3445ffefd447", "AQAAAAEAACcQAAAAENXEYnkFjPgzulXkwdom0SFNzbEe7KAXH/XxwZ3c/K1YI07aHG/UHkRL5sjwW6+QkQ==" });

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
                value: "ae5e3c0f-094b-4902-8dd6-30b806e8020f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e517eec1-2684-4209-af20-cfb5857c52a8", "AQAAAAEAACcQAAAAEPy1vf813zgPMPjiaXv8hWUaQrDwi2EvGY7UzEwkeBGsq48rIIuE7G2UhozmYosBBQ==" });

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
