using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositórios;
using Restaurante.Dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Servicos
{
    public class PratoServico : ServicoBase<Prato>, IPratoServicos
    {
        public PratoServico(IPratoRepositorio repositorio)
            : base(repositorio)
        {
            
        }
    }
}
