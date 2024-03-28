using Microsoft.EntityFrameworkCore;
using ResourseMangerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourseMangerContext
{
    public class ResourseMangerContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ValuedProperty<User>> DeviceUser { get; set; }
        public DbSet<ValuedProperty<string>> StringProperties { get; set; }
        public DbSet<ValuedProperty<bool>> binaryProperties { get; set; }
        public DbSet<ValuedProperty<double>> DoubleProperties { get; set; }
        public ResourseMangerContext(DbContextOptions option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>().HasOne(device => device.Category).WithMany(Category => Category.Devices).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasOne(user => user.valuedProperty).WithOne(prop => prop.Value).HasForeignKey< ValuedProperty<User>>(user=>user.Id).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
