using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.Linq
{
    public class LinqLayer
    {
        private static RHSCodingClubDataContext db = new RHSCodingClubDataContext();

        #region Student Methods

        public static DataTable GetAllStudents()
        {
            //get all student records where that are not flagged as deleted (0)
            var students = from s in db.Students where s.isDeleted.Equals(0) select new { s.Id, s.firstName, s.lastName, s.isDeleted };

            DataTable dtStudents = new DataTable("Students");
            dtStudents.Columns.Add("Id");
            dtStudents.Columns.Add("First Name");
            dtStudents.Columns.Add("Last Name");
            dtStudents.Columns.Add("isDeleted");

            foreach (var student in students)
            {
                dtStudents.Rows.Add(student.Id, student.firstName, student.lastName, student.isDeleted);
            }

            return dtStudents;
        }

        public static void AddStudent(string firstName, string lastName)
        {
            //add a new student record by suppling the firstname and lastname
            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            db.Students.InsertOnSubmit(student);
            db.SubmitChanges();
        }

        public static void DeleteStudent(int id)
        {
            //delete a student by setting its isDeleted flag to 1
            Student student = db.Students.Single(s => s.Id.Equals(id));
            student.isDeleted = 1;
            db.SubmitChanges();
        }

        public static void UpdateStudentName(int id, string firstName, string lastName)
        {
            bool submitChange = false;
            //update a student record by updating its first and/or last name
            Student student = db.Students.Single(s => s.Id.Equals(id));
            if (student.firstName != firstName)
            {
                student.firstName = firstName;
                submitChange = true;
            }
            if (student.lastName != lastName)
            {
                student.lastName = lastName;
                submitChange = true;
            }
            if (submitChange)
            {
                db.SubmitChanges();
            }
        }

        #endregion

        #region Course Methods

        public static DataTable GetAllCourses()
        {
            //get all student records where that are not flagged as deleted (0)
            var courses = from c in db.Courses where c.isDeleted.Equals(0) select new { c.Id, c.name, c.level, c.isDeleted };

            DataTable dtCourses = new DataTable("Courses");
            dtCourses.Columns.Add("Id");
            dtCourses.Columns.Add("Course Name");
            dtCourses.Columns.Add("Level");
            dtCourses.Columns.Add("isDeleted");

            foreach (var course in courses)
            {
                dtCourses.Rows.Add(course.Id, course.name, course.level, course.isDeleted);
            }

            return dtCourses;
        }

        public static void AddCourse(string name, string level)
        {
            //add a new course record by suppling the course name and level
            Course course = new Course();
            course.name = name;
            course.level = level;
            db.Courses.InsertOnSubmit(course);
            db.SubmitChanges();
        }

        public static void DeleteCourse(int id)
        {
            //delete a course by setting its isDeleted flag to 1
            Course course = db.Courses.Single(c => c.Id.Equals(id));
            course.isDeleted = 1;
            db.SubmitChanges();
        }

        public static void UpdateCourse(int id, string name, string level)
        {
            bool submitChange = false;
            //update a course record by updating its course name and/or level
            Course course = db.Courses.Single(c => c.Id.Equals(id));
            if (course.name != name)
            {
                course.name = name;
                submitChange = true;
            }
            if (course.level != level)
            {
                course.level = level;
                submitChange = true;
            }
            if (submitChange)
            {
                db.SubmitChanges();
            }
        }

        #endregion

        #region Student Course Methods

        public static DataTable GetAllStudentCourses()
        {
            //get all student course records that are not deleted (isDeleted = 0)
            var studentCourses = from sc in db.StudentCourses
                                 join s in db.Students on sc.studentId equals s.Id
                                 join c in db.Courses on sc.courseId equals c.Id
                                 where sc.isDeleted.Equals(0)
                                 select new
                                 {
                                     StudentCourseId = sc.Id,
                                     StudentId = s.Id,
                                     StudentName = s.firstName + " " + s.lastName,
                                     CourseId = c.Id,
                                     CourseLevel = c.name + " (" + c.level + ")",
                                     Mark = sc.finalGrade,
                                     sc.isDeleted
                                 };

            DataTable dtStudentCourses = new DataTable("StudentCourses");
            dtStudentCourses.Columns.Add("StudentCourseId");
            dtStudentCourses.Columns.Add("StudentId");
            dtStudentCourses.Columns.Add("Student Name");
            dtStudentCourses.Columns.Add("CourseId");
            dtStudentCourses.Columns.Add("Course (Level)");
            dtStudentCourses.Columns.Add("Mark");
            dtStudentCourses.Columns.Add("isDeleted");

            foreach (var studentCourse in studentCourses)
            {
                dtStudentCourses.Rows.Add(studentCourse.StudentCourseId, studentCourse.StudentId, studentCourse.StudentName, studentCourse.CourseId, studentCourse.CourseLevel, studentCourse.Mark, studentCourse.isDeleted);
            }

            return dtStudentCourses;
        }

        public static void AddStudentCourse(int studentId, int courseId, int mark)
        {
            //add a new student course record by suppling the student id, course id and mark
            StudentCourse studentCourse = new StudentCourse();
            studentCourse.studentId = studentId;
            studentCourse.courseId = courseId;
            studentCourse.finalGrade = mark;
            db.StudentCourses.InsertOnSubmit(studentCourse);
            db.SubmitChanges();
        }

        public static void UpdateStudentCourse(int studentCourseId, int studentId, int courseId, int mark)
        {
            bool submitChange = false;
            //update a student course
            StudentCourse studentCourse = db.StudentCourses.Single(sc => sc.Id.Equals(studentCourseId));
            if (studentCourse.studentId != studentId)
            {
                studentCourse.studentId = studentId;
                submitChange = true;
            }
            if (studentCourse.courseId != courseId)
            {
                studentCourse.courseId = courseId;
                submitChange = true;
            }
            if (studentCourse.finalGrade != mark)
            {
                studentCourse.finalGrade = mark;
                submitChange = true;
            }
            if (submitChange)
            {
                db.SubmitChanges();
            }
        }

        public static void DeleteStudentCourse(int studentCourseId)
        {
            //delete a student course by setting its isDeleted flag to 1
            StudentCourse studentCourse = db.StudentCourses.Single(sc => sc.Id.Equals(studentCourseId));
            studentCourse.isDeleted = 1;
            db.SubmitChanges();
        }

        public static DataTable GetStudentComboList()
        {
            //get all student records where that are not flagged as deleted (0)
            var students = from s in db.Students where s.isDeleted.Equals(0) select new { s.Id, StudentName = s.firstName + " " + s.lastName };

            DataTable dtStudentComboList = new DataTable("StudentComboList");
            dtStudentComboList.Columns.Add("Id");
            dtStudentComboList.Columns.Add("StudentName");

            foreach (var student in students)
            {
                dtStudentComboList.Rows.Add(student.Id, student.StudentName);
            }

            return dtStudentComboList;
        }

        public static DataTable GetCourseComboList()
        {
            //get all course records where that are not flagged as deleted (0)
            var courses = from c in db.Courses where c.isDeleted.Equals(0) select new { c.Id, NameLevel = c.name + " (" + c.level + ")" };

            DataTable dtCourseComboList = new DataTable("CourseComboList");
            dtCourseComboList.Columns.Add("Id");
            dtCourseComboList.Columns.Add("NameLevel");

            foreach (var course in courses)
            {
                dtCourseComboList.Rows.Add(course.Id, course.NameLevel);
            }

            return dtCourseComboList;
        }

        #endregion
    }
}
