using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cbis.ProductManagement.Client.Generated;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Represents a location of an image resource.
    /// </summary>
    public class ImageData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageData"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <exception cref="System.ArgumentNullException">location was null</exception>
        public ImageData(Uri location)
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            Location = location;
        }

        /// <summary>
        /// Gets the location of the image resource.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public Uri Location { get; private set; }

        /// <summary>
        /// Creates a <see cref="MediaInformationData"/> out of this instance..
        /// </summary>
        /// <returns></returns>
        public Generated.MediaInformationData Create()
        {
            return new MediaInformationData()
            {
               Location = this.Location,
               MediaType = MediaType.Image
            };
        }
    }
}
