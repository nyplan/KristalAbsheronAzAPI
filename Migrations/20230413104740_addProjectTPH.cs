using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KristalAbsheronAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addProjectTPH : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OngoingProjectId",
                table: "ProjectPhotos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "ProjectPhotos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "PlanOfApartments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompletedProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TermsOfSale = table.Column<string>(type: "text", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    AboutTheProject = table.Column<string>(type: "text", nullable: true),
                    IsPremium = table.Column<bool>(type: "boolean", nullable: false),
                    ProjectType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompletedProjects_EnumValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhotos_OngoingProjectId",
                table: "ProjectPhotos",
                column: "OngoingProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPhotos_ProjectId",
                table: "ProjectPhotos",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanOfApartments_ProjectId",
                table: "PlanOfApartments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedProjects_StatusId",
                table: "CompletedProjects",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanOfApartments_CompletedProjects_ProjectId",
                table: "PlanOfApartments",
                column: "ProjectId",
                principalTable: "CompletedProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPhotos_CompletedProjects_OngoingProjectId",
                table: "ProjectPhotos",
                column: "OngoingProjectId",
                principalTable: "CompletedProjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectPhotos_CompletedProjects_ProjectId",
                table: "ProjectPhotos",
                column: "ProjectId",
                principalTable: "CompletedProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanOfApartments_CompletedProjects_ProjectId",
                table: "PlanOfApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPhotos_CompletedProjects_OngoingProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectPhotos_CompletedProjects_ProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropTable(
                name: "CompletedProjects");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPhotos_OngoingProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropIndex(
                name: "IX_ProjectPhotos_ProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropIndex(
                name: "IX_PlanOfApartments_ProjectId",
                table: "PlanOfApartments");

            migrationBuilder.DropColumn(
                name: "OngoingProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "ProjectPhotos");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "PlanOfApartments");
        }
    }
}
