using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulOdev.Migrations
{
    /// <inheritdoc />
    public partial class OgrenciDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Numara = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.OgrenciId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}
