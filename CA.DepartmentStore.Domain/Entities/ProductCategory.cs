using CA.DepartmentStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Domain.Entities
{
    public class ProductCategory : BaseDomainEntity
    { 
        public string Category { get; set; }
    }
}
