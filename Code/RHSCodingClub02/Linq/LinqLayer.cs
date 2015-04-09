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
    }
}
