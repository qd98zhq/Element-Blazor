﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Element
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}
