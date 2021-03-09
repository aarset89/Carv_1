using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelsClass.Data
{
    public class HandleSession
    {
        public int Id { get; set; }
        public DateTime LoggingTime { get; set; }
        public int userId { get; set; }
        public string Token { get; set; }
        public bool Status { get; set; }
    }
}
