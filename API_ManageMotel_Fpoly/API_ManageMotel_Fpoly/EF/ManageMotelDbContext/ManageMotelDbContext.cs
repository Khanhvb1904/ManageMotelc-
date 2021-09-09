using API_ManageMotel_Fpoly.EF.Configurations;
using API_ManageMotel_Fpoly.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_ManageMotel_Fpoly.EF.ManageMotelDbContext
{
    public class ManageMotelDbContext : DbContext
    {
        public ManageMotelDbContext(DbContextOptions<ManageMotelDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Add Configurations
            modelBuilder.ApplyConfiguration(new DichVu_ChiTietHopDongConfigurations());
            modelBuilder.ApplyConfiguration(new DichVuConfigurations());
            modelBuilder.ApplyConfiguration(new HopDongConfigurations());
            modelBuilder.ApplyConfiguration(new KhanhHangConfigurations());
            modelBuilder.ApplyConfiguration(new LoaiDichVuConfigurations());
            modelBuilder.ApplyConfiguration(new LoaiPhongConfigurations());
            modelBuilder.ApplyConfiguration(new NhaTroConfigurations());
            modelBuilder.ApplyConfiguration(new PhongConfigurations());
            modelBuilder.ApplyConfiguration(new Phong_TrangThietBiConfigurations());
            modelBuilder.ApplyConfiguration(new TrangThietBi_ChiTietHopDongConfigurations());
            modelBuilder.ApplyConfiguration(new TrangThietBiConfigurations());
            modelBuilder.ApplyConfiguration(new TaiKhoanConfiguration());
            #endregion
        }

        #region Add DbSet
        public DbSet<ChiTietHopDong_DichVu> ChiTietHopDong_DichVu { get; set; }
        public DbSet<ChiTietHopDong_TrangThietBi> ChiTietHopDong_TrangThietBi { get; set; }
        public DbSet<DichVu> DichVu { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiDichVu> LoaiDichVu { get; set; }
        public DbSet<LoaiPhong> LoaiPhong { get; set; }
        public DbSet<LoaiThietBi> LoaiThietBi { get; set; }
        public DbSet<NhaTro> NhaTro { get; set; }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<Phong_TrangThietBi> Phong_TrangThietBi { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<TrangThietBi> TrangThietBi { get; set; }
        public DbSet<Xe> Xe { get; set; }
        public DbSet<LoaiXe> LoaiXe { get; set; }

        #endregion
    }
}
