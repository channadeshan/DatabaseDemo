using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountCode1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "discount_codes",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "DiscountType",
                table: "discount_codes",
                newName: "discount_type");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "code",
                table: "discount_codes",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "discount_type",
                table: "discount_codes",
                newName: "DiscountType");
        }
    }
}
