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

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Color { get; set; }
        [Required(ErrorMessage = "O campo modelo é obrigatório")]
        public string Modelo { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "O tamanho máximo do código é 4 caracteres")]
        public string Codigo { get; set; }
        [Range(10, 999, ErrorMessage = "O preço deverá ser entre 10 e 999.")]
        public float Preco { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }
        [StringLength(80, ErrorMessage = "O tamanho máximo daurl é 80 caracteres")]
        public string URLimagem { get; set; }
        public string Fabricado { get; set; }
    }
}