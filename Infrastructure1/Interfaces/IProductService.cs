using Infrastructure1.Models;

namespace Infrastructure1.Interfaces;

public interface IProductService
{
    bool CreateProduct(ProductCreateRequest product);

    IEnumerable<Product> GetAllProducts();

    Product GetProductsbyId(string id);
    Product GetProductByArticleNumber(string articleNumber);
    Product GetProductByProductName(string productName);

    bool UpdateProduct(string id, ProductUpdateRequest product);

    bool DeleteProduct(string id);

}
