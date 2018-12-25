using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gs.Model
{
    [Table("lg")]
    public class lg
    {
        [Key]
        public int id { get; set; }

        public string ip { get; set; }

        public string gz { get; set; }

        public string bs { get; set; }
    }
}
