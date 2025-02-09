﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StroyMarket.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StroyMarket.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StroyMarket.Model.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("created_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<DateTime>("deleted_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValue(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

                    b.Property<string>("description")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("name_ru")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("name_uz")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("StroyMarket.Model.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("user_id"));

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<int?>("verification_code")
                        .HasColumnType("integer");

                    b.Property<bool>("verified")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.HasKey("user_id");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
