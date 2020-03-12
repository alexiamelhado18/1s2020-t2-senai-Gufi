using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Logar(string email, string senha);

        List<Usuario> ListarUsuario();

        Usuario BuscarPorId(int id);

        void AtualizarUsuario(int id, Usuario usuarioAtualizado);

        void DeletarUsuario(int id);

    }
}
