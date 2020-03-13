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
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        //Fazendo um encapsulamento, para que meu _TipoUsuarioRepository seja chamado somente nesse controller
        private ITipoUsuarioRepository _TipoUsuarioRepository { get; set; }

        //Faço uma referencia que o _TipoUsuarioRepository
        //pega todos os métodos de TipoUsuarioRepository e tornando público no TipoUsuarioController
        public TipoUsuarioController()
        {
            _TipoUsuarioRepository = new TipoUsuarioRepository();
        }


        /// <summary>
        /// Método onde lista todos os Tipos De Usuários cadastrados
        /// </summary>
        /// <returns>Retorna uma lista de Tipo Usuários</returns>
        [HttpGet]
        public IActionResult GetListarTU()
        {
            return Ok(_TipoUsuarioRepository.ListarTipoUsuario());
            
        }


        /// <summary>
        /// Método que busca Tipo Usuário pelo seu identificador
        /// </summary>
        /// <param name="id">Identificador que será buscado</param>
        /// <returns>Retorna um Tipo Usuário buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetBuscarPorIdTU(int id)
        {
            return Ok(_TipoUsuarioRepository.BuscarPorId(id));
        }


        /// <summary>
        /// Método que cadastrada um novo Tipo Usuário 
        /// </summary>
        /// <param name="tUCadastrado">Objeto que será cdastrado</param>
        /// <returns>Retorna um Novo Tipo Usuário</returns>
        [HttpPost]
        public IActionResult PostCadstrarTU(TipoUsuario tUCadastrado)
        {
            _TipoUsuarioRepository.Cadastrar(tUCadastrado);

            return StatusCode(201, tUCadastrado);
        }


        /// <summary>
        /// Método que atualiza as informações do Tipo Usuário, que alterei pelo objeto e Identifcador
        /// </summary>
        /// <param name="id">Identificador que é buscado para atualizar as informações</param>
        /// <param name="tipoUsuarioAtualizado">Objeto que será altereado</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public IActionResult PutAtualizarTU(int id, TipoUsuario tipoUsuarioAtualizado)
        {
            _TipoUsuarioRepository.AtualizarTipoUsuario(id, tipoUsuarioAtualizado);

            return StatusCode(205, tipoUsuarioAtualizado);
        }


        /// <summary>
        /// Méto que excluí um Tipo Usuário pelo seu identificador 
        /// </summary>
        /// <param name="id">Identificador que será buscado, e excluído.</param>
        /// <returns>Exclui um Tipo Usuário</returns>
        [HttpDelete("{id}")]
        public IActionResult DeletarTU(int id)
        {
            try
            {
                _TipoUsuarioRepository.DeletarTipoUsuario(id);

                return Ok("Tipo Usuário excluído");
            }
            catch (Exception)
            {

                return NotFound("Tipo Usuário não encontrado para excluí-lo");
            }
           
           
        }

    }
}