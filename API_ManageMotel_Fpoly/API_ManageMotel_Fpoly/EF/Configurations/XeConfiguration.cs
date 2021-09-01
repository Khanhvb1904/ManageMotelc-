using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class XeConfiguration: IEntityTypeConfiguration<Xe>
    {
        public void Configure(EntityTypeBuilder<Xe> builder)
        {
            builder.ToTable("Xe");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);
            builder.HasOne(c => c.LoaiXe).WithMany(c => c.Xe).HasForeignKey(c => c.maLoaiXe);
            builder.HasOne(c => c.KhachHang).WithMany(c => c.Xe).HasForeignKey(c => c.maKhachHang);
        }
    }
}
