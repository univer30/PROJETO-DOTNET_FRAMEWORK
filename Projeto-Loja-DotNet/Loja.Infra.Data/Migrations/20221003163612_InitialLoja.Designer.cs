// <auto-generated />
using Loja.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Loja.Infra.Data.Migrations
{
    [DbContext(typeof(LojaDbContext))]
    [Migration("20221003163612_InitialLoja")]
    partial class InitialLoja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Loja.Domain.Models.LojaMarilia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LojaMarilias");
                });

            modelBuilder.Entity("Loja.Domain.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LojaMariliaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("preco")
                        .HasColumnType("REAL");

                    b.Property<int>("qtde")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LojaMariliaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Loja.Domain.Models.Produto", b =>
                {
                    b.HasOne("Loja.Domain.Models.LojaMarilia", "LojaMarilia")
                        .WithMany()
                        .HasForeignKey("LojaMariliaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LojaMarilia");
                });
#pragma warning restore 612, 618
        }
    }
}
