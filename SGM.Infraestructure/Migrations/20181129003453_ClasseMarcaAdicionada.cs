using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SGM.Infraestructure.Migrations
{
    public partial class ClasseMarcaAdicionada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TbMarcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    descrição = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbMarcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "TbVeiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Placa = table.Column<string>(nullable: true),
                    Renavam = table.Column<string>(nullable: true),
                    MarcasMarcaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbVeiculos", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_TbVeiculos_TbMarcas_MarcasMarcaId",
                        column: x => x.MarcasMarcaId,
                        principalTable: "TbMarcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TbInfração",
                columns: table => new
                {
                    MultaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<int>(nullable: false),
                    Pontuação = table.Column<int>(nullable: false),
                    VeiculosVeiculoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbInfração", x => x.MultaId);
                    table.ForeignKey(
                        name: "FK_TbInfração_TbVeiculos_VeiculosVeiculoId",
                        column: x => x.VeiculosVeiculoId,
                        principalTable: "TbVeiculos",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbInfração_VeiculosVeiculoId",
                table: "TbInfração",
                column: "VeiculosVeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_TbVeiculos_MarcasMarcaId",
                table: "TbVeiculos",
                column: "MarcasMarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbInfração");

            migrationBuilder.DropTable(
                name: "TbVeiculos");

            migrationBuilder.DropTable(
                name: "TbMarcas");
        }
    }
}
