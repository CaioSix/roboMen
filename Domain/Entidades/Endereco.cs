using Domain.Enums;
using Domain.Enuns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Bairro { get; set; }
        public string? UF { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Aberto;
        
        public string? Robo { get; set; }
    }
}
