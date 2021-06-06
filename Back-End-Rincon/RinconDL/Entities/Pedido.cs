using System.Collections.Generic;

namespace RinconDL.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int CartFId { get; set; }
        public string Date { get; set; }
        public string Estado { get; set; }
        public double TotalPrice { get; set; }
    }
}
