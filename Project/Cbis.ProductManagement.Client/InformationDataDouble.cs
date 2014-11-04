﻿using System.CodeDom.Compiler;
using System.Globalization;

namespace Cbis.ProductManagement.Client
{
    public class InformationDataDouble : InformationData
    {
        public InformationDataDouble(CultureInfo language, int attributeId, double value)
            : base(language, attributeId)
        {
            Value = value;
        }

        public double Value { get; private set; }

        internal override Generated.InformationData Create()
        {
            return new Generated.InformationDataDouble()
            {
                AttributeId = AttributeId,
                Culture = Language.Name,
                Value = Value
            };
        }

        public override bool Equals(object obj)
        {
            InformationDataDouble d = obj as InformationDataDouble;

            return base.Equals(d) && d.Value == Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Value.GetHashCode();
        }
    }
}