using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    public class Strings
    {

		#region Constructors (1) 

         private Strings()
        {
        }

		#endregion Constructors 

		#region Nested Classes (2) 


        public class Cut
        {

		#region Methods (1) 


		// Public Methods (1) 

            public static string Get(string s, int startIndex, int maxLength)
            {
                return Get(s, startIndex, maxLength, 0);
            }

            public static string Get(string s, int startIndex, int maxLength, int minLength)
            {
                if (String.IsNullOrEmpty(s))
                {
                    if (minLength <= 0)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return new string(' ', minLength);
                    }
                }
                else
                {
                    if (maxLength > s.Length)
                        return s;
                    return s.Substring(startIndex, maxLength);
                }
            }
		#endregion Methods 

        }
        /// <summary>
        /// Class for format string
        /// </summary>
        public class Formats
        {

		#region Fields (12) 

            /// <summary>
            /// Format for Date
            /// </summary>
            public const string DATE = "dd/MM/yyyy";
            /// <summary>
            /// Format for Date (es. 25 novembre 2005)
            /// </summary>
            public const string DATE_LONG = "dd MMMM yyyy";
            /// <summary>
            /// Format for Date and Time Short
            /// </summary>
            public const string DATE_SHORT_TIME = "dd/MM/yyyy HH:mm";
            /// <summary>
            /// Format for Date and Time
            /// </summary>
            public const string DATE_TIME = "dd/MM/yyyy HH:mm:ss";
            /// <summary>
            /// Format for Date and Time File
            /// </summary>
            public const string FILE_DATE_TIME = "[yyyy-MM-dd][HH-mm-ss-fff]";
            /// <summary>
            /// Format for Double number
            /// </summary>
            public const string NUMBER_DOUBLE = "#,##0.00";
            /// <summary>
            /// Format for Integer number
            /// </summary>
            public const string NUMBER_INTEGER = "#,##0";
            /// <summary>
            /// Format for Date and Time Query
            /// </summary>
            public const string QUERY_DATE_TIME = "dd/MM/yyyy HH:mm:ss";
            /// <summary>
            /// Format for Time
            /// </summary>
            public const string TIME = "HH:mm:ss";
            /// <summary>
            /// Format for Time Short
            /// </summary>
            public const string TIME_SHORT = "HH:mm";
            /// <summary>
            /// Format for Anno
            /// </summary>
            public const string YEAR = "YYYY";
            /// <summary>
            /// Format for Anno without the century
            /// </summary>
            public const string YEAR_SHORT = "YY";

		#endregion Fields 

		#region Constructors (1) 

            private Formats()
            {
            }

		#endregion Constructors 

        }
		#endregion Nested Classes 

    }
}
