using Grand.Services.Queries.Models;
using System.Collections.Generic;

namespace Grand.Framework.Kendoui
{
    public class DataSourceRequest
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public List<SortModel> Sort { get; set; }

        public DataSourceRequest()
        {
            Page = 1;
            PageSize = 10;
        }
    }
}
