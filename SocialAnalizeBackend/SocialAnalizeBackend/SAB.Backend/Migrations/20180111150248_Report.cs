using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SA.Backend.Migrations
{
    public partial class Report : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InternetActivityData_HashtagDetails_HashtagDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropForeignKey(
                name: "FK_InternetActivityData_HourActivityData_HourActivityDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HashtagDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropIndex(
                name: "IX_InternetActivityData_HourActivityDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropColumn(
                name: "HashtagDetailsId",
                table: "InternetActivityData");

            migrationBuilder.DropColumn(
                name: "HourActivityDetailsId",
                table: "InternetActivityData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HashtagDetailsId",
                table: "InternetActivityData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HourActivityDetailsId",
                table: "InternetActivityData",
                nullable: true);

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
                name: "FK_InternetActivityData_HashtagDetails_HashtagDetailsId",
                table: "InternetActivityData",
                column: "HashtagDetailsId",
                principalTable: "HashtagDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InternetActivityData_HourActivityData_HourActivityDetailsId",
                table: "InternetActivityData",
                column: "HourActivityDetailsId",
                principalTable: "HourActivityData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
