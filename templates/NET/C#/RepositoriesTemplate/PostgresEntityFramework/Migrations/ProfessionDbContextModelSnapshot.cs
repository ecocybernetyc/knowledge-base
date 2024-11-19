﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgresEntityFramework;

#nullable disable

namespace PostgresEntityFramework.Migrations
{
    [DbContext(typeof(ProfessionDbContext))]
    partial class ProfessionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PostgresEntityFramework.Model.Profession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("MinEducationLevel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("PostgresEntityFramework.Model.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.PrimitiveCollection<string[]>("Details")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ProfessionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("PostgresEntityFramework.Model.Skill", b =>
                {
                    b.HasOne("PostgresEntityFramework.Model.Profession", "Profession")
                        .WithMany("Skills")
                        .HasForeignKey("ProfessionId");

                    b.Navigation("Profession");
                });

            modelBuilder.Entity("PostgresEntityFramework.Model.Profession", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}