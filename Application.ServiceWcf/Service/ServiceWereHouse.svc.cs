using Application.Contract;
using Application.ServiceWcf.Map;
using Core.DTO.WereHouse;
using Domain.Contract.Repository;
using Domain.Entity;
using Infrastructure.Mapper;
using System.Collections.Generic;
using System.Linq;


namespace Application.ServiceWcf.Service
{

    public class ServiceWereHouse : IServiceWereHouse
    {
        private readonly IRepositoryWereHouse _repositoryProduct;
        private readonly Mapper _mapper;

        public ServiceWereHouse(Mapper mapper, IRepositoryWereHouse repositoryProduct)
        {
            this._mapper = mapper;
            this._repositoryProduct = repositoryProduct;
        }
        public List<ProductsDTO> GetAllProducts()
        {
            var products = _repositoryProduct.GetAllProducts().ToList();
            return products;
        }
    }
}
