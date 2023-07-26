using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace simpl_ToDoList.api.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Statuss",
                columns: new[] { "idStatus", "Value" },
                values: new object[,]
                {
                    { 1, "A Faire" },
                    { 2, "En cours" },
                    { 3, "Terminée" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "blabla@gmail.com", "Val", "Ras" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statuss",
                keyColumn: "idStatus",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuss",
                keyColumn: "idStatus",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuss",
                keyColumn: "idStatus",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1);
        }
    }
}
