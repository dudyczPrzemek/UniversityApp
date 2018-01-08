﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SA.Backend.DB;
using System;

namespace SA.Backend.Migrations
{
    [DbContext(typeof(SAContext))]
    [Migration("20180104234117_CreateFullDB")]
    partial class CreateFullDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("SA.Contracts.Facebook.User.facebook_user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("facebook_user");
                });

            modelBuilder.Entity("SA.Contracts.Instagram.User.instagram_media_recent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("instagram_media_recent");
                });

            modelBuilder.Entity("SA.Contracts.Reports.Character.CharacterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NegativeOpinions");

                    b.Property<int>("PositiveOpinions");

                    b.HasKey("Id");

                    b.ToTable("CharacterData");
                });

            modelBuilder.Entity("SA.Contracts.Reports.InternetActivity.HashtagDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("HashtagDetails");
                });

            modelBuilder.Entity("SA.Contracts.Reports.InternetActivity.HourActivityDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Hour");

                    b.Property<int>("Mentions");

                    b.Property<string>("Source");

                    b.HasKey("Id");

                    b.ToTable("HourActivityData");
                });

            modelBuilder.Entity("SA.Contracts.Reports.InternetActivity.InternetActivityData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HashtagDetailsId");

                    b.Property<int?>("HourActivityDetailsId");

                    b.HasKey("Id");

                    b.HasIndex("HashtagDetailsId");

                    b.HasIndex("HourActivityDetailsId");

                    b.ToTable("InternetActivityData");
                });

            modelBuilder.Entity("SA.Contracts.Reports.Localization.Localization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Hour");

                    b.Property<int>("Latitude");

                    b.Property<int>("Longitude");

                    b.HasKey("Id");

                    b.ToTable("Localization");
                });

            modelBuilder.Entity("SA.Contracts.Reports.PersonalData.PersonalData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("SA.Contracts.Twitter.user_tweets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data")
                        .HasColumnType("jsonb");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("user_tweets");
                });

            modelBuilder.Entity("SA.Contracts.User.FollowedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CharacterDataId");

                    b.Property<int>("FacebookId");

                    b.Property<int>("InstagramId");

                    b.Property<int?>("InternetActivityDataId");

                    b.Property<int?>("LocalizationDataId");

                    b.Property<int?>("PersonalDataId");

                    b.Property<int>("TwitterId");

                    b.Property<int?>("UserId");

                    b.Property<int?>("facebook_userId");

                    b.Property<int?>("instagram_media_recentId");

                    b.Property<int?>("user_tweetsId");

                    b.HasKey("Id");

                    b.HasIndex("CharacterDataId");

                    b.HasIndex("InternetActivityDataId");

                    b.HasIndex("LocalizationDataId");

                    b.HasIndex("PersonalDataId");

                    b.HasIndex("UserId");

                    b.HasIndex("facebook_userId");

                    b.HasIndex("instagram_media_recentId");

                    b.HasIndex("user_tweetsId");

                    b.ToTable("FollowedUser");
                });

            modelBuilder.Entity("SA.Contracts.User.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SA.Contracts.Reports.InternetActivity.InternetActivityData", b =>
                {
                    b.HasOne("SA.Contracts.Reports.InternetActivity.HashtagDetails", "HashtagDetails")
                        .WithMany()
                        .HasForeignKey("HashtagDetailsId");

                    b.HasOne("SA.Contracts.Reports.InternetActivity.HourActivityDetails", "HourActivityDetails")
                        .WithMany()
                        .HasForeignKey("HourActivityDetailsId");
                });

            modelBuilder.Entity("SA.Contracts.User.FollowedUser", b =>
                {
                    b.HasOne("SA.Contracts.Reports.Character.CharacterData", "CharacterData")
                        .WithMany()
                        .HasForeignKey("CharacterDataId");

                    b.HasOne("SA.Contracts.Reports.InternetActivity.InternetActivityData", "InternetActivityData")
                        .WithMany()
                        .HasForeignKey("InternetActivityDataId");

                    b.HasOne("SA.Contracts.Reports.Localization.Localization", "LocalizationData")
                        .WithMany()
                        .HasForeignKey("LocalizationDataId");

                    b.HasOne("SA.Contracts.Reports.PersonalData.PersonalData", "PersonalData")
                        .WithMany()
                        .HasForeignKey("PersonalDataId");

                    b.HasOne("SA.Contracts.User.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("SA.Contracts.Facebook.User.facebook_user", "facebook_user")
                        .WithMany()
                        .HasForeignKey("facebook_userId");

                    b.HasOne("SA.Contracts.Instagram.User.instagram_media_recent", "instagram_media_recent")
                        .WithMany()
                        .HasForeignKey("instagram_media_recentId");

                    b.HasOne("SA.Contracts.Twitter.user_tweets", "user_tweets")
                        .WithMany()
                        .HasForeignKey("user_tweetsId");
                });
#pragma warning restore 612, 618
        }
    }
}
