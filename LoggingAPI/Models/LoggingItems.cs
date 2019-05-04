using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoggingAPI.Models
{
    public class LoggingItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LogId { get; set; }
        public int AppId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public int Thread { get; set; }
        public string Class { get; set; }
        public string Message { get; set; }
    }
}
