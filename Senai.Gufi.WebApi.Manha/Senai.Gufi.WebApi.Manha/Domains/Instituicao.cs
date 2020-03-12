using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Gufi.WebApi.Manha.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdInstituicao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cnpj { get; set; }

        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
