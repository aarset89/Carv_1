using ModelsClass.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsClass.MethodParameters
{
    public class UserLoginOut:BaseOut
    {
        public bool usrLoggued { get; set; }
    }
}
