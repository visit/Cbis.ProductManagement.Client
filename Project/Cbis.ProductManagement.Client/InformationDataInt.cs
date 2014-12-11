using System.Globalization;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Represents informationdata which value is an <see cref="int"/>.
    /// </summary>
    public class InformationDataInt : InformationData
    {
        public InformationDataInt(CultureInfo language, int attributeId, int value) : base(language, attributeId)
        {
            Value = value;
        }

        public int Value { get; private set; }

        internal override Generated.InformationData Create()
        {
            return new Generated.InformationDataInt()
            {
                AttributeId = AttributeId,
                Culture = Language.Name,
                Value = Value
            };
        }

        public override bool Equals(object obj)
        {
            InformationDataInt d = obj as InformationDataInt;

            return base.Equals(d) && d.Value == Value;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Value.GetHashCode();
        }

    }
}