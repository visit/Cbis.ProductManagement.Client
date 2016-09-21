using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cbis.ProductManagement.Client
{
    /// <summary>
    /// Helps a client to create data that should be sent and stored with the cbis.
    /// </summary>
    public class InformationDataFactory
    {
        /// <summary>
        /// Creates a name for the specified language.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">name was null</exception>
        public InformationData CreateName(string name, CultureInfo language)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            return new InformationDataString(language, 99, name);
        }

        public InformationData CreateIngress(string ingress, CultureInfo language)
        {
            if (string.IsNullOrEmpty(ingress))
            {
                throw new ArgumentNullException("ingress");
            }

            return new InformationDataString(language, 101, ingress);
        }

        public InformationData CreateDescription(string description, CultureInfo language)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException("description");
            }

            return new InformationDataString(language, 102, description);
        }

        public InformationData CreateDirections(string directions, CultureInfo language)
        {
            if(string.IsNullOrEmpty(directions))
            {
                throw new ArgumentNullException("directions");
            }

            return new InformationDataString(language, 103, directions);
        }

        public InformationData CreateWebsite(Uri location, CultureInfo language)
        {
            return new InformationDataString(language, 110, location.ToString());
        }

        public IEnumerable<InformationData> CreateAddress(string street1, string street2, string street3, string postalCode, string city, string countryCode)
        {
            bool somethingCreated = false;
            if (!string.IsNullOrEmpty(street1))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 117, street1);
                somethingCreated = true;
            }

            if(!string.IsNullOrEmpty(street2))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 118, street2);
                somethingCreated = true;
            }
            
            if(!string.IsNullOrEmpty(street3))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 119, street3);
                somethingCreated = true;
            }

            if (!string.IsNullOrEmpty(postalCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 120, postalCode);
                somethingCreated = true;
            }

            if(!string.IsNullOrEmpty(city))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 121, city);
                somethingCreated = true;
            }

            if (!string.IsNullOrEmpty(countryCode))
            {
                if (countryCode.Length != 2)
                {
                    throw new ArgumentOutOfRangeException("countryCode", countryCode, "Must contain 2 chars as country code or not be submitted.");
                }

                yield return new InformationDataString(CultureInfo.InvariantCulture, 122, countryCode);
                somethingCreated = true;
            }

            if (!somethingCreated)
            {
                throw new InvalidOperationException("None of the parameters generated any content.");
            }
        }

        public InformationData CreateNumberOfRooms(int noRooms)
        {
            if (noRooms <= 0)
            {
                throw new ArgumentOutOfRangeException("noRooms", noRooms, "Must be positive or not defined.");
            }

            return new InformationDataInt(CultureInfo.InvariantCulture, 130, noRooms);
        }

        public InformationData CreateNumberOfFloors(int floors)
        {
            if(floors < 0)
            {
                throw new ArgumentOutOfRangeException("floors", floors, "Must be positive or not defined.");
            }

            return new InformationDataInt(CultureInfo.InvariantCulture, 131, floors);
        }

        public InformationData CreateNumberOfConferenceRooms(int noRooms)
        {
            if(noRooms < 0)
            {
                throw new ArgumentOutOfRangeException("noRooms", noRooms, "Must be positive or not defined.");
            }

            return new InformationDataInt(CultureInfo.InvariantCulture, 132, noRooms);
        }

        public InformationData CreateNumberOfBars(int noBars)
        {
            if(noBars < 0)
            {
                throw new ArgumentOutOfRangeException("noBars", noBars, "Must be positive or not defined.");
            }

            return new InformationDataInt(CultureInfo.InvariantCulture, 133, noBars);
        }

        public InformationData CreateYearBuilt(int year)
        {
            return new InformationDataString(CultureInfo.InvariantCulture, 134, year.ToString(CultureInfo.InvariantCulture));
        }

        public InformationData CreateYearRenovated(int year)
        {
            return new InformationDataString(CultureInfo.InvariantCulture, 135, year.ToString(CultureInfo.InvariantCulture));
        }

        public IEnumerable<InformationData> CreatePhoneReception(string countryCode, string areaCode, string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException("number", "No number, not need for a phone number");
            }

            if (!string.IsNullOrEmpty(countryCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 144, countryCode);
            }

            if (!string.IsNullOrEmpty(areaCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 143, areaCode);
            }

            if (!string.IsNullOrEmpty(number))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 142, number);
            }
        }

        public IEnumerable<InformationData> CreatePhoneBooking(string countryCode, string areaCode, string number)
        {
            if(string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException("number", "No number, not need for a phone number");
            }

            if(!string.IsNullOrEmpty(countryCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 147, countryCode);
            }

            if(!string.IsNullOrEmpty(areaCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 146, areaCode);
            }

            if(!string.IsNullOrEmpty(number))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 145, number);
            }
        }

        /// <summary>
        /// Creates the phone.
        /// If used in conjunction with CreateMobile, the country code may conflict and an exception will be thrown
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">number;No number, not need for a phone number</exception>
        public IEnumerable<InformationData> CreatePhoneNumber(string countryCode, string number)
        {
            if(string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException("number", "No number, not need for a phone number");
            }

            if(!string.IsNullOrEmpty(countryCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 556, countryCode);
            }

            if(!string.IsNullOrEmpty(number))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 107, number);
            }
        }

        /// <summary>
        /// Creates an anonymous mobile number. 
        /// If used in conjunction with CreatePhone, the country code may conflict and an exception will be thrown
        /// </summary>
        /// <param name="countryCode">The country code.</param>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">number;No number, not need for a phone number</exception>
        public IEnumerable<InformationData> CreateMobileNumber(string countryCode, string number)
        {
            if(string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException("number", "No number, not need for a phone number");
            }

            if(!string.IsNullOrEmpty(countryCode))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 556, countryCode);
            }

            if(!string.IsNullOrEmpty(number))
            {
                yield return new InformationDataString(CultureInfo.InvariantCulture, 108, number);
            }
        }

        public InformationData CreateEmail(string email, CultureInfo language)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("email");
            }

            return new InformationDataString(language, 161, email);
        }

        public InformationData CreateCheckInTime(string checkInTime, CultureInfo language)
        {
            if (string.IsNullOrEmpty(checkInTime))
            {
                throw new ArgumentNullException("checkInTime");
            }

            return new InformationDataString(language, 148, checkInTime);
        }

        public InformationData CreateCheckOutTime(string checkOutTime, CultureInfo language)
        {
            if (string.IsNullOrEmpty(checkOutTime))
            {
                throw new ArgumentNullException("checkOutTime");
            }

            return new InformationDataString(language, 149, checkOutTime);
        }

        public InformationData CreateOpeningHours(string openingHours, CultureInfo language)
        {
            if (string.IsNullOrEmpty(openingHours))
            {
                throw new ArgumentNullException("openingHours");
            }

            return new InformationDataString(language, 104, openingHours);
        }

        /// <summary>
        /// Creates the representation of longitude and latitude.
        /// </summary>
        /// <param name="longitude">The longitude.</param>
        /// <param name="latitude">The latitude.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// latitude;Must be -90 &gt;= latitude &lt;= 90
        /// or
        /// longitude;Must be between -180 and 180
        /// </exception>
        /// <exception cref="System.ArgumentNullException">latitude;Not likely to be valid with two zero numbers</exception>
        public IEnumerable<InformationData> CreateLongLat(double longitude, double latitude)
        {
            // Latitude 113, longitude 114
            if (latitude < -90 || latitude > 90)
            {
                throw new ArgumentOutOfRangeException("latitude", latitude, "Must be -90 >= latitude <= 90");
            }

            if (longitude < -180 || longitude > 180)
            {
                throw new ArgumentOutOfRangeException("longitude", longitude, "Must be between -180 and 180");
            }

            yield return new InformationDataDouble(CultureInfo.InvariantCulture, 113, latitude);
            yield return new InformationDataDouble(CultureInfo.InvariantCulture, 114, longitude);
        }

        public InformationData CreateOtherInfo(string info, CultureInfo language)
        {
            if (string.IsNullOrEmpty(info))
            {
                throw new ArgumentNullException("info");
            }

            return new InformationDataString(language, 112, info);
        }

        public Occasion CreateOccasion(DateTime startDate, DateTime endDate, DayOfWeekMask validDays)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("endDate is set before startDate");
            }

            return new Occasion(startDate, endDate, validDays);
        }

        public Occasion CreateOccasion(DateTime startDate, DateTime endDate, TimeSpan startTime, TimeSpan endTime, DayOfWeekMask validDays)
        {
            if (startDate > endDate)
            {
                throw new ArgumentException("endDate is set before startDate");
            }

            return new Occasion(startDate, endDate, validDays, startTime, endTime);
        }

        public ImageData CreateImage(Uri location)
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            return new ImageData(location);
        }

        public InformationData CreateStarRating(int rating)
        {
            if (rating <= 0 || rating > 5)
            {
                throw new ArgumentOutOfRangeException("rating");
            }

            return new InformationDataInt(CultureInfo.InvariantCulture, 151, rating);
        }

        /// <summary>
        /// Gives an indication of the starting price for a product an some currency.
        /// </summary>
        /// <param name="priceFrom">The price from.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">priceFrom was less than zero.</exception>
        public InformationData CreatePriceFrom(double priceFrom)
        {
            if (priceFrom < 0)
            {
                throw new ArgumentOutOfRangeException("priceFrom");
            }

            return new InformationDataDouble(CultureInfo.InvariantCulture, 141, priceFrom);
        }

        /// <summary>
        /// Creates the season text.
        /// </summary>
        /// <param name="seasonText">The season text.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">seasonText was null or empty</exception>
        public InformationData CreateSeasonText(string seasonText, CultureInfo language)
        {
            if (string.IsNullOrEmpty(seasonText))
            {
                throw new ArgumentNullException("seasonText");
            }

            return new InformationDataString(language, 922, seasonText);
        }

        /// <summary>
        /// Creates the document link text1. A text that should be shown and redirect the browser to the <seealso cref="CreateDocumentLink1" /> configured value.
        /// </summary>
        /// <param name="textIndex">Index of the text 1..10</param>
        /// <param name="text">The text.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">text was null or empty</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">textIndex;Must be between 1..10</exception>
        public InformationData CreateDocumentLinkText(int textIndex, string text, CultureInfo language)
        {
            if(string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("text");
            }

            switch (textIndex)
            {
                case 1:
                    return new InformationDataString(language, 931, text);

                case 2:
                    return new InformationDataString(language, 933, text);

                case 3:
                    return new InformationDataString(language, 935, text);

                case 4:
                    return new InformationDataString(language, 937, text);

                case 5:
                    return new InformationDataString(language, 939, text);

                case 6:
                    return new InformationDataString(language, 941, text);

                case 7:
                    return new InformationDataString(language, 943, text);

                case 8:
                    return new InformationDataString(language, 945, text);

                case 9:
                    return new InformationDataString(language, 947, text);

                case 10:
                    return new InformationDataString(language, 949, text);

                default:
                    throw new ArgumentOutOfRangeException("textIndex", textIndex, "Must be between 1..10");
            }
        }

        /// <summary>
        /// Creates the document link. A link that should be targeted when clicking the text defined in <see cref="CreateDocumentLinkText"/> with the same index.
        /// </summary>
        /// <param name="linkIndex">Index of the link 1..10</param>
        /// <param name="link">The link.</param>
        /// <param name="language">The language.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">The link was null</exception>
        public InformationData CreateDocumentLink1(int linkIndex, Uri link, CultureInfo language)
        {
            if(link == null)
            {
                throw new ArgumentNullException("link");
            }

            switch (linkIndex)
            {
                case 1:
                    return new InformationDataString(language, 932, link.ToString());

                case 2:
                    return new InformationDataString(language, 934, link.ToString());

                case 3:
                    return new InformationDataString(language, 936, link.ToString());

                case 4:
                    return new InformationDataString(language, 938, link.ToString());

                case 5:
                    return new InformationDataString(language, 940, link.ToString());

                case 6:
                    return new InformationDataString(language, 942, link.ToString());

                case 7:
                    return new InformationDataString(language, 944, link.ToString());

                case 8:
                    return new InformationDataString(language, 946, link.ToString());

                case 9:
                    return new InformationDataString(language, 948, link.ToString());

                case 10:
                    return new InformationDataString(language, 950, link.ToString());

                default:
                    throw new ArgumentOutOfRangeException("linkIndex", linkIndex, "Must be between 1..10");
            }
        }
    }
}
