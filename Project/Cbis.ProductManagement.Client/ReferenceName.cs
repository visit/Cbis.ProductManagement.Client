using System;

namespace Cbis.ProductManagement.Client
{
    using System.ServiceModel;

    /// <summary>
    /// Describes a reference name that is used with Cbis. Normally on the form cb:123 where cb is the sub system reference name. and the 123 is the id in that system.
    /// <para>
    /// If you don't know your local sub system, contact the Cbis team.
    /// </para>
    /// </summary>
    public class ReferenceName : IComparable
    {
        public ReferenceName(string complexId)
        {
            if (complexId == null)
            {
                throw new ArgumentNullException("complexId");
            }

            string[] splits = complexId.Split(new char[] {':'});
            if (splits.Length != 2)
            {
                throw new ArgumentOutOfRangeException("complexId", complexId, "Not on the format <system>:<id>");
            }

            if (!IsOkName(splits[0]))
            {
                throw new ArgumentOutOfRangeException("complexId", complexId, "sub system contained invalid chars");
            }

            if (!IsOkName(splits[1]))
            {
                throw new ArgumentOutOfRangeException("complexId", complexId, "id contained invalid chars");
            }

            SubSystem = splits[0];
            LocalName = splits[1];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceName"/> class.
        /// </summary>
        /// <param name="subSystem">The sub system acronym. If you don't know your system acronym, contact the Cbis-team.</param>
        /// <param name="localName">Local id represented as a string. Normally (but not limited to) an int</param>
        public ReferenceName(string subSystem, string localName)
        {
            if (string.IsNullOrEmpty(subSystem))
            {
                throw new ArgumentNullException("subSystem");
            }

            if (string.IsNullOrEmpty(localName))
            {
                throw new ArgumentNullException(localName);
            }

            if (subSystem.IndexOf(':') >= 0)
            {
                throw new ArgumentOutOfRangeException("subSystem", subSystem, "May not contain \":\"");
            }

            if (!IsOkName(subSystem))
            {
                throw new ArgumentOutOfRangeException("subSystem", subSystem, "Must not contain any of the chars: \"" + new string(InvalidChars) + "\"");
            }

            if(!IsOkName(localName))
            {
                throw new ArgumentOutOfRangeException("subSystem", localName, "Must not contain any of the chars: \"" + new string(InvalidChars) + "\"");
            }

            if (subSystem.Length + localName.Length > 39)
            {
                throw new ArgumentOutOfRangeException("subSystem", subSystem + ":" + localName, "Name was too many chars. MaxLength is 39");
            }

            SubSystem = subSystem;
            LocalName = localName;
        }

        private static readonly char[] InvalidChars = new[] { ':', ' ' };

        private bool IsOkName(string name)
        {
            return name.IndexOfAny(InvalidChars) < 0;
        }

        /// <summary>
        /// Gets the sub system acronym.
        /// </summary>
        /// <value>
        /// The sub system.
        /// </value>
        public string SubSystem { get; private set; }

        /// <summary>
        /// Gets the id of the local system.
        /// </summary>
        /// <value>
        /// The name of the local.
        /// </value>
        public string LocalName { get; private set; }

        /// <summary>
        /// Gets the name of the referenc that will be used with the Cbis.
        /// </summary>
        /// <value>
        /// The name of the referenc.
        /// </value>
        public string Name
        {
            get { return string.Format("{0}:{1}", SubSystem, LocalName); }
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            ReferenceName name = obj as ReferenceName;

            return name != null && name.SubSystem.Equals(SubSystem) && name.LocalName.Equals(LocalName);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return SubSystem.GetHashCode() ^ LocalName.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }

            ReferenceName name = obj as ReferenceName;

            if (name == null)
            {
                throw new ArgumentOutOfRangeException("obj", obj, "Can only be compared to ReferenceName");
            }

            int ret = SubSystem.CompareTo(name.SubSystem);
            return ret != 0 ? ret : LocalName.CompareTo(name.SubSystem);
        }

        internal Generated.ReferenceName CreateContractReferenceName()
        {
            return new Generated.ReferenceName(this);
        }
    }
}
