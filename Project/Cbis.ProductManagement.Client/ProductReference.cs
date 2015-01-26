using System.Collections.Generic;

namespace Cbis.ProductManagement.Client
{
    public class ProductReference
    {
        public ProductReference(string name, IEnumerable<Client.ReferenceName> referenceNames)
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
