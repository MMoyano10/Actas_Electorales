using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Votaciones.Models;

public partial class Bd2Context : DbContext
{
    public Bd2Context()
    {
    }

    public Bd2Context(DbContextOptions<Bd2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Acta> Actas { get; set; }

    public virtual DbSet<Canton> Cantons { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Jrv> Jrvs { get; set; }

    public virtual DbSet<JrvNovedade> JrvNovedades { get; set; }

    public virtual DbSet<MembershipUser> MembershipUsers { get; set; }

    public virtual DbSet<Parroquium> Parroquia { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<Recinto> Recintos { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=bd2;user=root;password=123", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.3.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Acta>(entity =>
        {
            entity.HasKey(e => e.IdActa).HasName("PRIMARY");

            entity
                .ToTable("actas")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdCanton, "id_canton");

            entity.HasIndex(e => e.IdJrv, "id_jrv");

            entity.HasIndex(e => e.IdParroquia, "id_parroquia");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRecinto, "id_recinto");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdActa).HasColumnName("id_acta");
            entity.Property(e => e.BlancosJrv)
                .HasMaxLength(40)
                .HasColumnName("blancos_jrv");
            entity.Property(e => e.Candidato10Jrv).HasColumnName("candidato10_jrv");
            entity.Property(e => e.Candidato11Jrv).HasColumnName("candidato11_jrv");
            entity.Property(e => e.Candidato12Jrv).HasColumnName("candidato12_jrv");
            entity.Property(e => e.Candidato13Jrv).HasColumnName("candidato13_jrv");
            entity.Property(e => e.Candidato14Jrv).HasColumnName("candidato14_jrv");
            entity.Property(e => e.Candidato15Jrv).HasColumnName("candidato15_jrv");
            entity.Property(e => e.Candidato16Jrv).HasColumnName("candidato16_jrv");
            entity.Property(e => e.Candidato17Jrv).HasColumnName("candidato17_jrv");
            entity.Property(e => e.Candidato18Jrv).HasColumnName("candidato18_jrv");
            entity.Property(e => e.Candidato19Jrv).HasColumnName("candidato19_jrv");
            entity.Property(e => e.Candidato1Jrv).HasColumnName("candidato1_jrv");
            entity.Property(e => e.Candidato20Jrv).HasColumnName("candidato20_jrv");
            entity.Property(e => e.Candidato2Jrv).HasColumnName("candidato2_jrv");
            entity.Property(e => e.Candidato3Jrv).HasColumnName("candidato3_jrv");
            entity.Property(e => e.Candidato4Jrv).HasColumnName("candidato4_jrv");
            entity.Property(e => e.Candidato5Jrv).HasColumnName("candidato5_jrv");
            entity.Property(e => e.Candidato6Jrv).HasColumnName("candidato6_jrv");
            entity.Property(e => e.Candidato7Jrv).HasColumnName("candidato7_jrv");
            entity.Property(e => e.Candidato8Jrv).HasColumnName("candidato8_jrv");
            entity.Property(e => e.Candidato9Jrv).HasColumnName("candidato9_jrv");
            entity.Property(e => e.DescripcionActa)
                .HasMaxLength(250)
                .HasColumnName("descripcion_acta");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.IdJrv).HasColumnName("id_jrv");
            entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRecinto).HasColumnName("id_recinto");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.NulosJrv)
                .HasMaxLength(40)
                .HasColumnName("nulos_jrv");
            entity.Property(e => e.ObservacionecsJrv)
                .HasMaxLength(250)
                .HasColumnName("observacionecs_jrv");
            entity.Property(e => e.TotalEleccionJrv).HasColumnName("total_eleccion_jrv");
            entity.Property(e => e.TotalPadronJrv).HasColumnName("total_padron_jrv");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Acta)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("fk_canton_parroquia_6");

            entity.HasOne(d => d.IdParroquiaNavigation).WithMany(p => p.Acta)
                .HasForeignKey(d => d.IdParroquia)
                .HasConstraintName("fk_parroquia_recinto_6");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Acta)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("fk_provincia_canton_6");

            entity.HasOne(d => d.IdRecintoNavigation).WithMany(p => p.Acta)
                .HasForeignKey(d => d.IdRecinto)
                .HasConstraintName("fk_recinto_jrv_6");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Acta)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia_6");
        });

        modelBuilder.Entity<Canton>(entity =>
        {
            entity.HasKey(e => e.IdCanton).HasName("PRIMARY");

            entity
                .ToTable("canton")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.CodigoCanton)
                .HasMaxLength(40)
                .HasColumnName("codigo_canton");
            entity.Property(e => e.CoordinadorCanton)
                .HasMaxLength(250)
                .HasColumnName("coordinador_canton");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.NombreCanton)
                .HasMaxLength(150)
                .HasColumnName("nombre_canton");
            entity.Property(e => e.PoblacionCanton)
                .HasPrecision(10, 2)
                .HasColumnName("poblacion_canton");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Cantons)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("fk_provincia_canton");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Cantons)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia_2");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Jrv>(entity =>
        {
            entity.HasKey(e => e.IdJrv).HasName("PRIMARY");

            entity
                .ToTable("jrv")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdCanton, "id_canton");

            entity.HasIndex(e => e.IdParroquia, "id_parroquia");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRecinto, "id_recinto");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdJrv).HasColumnName("id_jrv");
            entity.Property(e => e.AdicionalesJrv)
                .HasMaxLength(40)
                .HasColumnName("adicionales_jrv");
            entity.Property(e => e.ArchivoJrv)
                .HasMaxLength(40)
                .HasColumnName("archivo_jrv");
            entity.Property(e => e.CoordinadorJrv)
                .HasMaxLength(40)
                .HasColumnName("coordinador_jrv");
            entity.Property(e => e.DescripcionJrv)
                .HasMaxLength(250)
                .HasColumnName("descripcion_jrv");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRecinto).HasColumnName("id_recinto");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.ImagenJrv)
                .HasMaxLength(40)
                .HasColumnName("imagen_jrv");
            entity.Property(e => e.ObservacionesJrv)
                .HasMaxLength(250)
                .HasColumnName("observaciones_jrv");
            entity.Property(e => e.VotantesfJrv)
                .HasMaxLength(40)
                .HasColumnName("votantesf_jrv");
            entity.Property(e => e.VotantesmJrv).HasColumnName("votantesm_jrv");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Jrvs)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("fk_canton_parroquia_5");

            entity.HasOne(d => d.IdParroquiaNavigation).WithMany(p => p.Jrvs)
                .HasForeignKey(d => d.IdParroquia)
                .HasConstraintName("fk_parroquia_recinto_5");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Jrvs)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("fk_provincia_canton_5");

            entity.HasOne(d => d.IdRecintoNavigation).WithMany(p => p.Jrvs)
                .HasForeignKey(d => d.IdRecinto)
                .HasConstraintName("fk_recinto_jrv");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Jrvs)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia_5");
        });

        modelBuilder.Entity<JrvNovedade>(entity =>
        {
            entity.HasKey(e => e.IdNovedades).HasName("PRIMARY");

            entity
                .ToTable("jrv_novedades")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdCanton, "id_canton");

            entity.HasIndex(e => e.IdJrv, "id_jrv");

            entity.HasIndex(e => e.IdParroquia, "id_parroquia");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdNovedades).HasColumnName("id_novedades");
            entity.Property(e => e.DescripcionNovedad)
                .HasMaxLength(250)
                .HasColumnName("descripcion_novedad");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.IdJrv)
                .HasMaxLength(40)
                .HasColumnName("id_jrv");
            entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRecinto)
                .HasMaxLength(40)
                .HasDefaultValueSql("'ESCUELA BASICA   FEDERICO PROA&#209;O'")
                .HasColumnName("id_recinto");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.Referencia1Novedades)
                .HasMaxLength(40)
                .HasColumnName("referencia1_novedades");
            entity.Property(e => e.Referencia2Novedades)
                .HasMaxLength(40)
                .HasColumnName("referencia2_novedades");
        });

        modelBuilder.Entity<MembershipUser>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PRIMARY");

            entity
                .ToTable("membership_users")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GroupId, "groupID");

            entity.Property(e => e.MemberId)
                .HasMaxLength(20)
                .HasColumnName("memberID");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.Custom1)
                .HasColumnType("text")
                .HasColumnName("custom1");
            entity.Property(e => e.Custom2)
                .HasColumnType("text")
                .HasColumnName("custom2");
            entity.Property(e => e.Custom3)
                .HasColumnType("text")
                .HasColumnName("custom3");
            entity.Property(e => e.Custom4)
                .HasColumnType("text")
                .HasColumnName("custom4");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.GroupId).HasColumnName("groupID");
            entity.Property(e => e.IsApproved).HasColumnName("isApproved");
            entity.Property(e => e.IsBanned).HasColumnName("isBanned");
            entity.Property(e => e.PassMd5)
                .HasMaxLength(40)
                .HasColumnName("passMD5");
            entity.Property(e => e.PassResetExpiry).HasColumnName("pass_reset_expiry");
            entity.Property(e => e.PassResetKey)
                .HasMaxLength(100)
                .HasColumnName("pass_reset_key");
            entity.Property(e => e.SignupDate).HasColumnName("signupDate");
        });

        modelBuilder.Entity<Parroquium>(entity =>
        {
            entity.HasKey(e => e.IdParroquia).HasName("PRIMARY");

            entity
                .ToTable("parroquia")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdCanton, "id_canton");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");
            entity.Property(e => e.CodigoParroquia)
                .HasMaxLength(40)
                .HasColumnName("codigo_parroquia");
            entity.Property(e => e.CoordinadorParroquia)
                .HasMaxLength(250)
                .HasColumnName("coordinador_parroquia");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.NombreParroquia)
                .HasMaxLength(170)
                .HasColumnName("nombre_parroquia");
            entity.Property(e => e.PoblacionParroquia)
                .HasPrecision(10, 2)
                .HasColumnName("poblacion_parroquia");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Parroquia)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("fk_canton_parroquia");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Parroquia)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("fk_provincia_canton_3");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Parroquia)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia_3");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.IdProvincia).HasName("PRIMARY");

            entity
                .ToTable("provincia")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.CodigoProvincia)
                .HasMaxLength(40)
                .HasColumnName("codigo_provincia");
            entity.Property(e => e.CoordinadorProvincia)
                .HasMaxLength(250)
                .HasColumnName("coordinador_provincia");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.NombreProvincia)
                .HasMaxLength(40)
                .HasColumnName("nombre_provincia");
            entity.Property(e => e.PoblacionProvincia)
                .HasMaxLength(40)
                .HasColumnName("poblacion_provincia");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia");
        });

        modelBuilder.Entity<Recinto>(entity =>
        {
            entity.HasKey(e => e.IdRecinto).HasName("PRIMARY");

            entity
                .ToTable("recinto")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IdCanton, "id_canton");

            entity.HasIndex(e => e.IdParroquia, "id_parroquia");

            entity.HasIndex(e => e.IdProvincia, "id_provincia");

            entity.HasIndex(e => e.IdRegion, "id_region");

            entity.Property(e => e.IdRecinto).HasColumnName("id_recinto");
            entity.Property(e => e.CodigoRecinto)
                .HasMaxLength(40)
                .HasColumnName("codigo_recinto");
            entity.Property(e => e.CoordinadorRecinto)
                .HasMaxLength(250)
                .HasColumnName("coordinador_recinto");
            entity.Property(e => e.DireccionRecinto)
                .HasMaxLength(250)
                .HasColumnName("direccion_recinto");
            entity.Property(e => e.FotoCoordinadorRecinto)
                .HasMaxLength(40)
                .HasColumnName("foto_coordinador_recinto");
            entity.Property(e => e.IdCanton).HasColumnName("id_canton");
            entity.Property(e => e.IdParroquia).HasColumnName("id_parroquia");
            entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");
            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.JrvfNumeroRecinto).HasColumnName("jrvf_numero_recinto");
            entity.Property(e => e.JrvfVotantesRecinto)
                .HasMaxLength(40)
                .HasColumnName("jrvf_votantes_recinto");
            entity.Property(e => e.JrvmNumeroRecinto).HasColumnName("jrvm_numero_recinto");
            entity.Property(e => e.JrvmVotantesRecinto)
                .HasMaxLength(40)
                .HasColumnName("jrvm_votantes_recinto");
            entity.Property(e => e.NombreRecinto)
                .HasMaxLength(250)
                .HasColumnName("nombre_recinto");

            entity.HasOne(d => d.IdCantonNavigation).WithMany(p => p.Recintos)
                .HasForeignKey(d => d.IdCanton)
                .HasConstraintName("fk_canton_parroquia_4");

            entity.HasOne(d => d.IdParroquiaNavigation).WithMany(p => p.Recintos)
                .HasForeignKey(d => d.IdParroquia)
                .HasConstraintName("fk_parroquia_recinto");

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Recintos)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("fk_provincia_canton_4");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Recintos)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("fk_region_provincia_4");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.IdRegion).HasName("PRIMARY");

            entity
                .ToTable("region")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.IdRegion).HasColumnName("id_region");
            entity.Property(e => e.CoordinadorRegion)
                .HasMaxLength(250)
                .HasColumnName("coordinador_region");
            entity.Property(e => e.NombreRegion)
                .HasMaxLength(120)
                .HasColumnName("nombre_region");
            entity.Property(e => e.PoblacionRegion)
                .HasPrecision(12, 2)
                .HasColumnName("poblacion_region");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
