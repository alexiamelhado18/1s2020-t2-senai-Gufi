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
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository _UsuarioRepository { get; set; }

        public UsuarioController()
        {
            _UsuarioRepository = new UsuarioRepository();
        }


        /// <summary>
        /// Método que lista todos meus Usuários cadastrados
        /// </summary>
        /// <returns>Retorna uma lista de Usuários</returns>
        [HttpGet]
        public IActionResult GetListarUsuarios()
        {
            return Ok(_UsuarioRepository.ListarUsuario());
        }


        /// <summary>
        /// Método que busca Usuário pelo seu identificador
        /// </summary>
        /// <param name="id">Identificador que será buscado</param>
        /// <returns>Retorna um Usuário pelo seu Identificador</returns>
        [HttpGet("{id}")]
        public IActionResult GetBuscarPorIdU(int id)
        {         
            return Ok(_UsuarioRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult PostCadastrarU(Usuario novousuario)
        {
            _UsuarioRepository.Cadastrar(novousuario);

            return StatusCode(201, novousuario);
        }
    }
}