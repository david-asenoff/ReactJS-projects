﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesWebApi.Data.Migrations
{
    public partial class AddPictureUrlToJoke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Jokes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Jokes");
        }
    }
}
