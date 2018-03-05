using Core.DTO.WereHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Application.Contract
{
   
    [ServiceContract]
    public interface IServiceWereHouse
    {
        [OperationContract]
        List<ProductsDTO> GetAllProducts();
    }
}
