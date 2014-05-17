using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVagas.Core.Model;

namespace AVagas.Core.Data
{
    public interface IAVagasContext
    {
        IQueryable<Vaga> Vagas { get; } 
    }
}
