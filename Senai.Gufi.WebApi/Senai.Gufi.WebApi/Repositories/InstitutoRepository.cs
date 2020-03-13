using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class InstitutoRepository : IInstitutoRepository
    {
        GufiContext ctx = new GufiContext();

        public void AtualizarInstituicao(int id, Instituicao InstituicaoAtualizada)
        {
            throw new NotImplementedException();
        }

        public Instituicao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Instituicao InstituicaoNova)
        {
            throw new NotImplementedException();
        }

        public void DeletarInstituicao(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instituicao> ListarInstituto()
        {
            throw new NotImplementedException();
        }
    }
}
