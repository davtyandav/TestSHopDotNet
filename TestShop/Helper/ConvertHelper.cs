using TestShop.Dto;
using TestShop.Modules;

namespace TestShop.Helper
{
    public  class ConvertHelper
    {
        public static ProductDto ConvertToDto(Product product)
        {
            ProductDto productDto = new ProductDto();
            productDto.Model = ConvertToModelDto(product.Model);
            productDto.Category = product.Category.ToString();
            productDto.Price = product.Price;
            productDto.Discount = product.Discount;
            return productDto;
        }

        private static ModelDto ConvertToModelDto(Model model)
        {
            ModelDto modelDto = new ModelDto();
            modelDto.Name = model.Name;
            modelDto.Brand = ConvertToBrandDto(model.Brand);
            return modelDto;
        }

        private static BrandDto ConvertToBrandDto(Brand brand)
        {
            BrandDto brandDto = new BrandDto();
            brandDto.Name = brand.name;
            return brandDto;
        }
    }
}