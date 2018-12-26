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

        [Column("ip")]
        public string ip { get; set; }

        [Column("gz")]
        public decimal gz { get; set; }

        [Column("bs")]
        public string bs { get; set; }
    }
}
