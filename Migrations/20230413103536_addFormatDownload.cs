using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KristalAbsheronAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addFormatDownload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DownloadFormat",
                columns: table => new
                {
                    DownloadsId = table.Column<int>(type: "integer", nullable: false),
                    FormatsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DownloadFormat", x => new { x.DownloadsId, x.FormatsId });
                    table.ForeignKey(
                        name: "FK_DownloadFormat_Downloads_DownloadsId",
                        column: x => x.DownloadsId,
                        principalTable: "Downloads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DownloadFormat_Formats_FormatsId",
                        column: x => x.FormatsId,
                        principalTable: "Formats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DownloadFormat_FormatsId",
                table: "DownloadFormat",
                column: "FormatsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DownloadFormat");
        }
    }
}
