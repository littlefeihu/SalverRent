using NFine.Data.Entity.SalverManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Mapping.SalverManager
{
    public class RentOrderNoteMap : EntityTypeConfiguration<RentOrderNote>
    {
        public RentOrderNoteMap()
        {
            this.Property(o => o.F_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.ToTable("RentOrderNote");
            this.HasKey(t => t.F_Id);
            this.HasRequired(o => o.RentOrder)
               .WithMany(o => o.OrderNotes)
               .HasForeignKey(o => o.F_OrderId);
        }
    }
}
