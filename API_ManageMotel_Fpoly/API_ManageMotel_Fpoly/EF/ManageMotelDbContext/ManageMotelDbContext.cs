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

            #endregion
        }

        #region Add DbSet

        #endregion
    }
}
