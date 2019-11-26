using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.AuthenticateService.Migrations
{
    public partial class @as : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
