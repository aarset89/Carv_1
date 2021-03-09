
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ModelsClass.Data;

namespace ModelsClass.Data
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public string Surname { get; set; }
        [Required]
        [ForeignKey("IdentificationType")]
        public int IdType { get; set; }
        public IdentificationType IdentificationType{ get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(11)]
        public int IdNumber { get; set; }
        [Required]
        public string PassWord { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }


    }
}
