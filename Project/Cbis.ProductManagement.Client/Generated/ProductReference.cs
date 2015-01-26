using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client.Generated
{
    public partial class ReferenceName
    {
        [Obsolete("For serialization purposes.")]
        public ReferenceName()
        {
        }

        public ReferenceName(Client.ReferenceName reference)
        {
            if (reference == null)
            {
                throw new ArgumentNullException("reference");
            }

            this.SubSystem = reference.SubSystem;
            this.LocalName = reference.LocalName;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", SubSystem, LocalName);
        }
    }
}
