using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.RepositoryContracts;
using System.Linq.Expressions;

namespace DataAccessLayer.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Product?> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(Guid productID)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductByCondition(Expression<Func<Product, bool>> conditionExpression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product?>> GetProductsByCondition(Expression<Func<Product, bool>> conditionExpression)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
