using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeMedicos.Migrations
{
    public partial class BdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "VARCHAR (30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    Senha = table.Column<string>(type: "VARCHAR (30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR (255)", maxLength: 255, nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: true),
                    Crm = table.Column<string>(maxLength: 12, nullable: false),
                    Fk_Especialidade1 = table.Column<int>(nullable: false),
                    Fk_Especialidade2 = table.Column<int>(nullable: false),
                    Especialidade1Id = table.Column<int>(nullable: true),
                    Especialidade2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_Especialidade1Id",
                        column: x => x.Especialidade1Id,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Medico_Especialidade_Especialidade2Id",
                        column: x => x.Especialidade2Id,
                        principalTable: "Especialidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Especialidade_Id",
                table: "Especialidade",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_Especialidade1Id",
                table: "Medico",
                column: "Especialidade1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_Especialidade2Id",
                table: "Medico",
                column: "Especialidade2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medico_Id",
                table: "Medico",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id",
                table: "Usuario",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medico");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Especialidade");
        }
    }
}
