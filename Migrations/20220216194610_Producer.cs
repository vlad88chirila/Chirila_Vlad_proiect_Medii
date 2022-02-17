using Microsoft.EntityFrameworkCore.Migrations;

namespace Chirila_Vlad_proiect_Medii.Migrations
{
    public partial class Producer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProducerID",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProducerID",
                table: "Movie",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Producer_ProducerID",
                table: "Movie",
                column: "ProducerID",
                principalTable: "Producer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Producer_ProducerID",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_Movie_ProducerID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ProducerID",
                table: "Movie");
        }
    }
}
