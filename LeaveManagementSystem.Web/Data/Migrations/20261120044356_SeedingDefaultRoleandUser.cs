using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRoleandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45a02c50-b94c-4ea8-a49f-9551a41acb84", "8c112e27-1638-4031-9b93-da57793214c1", "Administrator", "ADMINISTRATOR" },
                    { "475c17c9-d7e3-48f8-8698-57b0997e286d", "0d321427-dae3-4668-a842-f305b763bd18", "Employee", "EMPLOYEE" },
                    { "7721ebeb-2b90-463f-8ebe-559110e7929b", "958810b4-f612-4eb1-9188-ce740634a7d2", "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf", 0, "1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEFMSjQGvVcYLAy9HxOU06eFvAOHhzqnLCxcDCn9Pr9oP2O7s3INvwJ61SPMD8TrZVg==", null, false, "7a1b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "45a02c50-b94c-4ea8-a49f-9551a41acb84", "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "475c17c9-d7e3-48f8-8698-57b0997e286d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7721ebeb-2b90-463f-8ebe-559110e7929b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45a02c50-b94c-4ea8-a49f-9551a41acb84", "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45a02c50-b94c-4ea8-a49f-9551a41acb84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e2e97e5-a28f-497c-bb0f-3c4a8d673faf");
        }
    }
}
