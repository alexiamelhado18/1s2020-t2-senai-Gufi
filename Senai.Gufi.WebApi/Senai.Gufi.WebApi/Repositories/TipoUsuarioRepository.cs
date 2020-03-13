using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public List<TipoUsuario> ListarTipoUsuario()
        {
            //Lista de Tipo Usuários
            return ctx.TipoUsuario.ToList();
        }

        public TipoUsuario BuscarPorId(int id)
        {

            //Busco um Tipo de Usário pelo seu identifcador e retorno 
            return ctx.TipoUsuario.FirstOrDefault(tu => tu.IdTipoUsuario == id);
        }

        public void AtualizarTipoUsuario(int id, TipoUsuario TipoUsuarioAtualizado)
        {
            //Busco o Usuário que quero atualizar pelo seu identificador
            TipoUsuario tipoUsuarioBuscado = ctx.TipoUsuario.Find(id);


            //Verifico se meu usuásio é válido, se for, atualiza.
            if (tipoUsuarioBuscado != null)
            {
                tipoUsuarioBuscado.TituloTipoUsuario = TipoUsuarioAtualizado.TituloTipoUsuario;

                ctx.Update(tipoUsuarioBuscado);

                ctx.SaveChanges();
            }


        }

        public void Cadastrar(TipoUsuario TipoUsuarioNovo)
        {
            //Adicionando um Novo Tipo de Usuário
            ctx.Add(TipoUsuarioNovo);

            //Salva no banco o Novo Usuário.
            ctx.SaveChanges();
        }

        public void DeletarTipoUsuario(int id)
        {
            //Buscando o Tipo de Usuário, e o removendo pelo seu identificador
            ctx.TipoUsuario.Remove(BuscarPorId(id));

            //Salvando no banco a alteração do Tipo Usuário exclído
            ctx.SaveChanges();
        }


    }
}
