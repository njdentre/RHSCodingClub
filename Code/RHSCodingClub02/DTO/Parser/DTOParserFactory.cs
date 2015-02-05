using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DTO.Parser
{
    internal static class DTOParserFactory
    {
        internal static DTOParser GetParser(Type dType)
        {
            string typeName = dType.Name;
            if (string.Equals(typeName, typeof(StudentDTO).Name, StringComparison.OrdinalIgnoreCase))
            {
                return new StudentDTOParser();
            }

            throw new ArgumentException("Unknown DTO Type.  Check DTOParserFactory.");
        }
    }
}
