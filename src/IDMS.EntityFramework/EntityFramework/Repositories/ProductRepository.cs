using Abp.EntityFramework;
using IDMS.Entities;
using IDMS.IRepositories;

namespace IDMS.EntityFramework.Repositories
{
    public class ProductRepository : IDMSRepositoryBase<Product>, IProductRepository
    {
        protected ProductRepository(IDbContextProvider<IDMSDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
