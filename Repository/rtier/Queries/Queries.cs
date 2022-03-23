using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.rtier
{
    /// <summary>
    /// Class for queries configurations
    /// </summary>
    public class Queries
    {
        /// <summary>
        /// Class for Oracle queries
        /// </summary>
        public class Oracle
        {
            /// <summary>
            /// Class for format queries
            /// </summary>
            public class Formats
            {
                /// <summary>
                /// Returns the format FIELD = DATE YEAR
                /// </summary>
                public const string FIELD_EQUALS_DATE_YEAR = "EXTRACT(YEAR FROM {0}) = {1}";

                /// <summary>
                /// Returns the format FIELD = DATE MONTH
                /// </summary>
                public const string FIELD_EQUALS_DATE_MONTH = "EXTRACT(MONTH FROM {0}) = {1}";

                /// <summary>
                /// Returns the format FIELD BETWEEN DATE1 and DATE2
                /// </summary>
                public const string FIELD_BETWEEN_DATE = "(TRUNC({0}) >= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy')) AND TRUNC({0}) <= TRUNC(TO_DATE('{2}', 'dd/MM/yyyy')))";

                /// <summary>
                /// Returns the format FIELD = DATE
                /// </summary>
                public const string FIELD_EQUALS_DATE = "TRUNC({0}) = TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";

                /// <summary>
                /// Returns the format FIELD equal or greater DATE
                /// </summary>
                public const string FIELD_EQUALS_OR_GREATER_DATE = "TRUNC({0}) >= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";

                /// <summary>
                /// Returns the format FIELD equal or less DATE
                /// </summary>
                public const string FIELD_EQUALS_OR_LESS_DATE = "TRUNC({0}) <= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";

                /// <summary>
                /// Returns the format  FIELD = NUMBER
                /// </summary>
                public const string FIELD_EQUALS_NUMBER = "{0} = {1}";

                /// <summary>
                /// Returns the format FIELD != NUMBER
                /// </summary>
                public const string FIELD_NOT_EQUALS_NUMBER = "{0} <> {1}";

                /// <summary>
                /// Returns the format FIELD = STRING
                /// </summary>
                public const string FIELD_EQUALS_STRING = "{0} = '{1}'";

                /// <summary>
                /// Returns the format FIELD = STRING
                /// </summary>
                public const string FIELD_EQUALS_STRING_LOWER = "LOWER({0}) = LOWER('{1}')";

                /// <summary>
                /// Returns the format order FIELD DESC
                /// </summary>
                public const string FIELD_ORDER_DESC = "{0} DESC";

                /// <summary>
                /// Returns the format LOWER(FIELD) LIKE LOWER('%VAL%')
                /// </summary>
                public const string FIELD_LIKE_VALUE = "LOWER({0}) LIKE LOWER('%{1}%')";

                /// <summary>
                /// Returns the format "field" >= 'A'
                /// </summary>
                public const string FIELD_GREATER_EQUAL_STRING_UPPER = "UPPER({0}) >= UPPER('{1}')";

                /// <summary>
                /// Returns the format "field" less then 'A'
                /// </summary>
                public const string FIELD_LOWER_STRING_UPPER = "UPPER({0}) < UPPER('{1}')";

                private Formats()
                {
                }
            }
        }

        private Queries()
        {
        }
    }
}