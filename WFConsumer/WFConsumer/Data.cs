using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFConsumer
{
    internal class Data
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(255)]
        public string message1 { get; set; }

        [StringLength(40)]
        public string name { get; set; }
    }
}
