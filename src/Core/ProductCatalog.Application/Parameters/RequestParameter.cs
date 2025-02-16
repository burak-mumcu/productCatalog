using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Application.Parameters
{
    public class RequestParameter
    {
       public int PageNumber { get; set; }

        public RequestParameter(int pageNumber)
        {
            PageNumber = pageNumber;
        }
    }
}
