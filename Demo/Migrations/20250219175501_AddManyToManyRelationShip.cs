using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse");
        }
    }
}
