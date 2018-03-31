namespace Hex_Assignment.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HexModel : DbContext
    {
        public HexModel()
            : base("name=HexModel")
        {
        }

        public virtual DbSet<SOFTSKILL_AREA> SOFTSKILL_AREA { get; set; }
        public virtual DbSet<USER_MASTER> USER_MASTER { get; set; }
        public virtual DbSet<USER_SKILL_RATING> USER_SKILL_RATING { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SOFTSKILL_AREA>()
            //    .HasMany(e => e.USER_SKILL_RATING)
            //    .WithRequired(e => e.SOFTSKILL_AREA)
            //    .HasForeignKey(e => e.SKILLSETID)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<USER_MASTER>()
            //    .HasMany(e => e.USER_SKILL_RATING)
            //    .WithRequired(e => e.USER_MASTER)
            //    .HasForeignKey(e => e.USERID)
            //    .WillCascadeOnDelete(false);



        }
    }
}
