using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class _Order_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropColumn(
                name: "SEO Метатег Description",
                table: "VehicleItem");

            migrationBuilder.DropColumn(
                name: "SEO Метатег Keywords",
                table: "VehicleItem");

            migrationBuilder.DropColumn(
                name: "SEO Метатег Title",
                table: "VehicleItem");

            migrationBuilder.AlterColumn<string>(
                name: "Тип транспортного засобу",
                table: "VehicleItem",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Вид палива",
                table: "VehicleItem",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CurrentOrderId",
                table: "VehicleItem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Імя = table.Column<string>(name: "Ім'я", maxLength: 20, nullable: false),
                    Прізвище = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<string>(maxLength: 17, nullable: false),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    Статусзамовлення = table.Column<bool>(name: "Статус замовлення", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "981ee795-5927-40a9-897a-b2a55462bda4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10327aa5-3fb6-4ba1-b77c-ec0a7fee3929", "AQAAAAEAACcQAAAAEAWMmeL6UnWi7hIHlO89i4wQaccOA5B0LzS66spMGIlPn72p1sQPuVHL0xLJG3yWyQ==" });

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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleItem_CurrentOrderId",
                table: "VehicleItem",
                column: "CurrentOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleItem_Orders_CurrentOrderId",
                table: "VehicleItem",
                column: "CurrentOrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleItem_Orders_CurrentOrderId",
                table: "VehicleItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_VehicleItem_CurrentOrderId",
                table: "VehicleItem");

            migrationBuilder.DropColumn(
                name: "CurrentOrderId",
                table: "VehicleItem");

            migrationBuilder.AlterColumn<string>(
                name: "Тип транспортного засобу",
                table: "VehicleItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Вид палива",
                table: "VehicleItem",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SEO Метатег Description",
                table: "VehicleItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SEO Метатег Keywords",
                table: "VehicleItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SEO Метатег Title",
                table: "VehicleItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Імя = table.Column<string>(name: "Ім'я", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Прізвище = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

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
    }
}
