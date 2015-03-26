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
            //update a student record by updating its first and last name
            Student student = db.Students.Single(s => s.Id.Equals(id));
            student.firstName = firstName;
            student.lastName = lastName;
            db.SubmitChanges();
        }
    }
}
