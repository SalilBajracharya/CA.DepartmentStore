using CA.DepartmentStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.DepartmentStore.Domain.Entities
{
    public class Product : BaseDomainEntity
    {
        public string Sku_id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
    }
}
