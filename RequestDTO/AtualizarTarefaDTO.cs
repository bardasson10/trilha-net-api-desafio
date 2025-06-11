#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.RequestDTO
{
    public class AtualizarTarefaDTO
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Data { get; set; }
        public EnumStatusTarefa ? Status { get; set; }
    }
}