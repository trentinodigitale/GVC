using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier
{
    public class Strings
    {
        /// <summary>
        /// Class for format string
        /// </summary>
        public class Formats
        {
            /// <summary>
            /// Format for Integer number
            /// </summary>
            public const string NUMBER_INTEGER = "#,##0";
            /// <summary>
            /// Format for Double number
            /// </summary>
            public const string NUMBER_DOUBLE = "#,##0.00";
            /// <summary>
            /// Format for Date
            /// </summary>
            public const string DATE = "dd/MM/yyyy";
            /// <summary>
            /// Format for Date (es. 25 novembre 2005)
            /// </summary>
            public const string DATE_LONG = "dd MMMM yyyy";
            /// <summary>
            /// Format for Time
            /// </summary>
            public const string TIME = "HH:mm:ss";
            /// <summary>
            /// Format for Time Short
            /// </summary>
            public const string TIME_SHORT = "HH:mm";
            /// <summary>
            /// Format for Date and Time
            /// </summary>
            public const string DATE_TIME = "dd/MM/yyyy HH:mm:ss";
            /// <summary>
            /// Format for Date and Time Short
            /// </summary>
            public const string DATE_SHORT_TIME = "dd/MM/yyyy HH:mm";
            /// <summary>
            /// Format for Date and Time Query
            /// </summary>
            public const string QUERY_DATE_TIME = "dd/MM/yyyy HH:mm:ss";
            /// <summary>
            /// Format for Date and Time File
            /// </summary>
            public const string FILE_DATE_TIME = "[yyyy-MM-dd][HH-mm-ss-fff]";
            /// <summary>
            /// Format for Year
            /// </summary>
            public const string YEAR = "YYYY";

            private Formats()
            {
            }
        }

        private Strings()
        {
        }
    }
}