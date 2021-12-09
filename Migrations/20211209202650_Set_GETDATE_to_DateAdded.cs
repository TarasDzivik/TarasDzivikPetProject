using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class Set_GETDATE_to_DateAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Додано",
                table: "VehicleItem",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "1d97e95c-21f1-481f-999b-a1ba330d50dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5530a54f-e251-4f0d-b560-b9d2bf03e7e0", "AQAAAAEAACcQAAAAEHTF+SPytVfwl0hXjZLMXlb6UDsZ4hVT5zfnSZ0tunP3+72NSoO+e8cZ1ZjTrwb5TQ==" });

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
            migrationBuilder.AlterColumn<DateTime>(
                name: "Додано",
                table: "VehicleItem",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "GETDATE()");

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
    }
}
