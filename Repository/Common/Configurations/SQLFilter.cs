using System;
using System.Collections;
using System.Text;

namespace it.dedagroup.GVC.Repository.Common.Configurations
{
    /// <summary>
    /// Creates a SQL Filter
    /// </summary>
    public class SQLFilter : IDisposable
    {

		#region Fields (1) 

        private SortedList entries = new SortedList();

		#endregion Fields 

		#region Constructors (2) 

        /// <summary>
        /// Default constructor
        /// </summary>
        public SQLFilter()
        {
        }

        /// <summary>
        /// Default destructor
        /// </summary>
        ~SQLFilter()
        {
            Dispose();
        }

		#endregion Constructors 

		#region Methods (3) 


		// Public Methods (3) 

        /// <summary>
        /// Adds a new pair to the filter collection
        /// </summary>
        /// <param name="key">key (eg. field name)</param>
        /// <param name="filter">SQL condition (e.g. ID=10)</param>
        public void Add(string key, string filter)
        {
            if (entries.ContainsKey(key.ToUpper()))
            {
                entries[key.ToUpper()] = entries[key.ToUpper()].ToString() + " OR " + filter;
            }
            else
            {
                entries.Add(key.ToUpper(), filter);
            }
        }

        /// <summary>
        /// Disposes the object
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Returns a string with all the filter expandend (eg. (ID=10) AND (STATE=1) )
        /// </summary>
        /// <returns>string of the filter</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (DictionaryEntry entry in entries)
            {
                if (sb.Length > 0)
                {
                    sb.Append(" AND ");
                }
                sb.Append(String.Format("({0})", entry.Value));
            }

            return sb.ToString();
        }


		#endregion Methods 

    }
}
