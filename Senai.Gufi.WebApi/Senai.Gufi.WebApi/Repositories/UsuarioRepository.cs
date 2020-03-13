using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        GufiContext ctx = new GufiContext();

        public Usuario Logar(string email, string senha)
        {
            return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public List<Usuario> ListarUsuario()
        {
            return ctx.Usuario.ToList();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(u => u.IdUsuario == id);
        }


        public void Cadastrar(Usuario NovoUsuario)
        {
            DateTime GerarData = ter
            
            ctx.Add(NovoUsuario);

            ctx.SaveChanges();
        }

        public void AtualizarUsuario(int id, Usuario usuarioAtualizado)
        {

            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if (usuarioBuscado != null)
            {
                usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;
                usuarioBuscado.Email = usuarioAtualizado.Email;
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
                usuarioBuscado.Genero = usuarioAtualizado.Genero;
                usuarioBuscado.DataCadastro = usuarioBuscado.DataCadastro;
                usuarioBuscado.IdTipousuario = usuarioAtualizado.IdTipousuario;
                
                ctx.Update(usuarioBuscado);

                ctx.SaveChanges();
            }

        }

        public void DeletarUsuario(int id)
        {
            ctx.Usuario.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

    }
}
