using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class Phong_TrangThietBiConfigurations:IEntityTypeConfiguration<Phong_TrangThietBi>
    {
        public void Configure(EntityTypeBuilder<Phong_TrangThietBi> builder)
        {
            builder.ToTable("Phong_TrangThietBi");
            builder.HasKey(c => new { c.maPhong, c.maTrangThietBi });
            builder.HasOne(c => c.Phong).WithMany(c => c.Phong_TrangThietBi).HasForeignKey(c => c.maPhong);
            builder.HasOne(c => c.TrangThietBi).WithMany(c => c.Phong_TrangThietBi).HasForeignKey(c => c.maTrangThietBi);
        }
    }
}
