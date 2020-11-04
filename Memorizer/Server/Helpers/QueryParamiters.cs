using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memorizer.Server.Helpers
{
    public class QueryParamiters
    {
        const int maxSize = 100;
        private int size = 50;
        private string sortOrder = "asc";

        public string Value { get; set; }
        public string SortBy { get; set; } = "Id";
        public int Page { get; set; } = 1;
        public int Size
        {
            get { return size; }
            set { size = Math.Min(maxSize, Math.Abs(value)); }
        }
        public string SortOrder 
        {
            get { return  sortOrder; }
            set 
            {
                if (value == "asc" || value == "desc" )
                {
                    sortOrder = value;
                }
            }
        }
    }       
}
