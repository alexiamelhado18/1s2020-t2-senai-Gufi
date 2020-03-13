using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using Senai.Gufi.WebApi.Manha.Repositories;

namespace Senai.Gufi.WebApi.Manha.Controllers
{   [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class EventoController : ControllerBase
    {

        private IEventoRepository _eventoRepository { get; set; }

        public EventoController()
        {
            _eventoRepository = new EventoRepository();
        }


      /// <summary>
      /// Método que lista Eventos
      /// </summary>
      /// <returns>Retorna lista de eventos</returns>
        [HttpGet]
        public IActionResult GetListar()
        {
            return Ok(_eventoRepository.ListarEvento());
        }


        /// <summary>
        /// Método que busca Evento pelo Identificador 
        /// </summary>
        /// <returns>Evento buscado pelo identificador</returns>
        [HttpGet("{id}")]
        public IActionResult GetBuscarPorId(int id)
        {
            return Ok(_eventoRepository.BuscarPorId(id));
        }


        /// <summary>
        /// Método que Cadastra um novo Evento
        /// </summary>
        /// <param name="eventoNovo">Objeto que será cadastrado</param>
        /// <returns>retorna um Evento cadastrado</returns>
        [HttpPost]
        public IActionResult PostCadastrarEvento(Evento eventoNovo)
        {
             _eventoRepository.Cadastrar(eventoNovo);

            return Created( "Evento criado", 201);
        }


        /// <summary>
        /// Método que atualiza Evento já cadastrado
        /// </summary>
        /// <param name="id">Identificador que será buscado, para atualizá-lo.</param>
        /// <param name="eventoNovo">Objeto que será atualizado</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult PutAtualizarEvento(int id, Evento eventoNovo)
        {

            try
            {                
                _eventoRepository.AtualizarEvento(id, eventoNovo);

                return StatusCode(205, "Evento atualizado ");
            }
            catch (Exception erro)
            {
                return NotFound(erro);
            }
        }

        /// <summary>
        /// Método que excluir um Evento
        /// </summary>
        /// <param name="id">Identificador que será buscado, e excluído.</param>
        /// <returns>Exclui um evento</returns>
        [HttpDelete("{id}")]
        public IActionResult DeletaEvento(int id)
        {
            try
            {
                _eventoRepository.DeletarEvento(id);
                
                return Ok("Evento deletado");

            }
            catch (Exception)
            {

                return NotFound("Evento não encontrado para excluí-lo");
            }

           
        }

    }
}