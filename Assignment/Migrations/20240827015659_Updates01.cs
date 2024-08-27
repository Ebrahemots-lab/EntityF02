using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    public partial class Updates01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dept_Id",
                table: "instructors",
                newName: "WorkForDept");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "TopicId");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Student_Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Student_Course",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "instructors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Cairo",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Cairo");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Manger_Id",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Course_Inst",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_CourseId",
                table: "Student_Course",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Course_StudentId",
                table: "Student_Course",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_DeptId",
                table: "instructors",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_instructors_WorkForDept",
                table: "instructors",
                column: "WorkForDept");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Manger_Id",
                table: "Departments",
                column: "Manger_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseId",
                table: "Course_Inst",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Courses_CourseId",
                table: "Course_Inst",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_instructors_Manger_Id",
                table: "Departments",
                column: "Manger_Id",
                principalTable: "instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_DeptId",
                table: "instructors",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_Departments_WorkForDept",
                table: "instructors",
                column: "WorkForDept",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_Courses_CourseId",
                table: "Student_Course",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Course_Students_StudentId",
                table: "Student_Course",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students",
                column: "DeptId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Courses_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_instructors_Manger_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_DeptId",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_Departments_WorkForDept",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_Courses_CourseId",
                table: "Student_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Course_Students_StudentId",
                table: "Student_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Student_Course_CourseId",
                table: "Student_Course");

            migrationBuilder.DropIndex(
                name: "IX_Student_Course_StudentId",
                table: "Student_Course");

            migrationBuilder.DropIndex(
                name: "IX_instructors_DeptId",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_instructors_WorkForDept",
                table: "instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Manger_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_CourseId",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Student_Course");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Student_Course");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "instructors");

            migrationBuilder.DropColumn(
                name: "Manger_Id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "WorkForDept",
                table: "instructors",
                newName: "Dept_Id");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                table: "instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Cairo",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Cairo");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
