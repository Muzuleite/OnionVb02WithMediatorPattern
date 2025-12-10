using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain;
using OnionVb02.Persistence.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Persistence.RepositoryConcretes
{
    public class ProductAttributeRepository(MyContext context) : BaseRepository<ProductAttribute>(context), IProductAttributeRepository
    {
    }
}
