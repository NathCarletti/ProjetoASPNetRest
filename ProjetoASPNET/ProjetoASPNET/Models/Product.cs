using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjetoASPNET.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Color { get; set; }
        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Codigo { get; set; }
        public float Preco { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }
        public string URLimagem { get; set; }
        public string Fabricado { get; set; }
    }
}