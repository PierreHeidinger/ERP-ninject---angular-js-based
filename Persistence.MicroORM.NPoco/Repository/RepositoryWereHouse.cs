using System;
using System.Collections.Generic;
using System.Linq;
using Core.DTO.WereHouse;
using Domain.Contract.Repository;
using Domain.Entity;
using NPoco.StoredProcedures;

namespace Persistence.MicroORM.NPoco.Repository
{
    public class RepositoryWereHouse : RepositoryBase<Producto>, IRepositoryWereHouse
    {
        private const string Schema = "PortalNegocios.";
        private const string getProducts = Schema + "ObtenerProductos";

        public List<ProductsDTO> GetAllProducts()
        {
            var products = useStoreProcedure<ProductsDTO>(getProducts).ToList();
            return products;
        }
    }
}
