using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServico.Application.DTOs;
using OrdemServico.Application.Interfaces;
using OrdemServico.Domain.Entities;
using OrdemServico.Infrastructure.Data;

namespace OrdemServico.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly OrdemServicoDbContext _contexto;
        public ServicoService(OrdemServicoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Apagar(int id)
        {
            var servico = _contexto.Servicos.Find(id);
            if (servico != null)
            {
                _contexto.Servicos.Remove(servico);
                _contexto.SaveChanges();
            }
            
        }

        public Servico Atualizar(int id, AtualizarServicoDTO atualizarServicoDTO)
        {
            var servicoExistente = _contexto.Servicos.Find(id);
            servicoExistente.QuantidadeCuboFreio = atualizarServicoDTO.QuantidadeCuboAtualizada;
            _contexto.SaveChanges();
            return servicoExistente;
        }

        public Servico BuscaPorId(int id)
        {
            return _contexto.Servicos.Where(c => c.Id == id).FirstOrDefault();   
        }

        public Servico CriarServico(CriarServicoDTO criarServicoDTO)
        {
            var servico = new Servico(criarServicoDTO.Placa, criarServicoDTO.QuantidadeCuboFreio);
            _contexto.Servicos.Add(servico);
            _contexto.SaveChanges();
            return servico;
        }

        public List<Servico> ListarTodos()
        {
            return _contexto.Servicos.ToList();
        }
    }
}