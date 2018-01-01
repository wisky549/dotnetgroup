using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DNG.Repository.EF.Migrations
{
    public partial class query2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Next",
                table: "Queries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Query",
                table: "Queries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Next",
                table: "Queries");

            migrationBuilder.DropColumn(
                name: "Query",
                table: "Queries");
        }
    }
}
