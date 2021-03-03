using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class addmigratioInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1L, "Produto A", 9.00m },
                    { 2L, "Produto B", 5.00m },
                    { 3L, "Produto C", 15.00m },
                    { 4L, "Produto D", 16.00m },
                    { 5L, "Produto E", 17.00m },
                    { 6L, "Produto F", 18.00m },
                    { 7L, "Produto G", 19.00m },
                    { 8L, "Produto H", 20.00m },
                    { 9L, "Produto I", 21.00m },
                    { 10L, "Produto J", 22.00m },
                    { 11L, "Produto K", 23.00m },
                    { 12L, "Produto L", 24.00m },
                    { 13L, "Produto M", 25.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
