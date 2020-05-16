using Microsoft.EntityFrameworkCore.Migrations;

namespace MultipleContexts.Migrations
{
    public partial class intake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intakes_Courses_ToughtCourseCourseId",
                table: "Intakes");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubcription_Intakes_IntakeId",
                table: "StudentSubcription");

            migrationBuilder.DropForeignKey(
                name: "FK_Teaching_Intakes_IntakeId",
                table: "Teaching");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Intakes",
                table: "Intakes");

            migrationBuilder.RenameTable(
                name: "Intakes",
                newName: "CourseIntake");

            migrationBuilder.RenameIndex(
                name: "IX_Intakes_ToughtCourseCourseId",
                table: "CourseIntake",
                newName: "IX_CourseIntake_ToughtCourseCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseIntake",
                table: "CourseIntake",
                column: "IntakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseIntake_Courses_ToughtCourseCourseId",
                table: "CourseIntake",
                column: "ToughtCourseCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubcription_CourseIntake_IntakeId",
                table: "StudentSubcription",
                column: "IntakeId",
                principalTable: "CourseIntake",
                principalColumn: "IntakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teaching_CourseIntake_IntakeId",
                table: "Teaching",
                column: "IntakeId",
                principalTable: "CourseIntake",
                principalColumn: "IntakeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseIntake_Courses_ToughtCourseCourseId",
                table: "CourseIntake");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubcription_CourseIntake_IntakeId",
                table: "StudentSubcription");

            migrationBuilder.DropForeignKey(
                name: "FK_Teaching_CourseIntake_IntakeId",
                table: "Teaching");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseIntake",
                table: "CourseIntake");

            migrationBuilder.RenameTable(
                name: "CourseIntake",
                newName: "Intakes");

            migrationBuilder.RenameIndex(
                name: "IX_CourseIntake_ToughtCourseCourseId",
                table: "Intakes",
                newName: "IX_Intakes_ToughtCourseCourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Intakes",
                table: "Intakes",
                column: "IntakeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Intakes_Courses_ToughtCourseCourseId",
                table: "Intakes",
                column: "ToughtCourseCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubcription_Intakes_IntakeId",
                table: "StudentSubcription",
                column: "IntakeId",
                principalTable: "Intakes",
                principalColumn: "IntakeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teaching_Intakes_IntakeId",
                table: "Teaching",
                column: "IntakeId",
                principalTable: "Intakes",
                principalColumn: "IntakeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
