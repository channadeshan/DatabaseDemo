using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountCode2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "discount_codes",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "TimesUsed",
                table: "discount_codes",
                newName: "times_used");

            migrationBuilder.RenameColumn(
                name: "MaxUsage",
                table: "discount_codes",
                newName: "max_usage");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "discount_codes",
                newName: "expiration_date");

            migrationBuilder.RenameColumn(
                name: "DiscountValue",
                table: "discount_codes",
                newName: "discount_value");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "discount_codes",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "times_used",
                table: "discount_codes",
                newName: "TimesUsed");

            migrationBuilder.RenameColumn(
                name: "max_usage",
                table: "discount_codes",
                newName: "MaxUsage");

            migrationBuilder.RenameColumn(
                name: "expiration_date",
                table: "discount_codes",
                newName: "ExpirationDate");

            migrationBuilder.RenameColumn(
                name: "discount_value",
                table: "discount_codes",
                newName: "DiscountValue");
        }
    }
}
