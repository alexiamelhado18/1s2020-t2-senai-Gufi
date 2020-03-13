using Senai.Gufi.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IInstitutoRepository
    {
        List<Instituicao> ListarInstituto();

        void Cadastrar(Instituicao InstituicaoNova);

        Instituicao BuscarPorId(int id);

        void AtualizarInstituicao(int id, Instituicao InstituicaoAtualizada);

        void DeletarInstituicao(int id);

        
    }
}
