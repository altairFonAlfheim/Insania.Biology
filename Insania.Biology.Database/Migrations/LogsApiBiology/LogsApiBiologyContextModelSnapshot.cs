﻿// <auto-generated />
using System;
using Insania.Biology.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Insania.Biology.Database.Migrations.LogsApiBiology
{
    [DbContext(typeof(LogsApiBiologyContext))]
    partial class LogsApiBiologyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("insania_logs_api_biology")
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Insania.Biology.Entities.LogApiBiology", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("DataIn")
                        .HasColumnType("jsonb")
                        .HasColumnName("data_in")
                        .HasComment("Данные на вход");

                    b.Property<string>("DataOut")
                        .HasColumnType("jsonb")
                        .HasColumnName("data_out")
                        .HasComment("Данные на выход");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime?>("DateEnd")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_end")
                        .HasComment("Дата окончания");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_start")
                        .HasComment("Дата начала");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("method")
                        .HasComment("Наименование вызываемого метода");

                    b.Property<bool>("Success")
                        .HasColumnType("boolean")
                        .HasColumnName("success")
                        .HasComment("Признак успешного выполнения");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type")
                        .HasComment("Тип вызываемого метода");

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

                    b.HasIndex("DataIn");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("DataIn"), "gin");

                    b.HasIndex("DataOut");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("DataOut"), "gin");

                    b.ToTable("r_logs_api_biology", "insania_logs_api_biology", t =>
                        {
                            t.HasComment("Логи сервиса биологии");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
