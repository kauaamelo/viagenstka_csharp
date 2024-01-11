using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Viagenstka.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomeCompleto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "id", "cpf", "telefone", "url", "nomeCompleto" },
                values: new object[,]
                {
                    { 1, "122.122.133-33", "(21)99797-4565", "https://fv5-2.failiem.lv/down.php?i=9zh6bmhrnj&view", "Thamires Almeida" },
                    { 2, "178.178.177-78", "(87)3184-2819", "https://fv5-2.failiem.lv/down.php?i=3g2ng3ugd2&view", "Ana Santos" },
                    { 3, "769.290.670-08", "(21)92555-2381", "https://fv5-2.failiem.lv/down.php?i=dv3vdcf54z&view", "Angela Rocha" },
                    { 4, "791.555.800-50", "(18)93571-6471", "https://fv5-2.failiem.lv/down.php?i=eqxha3jn88&view", "José Carlos" },
                    { 5, "532.284.780-41", "(13)92741-3363", "https://fv5-2.failiem.lv/down.php?i=8s9g72yxj9&view", "Vitor Alves" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente");
        }
    }
}
