using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTextWinApp
{
    /// <summary>
    /// Search result model
    /// </summary>
    internal class SearchResult
    {
        /// <summary>
        /// Number count
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// File Line No
        /// </summary>
        public int LineNo { get; set; }

        /// <summary>
        /// Line data
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// File Path
        /// </summary>
        public string FilePath { get; set; }
    }
}
