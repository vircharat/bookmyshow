using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTheShowDAL.Migrations
{
    public partial class moviedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moviesv",
                columns: table => new
                {
                    MovievId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovievName = table.Column<string>(nullable: true),
                    MovievDesc = table.Column<string>(nullable: true),
                    MovievType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moviesv", x => x.MovievId);
                });

            migrationBuilder.CreateTable(
                name: "theatresv",
                columns: table => new
                {
                    TheatrevId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheatrevName = table.Column<string>(nullable: true),
                    TheatrevAddress = table.Column<string>(nullable: true),
                    TheatrevComments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theatresv", x => x.TheatrevId);
                });

            migrationBuilder.CreateTable(
                name: "showtimingsv",
                columns: table => new
                {
                    ShowvId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovievId = table.Column<int>(nullable: false),
                    TheatrevId = table.Column<int>(nullable: false),
                    ShowTimevv = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_showtimingsv", x => x.ShowvId);
                    table.ForeignKey(
                        name: "FK_showtimingsv_moviesv_MovievId",
                        column: x => x.MovievId,
                        principalTable: "moviesv",
                        principalColumn: "MovievId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_showtimingsv_theatresv_TheatrevId",
                        column: x => x.TheatrevId,
                        principalTable: "theatresv",
                        principalColumn: "TheatrevId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_showtimingsv_MovievId",
                table: "showtimingsv",
                column: "MovievId");

            migrationBuilder.CreateIndex(
                name: "IX_showtimingsv_TheatrevId",
                table: "showtimingsv",
                column: "TheatrevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "showtimingsv");

            migrationBuilder.DropTable(
                name: "moviesv");

            migrationBuilder.DropTable(
                name: "theatresv");
        }
    }
}
