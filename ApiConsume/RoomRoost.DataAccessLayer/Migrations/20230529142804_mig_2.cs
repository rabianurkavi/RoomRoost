﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomRoost.DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TesminonialTitle",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TesminonialTitle",
                table: "Testimonials");
        }
    }
}
