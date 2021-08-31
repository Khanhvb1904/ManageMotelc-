using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class TrangThietBi_ChiTietHopDongConfigurations : IEntityTypeConfiguration<ChiTietHopDong_TrangThietBi>
    {
        public void Configure(EntityTypeBuilder<ChiTietHopDong_TrangThietBi> builder)
        {
            builder.ToTable("ChiTietHopDong_TrangThietBi");
            builder.HasKey(c => new { c.maPhong, c.maHopDong, c.maTrangThietBi });
            builder.HasOne(c => c.Phong).WithMany(c => c.ChiTietHopDong_TrangThietBi).HasForeignKey(c => c.maPhong);
            builder.HasOne(c => c.TrangThietBi).WithMany(c => c.ChiTietHopDong_TrangThietBi).HasForeignKey(c => c.maTrangThietBi);
            builder.HasOne(c => c.HopDong).WithMany(c => c.ChiTietHopDong_TrangThietBi).HasForeignKey(c => c.maHopDong);
        }
    }
}
