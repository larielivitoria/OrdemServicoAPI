using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServico.Application.DTOs;
using OrdemServico.Application.Interfaces;
using OrdemServico.Domain.Entities;


namespace OrdemServico.Application.Services
{
    public class ServicoService : IServicoService
    {
        private readonly IServicoRepository _repository;
        public ServicoService(IServicoRepository repository)
        {
            _repository = repository;
        }

        public void Apagar(int id)
        {
            var existe = _repository.BuscaPorId(id);
            if (existe == null)
            {
                throw new Exception("Serviço não encontrado.");
            }
            _repository.Remover(id);
            _repository.Salvar();
            
        }

        public Servico Atualizar(int id, AtualizarServicoDTO atualizarServicoDTO)
        {
            var servicoExistente = _repository.BuscaPorId(id);
            if (servicoExistente == null)
            {
                throw new Exception("Serviço não encontrado.");
            }
            servicoExistente.QuantidadeCuboFreio = atualizarServicoDTO.QuantidadeCuboAtualizada;
            _repository.Salvar();
            return servicoExistente;
        }

        public Servico BuscaPorId(int id)
        {
            var existe = _repository.BuscaPorId(id);
            if (existe == null)
            {
                throw new Exception("Serviço não encontrado.");
            }
            return existe;
        }

        public Servico CriarServico(CriarServicoDTO criarServicoDTO)
        {
            var servico = new Servico(criarServicoDTO.Placa, criarServicoDTO.QuantidadeCuboFreio);
            _repository.Adicionar(servico);
            _repository.Salvar();
            return servico;
        }

        public List<Servico> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}