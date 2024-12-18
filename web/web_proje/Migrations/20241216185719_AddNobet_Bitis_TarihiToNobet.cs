using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_proje.Migrations
{
    /// <inheritdoc />
    public partial class AddNobet_Bitis_TarihiToNobet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Nobet_Tarihi_Bitis",
                table: "Nobetler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nobet_Tarihi_Bitis",
                table: "Nobetler");
        }
    }
}
