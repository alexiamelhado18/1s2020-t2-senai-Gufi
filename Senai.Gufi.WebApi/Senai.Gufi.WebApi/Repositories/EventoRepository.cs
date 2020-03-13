using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class EventoRepository : IEventoRepository
    {

        GufiContext ctx = new GufiContext();

        public List<Evento> ListarEvento()
        {
            return ctx.Evento.ToList();
        }


        public Evento BuscarPorId(int id)
        {
           return ctx.Evento.FirstOrDefault(e => e.IdEvento == id);
        }

        public void Cadastrar(Evento eventoNovo)
        {
            ctx.Evento.Add(eventoNovo);

            ctx.SaveChanges();
        }


        public void AtualizarEvento(int id, Evento eventoAtualizado)
        {
            Evento eventoBuscado = ctx.Evento.FirstOrDefault(e => e.IdEvento == id);

            if (eventoBuscado != null)
            {
                eventoBuscado.NomeEvento = eventoAtualizado.NomeEvento;
                eventoBuscado.DataEvento = eventoAtualizado.DataEvento;
                eventoBuscado.Descricao = eventoAtualizado.Descricao;
                eventoBuscado.AcessoLivre = eventoAtualizado.AcessoLivre;
                eventoBuscado.IdInstituicao = eventoAtualizado.IdInstituicao;
                eventoBuscado.IdTipoEvento = eventoAtualizado.IdTipoEvento;

                ctx.Evento.Update(eventoAtualizado);

                ctx.SaveChanges();
            }
            
            
        }

        public void DeletarEvento(int id)
        {
            ctx.Evento.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Evento> ListarMeusEventos()
        {
            throw new NotImplementedException();
        }


        public void InscricaoEvento(Evento EfetuarInscricao)
        {
            throw new NotImplementedException();
        }


        public void ConvidarUsuario(Evento usuarioConvidado)
        {
            throw new NotImplementedException();
        }


    }
}
