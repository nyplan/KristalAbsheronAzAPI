using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KristalAbsheronAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationNewsPhotoNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "NewsPhotos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_NewsPhotos_NewsId",
                table: "NewsPhotos",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsPhotos_News_NewsId",
                table: "NewsPhotos",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsPhotos_News_NewsId",
                table: "NewsPhotos");

            migrationBuilder.DropIndex(
                name: "IX_NewsPhotos_NewsId",
                table: "NewsPhotos");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "NewsPhotos");
        }
    }
}
