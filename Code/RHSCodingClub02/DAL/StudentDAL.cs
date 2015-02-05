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
        public static List<StudentDTO> SearchStudent()
        {
            SqlCommand sqlCmd = GetStoredProcCommand("StudentSearch");

            List<StudentDTO> searchResults = GetDTOList<StudentDTO>(ref sqlCmd);

            return searchResults;
        }
    }
}
