﻿// <auto-generated />
using System;
using Insania.Biology.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Insania.Biology.Database.Migrations
{
    [DbContext(typeof(BiologyContext))]
    partial class BiologyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("insania_biology")
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Insania.Biology.Entities.Nation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description")
                        .HasComment("Описание");

                    b.Property<string>("LanguageForPersonalNames")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("language_for_personal_names")
                        .HasComment("Язык для имён");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<long>("RaceId")
                        .HasColumnType("bigint")
                        .HasColumnName("race_id")
                        .HasComment("Идентификатор расы");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.HasIndex("RaceId");

                    b.ToTable("c_nations", "insania_biology", t =>
                        {
                            t.HasComment("Нации");
                        });
                });

            modelBuilder.Entity("Insania.Biology.Entities.Race", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description")
                        .HasComment("Описание");

                    b.Property<int?>("MaxAge")
                        .HasColumnType("integer")
                        .HasColumnName("max_age")
                        .HasComment("Максимальный возраст в циклах");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_races", "insania_biology", t =>
                        {
                            t.HasComment("Расы");
                        });
                });

            modelBuilder.Entity("Insania.Biology.Entities.Nation", b =>
                {
                    b.HasOne("Insania.Biology.Entities.Race", "RaceEntity")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RaceEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
