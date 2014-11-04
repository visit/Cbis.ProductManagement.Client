using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client.Generated
{
    public partial class OrganizationReference
    {
        [Obsolete("Only for serialization purposes.")]
        public OrganizationReference()
        {
        }

        public OrganizationReference(Client.ReferenceName referenceName) 
            : base(referenceName)
        {
        }
    }
}
