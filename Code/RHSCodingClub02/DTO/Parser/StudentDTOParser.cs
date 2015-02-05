using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DTO.Parser
{
    class StudentDTOParser : DTOParser
    {
        private int m_IdOrdinal;
        private int m_firstNameOrdinal;
        private int m_lastNameOrdinal;
        private int m_isDeletedOrdinal;

        public override DTOBase PopulateDTO(System.Data.SqlClient.SqlDataReader sqlReader)
        {
            StudentDTO studentDTO = new StudentDTO();
            studentDTO.isNew = false;

            if (!sqlReader.IsDBNull(this.m_IdOrdinal))
            {
                studentDTO.Id = sqlReader.GetInt32(this.m_IdOrdinal);
            }

            if (!sqlReader.IsDBNull(this.m_firstNameOrdinal))
            {
                studentDTO.firstName = sqlReader.GetString(this.m_firstNameOrdinal);
            }

            if (!sqlReader.IsDBNull(this.m_lastNameOrdinal))
            {
                studentDTO.lastName = sqlReader.GetString(this.m_lastNameOrdinal);
            }

            if (!sqlReader.IsDBNull(this.m_isDeletedOrdinal))
            {
                studentDTO.isDeleted = sqlReader.GetInt32(this.m_isDeletedOrdinal);
            }

            return studentDTO;
        }

        public override void PopulateOrdinals(System.Data.SqlClient.SqlDataReader sqlReader)
        {
            this.m_IdOrdinal = sqlReader.GetOrdinal("Id");
            this.m_firstNameOrdinal = sqlReader.GetOrdinal("firstName");
            this.m_lastNameOrdinal = sqlReader.GetOrdinal("lastName");
            this.m_isDeletedOrdinal = sqlReader.GetOrdinal("isDeleted");
        }
    }
}
