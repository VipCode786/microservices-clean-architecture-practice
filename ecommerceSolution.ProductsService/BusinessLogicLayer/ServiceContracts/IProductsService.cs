using DataAccessLayer.Entities;
using BusinessLogicLayer.DTO;
using System.Linq.Expressions;

namespace BusinessLogicLayer.ServiceContracts
{
    internal interface IProductsService
    {
        Task<List<ProductResponse?>> GetProducts();
        Task<List<ProductResponse?>> GetProductsByCondition(Expression<Func<Product, bool>> conditionExpression);
        Task<ProductResponse?> GetProductByCondition(Expression<Func<Product, bool>> conditionExpression);
        Task<ProductResponse?> AddProduct(ProductAddRequest productAddRequest);
        Task<ProductResponse?> UpdateProduct(ProductUpdateRequest productUpdateRequest);
        Task<bool> DeleteProduct(Guid productID);


    }
}
