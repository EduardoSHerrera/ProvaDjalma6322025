using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public int Quantidade { get; set; }
        public string Marca { get; set; }
    }
}