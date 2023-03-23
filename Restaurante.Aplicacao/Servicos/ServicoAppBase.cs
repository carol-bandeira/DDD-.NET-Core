using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        protected readonly IServicosBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServicoAppBase(IMapper iMapper, IServicosBase<TEntidade> servico)
            : base() {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade) {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id) {
            servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade) {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade) {
            return servico.Incluir(iMapper.Map<TEntidade>(entidade));
        }

        public TEntidadeDTO GetById(int id) {
            return iMapper.Map<TEntidadeDTO>(servico.GetById(id));
        }

        public IEnumerable<TEntidadeDTO> SelectAll() {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.GetAll());
        }
    }
}
