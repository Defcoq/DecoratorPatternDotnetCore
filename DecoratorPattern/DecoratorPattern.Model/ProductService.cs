using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Model
{
    public class ProductService
    {
        private IProductRepository _productRepository; 
        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository; 
        }

        public IEnumerable<Product> GetAllProducts() 
        { 
            IEnumerable<Product> products = _productRepository.FindAll(); 
            products.ApplyTradeDiscount();
            products.ApplyCurrencyMultiplier(); 
            return products; 
        }
    }
}
