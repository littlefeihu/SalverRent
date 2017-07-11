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
    public class WarehouseMap : EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.ToTable("Warehouse");
            this.HasKey(t => t.F_Id);

          
            this.HasRequired(o => o.User)
                .WithMany(o => o.Warehouses)
                .HasForeignKey(o => o.F_UserId);

            this.Property(o => o.F_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(o => o.F_Latitude).HasPrecision(10, 6);
            this.Property(o => o.F_Longitude).HasPrecision(10, 6);

        }
    }
}
