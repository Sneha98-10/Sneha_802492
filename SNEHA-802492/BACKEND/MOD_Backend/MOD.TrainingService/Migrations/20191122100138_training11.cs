﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TrainingService.Migrations
{
    public partial class training11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mname = table.Column<string>(nullable: true),
                    Mmail = table.Column<string>(nullable: true),
                    Mnumber = table.Column<long>(nullable: false),
                    Mpassword = table.Column<string>(nullable: true),
                    Mskills = table.Column<string>(nullable: true),
                    Mexperience = table.Column<int>(nullable: false),
                    Mtimeslot = table.Column<string>(nullable: true),
                    Mavailability = table.Column<bool>(nullable: false),
                    Mactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mid);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(nullable: true),
                    STOC = table.Column<string>(nullable: true),
                    Sfee = table.Column<double>(nullable: false),
                    Sduration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uname = table.Column<string>(nullable: true),
                    Umail = table.Column<string>(nullable: true),
                    Unumber = table.Column<long>(nullable: false),
                    Upassword = table.Column<string>(nullable: true),
                    Uactive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uid = table.Column<int>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    Mid = table.Column<int>(nullable: false),
                    Mentor_Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pid);
                    table.ForeignKey(
                        name: "FK_Payment_Mentor_Mid",
                        column: x => x.Mid,
                        principalTable: "Mentor",
                        principalColumn: "Mid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_User_Uid",
                        column: x => x.Uid,
                        principalTable: "User",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_Mid",
                table: "Training",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Sid",
                table: "Training",
                column: "Sid");

            migrationBuilder.CreateIndex(
                name: "IX_Training_Uid",
                table: "Training",
                column: "Uid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Mid",
                table: "Payment",
                column: "Mid");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_Uid",
                table: "Payment",
                column: "Uid");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentor_Mid",
                table: "Training",
                column: "Mid",
                principalTable: "Mentor",
                principalColumn: "Mid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Skills_Sid",
                table: "Training",
                column: "Sid",
                principalTable: "Skills",
                principalColumn: "Sid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_User_Uid",
                table: "Training",
                column: "Uid",
                principalTable: "User",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentor_Mid",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Skills_Sid",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_User_Uid",
                table: "Training");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Training_Mid",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_Sid",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_Uid",
                table: "Training");
        }
    }
}
