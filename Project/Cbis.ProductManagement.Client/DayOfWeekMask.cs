using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Enables representing several day of weeks into a single enum.
    /// </summary>
    [Flags]
    public enum DayOfWeekMask
    {
        /// <summary>
        /// Sepecifes that this mask is not valid as a period defintion
        /// </summary>
        Exact = 0x0,

        /// <summary>
        /// The monday
        /// </summary>
        Monday = 0x01,

        /// <summary>
        /// The tuesday
        /// </summary>
        Tuesday = 0x02,

        /// <summary>
        /// The wednesday
        /// </summary>
        Wednesday = 0x04,

        /// <summary>
        /// The thursday
        /// </summary>
        Thursday = 0x08,

        /// <summary>
        /// The friday
        /// </summary>
        Friday = 0x10,

        /// <summary>
        /// The saturday
        /// </summary>
        Saturday = 0x20,

        /// <summary>
        /// The sunday
        /// </summary>
        Sunday = 0x40,

        /// <summary>
        /// Monday, Tuesday, Wednesday, Thursday, Friday, Saturday and Sunday.
        /// </summary>
        FullWeek = Monday | Tuesday | Wednesday | Thursday | Friday | Saturday | Sunday,

        /// <summary>
        /// Monday, Tuesday, Wednesday, Thursday and Friday.
        /// </summary>
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday,

        /// <summary>
        /// Saturday and Sunday.
        /// </summary>
        Weekend = Saturday | Sunday,
    }
}
