using AutoMapper;
using ETicaret.Catalog.Dtos.CategoryDtos;
using ETicaret.Catalog.Dtos.ProductDetailDtos;
using ETicaret.Catalog.Dtos.ProductDtos;
using ETicaret.Catalog.Dtos.ProductImagesDtos;
using ETicaret.Catalog.Entities;

namespace ETicaret.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetByIdCategoryDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<ProductDetail, ResultProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, CreateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, UpdateProductDetailDto>().ReverseMap();
            CreateMap<ProductDetail, GetByIdProductDetailDto>().ReverseMap();

            CreateMap<ProductImages, ResultProductImageDto>().ReverseMap();
            CreateMap<ProductImages, CreateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, UpdateProductImageDto>().ReverseMap();
            CreateMap<ProductImages, GetByIdProductImageDto>().ReverseMap();

        }
    }
}
