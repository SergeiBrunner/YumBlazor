using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YumBlazor.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "Product",
                newName: "SpecialTag");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SpecialTag",
                table: "Product",
                newName: "MyProperty");
        }
    }
}
