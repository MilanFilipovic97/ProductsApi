using AutoMapper;
using ProductsApiExtended.Dtos;

namespace ProductsApiExtended.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Models.Product, Dtos.ProductDto>();
        }
    }
}
