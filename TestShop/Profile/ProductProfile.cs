using TestShop.Dto.Response;
using TestShop.Moduls;

namespace TestShop.Profile
{
    public class ProductProfile : AutoMapper.Profile

    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>();
            CreateMap<Model, ModelResponse>();
            CreateMap<Brand, BrandResponse>();
        }
    }
}