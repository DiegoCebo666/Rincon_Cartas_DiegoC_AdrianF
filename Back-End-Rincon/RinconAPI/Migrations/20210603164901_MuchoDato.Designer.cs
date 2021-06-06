﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RinconDL.Contexts;

namespace RinconAPI.Migrations
{
    [DbContext(typeof(RinconContext))]
    [Migration("20210603164901_MuchoDato")]
    partial class MuchoDato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("RinconDL.Entities.Carrito", b =>
                {
                    b.Property<int>("CarritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioFId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarritoId");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("RinconDL.Entities.Carta", b =>
                {
                    b.Property<int>("CartaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CartaName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Img")
                        .HasColumnType("TEXT");

                    b.Property<int>("JuegoFId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartaId");

                    b.ToTable("Cartas");

                    b.HasData(
                        new
                        {
                            CartaId = 1,
                            CartaName = "Dunsparce (NDI 54)",
                            Img = "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg",
                            JuegoFId = 1
                        },
                        new
                        {
                            CartaId = 2,
                            CartaName = "Imakuni?'s Doduo (EVO 112)",
                            Img = "https://static.cardmarket.com/img/60b895275f86d14cc1fe1090647467de/items/51/EVO/293474.jpg",
                            JuegoFId = 1
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.CartaVendedor", b =>
                {
                    b.Property<int>("CartaVendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartaFId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CartaFName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<string>("FImg")
                        .HasColumnType("TEXT");

                    b.Property<string>("Idioma")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("VendedorFId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartaVendedorId");

                    b.HasIndex("CarritoId");

                    b.ToTable("CartasVendedor");

                    b.HasData(
                        new
                        {
                            CartaVendedorId = 1,
                            Cantidad = 30,
                            CartaFId = 1,
                            CartaFName = "Dunsparce (NDI 54)",
                            Estado = "Perfecta",
                            FImg = "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg",
                            Idioma = "es",
                            Precio = 100.0,
                            VendedorFId = 1
                        },
                        new
                        {
                            CartaVendedorId = 2,
                            Cantidad = 30,
                            CartaFId = 2,
                            CartaFName = "Imakuni?'s Doduo (EVO 112)",
                            Estado = "Casi Perfecta",
                            FImg = "https://static.cardmarket.com/img/60b895275f86d14cc1fe1090647467de/items/51/EVO/293474.jpg",
                            Idioma = "es",
                            Precio = 100.0,
                            VendedorFId = 1
                        },
                        new
                        {
                            CartaVendedorId = 3,
                            Cantidad = 20,
                            CartaFId = 1,
                            CartaFName = "Dunsparce (NDI 54)",
                            Estado = "Excelente",
                            FImg = "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg",
                            Idioma = "en",
                            Precio = 50.0,
                            VendedorFId = 2
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Juego", b =>
                {
                    b.Property<int>("JuegoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JuegoName")
                        .HasColumnType("TEXT");

                    b.HasKey("JuegoId");

                    b.ToTable("Juegos");

                    b.HasData(
                        new
                        {
                            JuegoId = 1,
                            JuegoName = "Pokemon"
                        },
                        new
                        {
                            JuegoId = 2,
                            JuegoName = "Yu-Gi-Oh"
                        },
                        new
                        {
                            JuegoId = 3,
                            JuegoName = "Magic"
                        },
                        new
                        {
                            JuegoId = 4,
                            JuegoName = "Dragon Ball"
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CartCarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Estado")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("PedidoId");

                    b.HasIndex("CartCarritoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("RinconDL.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Seller")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Email = "pipo@gmail.com",
                            Password = "Pipo",
                            Seller = true,
                            UserName = "Pipo"
                        },
                        new
                        {
                            UsuarioId = 2,
                            Email = "papo@gmail.com",
                            Password = "Papo",
                            Seller = true,
                            UserName = "Papo"
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.CartaVendedor", b =>
                {
                    b.HasOne("RinconDL.Entities.Carrito", null)
                        .WithMany("Cartas")
                        .HasForeignKey("CarritoId");
                });

            modelBuilder.Entity("RinconDL.Entities.Pedido", b =>
                {
                    b.HasOne("RinconDL.Entities.Carrito", "Cart")
                        .WithMany()
                        .HasForeignKey("CartCarritoId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("RinconDL.Entities.Carrito", b =>
                {
                    b.Navigation("Cartas");
                });
#pragma warning restore 612, 618
        }
    }
}
