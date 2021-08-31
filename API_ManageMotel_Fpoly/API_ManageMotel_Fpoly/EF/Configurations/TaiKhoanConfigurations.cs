using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class DichVu_ChiTietHopDongConfigurations : IEntityTypeConfiguration<ChiTietHopDong_DichVu>
    {
        public void Configure(EntityTypeBuilder<ChiTietHopDong_DichVu> builder)
        {
            builder.ToTable("ChiTietHopDong_DichVu");
            builder.HasKey(c => new { c.maHopDong, c.maPhong, c.maDichVu });
            builder.HasOne(c => c.HopDong).WithMany(c => c.ChiTietHopDong_DichVu).HasForeignKey(c => c.maHopDong);
            builder.HasOne(c => c.Phong).WithMany(c => c.ChiTietHopDong_DichVu).HasForeignKey(c => c.maPhong);
            builder.HasOne(c => c.DichVu).WithMany(c => c.ChiTietHopDong_DichVu).HasForeignKey(c => c.maDichVu);
        }
    }
}
