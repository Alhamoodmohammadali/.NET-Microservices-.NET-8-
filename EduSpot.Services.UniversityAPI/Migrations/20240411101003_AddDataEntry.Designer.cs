﻿// <auto-generated />
using EduSpot.Services.UniversityAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduSpot.Services.UniversityAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240411101003_AddDataEntry")]
    partial class AddDataEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EduSpot.Services.UniversityAPI.Models.University", b =>
                {
                    b.Property<int>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UniversityId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniversityId");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            UniversityId = 1,
                            Description = "The Syrian Virtual University is distinguished by offering flexible  \r\n                                    and accessible online academic programs, \r\n                                    allowing students to study at any time and from anywhere that suits them.\r\n                                    The university also focuses on providing excellent technical and academic \r\n                                    support to students to ensure their academic success.\\r\\n",
                            ImageUrl = "https://placehold.co/603x403",
                            Location = "Syrian",
                            Name = "Syrian Virtual University"
                        },
                        new
                        {
                            UniversityId = 2,
                            Description = "Damascus International University is considered one of the leading universities in Syria,\\n\r\n                                    providing high-quality education in a variety of academic disciplines.\\n\r\n                                    The university aims to develop students' skills and enhance their capabilities \\n\r\n                                    through comprehensive academic programs and updated curricula that meet the needs of the job market.\\n\r\n                                    The university is characterized by a modern academic environment and advanced facilities that facilitate\\n\r\n                                    the learning process and motivate students to achieve their academic and professional goals.\\n",
                            ImageUrl = "https://placehold.co/603x403",
                            Location = "Damascus",
                            Name = "Damascus International University"
                        },
                        new
                        {
                            UniversityId = 3,
                            Description = "The Syrian Private University is considered a prestigious educational destination in Syria, \\n\r\n                                   providing a distinctive learning environment that helps students achieve their academic and professional goals. \\n\r\n                                   The university is known for offering diverse academic programs covering a wide range of specialties, \\n\r\n                                   allowing students to choose the field that suits their interests and professional inclinations. Additionally,\\n\r\n                                   the university provides modern infrastructure and educational facilities equipped with the latest technologies,\\n\r\n                                   which help enhance the learning process and develop students' skills effectively",
                            ImageUrl = "https://placehold.co/603x403",
                            Location = "Damascus",
                            Name = "Syrian Private University"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
