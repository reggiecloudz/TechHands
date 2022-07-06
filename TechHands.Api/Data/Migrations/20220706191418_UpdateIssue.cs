using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechHands.Api.Data.Migrations
{
    public partial class UpdateIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69b59dd7-85c6-4499-bf7d-b7fa7addc33d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2fd23f1-ebf7-46b0-b6fa-43127e20e69e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff0910cf-05bf-44c7-9325-7626826342fe");

            migrationBuilder.AddColumn<bool>(
                name: "OpenToCommunity",
                table: "Issues",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0de819de-9242-481d-82c1-dff1e1fb1be2", "f982bf77-63c5-4989-b202-eca4d907b08a", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "601ee43a-943a-4c3c-a764-fc8095e12734", "ff5b28c0-50d0-4696-be3d-af5ba64f689d", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba027b83-a416-4915-8488-73a7674ad9f1", "5d0ef2dd-7e12-40f6-9dbc-594668a8cc0f", "Technician", "TECHNICIAN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0de819de-9242-481d-82c1-dff1e1fb1be2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "601ee43a-943a-4c3c-a764-fc8095e12734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba027b83-a416-4915-8488-73a7674ad9f1");

            migrationBuilder.DropColumn(
                name: "OpenToCommunity",
                table: "Issues");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69b59dd7-85c6-4499-bf7d-b7fa7addc33d", "6f874c82-d2ce-44e5-889d-6e1ae5c1c89f", "Technician", "TECHNICIAN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2fd23f1-ebf7-46b0-b6fa-43127e20e69e", "2680e50d-2649-428c-b7de-6944164842b5", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff0910cf-05bf-44c7-9325-7626826342fe", "b2b98c60-e0b0-4611-91bc-e29167145e0a", "Administrator", "ADMINISTRATOR" });
        }
    }
}
