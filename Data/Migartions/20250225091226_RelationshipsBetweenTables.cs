using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment.Data.Migartions
{
    /// <inheritdoc />
    public partial class RelationshipsBetweenTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropColumn(
                name: "Ins_ID",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Dep_ID",
                table: "students",
                newName: "dep_id");

            migrationBuilder.RenameColumn(
                name: "Course_ID",
                table: "StudentCourse",
                newName: "course_Id");

            migrationBuilder.RenameColumn(
                name: "Stud_ID",
                table: "StudentCourse",
                newName: "Student_Id");

            migrationBuilder.RenameColumn(
                name: "dep_id",
                table: "Instructors",
                newName: "Department_Id");

            migrationBuilder.RenameColumn(
                name: "Topic_ID",
                table: "courses",
                newName: "Topic_Id");

            migrationBuilder.RenameColumn(
                name: "course_ID",
                table: "CourseInstructor",
                newName: "course_Id");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "CourseInstructor",
                newName: "Instructor_Id");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "StudentCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "CourseInstructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "CourseInstructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "Student_Id", "course_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_students_dep_id",
                table: "students",
                column: "dep_id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_courseId",
                table: "StudentCourse",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Department_Id",
                table: "Instructors",
                column: "Department_Id");

            migrationBuilder.CreateIndex(
                name: "IX_courses_Topic_Id",
                table: "courses",
                column: "Topic_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_courseId",
                table: "CourseInstructor",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_Instructors_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_courses_courseId",
                table: "CourseInstructor",
                column: "courseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_Topics_Topic_Id",
                table: "courses",
                column: "Topic_Id",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Department_Id",
                table: "Instructors",
                column: "Department_Id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_courses_courseId",
                table: "StudentCourse",
                column: "courseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_students_Departments_dep_id",
                table: "students",
                column: "dep_id",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_Instructors_InstructorId",
                table: "CourseInstructor");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_courses_courseId",
                table: "CourseInstructor");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_Topics_Topic_Id",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Department_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_courses_courseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_students_Departments_dep_id",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_dep_id",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_courseId",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourse_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Department_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_courses_Topic_Id",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructor_courseId",
                table: "CourseInstructor");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentCourse");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "StudentCourse");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseInstructor");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "CourseInstructor");

            migrationBuilder.RenameColumn(
                name: "dep_id",
                table: "students",
                newName: "Dep_ID");

            migrationBuilder.RenameColumn(
                name: "course_Id",
                table: "StudentCourse",
                newName: "Course_ID");

            migrationBuilder.RenameColumn(
                name: "Student_Id",
                table: "StudentCourse",
                newName: "Stud_ID");

            migrationBuilder.RenameColumn(
                name: "Department_Id",
                table: "Instructors",
                newName: "dep_id");

            migrationBuilder.RenameColumn(
                name: "Topic_Id",
                table: "courses",
                newName: "Topic_ID");

            migrationBuilder.RenameColumn(
                name: "course_Id",
                table: "CourseInstructor",
                newName: "course_ID");

            migrationBuilder.RenameColumn(
                name: "Instructor_Id",
                table: "CourseInstructor",
                newName: "Ins_ID");

            migrationBuilder.AddColumn<int>(
                name: "Ins_ID",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "Course_ID", "Stud_ID" });
        }
    }
}
