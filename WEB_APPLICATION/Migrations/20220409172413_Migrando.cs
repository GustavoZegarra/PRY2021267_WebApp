using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WEB_APPLICATION.Migrations
{
    public partial class Migrando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Continente",
                columns: table => new
                {
                    IdContinente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Codigo = table.Column<string>(unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continente", x => x.IdContinente);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.IdDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "GPS",
                columns: table => new
                {
                    IdGps = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitud = table.Column<double>(type: "float", nullable: true),
                    Longitud = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPS", x => x.IdGps);
                });

            migrationBuilder.CreateTable(
                name: "Nivel",
                columns: table => new
                {
                    IdNivel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Riesgo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PrecipitacionLimSup = table.Column<double>(type: "float", nullable: true),
                    PrecipitacionLimInf = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nivel", x => x.IdNivel);
                });

            migrationBuilder.CreateTable(
                name: "Quebrada",
                columns: table => new
                {
                    IdQuebrada = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quebrada", x => x.IdQuebrada);
                });

            migrationBuilder.CreateTable(
                name: "Wifi",
                columns: table => new
                {
                    IdWifi = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Standar = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Protocolo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Red = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wifi", x => x.IdWifi);
                });

            migrationBuilder.CreateTable(
                name: "Motivo",
                columns: table => new
                {
                    IdMotivo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(maxLength: 250, nullable: true),
                    IdCategoria = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motivo", x => x.IdMotivo);
                    table.ForeignKey(
                        name: "FK_Motivo_Categoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Codigo = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    Gentilicio = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdContinente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                    table.ForeignKey(
                        name: "FK_Pais_Continente",
                        column: x => x.IdContinente,
                        principalTable: "Continente",
                        principalColumn: "IdContinente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    IdProvincia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdDepartamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.IdProvincia);
                    table.ForeignKey(
                        name: "FK_Provincia_Departamento",
                        column: x => x.IdDepartamento,
                        principalTable: "Departamento",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    IdRecomendacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(maxLength: 250, nullable: true),
                    IdNivel = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.IdRecomendacion);
                    table.ForeignKey(
                        name: "FK_Recomendacion_Nivel",
                        column: x => x.IdNivel,
                        principalTable: "Nivel",
                        principalColumn: "IdNivel",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    IdSensor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PrecipitacionMax = table.Column<double>(type: "float", nullable: true),
                    PrecipitacionMin = table.Column<double>(type: "float", nullable: true),
                    IdQuebrada = table.Column<int>(nullable: true),
                    IdWifi = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.IdSensor);
                    table.ForeignKey(
                        name: "FK_Sensor_Quebrada",
                        column: x => x.IdQuebrada,
                        principalTable: "Quebrada",
                        principalColumn: "IdQuebrada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sensor_Wifi",
                        column: x => x.IdWifi,
                        principalTable: "Wifi",
                        principalColumn: "IdWifi",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pasaporte",
                columns: table => new
                {
                    IdPasaporte = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasaporte", x => x.IdPasaporte);
                    table.ForeignKey(
                        name: "FK_Pasaporte_Pais",
                        column: x => x.IdPais,
                        principalTable: "Pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distrito",
                columns: table => new
                {
                    IdDistrito = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdProvincia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distrito", x => x.IdDistrito);
                    table.ForeignKey(
                        name: "FK_Distrito_Provincia",
                        column: x => x.IdProvincia,
                        principalTable: "Provincia",
                        principalColumn: "IdProvincia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alerta",
                columns: table => new
                {
                    IdAlerta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecipitacionProm = table.Column<double>(type: "float", nullable: true),
                    PrecipitacionMax = table.Column<double>(type: "float", nullable: true),
                    PrecipitacionMin = table.Column<double>(type: "float", nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "date", nullable: true),
                    IdNivel = table.Column<int>(nullable: true),
                    IdSensor = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alerta", x => x.IdAlerta);
                    table.ForeignKey(
                        name: "FK_Alerta_Nivel",
                        column: x => x.IdNivel,
                        principalTable: "Nivel",
                        principalColumn: "IdNivel",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Alerta_Sensor",
                        column: x => x.IdSensor,
                        principalTable: "Sensor",
                        principalColumn: "IdSensor",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DNI",
                columns: table => new
                {
                    IdDni = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dni = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    CodVerificacion = table.Column<int>(nullable: true),
                    Direccion = table.Column<string>(maxLength: 250, nullable: true),
                    Referencia = table.Column<string>(maxLength: 250, nullable: true),
                    IdDistrito = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DNI", x => x.IdDni);
                    table.ForeignKey(
                        name: "FK_DNI_Distrito",
                        column: x => x.IdDistrito,
                        principalTable: "Distrito",
                        principalColumn: "IdDistrito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Correo = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Token = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Celular = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: true),
                    IdDni = table.Column<int>(nullable: true),
                    IdPasaporte = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Dni",
                        column: x => x.IdDni,
                        principalTable: "DNI",
                        principalColumn: "IdDni",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Pasaporte",
                        column: x => x.IdPasaporte,
                        principalTable: "Pasaporte",
                        principalColumn: "IdPasaporte",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidente",
                columns: table => new
                {
                    IdIncidente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: true),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "date", nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "date", nullable: true),
                    Resuelto = table.Column<bool>(type: "bit", nullable: true),
                    IdUsuario = table.Column<int>(nullable: true),
                    IdQuebrada = table.Column<int>(nullable: true),
                    IdMotivo = table.Column<int>(nullable: true),
                    IdGPS = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidente", x => x.IdIncidente);
                    table.ForeignKey(
                        name: "FK_Incidente_Gps",
                        column: x => x.IdGPS,
                        principalTable: "GPS",
                        principalColumn: "IdGps",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidente_Motivo",
                        column: x => x.IdMotivo,
                        principalTable: "Motivo",
                        principalColumn: "IdMotivo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidente_Quebrada",
                        column: x => x.IdQuebrada,
                        principalTable: "Quebrada",
                        principalColumn: "IdQuebrada",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidente_Usuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alerta_IdNivel",
                table: "Alerta",
                column: "IdNivel");

            migrationBuilder.CreateIndex(
                name: "IX_Alerta_IdSensor",
                table: "Alerta",
                column: "IdSensor");

            migrationBuilder.CreateIndex(
                name: "IX_Distrito_IdProvincia",
                table: "Distrito",
                column: "IdProvincia");

            migrationBuilder.CreateIndex(
                name: "IX_DNI_IdDistrito",
                table: "DNI",
                column: "IdDistrito");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_IdGPS",
                table: "Incidente",
                column: "IdGPS",
                unique: true,
                filter: "[IdGPS] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_IdMotivo",
                table: "Incidente",
                column: "IdMotivo");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_IdQuebrada",
                table: "Incidente",
                column: "IdQuebrada");

            migrationBuilder.CreateIndex(
                name: "IX_Incidente_IdUsuario",
                table: "Incidente",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Motivo_IdCategoria",
                table: "Motivo",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_IdContinente",
                table: "Pais",
                column: "IdContinente");

            migrationBuilder.CreateIndex(
                name: "IX_Pasaporte_IdPais",
                table: "Pasaporte",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_IdDepartamento",
                table: "Provincia",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendacion_IdNivel",
                table: "Recomendacion",
                column: "IdNivel");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_IdQuebrada",
                table: "Sensor",
                column: "IdQuebrada");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_IdWifi",
                table: "Sensor",
                column: "IdWifi",
                unique: true,
                filter: "[IdWifi] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdDni",
                table: "Usuario",
                column: "IdDni",
                unique: true,
                filter: "[IdDni] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdPasaporte",
                table: "Usuario",
                column: "IdPasaporte",
                unique: true,
                filter: "[IdPasaporte] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alerta");

            migrationBuilder.DropTable(
                name: "Incidente");

            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "GPS");

            migrationBuilder.DropTable(
                name: "Motivo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Nivel");

            migrationBuilder.DropTable(
                name: "Quebrada");

            migrationBuilder.DropTable(
                name: "Wifi");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "DNI");

            migrationBuilder.DropTable(
                name: "Pasaporte");

            migrationBuilder.DropTable(
                name: "Distrito");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Continente");

            migrationBuilder.DropTable(
                name: "Departamento");
        }
    }
}
