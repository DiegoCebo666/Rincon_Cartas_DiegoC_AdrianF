using System.Collections.Generic;

namespace RinconDL.Entities
{
    public class CartaCarrito
    {
        public int CartaCarritoId { get; set; }
        public int CarritoFId { get; set; }
        public int CartaVendedorFId { get; set; }
        public int FCantidad { get; set; }
    }
}
