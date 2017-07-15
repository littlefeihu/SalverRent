using NFine.Data.Entity.SalverManager;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.SalverManager
{
    public class RentOrderItemMap : EntityTypeConfiguration<RentOrderItem>
    {
        public RentOrderItemMap()
        {
            this.ToTable("OrderItem");

            this.Property(o => o.F_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasKey(t => t.F_Id);
            this.HasRequired(o => o.RentOrder)
          .WithMany(o => o.OrderItems)
          .HasForeignKey(o => o.F_OrderId);

            this.HasRequired(o => o.Salver).WithMany(o => o.RentOrderItems).HasForeignKey(o => o.F_SalverId);
        }
    }
}
