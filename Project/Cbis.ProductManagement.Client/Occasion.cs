using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// 
    /// </summary>
    public class Occasion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Occasion"/> class.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="mask">The mask.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// startDate;Must not be equals to end date, that is a zero period and does not exist.
        /// or
        /// endDate;Must be after start date:  + startDate
        /// </exception>
        public Occasion(DateTime startDate, DateTime endDate, DayOfWeekMask mask)
        {
            if (startDate == endDate)
            {
                throw new ArgumentOutOfRangeException("startDate", startDate, "Must not be equals to end date, that is a zero period and does not exist.");
            }

            if (startDate > endDate)
            {
                throw new ArgumentOutOfRangeException("endDate", endDate, "Must be after start date: " + startDate);
            }

            StartDate = startDate;
            EndDate = endDate;
            Weekdays = mask;
            StartTime = null;
            EndTime = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Occasion"/> class.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="mask">The mask.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// startTime;Must be between greater or equal to zero and less than a day
        /// or
        /// endTime;Must be between greater or equal to zero and less than a day
        /// </exception>
        public Occasion(DateTime startDate, DateTime endDate, DayOfWeekMask mask, TimeSpan startTime,
            TimeSpan endTime) : this(startDate, endDate, mask)
        {
            if (TimeSpan.Zero > startTime || TimeSpan.FromHours(24) <= startTime)
            {
                throw new ArgumentOutOfRangeException("startTime", startTime, "Must be between greater or equal to zero and less than a day");
            }

            if(TimeSpan.Zero > endTime || TimeSpan.FromHours(24) <= endTime)
            {
                throw new ArgumentOutOfRangeException("endTime", endTime, "Must be between greater or equal to zero and less than a day");
            }

            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; private set; }
        
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// Gets or sets the weekdays.
        /// </summary>
        /// <value>
        /// The weekdays.
        /// </value>
        public DayOfWeekMask Weekdays { get; private set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public TimeSpan? StartTime { get; private set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public TimeSpan? EndTime { get; private set; }

        public Generated.OccasionInformationData Create()
        {
            return new Generated.OccasionInformationData()
            {
                StartDate = this.StartDate,
                EndDate = this.EndDate,
                StartTime = this.StartTime,
                EndTime = this.EndTime,
                ValidDays = (Generated.WeekDays)this.Weekdays
            };
        }
    }
}
