using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Repositories
{
    public class PresencaRepository : IPresencaRepository
    {
        GufiContext ctx = new GufiContext();

        public Presenca AprovarPresenca(int id, Presenca presencaAtualizada)
        {
            throw new NotImplementedException();
        }

        public List<Presenca> ListarPresenca()
        {
            throw new NotImplementedException();
        }
    }
}
