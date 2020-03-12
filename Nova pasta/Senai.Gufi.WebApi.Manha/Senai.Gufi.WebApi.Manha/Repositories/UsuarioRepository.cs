using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarUsuario()
        {
            throw new NotImplementedException();
        }

        public Usuario Logar(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
