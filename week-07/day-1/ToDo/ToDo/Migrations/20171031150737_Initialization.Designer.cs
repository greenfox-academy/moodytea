﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ToDo.Entities;

namespace ToDo.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20171031150737_Initialization")]
    partial class Initialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDo.Models.ToDoClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDone");

                    b.Property<bool>("IsUrgent");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("ToDos");
                });
        }
    }
}
