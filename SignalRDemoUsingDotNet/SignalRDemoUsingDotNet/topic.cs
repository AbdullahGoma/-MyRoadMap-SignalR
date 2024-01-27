namespace SignalRDemoUsingDotNet
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("topic")]
    public partial class topic
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
