using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SingleContextWithAggregateRoots.DataLayer.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CenterEvents",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Desciption = table.Column<string>(nullable: true),
                    Agenda = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CenterEvents", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "CourseEvaluation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstructorRating = table.Column<int>(nullable: false),
                    CenterRating = table.Column<int>(nullable: false),
                    ContentRating = table.Column<int>(nullable: false),
                    ToolsRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseEvaluation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(nullable: true),
                    CourseDays = table.Column<int>(nullable: false),
                    CourseDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentEvaluation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attendence = table.Column<int>(nullable: false),
                    CourseWork = table.Column<int>(nullable: false),
                    Assignments = table.Column<int>(nullable: false),
                    GraduationProject = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEvaluation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    Location = table.Column<Guid>(nullable: false),
                    ImageDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Image_CenterEvents_EventId",
                        column: x => x.EventId,
                        principalTable: "CenterEvents",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Intakes",
                columns: table => new
                {
                    IntakeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToughtCourseCourseId = table.Column<int>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    ClassDays = table.Column<string>(nullable: true),
                    ClassTime = table.Column<int>(nullable: false),
                    EventLocation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intakes", x => x.IntakeId);
                    table.ForeignKey(
                        name: "FK_Intakes_Courses_ToughtCourseCourseId",
                        column: x => x.ToughtCourseCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    LessonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonName = table.Column<string>(nullable: true),
                    LessonDescription = table.Column<string>(nullable: true),
                    MainCourseCourseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lesson_Courses_MainCourseCourseId",
                        column: x => x.MainCourseCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    MainDepartmentDepartmentId = table.Column<int>(nullable: true),
                    FixedSalary = table.Column<decimal>(nullable: true),
                    HourRate = table.Column<int>(nullable: true),
                    Skills = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Departments_MainDepartmentDepartmentId",
                        column: x => x.MainDepartmentDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentSubcription",
                columns: table => new
                {
                    IntakeId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Payed = table.Column<decimal>(nullable: false),
                    CourseScoreId = table.Column<int>(nullable: true),
                    StudentEvaluationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSubcription", x => new { x.IntakeId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StudentSubcription_StudentEvaluation_CourseScoreId",
                        column: x => x.CourseScoreId,
                        principalTable: "StudentEvaluation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubcription_Intakes_IntakeId",
                        column: x => x.IntakeId,
                        principalTable: "Intakes",
                        principalColumn: "IntakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentSubcription_CourseEvaluation_StudentEvaluationId",
                        column: x => x.StudentEvaluationId,
                        principalTable: "CourseEvaluation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentSubcription_Users_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teaching",
                columns: table => new
                {
                    IntakeId = table.Column<int>(nullable: false),
                    InstructorId = table.Column<int>(nullable: false),
                    ReceivedPayment = table.Column<decimal>(nullable: false),
                    InstructorCurrentRole = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teaching", x => new { x.IntakeId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_Teaching_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teaching_Intakes_IntakeId",
                        column: x => x.IntakeId,
                        principalTable: "Intakes",
                        principalColumn: "IntakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intakes_ToughtCourseCourseId",
                table: "Intakes",
                column: "ToughtCourseCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_MainCourseCourseId",
                table: "Lesson",
                column: "MainCourseCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubcription_CourseScoreId",
                table: "StudentSubcription",
                column: "CourseScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubcription_StudentEvaluationId",
                table: "StudentSubcription",
                column: "StudentEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubcription_StudentId",
                table: "StudentSubcription",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teaching_InstructorId",
                table: "Teaching",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MainDepartmentDepartmentId",
                table: "Users",
                column: "MainDepartmentDepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "StudentSubcription");

            migrationBuilder.DropTable(
                name: "Teaching");

            migrationBuilder.DropTable(
                name: "CenterEvents");

            migrationBuilder.DropTable(
                name: "StudentEvaluation");

            migrationBuilder.DropTable(
                name: "CourseEvaluation");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Intakes");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
