using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webgame.Models
{
    public class HighScore
    {
        public int ID { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Score { get; set; }
    }
}
