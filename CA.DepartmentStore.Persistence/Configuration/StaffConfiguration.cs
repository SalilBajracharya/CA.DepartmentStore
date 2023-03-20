using CA.DepartmentStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Persistence.Configuration
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 999,
                    Email = "",
                    Name = "Master",
                    Address = "",
                    Age = 99,
                    MobileNo = "9999999999",
                    Password = "Server@123"
                });

        }
    }
}
