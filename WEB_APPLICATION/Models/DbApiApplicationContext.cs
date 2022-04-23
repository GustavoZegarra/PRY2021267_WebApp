

using Microsoft.EntityFrameworkCore;

namespace WEB_APPLICATION.Models
{
    public class DbApiApplicationContext : DbContext
    {
        public DbApiApplicationContext()
        {

        }
        public DbApiApplicationContext(DbContextOptions<DbApiApplicationContext> options) : base(options)
        {

        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Pasaporte> Pasaportes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DNI> DNIs { get; set; }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Motivo> Motivos { get; set; }
        public DbSet<GPS> GPSes { get; set; }
        public DbSet<Quebrada> Quebradas { get; set; }
        public DbSet<Sensor> Sensores { get; set; }
        public DbSet<Wifi> Wifis { get; set; }
        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Recomendacion> Recomendaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=tcp:safetysat.database.windows.net,1433;Initial Catalog=DbSafetyApiApplication;User Id=main@safetysat;Password=P@$$w0rd");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Dpartamento
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("Departamento");
                entity.HasKey(e => e.IdDepartamento);
                entity.Property(e => e.IdDepartamento);

                entity.Property(m => m.Nombre)
                .HasMaxLength(50).IsUnicode(false);
     
            });

            //Provincia
            modelBuilder.Entity<Provincia>(entity => {
                entity.ToTable("Provincia");
                entity.HasKey(e => e.IdProvincia);
                entity.Property(e => e.IdProvincia);

                entity.Property(m => m.Nombre)
                .HasMaxLength(50).IsUnicode(false);

                //Un departamento tiene varias provincias
                entity.HasOne(e => e.Departamento)
               .WithMany(e => e.Provincias)
               .HasForeignKey(e => e.IdDepartamento)
               .HasConstraintName("FK_Provincia_Departamento");


            });

            //Distrito
            modelBuilder.Entity<Distrito>(entity => {
                entity.ToTable("Distrito");
                entity.HasKey(e => e.IdDistrito);
                entity.Property(e => e.IdDistrito);

                entity.Property(m => m.Nombre)
                .HasMaxLength(50).IsUnicode(false);

                //Una Provincia tiene varios distritos
                entity.HasOne(e => e.Provincia)
               .WithMany(e => e.Distritos)
               .HasForeignKey(e => e.IdProvincia)
               .HasConstraintName("FK_Distrito_Provincia");

            });

            //DNI
            modelBuilder.Entity<DNI>(entity => {
                entity.ToTable("DNI");
                entity.HasKey(e => e.IdDni);
                entity.Property(e => e.IdDni);

                entity.Property(m => m.Dni)
                .HasMaxLength(8).IsUnicode(false);

                entity.Property(m => m.Direccion)
               .HasMaxLength(250).IsUnicode(true);

                entity.Property(m => m.Referencia)
               .HasMaxLength(250).IsUnicode(true);


                //Un Distrtio tiene varios DNIs
                entity.HasOne(e => e.Distrito)
               .WithMany(e => e.DNIs)
               .HasForeignKey(e => e.IdDistrito)
               .HasConstraintName("FK_DNI_Distrito");

                //Relacion 1 a 1 Usuario con DNI
                entity.HasOne(e => e.Usuario)
               .WithOne(e => e.DNI)
               .HasForeignKey<Usuario>(e => e.IdDni).OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Usuario_Dni");

            });



