using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess.Maps
{
    public class TrimMap : EntityTypeConfiguration<Trim>
    {
        public TrimMap()
        {
            Property(t => t.EngineName)
                .IsRequired()
                .HasMaxLength(400);
            ToTable("Trim");
        }
    }
}
