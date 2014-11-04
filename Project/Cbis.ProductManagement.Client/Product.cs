using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    public class Product
    {
        public Product(ReferenceName productReference, List<InformationData> informationData, List<Occasion> occasions, List<ImageData> images)
        {
            this.Reference = productReference;
            this.InformationData = informationData;
            this.Occasions = occasions;
            this.Images = images;
        }

        public ReferenceName Reference { get; set; }

        public List<InformationData> InformationData { get; set; }

        public List<Occasion> Occasions { get; set; }

        public List<ImageData> Images { get; set; }
    }
}
