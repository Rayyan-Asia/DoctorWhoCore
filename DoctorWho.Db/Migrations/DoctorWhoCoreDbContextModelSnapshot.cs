﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    partial class DoctorWhoCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Rayyan Asia"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Raneen Asia"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Rami Asia"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Reema Asia"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Karam Shawish"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Dr. Grace Hollow",
                            WhoPlayed = "Daphne Ashbrook"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Elizabeth Shaw",
                            WhoPlayed = "Caroline John"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Ace",
                            WhoPlayed = "Sophie Aldred"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Captain Mike Yates",
                            WhoPlayed = "Richard Franklin"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Melanie",
                            WhoPlayed = "Bonnie Langford"
                        },
                        new
                        {
                            CompanionId = 6,
                            CompanionName = "TuTu",
                            WhoPlayed = "Tawfieg"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.CompanionEpisode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodesEpisodeId");

                    b.Property<int>("CompanionId")
                        .HasColumnType("int")
                        .HasColumnName("CompanionsCompanionId");

                    b.HasKey("EpisodeId", "CompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("CompanionEpisode", (string)null);

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            CompanionId = 1
                        },
                        new
                        {
                            EpisodeId = 2,
                            CompanionId = 2
                        },
                        new
                        {
                            EpisodeId = 3,
                            CompanionId = 3
                        },
                        new
                        {
                            EpisodeId = 4,
                            CompanionId = 4
                        },
                        new
                        {
                            EpisodeId = 5,
                            CompanionId = 5
                        },
                        new
                        {
                            EpisodeId = 1,
                            CompanionId = 2
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATE");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("DATE");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("DATE");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1980, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "David Tennant",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(2010, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2013, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Matt Smith",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1985, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Peter Capaldi",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2018, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1992, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Christopher Eccleston",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1990, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jodie Whittaker",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Fellow Time Lord that constantly tries to torment and destroy the doctor.",
                            EnemyName = "The Master"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Beings that chased The Doctor for near immortality.",
                            EnemyName = "Family of Blood"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "These robots have plagued the Doctor for centuries.",
                            EnemyName = "Daleks"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "Emotionless robots from another world that constantly change their design, becoming more powerful, and upgrading every time we see them.",
                            EnemyName = "Cybermen"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Horrifying stone statues that have a pretty scary design, but the real fear is how these creatures move and kill their prey.",
                            EnemyName = "Weeping Angels"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EnemyEpisode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int")
                        .HasColumnName("EpisodesEpisodeId");

                    b.Property<int>("EnemyId")
                        .HasColumnType("int")
                        .HasColumnName("EnemiesEnemyId");

                    b.HasKey("EpisodeId", "EnemyId");

                    b.HasIndex("EnemyId");

                    b.ToTable("EnemyEpisode", (string)null);

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            EnemyId = 1
                        },
                        new
                        {
                            EpisodeId = 2,
                            EnemyId = 2
                        },
                        new
                        {
                            EpisodeId = 3,
                            EnemyId = 3
                        },
                        new
                        {
                            EpisodeId = 4,
                            EnemyId = 4
                        },
                        new
                        {
                            EpisodeId = 5,
                            EnemyId = 5
                        },
                        new
                        {
                            EpisodeId = 1,
                            EnemyId = 2
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("date");

                    b.Property<int>("EpisodeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Null");

                    b.Property<int>("SeriesNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2010, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Comedy,Eerie",
                            Notes = "The Best Doctor IMO",
                            SeriesNumber = 1,
                            Title = "Pilot"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Comedy,Eerie,Investigation",
                            Notes = "Longest Production Episode",
                            SeriesNumber = 2,
                            Title = "The Second Doctor"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Comedy,Action",
                            SeriesNumber = 3,
                            Title = "Back to the Booth"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Comedy,Detective",
                            SeriesNumber = 4,
                            Title = "Another Doctor"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Comedy,Eerie",
                            Notes = "New Cast Who Dis?",
                            SeriesNumber = 5,
                            Title = "Time Is Not So Simple"
                        },
                        new
                        {
                            EpisodeId = 6,
                            AuthorId = 1,
                            EpisodeDate = new DateTime(2010, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Comedy,Eerie",
                            Notes = "No Doctor",
                            SeriesNumber = 1,
                            Title = "Our Fist Encounter"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.CompanionEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany()
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EnemyEpisode", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId");

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
