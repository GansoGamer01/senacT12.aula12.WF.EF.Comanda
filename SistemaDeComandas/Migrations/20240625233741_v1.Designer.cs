﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDeComandas.BancoDeDados;

#nullable disable

namespace SistemaDeComandas.Migrations
{
    [DbContext(typeof(ComandaContexto))]
    [Migration("20240625233741_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("PedidoCozinhaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PedidoCozinhaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComandaItemId");

                    b.HasIndex("PedidoCozinhaId");

                    b.ToTable("PedidoCozinhaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.CardapioItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("PossuiPreparo")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("cardapioItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoComanda")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Comandas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.ComandaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardapioItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardapioItemId");

                    b.HasIndex("ComandaId");

                    b.ToTable("ComandaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumeroMesa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoMesa")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComandaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("PedidoCozinhas");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("PedidoCozinhaItem", b =>
                {
                    b.HasOne("SistemaDeComandas.Modelos.ComandaItem", "ComandaItem")
                        .WithMany()
                        .HasForeignKey("ComandaItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeComandas.Modelos.PedidoCozinha", "PedidoCozinha")
                        .WithMany("PedidoCozinhaItems")
                        .HasForeignKey("PedidoCozinhaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ComandaItem");

                    b.Navigation("PedidoCozinha");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.ComandaItem", b =>
                {
                    b.HasOne("SistemaDeComandas.Modelos.CardapioItem", "CardapioItem")
                        .WithMany()
                        .HasForeignKey("CardapioItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDeComandas.Modelos.Comanda", "Comanda")
                        .WithMany("ComandaItems")
                        .HasForeignKey("ComandaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CardapioItem");

                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.Comanda", b =>
                {
                    b.Navigation("ComandaItems");
                });

            modelBuilder.Entity("SistemaDeComandas.Modelos.PedidoCozinha", b =>
                {
                    b.Navigation("PedidoCozinhaItems");
                });
#pragma warning restore 612, 618
        }
    }
}
