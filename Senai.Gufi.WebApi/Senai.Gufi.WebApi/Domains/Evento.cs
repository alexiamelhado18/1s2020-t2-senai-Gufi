using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class Evento
    {
        public Evento()
        {
            Presenca = new HashSet<Presenca>();
        }

        public int IdEvento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeEvento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataEvento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public bool? AcessoLivre { get; set; }

        public int? IdInstituicao { get; set; }

        public int? IdTipoEvento { get; set; }

        public Instituicao IdInstituicaoNavigation { get; set; }

        public TipoEvento IdTipoEventoNavigation { get; set; }

        public ICollection<Presenca> Presenca { get; set; }
    }
}
