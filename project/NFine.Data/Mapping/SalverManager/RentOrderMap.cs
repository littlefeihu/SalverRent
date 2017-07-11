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
    public class RentOrderMap : EntityTypeConfiguration<RentOrder>
    {
        public RentOrderMap()
        {
            this.ToTable("Order");

            this.Property(o => o.F_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasKey(t => t.F_Id);
            this.HasRequired(o => o.User)
                 .WithMany(o => o.RentOrders)
                 .HasForeignKey(o => o.F_UserId);

        }
    }
}
