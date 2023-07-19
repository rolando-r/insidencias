using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    IdCategoriaContacto = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategoria = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreCategoriaUsuario = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.IdCategoriaContacto);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    IdEstado = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.IdEstado);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HerramientaTrabajos",
                columns: table => new
                {
                    IdHerramienta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreHerramienta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HerramientaTrabajos", x => x.IdHerramienta);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NivelInsidencias",
                columns: table => new
                {
                    IdNivelInsidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreNivelInsidencia = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionNivelInsidencia = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelInsidencias", x => x.IdNivelInsidencia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreRol = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionRol = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoContactos",
                columns: table => new
                {
                    IdTipoContacto = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoContacto = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionTipoContacto = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContactos", x => x.IdTipoContacto);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoDocumento = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abreviatura = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.IdTipoDocumento);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoInsidencias",
                columns: table => new
                {
                    IdTipoInsidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreTipoInsidencia = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionTipoInsidencia = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoInsidencias", x => x.IdTipoInsidencia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreUsuario = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidoUSuario = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DireccionUsuario = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoDocumento = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdRoles = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_IdRoles",
                        column: x => x.IdRoles,
                        principalTable: "Roles",
                        principalColumn: "IdRol");
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoDocumentos_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "TipoDocumentos",
                        principalColumn: "IdTipoDocumento");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleInsidencias",
                columns: table => new
                {
                    IdDetalleInsidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdHerramienta = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoInsidencia = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdNivelInsidencia = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleInsidencias", x => x.IdDetalleInsidencia);
                    table.ForeignKey(
                        name: "FK_DetalleInsidencias_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_DetalleInsidencias_NivelInsidencias_IdNivelInsidencia",
                        column: x => x.IdNivelInsidencia,
                        principalTable: "NivelInsidencias",
                        principalColumn: "IdNivelInsidencia");
                    table.ForeignKey(
                        name: "FK_DetalleInsidencias_TipoInsidencias_IdTipoInsidencia",
                        column: x => x.IdTipoInsidencia,
                        principalTable: "TipoInsidencias",
                        principalColumn: "IdTipoInsidencia");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    IdContacto = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoContacto = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategoriaContacto = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.IdContacto);
                    table.ForeignKey(
                        name: "FK_Contactos_Categorias_IdCategoriaContacto",
                        column: x => x.IdCategoriaContacto,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoriaContacto");
                    table.ForeignKey(
                        name: "FK_Contactos_TipoContactos_IdTipoContacto",
                        column: x => x.IdTipoContacto,
                        principalTable: "TipoContactos",
                        principalColumn: "IdTipoContacto");
                    table.ForeignKey(
                        name: "FK_Contactos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleInsidenciaHerramientaTrabajo",
                columns: table => new
                {
                    DetalleInsidenciasIdDetalleInsidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HerramientaTrabajosIdHerramienta = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleInsidenciaHerramientaTrabajo", x => new { x.DetalleInsidenciasIdDetalleInsidencia, x.HerramientaTrabajosIdHerramienta });
                    table.ForeignKey(
                        name: "FK_DetalleInsidenciaHerramientaTrabajo_DetalleInsidencias_Detal~",
                        column: x => x.DetalleInsidenciasIdDetalleInsidencia,
                        principalTable: "DetalleInsidencias",
                        principalColumn: "IdDetalleInsidencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleInsidenciaHerramientaTrabajo_HerramientaTrabajos_Herr~",
                        column: x => x.HerramientaTrabajosIdHerramienta,
                        principalTable: "HerramientaTrabajos",
                        principalColumn: "IdHerramienta",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    IdArea = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreArea = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionArea = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InsidenciaIdInsidencia = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.IdArea);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lugares",
                columns: table => new
                {
                    IdLugar = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreLugar = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionLugar = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdArea = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugares", x => x.IdLugar);
                    table.ForeignKey(
                        name: "FK_Lugares_Areas_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AreaUsuarios",
                columns: table => new
                {
                    IdAreaUsuario = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdArea = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarIdLugar = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaUsuarios", x => x.IdAreaUsuario);
                    table.ForeignKey(
                        name: "FK_AreaUsuarios_Areas_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea");
                    table.ForeignKey(
                        name: "FK_AreaUsuarios_Lugares_LugarIdLugar",
                        column: x => x.LugarIdLugar,
                        principalTable: "Lugares",
                        principalColumn: "IdLugar");
                    table.ForeignKey(
                        name: "FK_AreaUsuarios_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Insidencias",
                columns: table => new
                {
                    IdInsidencia = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEstado = table.Column<string>(type: "varchar(20)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdUsuario = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdArea = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdLugar = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescripcionInsidencia = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaInsidencia = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insidencias", x => x.IdInsidencia);
                    table.ForeignKey(
                        name: "FK_Insidencias_Areas_IdArea",
                        column: x => x.IdArea,
                        principalTable: "Areas",
                        principalColumn: "IdArea");
                    table.ForeignKey(
                        name: "FK_Insidencias_Estados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "Estados",
                        principalColumn: "IdEstado");
                    table.ForeignKey(
                        name: "FK_Insidencias_Lugares_IdLugar",
                        column: x => x.IdLugar,
                        principalTable: "Lugares",
                        principalColumn: "IdLugar");
                    table.ForeignKey(
                        name: "FK_Insidencias_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Areas_InsidenciaIdInsidencia",
                table: "Areas",
                column: "InsidenciaIdInsidencia");

            migrationBuilder.CreateIndex(
                name: "IX_AreaUsuarios_IdArea",
                table: "AreaUsuarios",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_AreaUsuarios_IdUsuario",
                table: "AreaUsuarios",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_AreaUsuarios_LugarIdLugar",
                table: "AreaUsuarios",
                column: "LugarIdLugar");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_IdCategoriaContacto",
                table: "Contactos",
                column: "IdCategoriaContacto");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_IdTipoContacto",
                table: "Contactos",
                column: "IdTipoContacto");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_IdUsuario",
                table: "Contactos",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInsidenciaHerramientaTrabajo_HerramientaTrabajosIdHer~",
                table: "DetalleInsidenciaHerramientaTrabajo",
                column: "HerramientaTrabajosIdHerramienta");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInsidencias_IdEstado",
                table: "DetalleInsidencias",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInsidencias_IdNivelInsidencia",
                table: "DetalleInsidencias",
                column: "IdNivelInsidencia");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleInsidencias_IdTipoInsidencia",
                table: "DetalleInsidencias",
                column: "IdTipoInsidencia");

            migrationBuilder.CreateIndex(
                name: "IX_Insidencias_IdArea",
                table: "Insidencias",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_Insidencias_IdEstado",
                table: "Insidencias",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Insidencias_IdLugar",
                table: "Insidencias",
                column: "IdLugar");

            migrationBuilder.CreateIndex(
                name: "IX_Insidencias_IdUsuario",
                table: "Insidencias",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Lugares_IdArea",
                table: "Lugares",
                column: "IdArea");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdRoles",
                table: "Usuarios",
                column: "IdRoles");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_IdTipoDocumento",
                table: "Usuarios",
                column: "IdTipoDocumento");

            migrationBuilder.AddForeignKey(
                name: "FK_Areas_Insidencias_InsidenciaIdInsidencia",
                table: "Areas",
                column: "InsidenciaIdInsidencia",
                principalTable: "Insidencias",
                principalColumn: "IdInsidencia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Areas_Insidencias_InsidenciaIdInsidencia",
                table: "Areas");

            migrationBuilder.DropTable(
                name: "AreaUsuarios");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "DetalleInsidenciaHerramientaTrabajo");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "TipoContactos");

            migrationBuilder.DropTable(
                name: "DetalleInsidencias");

            migrationBuilder.DropTable(
                name: "HerramientaTrabajos");

            migrationBuilder.DropTable(
                name: "NivelInsidencias");

            migrationBuilder.DropTable(
                name: "TipoInsidencias");

            migrationBuilder.DropTable(
                name: "Insidencias");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Lugares");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");
        }
    }
}
