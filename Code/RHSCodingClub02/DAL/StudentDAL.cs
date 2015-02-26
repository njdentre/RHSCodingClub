using RHSCodingClub02.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DAL
{
    public class StudentDAL : DALBase
    {
        public static DataTable SearchStudent()
        {
            SqlCommand sqlCmd = GetStoredProcCommand("StudentSearch");
            sqlCmd.Parameters.AddWithValue("@QueryType", "ALL");

            List<StudentDTO> searchResults = GetDTOList<StudentDTO>(ref sqlCmd);

            DataTable dtStudents = new DataTable("Students");
            dtStudents.Columns.Add("Id");
            dtStudents.Columns.Add("First Name");
            dtStudents.Columns.Add("Last Name");
            dtStudents.Columns.Add("isDeleted");

            foreach (StudentDTO student in searchResults)
            {
                dtStudents.Rows.Add(student.Id, student.firstName, student.lastName, student.isDeleted);
            }

            return dtStudents;
        }
    }
}
