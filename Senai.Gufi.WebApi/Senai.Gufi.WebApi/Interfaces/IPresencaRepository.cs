﻿using Senai.Gufi.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Manha.Interfaces
{
    interface IPresencaRepository
    {
        List<Presenca> ListarPresenca();

        Presenca AprovarPresenca(int id, Presenca presencaAtualizada);
    }
}
