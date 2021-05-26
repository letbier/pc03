using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace busco.Models
{
    public class Cliente
    {
        public int Id {get;set;}
        public string NombreProducto {get;set;}
        public string Foto {get;set;}
        public string Descripcion {get;set;}
        public Decimal Precio {get;set;}
        public Decimal Celular {get;set;}
        public string Lugar {get;set;}
        public string NombreCliente {get;set;}

        public Categoria Categoria {get;set;}

        // EF Shadow property

        public int CategoriaId { get; set; }

    }
}