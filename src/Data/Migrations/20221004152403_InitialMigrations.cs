using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreCodeCamp.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks");

            migrationBuilder.AlterColumn<int>(
                name: "CampId",
                table: "Talks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "CampId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks");

            migrationBuilder.AlterColumn<int>(
                name: "CampId",
                table: "Talks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Talks_Camps_CampId",
                table: "Talks",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "CampId");
        }
    }
}