            //Continente
            modelBuilder.Entity<Continente>(entity => {
                entity.ToTable("Continente");
                entity.HasKey(e => e.IdContinente);
                entity.Property(e => e.IdContinente);

                entity.Property(m => m.Nombre)
               .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Codigo)
               .HasMaxLength(2).IsUnicode(false);
            });

            //Pais
            modelBuilder.Entity<Pais>(entity => {
                entity.ToTable("Pais");
                entity.HasKey(e => e.IdPais);
                entity.Property(e => e.IdPais);

                entity.Property(m => m.Nombre)
               .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Codigo)
               .HasMaxLength(3).IsUnicode(false);

                entity.Property(m => m.Gentilicio)
               .HasMaxLength(50).IsUnicode(false);


                //Un Continente tiene varios Paises
                entity.HasOne(e => e.Continente)
               .WithMany(e => e.Paises)
               .HasForeignKey(e => e.IdContinente)
               .HasConstraintName("FK_Pais_Continente");

            });


            //Pasaporte
            modelBuilder.Entity<Pasaporte>(entity => {
                entity.ToTable("Pasaporte");
                entity.HasKey(e => e.IdPasaporte);
                entity.Property(e => e.IdPasaporte);

                entity.Property(m => m.Numero)
               .HasMaxLength(50).IsUnicode(false);

                //Un Pais tiene varios Pasaportes
                entity.HasOne(e => e.Pais)
               .WithMany(e => e.Pasaportes)
               .HasForeignKey(e => e.IdPais)
               .HasConstraintName("FK_Pasaporte_Pais");

                //Relacion 1 a 1 con Pasaporte
                entity.HasOne(e => e.Usuario)
               .WithOne(e => e.Pasaporte)
               .HasForeignKey<Usuario>(e => e.IdPasaporte).OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Usuario_Pasaporte");


            });


            //Usuario
            modelBuilder.Entity<Usuario>(entity => {
                entity.ToTable("Usuario");
                entity.HasKey(e => e.IdUsuario);
                entity.Property(e => e.IdUsuario);

                entity.Property(m => m.Nombre)
               .HasMaxLength(250).IsUnicode(false);

                entity.Property(m => m.Correo)
               .HasMaxLength(250).IsUnicode(false);

                entity.Property(m => m.Token)
               .HasColumnType("varbinary(max)");

                entity.Property(m => m.Celular)
               .HasMaxLength(20).IsUnicode(false);

                entity.Property(m => m.FechaNacimiento)
              .HasColumnType("date");

            });



            //Incidente
            modelBuilder.Entity<Incidente>(entity =>
            {
                entity.ToTable("Incidente");
                entity.HasKey(e => e.IdIncidente);
                entity.Property(e => e.IdIncidente);

                entity.Property(m => m.Descripcion)
               .HasMaxLength(250).IsUnicode(true);

                entity.Property(e => e.Imagen)
                .HasColumnType("varbinary(max)");

                entity.Property(m => m.FechaRegistro)
               .HasColumnType("date");

                entity.Property(m => m.FechaActualizacion)
              .HasColumnType("date");

                entity.Property(e => e.Resuelto)
                 .HasColumnType("bit");

                //Un Usuario tiene varios Incidentes
                entity.HasOne(e => e.Usuario)
               .WithMany(e => e.Incidentes)
               .HasForeignKey(e => e.IdUsuario)
               .HasConstraintName("FK_Incidente_Usuario");


                //Una quebrada puede ser reportada en varios incidentes
                entity.HasOne(e => e.Quebrada)
               .WithMany(e => e.Incidentes)
               .HasForeignKey(e => e.IdQuebrada)
               .HasConstraintName("FK_Incidente_Quebrada");


                //Un Motivo Puede estar en varios Incidentes
                entity.HasOne(e => e.Motivo)
               .WithMany(e => e.Incidentes)
               .HasForeignKey(e => e.IdMotivo)
               .HasConstraintName("FK_Incidente_Motivo");


            });


            //GPS
            modelBuilder.Entity<GPS>(entity => {
                entity.ToTable("GPS");
                entity.HasKey(e => e.IdGps);
                entity.Property(e => e.IdGps);

                entity.Property(m => m.Latitud).HasColumnType("float");
                entity.Property(m => m.Latitud).HasColumnType("float");


                //Relacion 1 a 1 GPS con Incidente
                entity.HasOne(e => e.Incidente)
               .WithOne(e => e.GPS)
               .HasForeignKey<Incidente>(e => e.IdGPS)
               .HasConstraintName("FK_Incidente_Gps");
            });



            //Motivo
            modelBuilder.Entity<Motivo>(entity => {
                entity.ToTable("Motivo");
                entity.HasKey(e => e.IdMotivo);
                entity.Property(e => e.IdMotivo);

                entity.Property(m => m.Detalle)
               .HasMaxLength(250).IsUnicode(true);

                //Una Categoria tiene varios Motivos
                entity.HasOne(e => e.Categoria)
               .WithMany(e => e.Motivos)
               .HasForeignKey(e => e.IdCategoria)
               .HasConstraintName("FK_Motivo_Categoria");

            });


            //Categoria
            modelBuilder.Entity<Categoria>(entity => {
                entity.ToTable("Categoria");
                entity.HasKey(e => e.IdCategoria);
                entity.Property(e => e.IdCategoria);

                entity.Property(m => m.Detalle)
               .HasMaxLength(250).IsUnicode(true);

            });

            //Quebrada
            modelBuilder.Entity<Quebrada>(entity => {
                entity.ToTable("Quebrada");
                entity.HasKey(e => e.IdQuebrada);
                entity.Property(e => e.IdQuebrada);


                entity.Property(m => m.Nombre)
                        .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Descripcion)
                        .HasMaxLength(250).IsUnicode(false);

            });



            //Sensor
            modelBuilder.Entity<Sensor>(entity => {
                entity.ToTable("Sensor");
                entity.HasKey(e => e.IdSensor);
                entity.Property(e => e.IdSensor);

                entity.Property(m => m.Modelo)
                  .HasMaxLength(50).IsUnicode(false);


                entity.Property(m => m.PrecipitacionMax).HasColumnType("float");
                entity.Property(m => m.PrecipitacionMin).HasColumnType("float");


                //Una quebrada tiene varios Sensores
                entity.HasOne(e => e.Quebrada)
               .WithMany(e => e.Sensores)
               .HasForeignKey(e => e.IdQuebrada)
               .HasConstraintName("FK_Sensor_Quebrada");
            });


            //Wifi
            modelBuilder.Entity<Wifi>(entity => {
                entity.ToTable("Wifi");
                entity.HasKey(e => e.IdWifi);
                entity.Property(e => e.IdWifi);

                entity.Property(m => m.Modelo)
                .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Standar)
                .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Protocolo)
                .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.Red)
                .HasMaxLength(50).IsUnicode(false);

                //Relacion 1 a 1 Wifi con Sensor
                entity.HasOne(e => e.Sensor)
               .WithOne(e => e.Wifi)
               .HasForeignKey<Sensor>(e => e.IdWifi)
               .HasConstraintName("FK_Sensor_Wifi");
            });



            //Nivel
            modelBuilder.Entity<Nivel>(entity => {
                entity.ToTable("Nivel");
                entity.HasKey(e => e.IdNivel);
                entity.Property(e => e.IdNivel);

                entity.Property(m => m.Riesgo)
                  .HasMaxLength(50).IsUnicode(false);

                entity.Property(m => m.PrecipitacionLimSup).HasColumnType("float");
                entity.Property(m => m.PrecipitacionLimInf).HasColumnType("float");


            });

            //Recomendacion
            modelBuilder.Entity<Recomendacion>(entity => {
                entity.ToTable("Recomendacion");
                entity.HasKey(e => e.IdRecomendacion);
                entity.Property(e => e.IdRecomendacion);

                entity.Property(m => m.Detalle)
               .HasMaxLength(250).IsUnicode(true);

                //Un Nivel tiene varias Recomendaciones
                entity.HasOne(e => e.Nivel)
               .WithMany(e => e.Recomendaciones)
               .HasForeignKey(e => e.IdNivel)
               .HasConstraintName("FK_Recomendacion_Nivel");

            });

            //Alerta
            modelBuilder.Entity<Alerta>(entity => {
                entity.ToTable("Alerta");
                entity.HasKey(e => e.IdAlerta);
                entity.Property(e => e.IdAlerta);

                entity.Property(m => m.PrecipitacionProm).HasColumnType("float");
                entity.Property(m => m.PrecipitacionMax).HasColumnType("float");
                entity.Property(m => m.PrecipitacionMin).HasColumnType("float");

                entity.Property(m => m.Descripcion)
               .HasMaxLength(250).IsUnicode(false);

                entity.Property(m => m.FechaRegistro)
             .HasColumnType("date");

                //Una Nivel tiene varios Alertas
                entity.HasOne(e => e.Nivel)
               .WithMany(e => e.Alertas)
               .HasForeignKey(e => e.IdNivel)
               .HasConstraintName("FK_Alerta_Nivel");

                //Un Sensor tiene varias Alertas
                entity.HasOne(e => e.Sensor)
               .WithMany(e => e.Alertas)
               .HasForeignKey(e => e.IdSensor)
               .HasConstraintName("FK_Alerta_Sensor");

            });

        }

    }
}
