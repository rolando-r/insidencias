﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(InsidenciasContext))]
    [Migration("20230719054750_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Area", b =>
                {
                    b.Property<string>("IdArea")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionArea")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("InsidenciaIdInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreArea")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdArea");

                    b.HasIndex("InsidenciaIdInsidencia");

                    b.ToTable("Areas", (string)null);
                });

            modelBuilder.Entity("Core.Entities.AreaUsuario", b =>
                {
                    b.Property<string>("IdAreaUsuario")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdArea")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LugarIdLugar")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdAreaUsuario");

                    b.HasIndex("IdArea");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("LugarIdLugar");

                    b.ToTable("AreaUsuarios", (string)null);
                });

            modelBuilder.Entity("Core.Entities.CategoriaContacto", b =>
                {
                    b.Property<string>("IdCategoriaContacto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdCategoria")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreCategoriaUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdCategoriaContacto");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Contacto", b =>
                {
                    b.Property<string>("IdContacto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdCategoriaContacto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdTipoContacto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdContacto");

                    b.HasIndex("IdCategoriaContacto");

                    b.HasIndex("IdTipoContacto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Contactos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DetalleInsidencia", b =>
                {
                    b.Property<string>("IdDetalleInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdEstado")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdHerramienta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdNivelInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdTipoInsidencia")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdDetalleInsidencia");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdNivelInsidencia");

                    b.HasIndex("IdTipoInsidencia");

                    b.ToTable("DetalleInsidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Property<string>("IdEstado")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.HasKey("IdEstado");

                    b.ToTable("Estados", (string)null);
                });

            modelBuilder.Entity("Core.Entities.HerramientaTrabajo", b =>
                {
                    b.Property<string>("IdHerramienta")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreHerramienta")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdHerramienta");

                    b.ToTable("HerramientaTrabajos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Insidencia", b =>
                {
                    b.Property<string>("IdInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionInsidencia")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<DateTime>("FechaInsidencia")
                        .HasColumnType("date");

                    b.Property<string>("IdArea")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdEstado")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("IdLugar")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdInsidencia");

                    b.HasIndex("IdArea");

                    b.HasIndex("IdEstado");

                    b.HasIndex("IdLugar");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Insidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Lugar", b =>
                {
                    b.Property<string>("IdLugar")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionLugar")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdArea")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreLugar")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdLugar");

                    b.HasIndex("IdArea");

                    b.ToTable("Lugares", (string)null);
                });

            modelBuilder.Entity("Core.Entities.NivelInsidencia", b =>
                {
                    b.Property<string>("IdNivelInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionNivelInsidencia")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("NombreNivelInsidencia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdNivelInsidencia");

                    b.ToTable("NivelInsidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Property<string>("IdRol")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionRol")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("NombreRol")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdRol");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Property<string>("IdTipoContacto")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionTipoContacto")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("NombreTipoContacto")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdTipoContacto");

                    b.ToTable("TipoContactos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Property<string>("IdTipoDocumento")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NombreTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdTipoDocumento");

                    b.ToTable("TipoDocumentos", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoInsidencia", b =>
                {
                    b.Property<string>("IdTipoInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DescripcionTipoInsidencia")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("NombreTipoInsidencia")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdTipoInsidencia");

                    b.ToTable("TipoInsidencias", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Property<string>("IdUsuario")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ApellidoUSuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DireccionUsuario")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("IdRoles")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("IdTipoDocumento")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdRoles");

                    b.HasIndex("IdTipoDocumento");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("DetalleInsidenciaHerramientaTrabajo", b =>
                {
                    b.Property<string>("DetalleInsidenciasIdDetalleInsidencia")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("HerramientaTrabajosIdHerramienta")
                        .HasColumnType("varchar(20)");

                    b.HasKey("DetalleInsidenciasIdDetalleInsidencia", "HerramientaTrabajosIdHerramienta");

                    b.HasIndex("HerramientaTrabajosIdHerramienta");

                    b.ToTable("DetalleInsidenciaHerramientaTrabajo");
                });

            modelBuilder.Entity("Core.Entities.Area", b =>
                {
                    b.HasOne("Core.Entities.Insidencia", null)
                        .WithMany("Areas")
                        .HasForeignKey("InsidenciaIdInsidencia");
                });

            modelBuilder.Entity("Core.Entities.AreaUsuario", b =>
                {
                    b.HasOne("Core.Entities.Area", "Area")
                        .WithMany("AreaUsuarios")
                        .HasForeignKey("IdArea");

                    b.HasOne("Core.Entities.Usuario", "Usuario")
                        .WithMany("AreaUsuarios")
                        .HasForeignKey("IdUsuario");

                    b.HasOne("Core.Entities.Lugar", null)
                        .WithMany("AreaUsuarios")
                        .HasForeignKey("LugarIdLugar");

                    b.Navigation("Area");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Core.Entities.Contacto", b =>
                {
                    b.HasOne("Core.Entities.CategoriaContacto", "CategoriaContacto")
                        .WithMany("Contactos")
                        .HasForeignKey("IdCategoriaContacto");

                    b.HasOne("Core.Entities.TipoContacto", "tipoContacto")
                        .WithMany("Contactos")
                        .HasForeignKey("IdTipoContacto");

                    b.HasOne("Core.Entities.Usuario", "Usuario")
                        .WithMany("Contactos")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("CategoriaContacto");

                    b.Navigation("Usuario");

                    b.Navigation("tipoContacto");
                });

            modelBuilder.Entity("Core.Entities.DetalleInsidencia", b =>
                {
                    b.HasOne("Core.Entities.Estado", "Estado")
                        .WithMany("DetalleInsidencias")
                        .HasForeignKey("IdEstado");

                    b.HasOne("Core.Entities.NivelInsidencia", "NivelInsidencia")
                        .WithMany("DetalleInsidencias")
                        .HasForeignKey("IdNivelInsidencia");

                    b.HasOne("Core.Entities.TipoInsidencia", "TipoInsidencia")
                        .WithMany("DetalleInsidencias")
                        .HasForeignKey("IdTipoInsidencia");

                    b.Navigation("Estado");

                    b.Navigation("NivelInsidencia");

                    b.Navigation("TipoInsidencia");
                });

            modelBuilder.Entity("Core.Entities.Insidencia", b =>
                {
                    b.HasOne("Core.Entities.Area", "Area")
                        .WithMany("Insidencias")
                        .HasForeignKey("IdArea");

                    b.HasOne("Core.Entities.Estado", "Estado")
                        .WithMany("Insidencias")
                        .HasForeignKey("IdEstado");

                    b.HasOne("Core.Entities.Lugar", "Lugar")
                        .WithMany("Insidencias")
                        .HasForeignKey("IdLugar");

                    b.HasOne("Core.Entities.Usuario", "Usuario")
                        .WithMany("Insidencias")
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Area");

                    b.Navigation("Estado");

                    b.Navigation("Lugar");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Core.Entities.Lugar", b =>
                {
                    b.HasOne("Core.Entities.Area", "Area")
                        .WithMany("Lugares")
                        .HasForeignKey("IdArea");

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.HasOne("Core.Entities.Rol", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRoles");

                    b.HasOne("Core.Entities.TipoDocumento", "TipoDocumento")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoDocumento");

                    b.Navigation("Rol");

                    b.Navigation("TipoDocumento");
                });

            modelBuilder.Entity("DetalleInsidenciaHerramientaTrabajo", b =>
                {
                    b.HasOne("Core.Entities.DetalleInsidencia", null)
                        .WithMany()
                        .HasForeignKey("DetalleInsidenciasIdDetalleInsidencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.HerramientaTrabajo", null)
                        .WithMany()
                        .HasForeignKey("HerramientaTrabajosIdHerramienta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Area", b =>
                {
                    b.Navigation("AreaUsuarios");

                    b.Navigation("Insidencias");

                    b.Navigation("Lugares");
                });

            modelBuilder.Entity("Core.Entities.CategoriaContacto", b =>
                {
                    b.Navigation("Contactos");
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Navigation("DetalleInsidencias");

                    b.Navigation("Insidencias");
                });

            modelBuilder.Entity("Core.Entities.Insidencia", b =>
                {
                    b.Navigation("Areas");
                });

            modelBuilder.Entity("Core.Entities.Lugar", b =>
                {
                    b.Navigation("AreaUsuarios");

                    b.Navigation("Insidencias");
                });

            modelBuilder.Entity("Core.Entities.NivelInsidencia", b =>
                {
                    b.Navigation("DetalleInsidencias");
                });

            modelBuilder.Entity("Core.Entities.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.TipoContacto", b =>
                {
                    b.Navigation("Contactos");
                });

            modelBuilder.Entity("Core.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Core.Entities.TipoInsidencia", b =>
                {
                    b.Navigation("DetalleInsidencias");
                });

            modelBuilder.Entity("Core.Entities.Usuario", b =>
                {
                    b.Navigation("AreaUsuarios");

                    b.Navigation("Contactos");

                    b.Navigation("Insidencias");
                });
#pragma warning restore 612, 618
        }
    }
}
