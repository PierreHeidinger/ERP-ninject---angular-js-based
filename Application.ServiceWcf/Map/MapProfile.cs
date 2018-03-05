using AutoMapper;

using Domain.Entity;
using Core.DTO.WereHouse;

namespace Application.ServiceWcf.Map
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //Producto <=> ProductsDTO
            CreateMap<Producto, ProductsDTO>();
            CreateMap<ProductsDTO, ProductsDTO>();
        }
    }
}