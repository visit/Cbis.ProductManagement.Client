using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    using System.ServiceModel.Channels;

    public class ProductReference
    {
        public ProductReference(string name, IEnumerable<Generated.ReferenceName> referenceNames)
        {
            this.Name = name;
            this.ReferenceNames = new List<ReferenceName>();

            foreach (var rf in referenceNames)
            {
                this.ReferenceNames.Add(new ReferenceName(rf.SubSystem, rf.LocalName));
            }
        }

        public List<ReferenceName> ReferenceNames { get; set; }

        public string Name { get; set; }
    }
}
