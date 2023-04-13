﻿// <auto-generated />
using KristalAbsheronAzAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KristalAbsheronAzAPI.Migrations
{
    [DbContext(typeof(KAContext))]
    [Migration("20230413103800_addNewsPhoto")]
    partial class addNewsPhoto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DownloadFormat", b =>
                {
                    b.Property<int>("DownloadsId")
                        .HasColumnType("integer");

                    b.Property<int>("FormatsId")
                        .HasColumnType("integer");

                    b.HasKey("DownloadsId", "FormatsId");

                    b.HasIndex("FormatsId");

                    b.ToTable("DownloadFormat");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.Ad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.Download", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Downloads");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.EnumKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EnumKeys");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.EnumValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("KeyId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KeyId");

                    b.ToTable("EnumValues");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Header")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.NewsPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NewsPhotos");
                });

            modelBuilder.Entity("DownloadFormat", b =>
                {
                    b.HasOne("KristalAbsheronAzAPI.Entities.Download", null)
                        .WithMany()
                        .HasForeignKey("DownloadsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KristalAbsheronAzAPI.Entities.Format", null)
                        .WithMany()
                        .HasForeignKey("FormatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KristalAbsheronAzAPI.Entities.EnumValue", b =>
                {
                    b.HasOne("KristalAbsheronAzAPI.Entities.EnumKey", "Key")
                        .WithMany()
                        .HasForeignKey("KeyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Key");
                });
#pragma warning restore 612, 618
        }
    }
}
