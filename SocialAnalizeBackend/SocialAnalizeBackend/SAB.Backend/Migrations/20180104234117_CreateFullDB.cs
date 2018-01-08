using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class CreateFullDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacebookUser");

            migrationBuilder.DropTable(
                name: "twitter_searched_user_data");

            migrationBuilder.CreateTable(
                name: "CharacterData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NegativeOpinions = table.Column<int>(nullable: false),
                    PositiveOpinions = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "facebook_user",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Data = table.Column<string>(type: "jsonb", nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facebook_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HashtagDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Count = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashtagDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourActivityData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Hour = table.Column<int>(nullable: false),
                    Mentions = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourActivityData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localization",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Hour = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<int>(nullable: false),
                    Longitude = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_tweets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Data = table.Column<string>(type: "jsonb", nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_tweets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternetActivityData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    HashtagDetailsId = table.Column<int>(nullable: true),
                    HourActivityDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternetActivityData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternetActivityData_HashtagDetails_HashtagDetailsId",
                        column: x => x.HashtagDetailsId,
                        principalTable: "HashtagDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternetActivityData_HourActivityData_HourActivityDetailsId",
                        column: x => x.HourActivityDetailsId,
                        principalTable: "HourActivityData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FollowedUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CharacterDataId = table.Column<int>(nullable: true),
                    FacebookId = table.Column<int>(nullable: false),
                    InstagramId = table.Column<int>(nullable: false),
                    InternetActivityDataId = table.Column<int>(nullable: true),
                    LocalizationDataId = table.Column<int>(nullable: true),
                    PersonalDataId = table.Column<int>(nullable: true),
                    TwitterId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    facebook_userId = table.Column<int>(nullable: true),
                    instagram_media_recentId = table.Column<int>(nullable: true),
                    user_tweetsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowedUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowedUser_CharacterData_CharacterDataId",
                        column: x => x.CharacterDataId,
                        principalTable: "CharacterData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_InternetActivityData_InternetActivityDataId",
                        column: x => x.InternetActivityDataId,
                        principalTable: "InternetActivityData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_Localization_LocalizationDataId",
                        column: x => x.LocalizationDataId,
                        principalTable: "Localization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_PersonalData_PersonalDataId",
                        column: x => x.PersonalDataId,
                        principalTable: "PersonalData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_facebook_user_facebook_userId",
                        column: x => x.facebook_userId,
                        principalTable: "facebook_user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_instagram_media_recent_instagram_media_recentId",
                        column: x => x.instagram_media_recentId,
                        principalTable: "instagram_media_recent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowedUser_user_tweets_user_tweetsId",
                        column: x => x.user_tweetsId,
                        principalTable: "user_tweets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_CharacterDataId",
                table: "FollowedUser",
                column: "CharacterDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_InternetActivityDataId",
                table: "FollowedUser",
                column: "InternetActivityDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_LocalizationDataId",
                table: "FollowedUser",
                column: "LocalizationDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_PersonalDataId",
                table: "FollowedUser",
                column: "PersonalDataId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_UserId",
                table: "FollowedUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_facebook_userId",
                table: "FollowedUser",
                column: "facebook_userId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_instagram_media_recentId",
                table: "FollowedUser",
                column: "instagram_media_recentId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_user_tweetsId",
                table: "FollowedUser",
                column: "user_tweetsId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData",
                column: "HashtagDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData",
                column: "HourActivityDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowedUser");

            migrationBuilder.DropTable(
                name: "CharacterData");

            migrationBuilder.DropTable(
                name: "InternetActivityData");

            migrationBuilder.DropTable(
                name: "Localization");

            migrationBuilder.DropTable(
                name: "PersonalData");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "facebook_user");

            migrationBuilder.DropTable(
                name: "user_tweets");

            migrationBuilder.DropTable(
                name: "HashtagDetails");

            migrationBuilder.DropTable(
                name: "HourActivityData");

            migrationBuilder.CreateTable(
                name: "FacebookUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacebookUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "twitter_searched_user_data",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Data = table.Column<string>(type: "jsonb", nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_twitter_searched_user_data", x => x.Id);
                });
        }
    }
}
