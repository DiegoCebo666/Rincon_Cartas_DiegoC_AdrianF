using System.Collections.Generic;

namespace RinconDL.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Seller { get; set; }
    }
}
