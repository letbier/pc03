using System.Collections.Generic;

namespace busco.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nombre {get;set;}


        public ICollection<Cliente> Clientes { get; set; }
    }
}