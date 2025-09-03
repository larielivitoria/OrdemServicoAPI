using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServico.Domain.Entities;

namespace OrdemServico.Application.Interfaces
{
    public interface IServicoRepository
    {
        List<Servico> ListarTodos();
        Servico BuscaPorId(int id);
        Servico Adicionar(Servico servico);
        Servico Atualizar(Servico servico);
        void Remover(int id);

        void Salvar();
    }
}