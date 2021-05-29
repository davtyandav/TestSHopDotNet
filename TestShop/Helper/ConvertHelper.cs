using TestShop.Dto;
using TestShop.Dto.Response;
using TestShop.Moduls;

namespace TestShop.Helper
{
    public static class ConvertHelper
    {
        public static ProductResponse Toresponse(this Product product)
        {
            ProductResponse productResponse = new ProductResponse();
            productResponse.Model = product.Model.Toresponse();
            productResponse.Category = product.Category.ToString();
            productResponse.Price = product.Price;
            productResponse.Discount = product.Discount;
            return productResponse;
        }

        private static ModelResponse Toresponse(this Model model)
        {
            ModelResponse modelResponse = new ModelResponse();
            modelResponse.Name = model.Name;
            modelResponse.Brand = model.Brand.Toresponse();
            return modelResponse;
        }

        private static BrandResponse Toresponse(this Brand brand)
        {
            BrandResponse brandResponse = new BrandResponse();
            brandResponse.Name = brand.name;
            return brandResponse;
        }
    }
}