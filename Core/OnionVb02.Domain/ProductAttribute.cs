using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Domain
{
    public class ProductAttribute : BaseEntity
    {
        public string Name { get; set; } 
        public virtual ICollection<ProductAttributeValue> AttributeValues { get; set; }
    }
}
