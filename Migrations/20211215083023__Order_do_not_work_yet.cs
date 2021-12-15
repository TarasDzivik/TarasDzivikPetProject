using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TarasDzivikPetProject.Migrations
{
    public partial class _Order_do_not_work_yet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "78491891-00bf-40ca-969b-2e96bf7cfa70");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e50fe46-11fa-47bb-a50f-2a61b56c1a2c", "AQAAAAEAACcQAAAAEMgluGyieJn5fJDOZYP2ek24qthBMOnnAGFU+KYqVjYbWPVZdVOWUB8YZx2wAOVmlA==" });

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
            migrationBuilder.AddColumn<int>(
                name: "CurrentOrderId",
                table: "VehicleItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Статусзамовлення = table.Column<bool>(name: "Статус замовлення", type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Імя = table.Column<string>(name: "Ім'я", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Прізвище = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(17)", maxLength: 17, nullable: false)
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
                value: "67483efb-3c4b-4516-8453-040a0bc3642b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "247d931b-bfbd-4e79-9372-e364bb41bc17", "AQAAAAEAACcQAAAAED9kKuVKvDka+LujxeeHQA7fjIhOKI9B6YMZz9ho2FCU8izdpxqB63ycr32zMEaW+w==" });

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
    }
}
