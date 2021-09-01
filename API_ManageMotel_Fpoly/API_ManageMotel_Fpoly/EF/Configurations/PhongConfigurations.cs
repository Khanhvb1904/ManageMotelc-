using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class PhongConfigurations:IEntityTypeConfiguration<Phong>
    {
        public void Configure(EntityTypeBuilder<Phong> builder)
        {
            builder.ToTable("Phong");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1, 1);
            builder.HasOne(c => c.LoaiPhong).WithMany(c => c.Phong).HasForeignKey(c => c.maLoaiPhong);
            builder.HasOne(c => c.NhaTro).WithMany(c => c.Phong).HasForeignKey(c => c.maNhaTro);
        }
    }
}
