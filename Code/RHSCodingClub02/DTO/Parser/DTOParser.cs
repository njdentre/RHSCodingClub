using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DTO.Parser
{
    public abstract class DTOParser
    {
        public abstract DTOBase PopulateDTO(SqlDataReader sqlReader);
        public abstract void PopulateOrdinals(SqlDataReader sqlReader);
    }
}
