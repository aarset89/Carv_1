using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsClass.MethodParameters
{
    public class UserLoginIn
    {
        [Required]
        public string IdNumber { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
