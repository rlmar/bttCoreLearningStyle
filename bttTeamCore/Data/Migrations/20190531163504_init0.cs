using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace bttTeamCore.Data.Migrations
{
    public partial class init0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciclistas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Telemovel = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    BI = table.Column<string>(nullable: false),
                    Localidade = table.Column<string>(nullable: false),
                    UserFK = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciclistas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Equipas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeEquipa = table.Column<string>(nullable: false),
                    Localidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeProva = table.Column<string>(nullable: false),
                    DataProva = table.Column<DateTime>(nullable: false),
                    PrecoProva = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    PrecoComAlmoco = table.Column<decimal>(type: "decimal(4,2)", nullable: false),
                    PrecoApenasAlmoco = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeFoto = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 255, nullable: true),
                    Visivel = table.Column<bool>(nullable: false),
                    CiclistaId = table.Column<int>(nullable: false),
                    ProvaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fotos_Ciclistas_CiclistaId",
                        column: x => x.CiclistaId,
                        principalTable: "Ciclistas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fotos_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "provaCiclEquipas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvaId = table.Column<int>(nullable: false),
                    CiclistaId = table.Column<int>(nullable: false),
                    EquipaID = table.Column<int>(nullable: true),
                    Almoco = table.Column<bool>(nullable: false),
                    NumAcompanhantes = table.Column<int>(nullable: false),
                    ValorPagamento = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    Pago = table.Column<bool>(nullable: false),
                    Dorsal = table.Column<int>(nullable: true),
                    Tempo = table.Column<TimeSpan>(nullable: true),
                    Classificacao = table.Column<int>(nullable: true),
                    Percursos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provaCiclEquipas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_provaCiclEquipas_Ciclistas_CiclistaId",
                        column: x => x.CiclistaId,
                        principalTable: "Ciclistas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_provaCiclEquipas_Equipas_EquipaID",
                        column: x => x.EquipaID,
                        principalTable: "Equipas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_provaCiclEquipas_Provas_ProvaId",
                        column: x => x.ProvaId,
                        principalTable: "Provas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_CiclistaId",
                table: "Fotos",
                column: "CiclistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_ProvaId",
                table: "Fotos",
                column: "ProvaId");

            migrationBuilder.CreateIndex(
                name: "IX_provaCiclEquipas_CiclistaId",
                table: "provaCiclEquipas",
                column: "CiclistaId");

            migrationBuilder.CreateIndex(
                name: "IX_provaCiclEquipas_EquipaID",
                table: "provaCiclEquipas",
                column: "EquipaID");

            migrationBuilder.CreateIndex(
                name: "IX_provaCiclEquipas_ProvaId",
                table: "provaCiclEquipas",
                column: "ProvaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "provaCiclEquipas");

            migrationBuilder.DropTable(
                name: "Ciclistas");

            migrationBuilder.DropTable(
                name: "Equipas");

            migrationBuilder.DropTable(
                name: "Provas");
        }
    }
}
