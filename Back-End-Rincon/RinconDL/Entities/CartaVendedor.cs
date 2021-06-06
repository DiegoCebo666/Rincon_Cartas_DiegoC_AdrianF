using System.Collections.Generic;

namespace RinconDL.Entities
{
    public class CartaVendedor
    {
        public int CartaVendedorId { get; set; }
        public int CartaFId { get; set; }
        public string CartaFName { get; set; }
        public string FImg { get; set; }
        public int VendedorFId { get; set; }
        public string Idioma { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}
