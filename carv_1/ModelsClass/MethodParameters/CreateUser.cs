using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsClass.MethodParameters
{
    public class CreateUser
    {
        [Required]

        public string Name { get; set; }
        [Required]

        public string Surname { get; set; }
        [Required]
        public string IdType { get; set; }

        [Required]
        public string IdNumber { get; set; }
        [Required]

        public string PassWord { get; set; }
        [Required]

        public string Email { get; set; }
    }
}
