using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Application.Wrappers
{
    internal class BaseResponse
    {
        public int Id {  get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
