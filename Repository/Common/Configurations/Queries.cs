using System;
using System.Collections.Generic;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    /// <summary>
    /// Class for queries configurations
    /// </summary>
    public class Queries
    {

		#region Constructors (1) 

        private Queries()
        {
        }

		#endregion Constructors 

		#region Nested Classes (1) 


        /// <summary>
        /// Class for Oracle queries
        /// </summary>
        public class Oracle
        {

		#region Nested Classes (1) 


            /// <summary>
            /// Class for format queries
            /// </summary>
            public class Formats
            {

		#region Fields (11) 

                /// <summary>
                /// Returns the format OF A DATE
                /// </summary>
                public const string DATE_FORMATTER = "TRUNC(TO_DATE('{0}', 'dd/MM/yyyy'))";

                /// <summary>
                /// Returns the format FIELD BETWEEN DATE1 and DATE2
                /// </summary>
                public const string FIELD_BETWEEN_DATE = "(TRUNC({0}) >= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy')) AND TRUNC({0}) <= TRUNC(TO_DATE('{2}', 'dd/MM/yyyy')))";
                /// <summary>
                /// Returns the format FIELD = DATE
                /// </summary>
                public const string FIELD_EQUALS_DATE = "TRUNC({0}) = TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";
                /// <summary>
                /// Returns the format FIELD = DATE MONTH
                /// </summary>
                public const string FIELD_EQUALS_DATE_MONTH = "EXTRACT(MONTH FROM {0}) = {1}";
                /// <summary>
                /// Returns the format FIELD = DATE YEAR
                /// </summary>
                public const string FIELD_EQUALS_DATE_YEAR = "EXTRACT(YEAR FROM {0}) = {1}";
                /// <summary>
                /// Returns the format  FIELD = NUMBER
                /// </summary>
                public const string FIELD_EQUALS_NUMBER = "{0} = {1}";
                /// <summary>
                /// Returns the format FIELD equal or greater DATE
                /// </summary>
                public const string FIELD_EQUALS_OR_GREATER_DATE = "TRUNC({0}) >= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";
                /// <summary>
                /// Returns the format FIELD equal or less DATE
                /// </summary>
                public const string FIELD_EQUALS_OR_LESS_DATE = "TRUNC({0}) <= TRUNC(TO_DATE('{1}', 'dd/MM/yyyy'))";
                /// <summary>
                /// Returns the format FIELD = STRING
                /// </summary>
                public const string FIELD_EQUALS_STRING = "{0} = '{1}'";
                /// <summary>
                /// Returns the format LOWER(FIELD) LIKE LOWER('%VAL%')
                /// </summary>
                public const string FIELD_LIKE_VALUE = "LOWER({0}) LIKE LOWER('%{1}%')";
                /// <summary>
                /// Returns the format FIELD != NUMBER
                /// </summary>
                public const string FIELD_NOT_EQUALS_NUMBER = "{0} <> {1}";
                /// <summary>
                /// Returns the format order FIELD DESC
                /// </summary>
                public const string FIELD_ORDER_DESC = "{0} DESC";

		#endregion Fields 

		#region Constructors (1) 

                private Formats()
                {
                }

		#endregion Constructors 

            }
		#endregion Nested Classes 

        }
		#endregion Nested Classes 

    }
}
