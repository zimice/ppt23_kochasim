﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ppt.Api.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vybavenis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PriceCzk = table.Column<int>(type: "INTEGER", nullable: false),
                    BoughtDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastRevisionDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vybavenis", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vybavenis");
        }
    }
}
