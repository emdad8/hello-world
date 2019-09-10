using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Organization
    {
        public int OrganizationId { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string OrganizationName { get; set; }

        public Organization(int Id,string Addr, string tin,string OName)
        {
            this.OrganizationId = Id;
            this.Address = Addr;
            this.OrganizationName = OName;
            this.TIN = tin;
        }


       // number of Affiliations


        // business sector

        // partners

        // business locations
    }
}
