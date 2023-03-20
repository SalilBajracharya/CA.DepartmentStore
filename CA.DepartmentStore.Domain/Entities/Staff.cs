using CA.DepartmentStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Domain.Entities
{
    public class Staff : BaseDomainEntity
    {
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Role StaffRole { get; set; }
        
    }
}
