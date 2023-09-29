using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoOlimpiadas.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Paciente_id = table.Column<int>(type: "int", nullable: false),
                    Enfermero_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DatosMedicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grupo_sanguineo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    alergias = table.Column<bool>(type: "bit", nullable: false),
                    alergias_descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    medicamentos = table.Column<bool>(type: "bit", nullable: false),
                    medicamentos_descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vacunas = table.Column<bool>(type: "bit", nullable: false),
                    vacunas_descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosMedicos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Enfermero",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_completo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    genero = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    fecha_de_nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    Telefono_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermero", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Llamadas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gravedad = table.Column<bool>(type: "bit", nullable: false),
                    origen = table.Column<bool>(type: "bit", nullable: false),
                    tiempo_de_llamada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tiempo_de_atencion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_y_hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Llamadas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ObraSocial",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numerodeafiliado = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObraSocial", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_completo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    genero = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    fecha_de_naciemiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono_id = table.Column<int>(type: "int", nullable: false),
                    DatosMedicos_id = table.Column<int>(type: "int", nullable: false),
                    ObraSocial_numero_de_afiliado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fijo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    celular = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    otro = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "DatosMedicos");

            migrationBuilder.DropTable(
                name: "Enfermero");

            migrationBuilder.DropTable(
                name: "Llamadas");

            migrationBuilder.DropTable(
                name: "ObraSocial");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Telefono");
        }
    }
}
