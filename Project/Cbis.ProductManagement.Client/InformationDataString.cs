using System.Globalization;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Represents information data which value is of the type <see cref="string"/>.
    /// </summary>
    public class InformationDataString : InformationData
    {
        public InformationDataString(CultureInfo language, int attributeId, string value)
            : base(language, attributeId)
        {
            Value = value;
        }

        public string Value { get; private set; }

        internal override Generated.InformationData Create()
        {
            return new Generated.InformationDataString()
            {
                AttributeId = AttributeId,
                Culture = Language.Name,
                Value = Value
            };
        }

        public override bool Equals(object obj)
        {
            InformationDataInt d = obj as InformationDataInt;

            return base.Equals(d) && d.Value.Equals(Value);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Value.GetHashCode();
        }

    }
}