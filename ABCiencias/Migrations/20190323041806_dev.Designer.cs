﻿// <auto-generated />
using System;
using ABCiencias.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ABCiencias.Migrations
{
    [DbContext(typeof(ABCienciasContext))]
    [Migration("20190323041806_dev")]
    partial class dev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ABCiencias.Models.CategoriaServico", b =>
                {
                    b.Property<int>("IdCategoriaServico")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("IdCategoriaServico");

                    b.ToTable("CategoriaServico");
                });

            modelBuilder.Entity("ABCiencias.Models.Eventos.ContratoEvento", b =>
                {
                    b.Property<int>("IdContratoEvento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<int>("IdEvento_fk");

                    b.Property<int>("Status");

                    b.Property<decimal>("Valor");

                    b.HasKey("IdContratoEvento");

                    b.HasIndex("IdEvento_fk")
                        .IsUnique();

                    b.ToTable("ContratoEventos");
                });

            modelBuilder.Entity("ABCiencias.Models.Eventos.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Evento");

                    b.Property<string>("Descricao");

                    b.Property<string>("NomeEvento");

                    b.Property<int>("Status");

                    b.HasKey("IdEvento");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("ABCiencias.Models.Eventos.ServicoEventoFornecedor", b =>
                {
                    b.Property<int>("IdServicoEventoFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdContratoEvento_fk");

                    b.Property<int>("IdServicoFornecedor_fk");

                    b.Property<decimal>("ValorCobrado");

                    b.HasKey("IdServicoEventoFornecedor");

                    b.HasIndex("IdContratoEvento_fk");

                    b.HasIndex("IdServicoFornecedor_fk");

                    b.ToTable("ServicoEventoFornecedor");
                });

            modelBuilder.Entity("ABCiencias.Models.Fornecedor", b =>
                {
                    b.Property<int>("IdFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ");

                    b.Property<string>("Descricao");

                    b.Property<string>("RazaoSocial");

                    b.Property<int>("Status");

                    b.HasKey("IdFornecedor");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("ABCiencias.Models.Servico", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<int>("IdCategoriaServico_fk");

                    b.Property<string>("Nome");

                    b.HasKey("IdServico");

                    b.HasIndex("IdCategoriaServico_fk");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("ABCiencias.Models.ServicoFornecedor", b =>
                {
                    b.Property<int>("IdServicoFornecedor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdFornecedor_fk");

                    b.Property<int>("IdServico_fk");

                    b.HasKey("IdServicoFornecedor");

                    b.HasIndex("IdFornecedor_fk");

                    b.HasIndex("IdServico_fk");

                    b.ToTable("ServicoFornecedor");
                });

            modelBuilder.Entity("ABCiencias.Models.URLShortener", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Clicks");

                    b.Property<string>("Domain");

                    b.Property<string>("Guid");

                    b.Property<string>("Nome");

                    b.Property<int>("Status");

                    b.Property<string>("UrlToRedirect");

                    b.HasKey("Id");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("ABCiencias.Models.User.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Passoword");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ABCiencias.Models.Eventos.ContratoEvento", b =>
                {
                    b.HasOne("ABCiencias.Models.Eventos.Evento", "Evento")
                        .WithOne("Contrato")
                        .HasForeignKey("ABCiencias.Models.Eventos.ContratoEvento", "IdEvento_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ABCiencias.Models.Eventos.ServicoEventoFornecedor", b =>
                {
                    b.HasOne("ABCiencias.Models.Eventos.ContratoEvento", "Contrato")
                        .WithMany("Servicos")
                        .HasForeignKey("IdContratoEvento_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ABCiencias.Models.ServicoFornecedor", "ServicoFornecedor")
                        .WithMany()
                        .HasForeignKey("IdServicoFornecedor_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ABCiencias.Models.Servico", b =>
                {
                    b.HasOne("ABCiencias.Models.CategoriaServico", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoriaServico_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ABCiencias.Models.ServicoFornecedor", b =>
                {
                    b.HasOne("ABCiencias.Models.Fornecedor", "Fornecedor")
                        .WithMany("Servicos")
                        .HasForeignKey("IdFornecedor_fk")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ABCiencias.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("IdServico_fk")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
