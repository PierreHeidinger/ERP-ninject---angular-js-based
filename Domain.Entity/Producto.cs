using NPoco;
using System;


namespace Domain.Entity
{
    [TableName("[PortalNegocios].[Producto]")]
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int idTipo { get; set; }
        public int IdMarca { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int idEstado { get; set; }
    }
}
