using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsClass.Common
{
    public class BaseOut
    {
        public string Message { get; set; }
        public Result Result { get; set; }
    }

    public enum Result
    {
        success,
        badRequest,
        error,
        notFound,
        alreadyExist
    }
}
