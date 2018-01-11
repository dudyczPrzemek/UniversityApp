using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class Report2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InternetActivityDataId",
                table: "HourActivityData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InternetActivityDataId",
                table: "HashtagDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HourActivityData_InternetActivityDataId",
                table: "HourActivityData",
                column: "InternetActivityDataId");

            migrationBuilder.CreateIndex(
                name: "IX_HashtagDetails_InternetActivityDataId",
                table: "HashtagDetails",
                column: "InternetActivityDataId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HashtagDetails_InternetActivityData_InternetActivityDataId",
                table: "HashtagDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_HourActivityData_InternetActivityData_InternetActivityDataId",
                table: "HourActivityData");

            migrationBuilder.DropIndex(
                name: "IX_HourActivityData_InternetActivityDataId",
                table: "HourActivityData");

            migrationBuilder.DropIndex(
                name: "IX_HashtagDetails_InternetActivityDataId",
                table: "HashtagDetails");

            migrationBuilder.DropColumn(
                name: "InternetActivityDataId",
                table: "HourActivityData");

            migrationBuilder.DropColumn(
                name: "InternetActivityDataId",
                table: "HashtagDetails");
        }
    }
}
