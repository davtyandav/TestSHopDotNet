using TestShop.Dto.Requset;
using TestShop.Dto.Response;
using TestShop.Moduls;

namespace TestShop.Profile
{
    public class ProductProfile : AutoMapper.Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponse>();
            CreateMap<Category, CategoryResponse>();
            CreateMap<Brand, BrandResponse>();
        }
    }
}