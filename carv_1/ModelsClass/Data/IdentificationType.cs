using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsClass.Data
{
    public class IdentificationType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string IdentificationName { get; set; }
        [Required]
        public string Code { get; set; }

    }
}
