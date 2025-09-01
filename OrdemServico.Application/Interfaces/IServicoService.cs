using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrdemServico.Application.DTOs;
using OrdemServico.Domain.Entities;

namespace OrdemServico.Application.Interfaces
{
    public interface IServicoService
    {
        Servico CriarServico(CriarServicoDTO criarServicoDTO);
        List<Servico> ListarTodos();
        void Apagar(int id);
    }
}