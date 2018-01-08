using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class FullDBChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowedUser_facebook_user_facebook_userId",
                table: "FollowedUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowedUser_instagram_media_recent_instagram_media_recentId",
                table: "FollowedUser");

            migrationBuilder.DropForeignKey(
                name: "FK_FollowedUser_user_tweets_user_tweetsId",
                table: "FollowedUser");

            migrationBuilder.DropIndex(
                name: "IX_FollowedUser_facebook_userId",
                table: "FollowedUser");

            migrationBuilder.DropIndex(
                name: "IX_FollowedUser_instagram_media_recentId",
                table: "FollowedUser");

            migrationBuilder.DropIndex(
                name: "IX_FollowedUser_user_tweetsId",
                table: "FollowedUser");

            migrationBuilder.DropColumn(
                name: "facebook_userId",
                table: "FollowedUser");

            migrationBuilder.DropColumn(
                name: "instagram_media_recentId",
                table: "FollowedUser");

            migrationBuilder.DropColumn(
                name: "user_tweetsId",
                table: "FollowedUser");

            migrationBuilder.AddColumn<int>(
                name: "FollowedUserId",
                table: "user_tweets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FollowedUserId",
                table: "instagram_media_recent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FollowedUserId",
                table: "facebook_user",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_tweets_FollowedUserId",
                table: "user_tweets",
                column: "FollowedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_instagram_media_recent_FollowedUserId",
                table: "instagram_media_recent",
                column: "FollowedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_facebook_user_FollowedUserId",
                table: "facebook_user",
                column: "FollowedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_facebook_user_FollowedUser_FollowedUserId",
                table: "facebook_user",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_instagram_media_recent_FollowedUser_FollowedUserId",
                table: "instagram_media_recent",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_user_tweets_FollowedUser_FollowedUserId",
                table: "user_tweets",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facebook_user_FollowedUser_FollowedUserId",
                table: "facebook_user");

            migrationBuilder.DropForeignKey(
                name: "FK_instagram_media_recent_FollowedUser_FollowedUserId",
                table: "instagram_media_recent");

            migrationBuilder.DropForeignKey(
                name: "FK_user_tweets_FollowedUser_FollowedUserId",
                table: "user_tweets");

            migrationBuilder.DropIndex(
                name: "IX_user_tweets_FollowedUserId",
                table: "user_tweets");

            migrationBuilder.DropIndex(
                name: "IX_instagram_media_recent_FollowedUserId",
                table: "instagram_media_recent");

            migrationBuilder.DropIndex(
                name: "IX_facebook_user_FollowedUserId",
                table: "facebook_user");

            migrationBuilder.DropColumn(
                name: "FollowedUserId",
                table: "user_tweets");

            migrationBuilder.DropColumn(
                name: "FollowedUserId",
                table: "instagram_media_recent");

            migrationBuilder.DropColumn(
                name: "FollowedUserId",
                table: "facebook_user");

            migrationBuilder.AddColumn<int>(
                name: "facebook_userId",
                table: "FollowedUser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "instagram_media_recentId",
                table: "FollowedUser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_tweetsId",
                table: "FollowedUser",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_FollowedUser_facebook_user_facebook_userId",
                table: "FollowedUser",
                column: "facebook_userId",
                principalTable: "facebook_user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowedUser_instagram_media_recent_instagram_media_recentId",
                table: "FollowedUser",
                column: "instagram_media_recentId",
                principalTable: "instagram_media_recent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FollowedUser_user_tweets_user_tweetsId",
                table: "FollowedUser",
                column: "user_tweetsId",
                principalTable: "user_tweets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
