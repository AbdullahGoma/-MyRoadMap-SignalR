using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FirstDemo.Models
{
    public partial class ChatContext : DbContext
    {
        public ChatContext()
            : base("name=ChatContext")
        {
        }

        public virtual DbSet<Messages> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
