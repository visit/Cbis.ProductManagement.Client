﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Representation of a data item containing attribute, language and culture and of course value. 
    /// </summary>
    /// <seealso cref="InformationDataBool"/>
    /// <seealso cref="InformationDataDouble"/>
    /// <seealso cref="InformationDataInt"/>
    /// <seealso cref="InformationDataString"/>
    public abstract class InformationData
    {
        protected InformationData(CultureInfo language, int attributeId)
        {
            if (language == null)
            {
                throw new ArgumentNullException("language");
            }
            
            if (attributeId <= 0)
            {
                throw new ArgumentOutOfRangeException("attributeId", attributeId, "Must be over zero");
            }

            Language = language;
            AttributeId = attributeId;
        }

        public CultureInfo Language { get; private set; }

        /// <summary>
        /// Gets the attribute identifier that uniquely describes which content is expected.
        /// </summary>
        /// <value>
        /// The attribute identifier.
        /// </value>
        public int AttributeId { get; private set; }

        internal abstract Generated.InformationData Create();

        public abstract override bool Equals(object obj);

        protected bool Equals(InformationData id)
        {
            return id != null && id.AttributeId == AttributeId && id.Language.Equals(Language);
        }

        public override int GetHashCode()
        {
            return AttributeId.GetHashCode() ^ Language.GetHashCode();
        }

        public abstract override string ToString();
    }
}
