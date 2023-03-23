using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO : DTOBase
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}