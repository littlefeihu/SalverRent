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
    public class SalverPositionMap : EntityTypeConfiguration<SalverPosition>
    {
        public SalverPositionMap()
        {
            this.ToTable("SalverPosition");
            this.HasKey(t => t.F_Id);

            this.HasRequired(o => o.Salver)
                .WithMany(o => o.SalverPositions)
                .HasForeignKey(o => o.SalverId);

            this.Property(o => o.F_Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(o => o.F_Latitude).HasPrecision(10, 6);
            this.Property(o => o.F_Longitude).HasPrecision(10, 6);

        }
    }
}
