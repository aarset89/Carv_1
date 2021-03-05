using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Common
{
    public abstract class BaseOut
    {
        public string Message { get; set; }
        public Result Result { get; set; }
    }

    public enum Result
    {
        success,
        error,
        notFound
    }
}
