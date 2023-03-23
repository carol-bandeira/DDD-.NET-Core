using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Entidades
{
    public class Prato : EntidadeBase
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
