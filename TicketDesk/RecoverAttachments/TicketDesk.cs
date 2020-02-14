namespace RecoverAttachments
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TicketDesk : DbContext
    {
        public TicketDesk()
            : base("name=TicketDesk")
        {
        }

        public virtual DbSet<TicketAttachment> TicketAttachments { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .Property(e => e.Version)
                .IsFixedLength();
        }
    }
}
