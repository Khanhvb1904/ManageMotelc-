using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.Configurations
{
    public class LoaiPhongConfigurations : IEntityTypeConfiguration<LoaiPhong>
    {
        public void Configure(EntityTypeBuilder<LoaiPhong> builder)
        {
            builder.ToTable("LoaiPhong");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn(1,1);
        }
    }
}
