using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DTO
{
    public class StudentDTO : DTOBase
    {
        private int m_Id;
        private string m_firstName;
        private string m_lastName;
        private int m_isDeleted;

        public StudentDTO()
        {
            this.isNew = true;
            this.m_Id = Int_NullValue;
            this.m_firstName = String_NullValue;
            this.m_lastName = String_NullValue;
            this.m_isDeleted = Int_NullValue;
        }

        public int Id
        {
            get { return this.m_Id; }
            set { this.m_Id = value; }
        }

        public string firstName
        {
            get { return this.m_firstName; }
            set { this.m_firstName = value; }
        }

        public string lastName
        {
            get { return this.m_lastName; }
            set { this.m_lastName = value; }
        }

        public int isDeleted
        {
            get { return this.m_isDeleted; }
            set { this.m_isDeleted = value; }
        }
    }
}
