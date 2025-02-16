﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Application.Wrappers
{
    internal class ServiceResponse<T>
    {
        public T Value { get; set; }

        public ServiceResponse(T value) 
        {
            Value = value;
        }

        public ServiceResponse()
        {
            
        }
    }
}
