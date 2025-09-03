using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServico.Infrastructure.Data;
using OrdemServico.Application.Interfaces;
using OrdemServico.Domain.Entities;
using Azure.Core.Pipeline;

namespace OrdemServico.Infrastructure.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        public readonly OrdemServicoDbContext _contexto;
        public ServicoRepository(OrdemServicoDbContext context)
        {
            _contexto = context;
        }

        public Servico Adicionar(Servico servico)
        {
            _contexto.Servicos.Add(servico);
            return servico;
        }

        public Servico Atualizar(Servico servico)
        {
            _contexto.Servicos.Update(servico);
            return servico;
        }

        public Servico? BuscaPorId(int id)
        {
            var busca = _contexto.Servicos.Find(id);
            return busca;
        }

        public List<Servico> ListarTodos()
        {
            var lista = _contexto.Servicos.ToList();
            return lista;
        }

        public void Remover(int id)
        {
            var remover = _contexto.Servicos.Find(id);
            if (remover != null)
            {
                _contexto.Servicos.Remove(remover);
            };
        }

        public void Salvar()
        {
            _contexto.SaveChanges();
        }
    }
}