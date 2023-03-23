using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositórios;
using Restaurante.Dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicosBase<TEntidade> 
        where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio) 
        {
            this.repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade) {
            repositorio.Alterar(entidade);
        }

        public void Excluir(int id) {
            repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade) {
            repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade) {
            return repositorio.Incluir(entidade);
        }

        public TEntidade GetById(int id) {
            return repositorio.GetById(id);
        }

        public IEnumerable<TEntidade> GetAll() {
            return repositorio.GetAll();
        }
    }
}
