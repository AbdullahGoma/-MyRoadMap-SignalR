namespace FirstDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Messages
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
