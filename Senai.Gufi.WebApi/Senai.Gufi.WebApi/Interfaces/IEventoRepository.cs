using Senai.Gufi.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> ListarEvento();

        void Cadastrar(Evento eventoNovo);

        Evento BuscarPorId(int id);

        void AtualizarEvento(int id, Evento eventoAtualizado);

        void DeletarEvento(int id);

        List<Evento> ListarMeusEventos();

        void ConvidarUsuario(Evento usuarioConvidado);

        void InscricaoEvento(Evento EfetuarInscricao);

    }
}
