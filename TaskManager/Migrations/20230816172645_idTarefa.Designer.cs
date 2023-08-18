﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Data;

namespace TaskManager.Migrations
{
    [DbContext(typeof(TaskManagerContext))]
    [Migration("20230816172645_idTarefa")]
    partial class idTarefa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TaskManager.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Color");

                    b.Property<bool>("Complet");

                    b.Property<DateTime>("DateOff");

                    b.Property<string>("Description");

                    b.Property<int>("TarefaId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Tarefa");
                });
#pragma warning restore 612, 618
        }
    }
}
