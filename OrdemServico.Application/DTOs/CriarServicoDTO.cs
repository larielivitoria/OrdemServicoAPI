using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdemServico.Application.DTOs
{
    public class CriarServicoDTO
    {
        public string Placa { get; set; }
        public int QuantidadeCuboFreio { get; set; }
    }
}