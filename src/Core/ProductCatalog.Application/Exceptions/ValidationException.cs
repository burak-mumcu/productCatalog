using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Application.Exceptions
{
    internal class ValidationException: Exception
    {
        public ValidationException(): this("validation error")
        {
            
        }

        public ValidationException(string message): base(message) 
        {
            
        }

        public ValidationException(Exception ex): this(ex.Message) 
        {
            
        }
    }
}
