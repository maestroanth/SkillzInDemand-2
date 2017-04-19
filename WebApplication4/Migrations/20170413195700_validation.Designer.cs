using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication4.Models;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20170413195700_validation")]
    partial class validation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Genre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("ID");

                    b.ToTable("Album");
                });
        }
    }
}
