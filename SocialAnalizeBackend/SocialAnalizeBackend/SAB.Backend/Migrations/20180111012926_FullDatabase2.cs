using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class FullDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FollowedUser_Localization_LocalizationDataId",
                table: "FollowedUser");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropIndex(
                name: "IX_FollowedUser_LocalizationDataId",
                table: "FollowedUser");

            migrationBuilder.DropColumn(
                name: "LocalizationDataId",
                table: "FollowedUser");

            migrationBuilder.AddColumn<int>(
                name: "FollowedUserId",
                table: "Localization",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Localization_FollowedUserId",
                table: "Localization",
                column: "FollowedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData",
                column: "HashtagDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData",
                column: "HourActivityDetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Localization_FollowedUser_FollowedUserId",
                table: "Localization",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Localization_FollowedUser_FollowedUserId",
                table: "Localization");

            migrationBuilder.DropIndex(
                name: "IX_Localization_FollowedUserId",
                table: "Localization");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropColumn(
                name: "FollowedUserId",
                table: "Localization");

            migrationBuilder.AddColumn<int>(
                name: "LocalizationDataId",
                table: "FollowedUser",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData",
                column: "HashtagDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData",
                column: "HourActivityDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_FollowedUser_LocalizationDataId",
                table: "FollowedUser",
                column: "LocalizationDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_FollowedUser_Localization_LocalizationDataId",
                table: "FollowedUser",
                column: "LocalizationDataId",
                principalTable: "Localization",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
