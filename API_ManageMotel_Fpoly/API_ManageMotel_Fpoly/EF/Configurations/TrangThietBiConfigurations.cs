using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class TrangThietBiConfigurations : IEntityTypeConfiguration<TrangThietBi>
    {
        public void Configure(EntityTypeBuilder<TrangThietBi> builder)
        {
            builder.ToTable("TrangThietBi");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);
            builder.HasOne(c => c.LoaiThietBi).WithMany(c => c.TrangThietBi).HasForeignKey(c => c.maLoaiThietBi);
        }
    }
}
