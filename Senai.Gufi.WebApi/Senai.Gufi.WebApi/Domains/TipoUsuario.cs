﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class TipoUsuario
    {
        public TipoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string TituloTipoUsuario { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
