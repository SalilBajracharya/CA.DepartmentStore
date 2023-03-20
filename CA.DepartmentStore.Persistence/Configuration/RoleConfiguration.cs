using CA.DepartmentStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Persistence.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = 1,
                    RoleType = "Store Manager"
                },
                new Role
                {
                    Id = 2,
                    RoleType = "Cashier"
                },
                new Role
                {
                    Id = 3,
                    RoleType = "Inventory Manager"
                });
        }
    }
}
