using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ppt.Api.Migrations
{
    /// <inheritdoc />
    public partial class secondmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isRevisionNeeded",
                table: "Vybavenis",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isRevisionNeeded",
                table: "Vybavenis");
        }
    }
}
