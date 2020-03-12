using Senai.Gufi.WebApi.Manha.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List< TipoUsuario> ListarTipoUsuario();

        void Cadastrar(TipoUsuario TipoUsuarioNovo);

        TipoUsuario BuscarPorId(int id);

        void AtualizarTipoUsuario(int id, TipoUsuario TipoUsuarioAtualizado);

        void DeletarTipoUsuario(int id);
    }
}
