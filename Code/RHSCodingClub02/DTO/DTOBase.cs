using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSCodingClub02.DTO
{
    public abstract class DTOBase : CommonBase
    {
        private bool m_isNew;

        public bool isNew
        { 
            get { return m_isNew; }
            set { this.m_isNew = value; }
        }
    }
}
