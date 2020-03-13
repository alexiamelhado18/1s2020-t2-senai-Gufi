using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class Presenca
    {
        public int IdPresenca { get; set; }

        public int? IdUsuario { get; set; }

        public int? IdEvento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Situacao { get; set; }

        public Evento IdEventoNavigation { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
