using System.CodeDom.Compiler;
using System.Globalization;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Represents a bool data value
    /// </summary>
    public class InformationDataBool : InformationData
    {
        public InformationDataBool(CultureInfo language, int attributeId, bool value)
            : base(language, attributeId)
        {
            Value = value;
        }

        public bool Value { get; private set; }

        internal override Generated.InformationData Create()
        {
            return new Generated.InformationDataBoolean()
            {
                AttributeId = AttributeId,
                Culture = Language.Name,
                Value = Value
            };
        }

        public override bool Equals(object obj)
        {
            InformationDataBool b = obj as InformationDataBool;

            return base.Equals(b) && b.Value == Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Value.GetHashCode();
        }
    }
}