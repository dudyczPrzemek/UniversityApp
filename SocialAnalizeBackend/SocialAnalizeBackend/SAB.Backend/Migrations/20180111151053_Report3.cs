using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class Report3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HashtagDetails_InternetActivityData_InternetActivityDataId",
                table: "HashtagDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_HourActivityData_InternetActivityData_InternetActivityDataId",
                table: "HourActivityData");

            migrationBuilder.RenameColumn(
                name: "InternetActivityDataId",
                table: "HourActivityData",
                newName: "FollowedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_HourActivityData_InternetActivityDataId",
                table: "HourActivityData",
                newName: "IX_HourActivityData_FollowedUserId");

            migrationBuilder.RenameColumn(
                name: "InternetActivityDataId",
                table: "HashtagDetails",
                newName: "FollowedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_HashtagDetails_InternetActivityDataId",
                table: "HashtagDetails",
                newName: "IX_HashtagDetails_FollowedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_HashtagDetails_FollowedUser_FollowedUserId",
                table: "HashtagDetails",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HourActivityData_FollowedUser_FollowedUserId",
                table: "HourActivityData",
                column: "FollowedUserId",
                principalTable: "FollowedUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HashtagDetails_FollowedUser_FollowedUserId",
                table: "HashtagDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_HourActivityData_FollowedUser_FollowedUserId",
                table: "HourActivityData");

            migrationBuilder.RenameColumn(
                name: "FollowedUserId",
                table: "HourActivityData",
                newName: "InternetActivityDataId");

            migrationBuilder.RenameIndex(
                name: "IX_HourActivityData_FollowedUserId",
                table: "HourActivityData",
                newName: "IX_HourActivityData_InternetActivityDataId");

            migrationBuilder.RenameColumn(
                name: "FollowedUserId",
                table: "HashtagDetails",
                newName: "InternetActivityDataId");

            migrationBuilder.RenameIndex(
                name: "IX_HashtagDetails_FollowedUserId",
                table: "HashtagDetails",
                newName: "IX_HashtagDetails_InternetActivityDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_HashtagDetails_InternetActivityData_InternetActivityDataId",
                table: "HashtagDetails",
                column: "InternetActivityDataId",
                principalTable: "InternetActivityData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HourActivityData_InternetActivityData_InternetActivityDataId",
                table: "HourActivityData",
                column: "InternetActivityDataId",
                principalTable: "InternetActivityData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
