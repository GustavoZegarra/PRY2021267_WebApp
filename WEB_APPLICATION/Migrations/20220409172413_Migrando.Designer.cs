﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEB_APPLICATION.Models;

namespace WEB_APPLICATION.Migrations
{
    [DbContext(typeof(DbApiApplicationContext))]
    [Migration("20220409172413_Migrando")]
    partial class Migrando
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEB_APPLICATION.Models.Alerta", b =>
                {
                    b.Property<int>("IdAlerta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int?>("IdNivel")
                        .HasColumnType("int");

                    b.Property<int?>("IdSensor")
                        .HasColumnType("int");

                    b.Property<double?>("PrecipitacionMax")
                        .HasColumnType("float");

                    b.Property<double?>("PrecipitacionMin")
                        .HasColumnType("float");

                    b.Property<double?>("PrecipitacionProm")
                        .HasColumnType("float");

                    b.HasKey("IdAlerta");

                    b.HasIndex("IdNivel");

                    b.HasIndex("IdSensor");

                    b.ToTable("Alerta");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Continente", b =>
                {
                    b.Property<int>("IdContinente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdContinente");

                    b.ToTable("Continente");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.DNI", b =>
                {
                    b.Property<int>("IdDni")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CodVerificacion")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<string>("Dni")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<int>("IdDistrito")
                        .HasColumnType("int");

                    b.Property<string>("Referencia")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.HasKey("IdDni");

                    b.HasIndex("IdDistrito");

                    b.ToTable("DNI");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Departamento", b =>
                {
                    b.Property<int>("IdDepartamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdDepartamento");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Distrito", b =>
                {
                    b.Property<int>("IdDistrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdDistrito");

                    b.HasIndex("IdProvincia");

                    b.ToTable("Distrito");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.GPS", b =>
                {
                    b.Property<int>("IdGps")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Latitud")
                        .HasColumnType("float");

                    b.Property<float?>("Longitud")
                        .HasColumnType("real");

                    b.HasKey("IdGps");

                    b.ToTable("GPS");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Incidente", b =>
                {
                    b.Property<int>("IdIncidente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<DateTime?>("FechaActualizacion")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int?>("IdGPS")
                        .HasColumnType("int");

                    b.Property<int?>("IdMotivo")
                        .HasColumnType("int");

                    b.Property<int?>("IdQuebrada")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool?>("Resuelto")
                        .HasColumnType("bit");

                    b.HasKey("IdIncidente");

                    b.HasIndex("IdGPS")
                        .IsUnique()
                        .HasFilter("[IdGPS] IS NOT NULL");

                    b.HasIndex("IdMotivo");

                    b.HasIndex("IdQuebrada");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Incidente");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Motivo", b =>
                {
                    b.Property<int>("IdMotivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int");

                    b.HasKey("IdMotivo");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Motivo");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Nivel", b =>
                {
                    b.Property<int>("IdNivel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("PrecipitacionLimInf")
                        .HasColumnType("float");

                    b.Property<double?>("PrecipitacionLimSup")
                        .HasColumnType("float");

                    b.Property<string>("Riesgo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdNivel");

                    b.ToTable("Nivel");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Pais", b =>
                {
                    b.Property<int>("IdPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("Gentilicio")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("IdContinente")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdPais");

                    b.HasIndex("IdContinente");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Pasaporte", b =>
                {
                    b.Property<int>("IdPasaporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdPasaporte");

                    b.HasIndex("IdPais");

                    b.ToTable("Pasaporte");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Provincia", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdProvincia");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Quebrada", b =>
                {
                    b.Property<int>("IdQuebrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdQuebrada");

                    b.ToTable("Quebrada");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Recomendacion", b =>
                {
                    b.Property<int>("IdRecomendacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<int?>("IdNivel")
                        .HasColumnType("int");

                    b.HasKey("IdRecomendacion");

                    b.HasIndex("IdNivel");

                    b.ToTable("Recomendacion");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Sensor", b =>
                {
                    b.Property<int>("IdSensor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdQuebrada")
                        .HasColumnType("int");

                    b.Property<int?>("IdWifi")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<double?>("PrecipitacionMax")
                        .HasColumnType("float");

                    b.Property<double?>("PrecipitacionMin")
                        .HasColumnType("float");

                    b.HasKey("IdSensor");

                    b.HasIndex("IdQuebrada");

                    b.HasIndex("IdWifi")
                        .IsUnique()
                        .HasFilter("[IdWifi] IS NOT NULL");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int?>("IdDni")
                        .HasColumnType("int");

                    b.Property<int?>("IdPasaporte")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<byte[]>("Token")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdDni")
                        .IsUnique()
                        .HasFilter("[IdDni] IS NOT NULL");

                    b.HasIndex("IdPasaporte")
                        .IsUnique()
                        .HasFilter("[IdPasaporte] IS NOT NULL");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Wifi", b =>
                {
                    b.Property<int>("IdWifi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Protocolo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Red")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Standar")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdWifi");

                    b.ToTable("Wifi");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Alerta", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Nivel", "Nivel")
                        .WithMany("Alertas")
                        .HasForeignKey("IdNivel")
                        .HasConstraintName("FK_Alerta_Nivel");

                    b.HasOne("WEB_APPLICATION.Models.Sensor", "Sensor")
                        .WithMany("Alertas")
                        .HasForeignKey("IdSensor")
                        .HasConstraintName("FK_Alerta_Sensor");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.DNI", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Distrito", "Distrito")
                        .WithMany("DNIs")
                        .HasForeignKey("IdDistrito")
                        .HasConstraintName("FK_DNI_Distrito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Distrito", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Provincia", "Provincia")
                        .WithMany("Distritos")
                        .HasForeignKey("IdProvincia")
                        .HasConstraintName("FK_Distrito_Provincia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Incidente", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.GPS", "GPS")
                        .WithOne("Incidente")
                        .HasForeignKey("WEB_APPLICATION.Models.Incidente", "IdGPS")
                        .HasConstraintName("FK_Incidente_Gps");

                    b.HasOne("WEB_APPLICATION.Models.Motivo", "Motivo")
                        .WithMany("Incidentes")
                        .HasForeignKey("IdMotivo")
                        .HasConstraintName("FK_Incidente_Motivo");

                    b.HasOne("WEB_APPLICATION.Models.Quebrada", "Quebrada")
                        .WithMany("Incidentes")
                        .HasForeignKey("IdQuebrada")
                        .HasConstraintName("FK_Incidente_Quebrada");

                    b.HasOne("WEB_APPLICATION.Models.Usuario", "Usuario")
                        .WithMany("Incidentes")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK_Incidente_Usuario");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Motivo", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Categoria", "Categoria")
                        .WithMany("Motivos")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK_Motivo_Categoria");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Pais", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Continente", "Continente")
                        .WithMany("Paises")
                        .HasForeignKey("IdContinente")
                        .HasConstraintName("FK_Pais_Continente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Pasaporte", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Pais", "Pais")
                        .WithMany("Pasaportes")
                        .HasForeignKey("IdPais")
                        .HasConstraintName("FK_Pasaporte_Pais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Provincia", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Departamento", "Departamento")
                        .WithMany("Provincias")
                        .HasForeignKey("IdDepartamento")
                        .HasConstraintName("FK_Provincia_Departamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Recomendacion", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Nivel", "Nivel")
                        .WithMany("Recomendaciones")
                        .HasForeignKey("IdNivel")
                        .HasConstraintName("FK_Recomendacion_Nivel");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Sensor", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.Quebrada", "Quebrada")
                        .WithMany("Sensores")
                        .HasForeignKey("IdQuebrada")
                        .HasConstraintName("FK_Sensor_Quebrada");

                    b.HasOne("WEB_APPLICATION.Models.Wifi", "Wifi")
                        .WithOne("Sensor")
                        .HasForeignKey("WEB_APPLICATION.Models.Sensor", "IdWifi")
                        .HasConstraintName("FK_Sensor_Wifi");
                });

            modelBuilder.Entity("WEB_APPLICATION.Models.Usuario", b =>
                {
                    b.HasOne("WEB_APPLICATION.Models.DNI", "DNI")
                        .WithOne("Usuario")
                        .HasForeignKey("WEB_APPLICATION.Models.Usuario", "IdDni")
                        .HasConstraintName("FK_Usuario_Dni");

                    b.HasOne("WEB_APPLICATION.Models.Pasaporte", "Pasaporte")
                        .WithOne("Usuario")
                        .HasForeignKey("WEB_APPLICATION.Models.Usuario", "IdPasaporte")
                        .HasConstraintName("FK_Usuario_Pasaporte");
                });
#pragma warning restore 612, 618
        }
    }
}
