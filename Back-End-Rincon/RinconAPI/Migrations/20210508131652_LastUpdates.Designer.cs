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
    [Migration("20210508131652_LastUpdates")]
    partial class LastUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("RinconDL.Entities.Carrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Carritos");
                });

            modelBuilder.Entity("RinconDL.Entities.Carta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarritoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Img")
                        .HasColumnType("TEXT");

                    b.Property<int>("JuegoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarritoId");

                    b.ToTable("Cartas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Img = "https://static.cardmarket.com/img/a2874630bf08babe923e75b1a73fba29/items/51/NDI/274565.jpg",
                            JuegoId = 1,
                            Name = "Dunsparce (NDI 54)"
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.CartaVendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartaId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<int>("VendedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CartasVendedor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 30,
                            CartaId = 1,
                            Precio = 100.0,
                            VendedorId = 1
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Juego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Juegos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pokemon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Yu-Gi-Oh"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Magic"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dragon Ball"
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CartId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("RinconDL.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Seller")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pipo",
                            Password = "Pipo",
                            Seller = true
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdUser = 1
                        });
                });

            modelBuilder.Entity("RinconDL.Entities.Carta", b =>
                {
                    b.HasOne("RinconDL.Entities.Carrito", null)
                        .WithMany("Cartas")
                        .HasForeignKey("CarritoId");
                });

            modelBuilder.Entity("RinconDL.Entities.Pedido", b =>
                {
                    b.HasOne("RinconDL.Entities.Carrito", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");

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
