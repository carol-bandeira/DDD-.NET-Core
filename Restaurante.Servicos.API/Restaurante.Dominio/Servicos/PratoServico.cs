using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Servicos
{
    public class PratoServico : ServicoBase<Prato>, IPratoServico
    {
        public PratoServico(IPratoRepositorio repositorio)
            : base(repositorio) {

        }
    }
}
