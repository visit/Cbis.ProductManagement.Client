using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    public class ProductReferenceSetResult
    {
        public ProductReferenceSetResult(
            IEnumerable<ReferenceName> addedReferences,
            IEnumerable<ReferenceName> removedReferences)
        {
            if (addedReferences == null)
            {
                throw new ArgumentNullException("addedReferences");
            }

            if (removedReferences == null)
            {
                throw new ArgumentNullException("removedReferences");
            }

            AddedReferences = new List<ReferenceName>(addedReferences).AsReadOnly();
            RemovedReferences = new List<ReferenceName>(removedReferences).AsReadOnly();
        }

        public IList<ReferenceName> AddedReferences { get; private set; }

        public IList<ReferenceName> RemovedReferences { get; private set; }
    }
}
