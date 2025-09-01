using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OrdemServico.Domain.Entities
{
    public class Servico
    {
        private Servico()
        {
            
        }
        public Servico(string placa, int quantidadeCubo)
        {
            if (string.IsNullOrWhiteSpace(placa))
            {
                throw new ArgumentException("Placa inválida");
            }

            ValidarPlaca(placa);

            if (quantidadeCubo <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero");
            }

            PlacaCaminhao = placa;
            QuantidadeCuboFreio = quantidadeCubo;
            Data = DateTime.Now.Date;

            ValorTotal = QuantidadeCuboFreio * 70;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }

        public DateTime Data { get; private set; }

        [Required]
        public string PlacaCaminhao { get; private set; }

        [Required]
        public int QuantidadeCuboFreio { get; private set; }

        [Required]
        public decimal ValorTotal { get; private set; }

        

        private void ValidarPlaca(string placa)
        {
            string padrao = @"^[A-Z]{3}(\d{4}|\d[A-Z]\d{2})$";
            if (!Regex.IsMatch(placa, padrao))
            {
                throw new ArgumentException("Placa não segue o padrão válido");
            }
        }
    }
}