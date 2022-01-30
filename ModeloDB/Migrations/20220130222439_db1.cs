using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personales",
                columns: table => new
                {
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    no_documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sueldo = table.Column<double>(type: "float", nullable: false),
                    estado_civil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personales", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "Decimo_Cuartos",
                columns: table => new
                {
                    Decimo_CuartoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decimo_Cuartos", x => x.Decimo_CuartoId);
                    table.ForeignKey(
                        name: "FK_Decimo_Cuartos_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decimo_Terceros",
                columns: table => new
                {
                    Decimo_TerceroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    finicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ffinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decimo_Terceros", x => x.Decimo_TerceroId);
                    table.ForeignKey(
                        name: "FK_Decimo_Terceros_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: true),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                    table.ForeignKey(
                        name: "FK_Departamento_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fondo_reservas",
                columns: table => new
                {
                    Fondo_reservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    porcentaje = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fondo_reservas", x => x.Fondo_reservaId);
                    table.ForeignKey(
                        name: "FK_Fondo_reservas_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    Arecibir = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RolesId);
                    table.ForeignKey(
                        name: "FK_Roles_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacaciones",
                columns: table => new
                {
                    VacacionesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    meses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sueldo = table.Column<double>(type: "float", nullable: false),
                    comisiones = table.Column<double>(type: "float", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacaciones", x => x.VacacionesID);
                    table.ForeignKey(
                        name: "FK_Vacaciones_Personales_PersonalId",
                        column: x => x.PersonalId,
                        principalTable: "Personales",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Decimo_Cuartos_PersonalId",
                table: "Decimo_Cuartos",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Decimo_Terceros_PersonalId",
                table: "Decimo_Terceros",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_PersonalId",
                table: "Departamento",
                column: "PersonalId",
                unique: true,
                filter: "[PersonalId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Fondo_reservas_PersonalId",
                table: "Fondo_reservas",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_PersonalId",
                table: "Roles",
                column: "PersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacaciones_PersonalId",
                table: "Vacaciones",
                column: "PersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Decimo_Cuartos");

            migrationBuilder.DropTable(
                name: "Decimo_Terceros");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Fondo_reservas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Vacaciones");

            migrationBuilder.DropTable(
                name: "Personales");
        }
    }
}
