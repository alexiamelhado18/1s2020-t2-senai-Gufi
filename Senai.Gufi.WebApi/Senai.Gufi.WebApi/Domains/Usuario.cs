using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Presenca = new HashSet<Presenca>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime? DataCadastro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Genero { get; set; }
        
        public int? IdTipousuario { get; set; }

        public TipoUsuario IdTipousuarioNavigation { get; set; }

        public ICollection<Presenca> Presenca { get; set; }
    }
}
