using Core.DTO.WereHouse;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contract.Repository
{
    public interface IRepositoryWereHouse
    {
        List<ProductsDTO> GetAllProducts();
    }
}
