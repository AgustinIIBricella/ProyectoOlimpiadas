using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoOlimpiadas.Data.Migrations
{
    public partial class prueba0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enfermero_id",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Paciente_id",
                table: "Areas");

            migrationBuilder.RenameColumn(
                name: "Telefono_id",
                table: "Paciente",
                newName: "TelefonoId");

            migrationBuilder.RenameColumn(
                name: "ObraSocial_numero_de_afiliado",
                table: "Paciente",
                newName: "ObraSocialId");

            migrationBuilder.RenameColumn(
                name: "DatosMedicos_id",
                table: "Paciente",
                newName: "DatosMedicosId");

            migrationBuilder.RenameColumn(
                name: "Telefono_id",
                table: "Enfermero",
                newName: "telefonoid");

            migrationBuilder.AlterColumn<string>(
                name: "otro",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "fijo",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "AreaId",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "numerodeafiliado",
                table: "ObraSocial",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "tiempo_de_atencion",
                table: "Llamadas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "vacunas_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "medicamentos_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "alergias_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "AreasEnfermero",
                columns: table => new
                {
                    Areaid = table.Column<int>(type: "int", nullable: false),
                    Enfermerosid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreasEnfermero", x => new { x.Areaid, x.Enfermerosid });
                    table.ForeignKey(
                        name: "FK_AreasEnfermero_Areas_Areaid",
                        column: x => x.Areaid,
                        principalTable: "Areas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AreasEnfermero_Enfermero_Enfermerosid",
                        column: x => x.Enfermerosid,
                        principalTable: "Enfermero",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_AreaId",
                table: "Paciente",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_DatosMedicosId",
                table: "Paciente",
                column: "DatosMedicosId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_ObraSocialId",
                table: "Paciente",
                column: "ObraSocialId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TelefonoId",
                table: "Paciente",
                column: "TelefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enfermero_telefonoid",
                table: "Enfermero",
                column: "telefonoid");

            migrationBuilder.CreateIndex(
                name: "IX_AreasEnfermero_Enfermerosid",
                table: "AreasEnfermero",
                column: "Enfermerosid");

            migrationBuilder.AddForeignKey(
                name: "FK_Enfermero_Telefono_telefonoid",
                table: "Enfermero",
                column: "telefonoid",
                principalTable: "Telefono",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Areas_AreaId",
                table: "Paciente",
                column: "AreaId",
                principalTable: "Areas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_DatosMedicos_DatosMedicosId",
                table: "Paciente",
                column: "DatosMedicosId",
                principalTable: "DatosMedicos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_ObraSocial_ObraSocialId",
                table: "Paciente",
                column: "ObraSocialId",
                principalTable: "ObraSocial",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Telefono_TelefonoId",
                table: "Paciente",
                column: "TelefonoId",
                principalTable: "Telefono",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfermero_Telefono_telefonoid",
                table: "Enfermero");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Areas_AreaId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_DatosMedicos_DatosMedicosId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_ObraSocial_ObraSocialId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Telefono_TelefonoId",
                table: "Paciente");

            migrationBuilder.DropTable(
                name: "AreasEnfermero");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_AreaId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_DatosMedicosId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_ObraSocialId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_TelefonoId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Enfermero_telefonoid",
                table: "Enfermero");

            migrationBuilder.DropColumn(
                name: "AreaId",
                table: "Paciente");

            migrationBuilder.RenameColumn(
                name: "TelefonoId",
                table: "Paciente",
                newName: "Telefono_id");

            migrationBuilder.RenameColumn(
                name: "ObraSocialId",
                table: "Paciente",
                newName: "ObraSocial_numero_de_afiliado");

            migrationBuilder.RenameColumn(
                name: "DatosMedicosId",
                table: "Paciente",
                newName: "DatosMedicos_id");

            migrationBuilder.RenameColumn(
                name: "telefonoid",
                table: "Enfermero",
                newName: "Telefono_id");

            migrationBuilder.AlterColumn<string>(
                name: "otro",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fijo",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "celular",
                table: "Telefono",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "numerodeafiliado",
                table: "ObraSocial",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<DateTime>(
                name: "tiempo_de_atencion",
                table: "Llamadas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "vacunas_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "medicamentos_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "alergias_descripcion",
                table: "DatosMedicos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Enfermero_id",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Paciente_id",
                table: "Areas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
