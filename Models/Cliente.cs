using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Astromaze.Models
{
    public class Cliente
    {
        public string id { get; set; }
        public string Especie { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Tel { get; set; }
        public string Idade { get; set; }
    }
}