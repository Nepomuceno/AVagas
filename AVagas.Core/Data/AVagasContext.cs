using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVagas.Core.Model;

namespace AVagas.Core.Data
{
    public class AVagasContext : IAVagasContext
    {
        public IQueryable<Model.Vaga> Vagas
        {
            get
            {
                return new List<Model.Vaga>()
                {
                    new Vaga()
                    {
                        Coberto = true,
                        Descricao = "Vaga coberta disponivel",
                        Endereco = "Rua Paracatu 1300 vaga 13",
                        Foto = "http://placehold.it/320x250",
                        Id = 1,
                        Disponivel = true,
                        Valor = 1.0m
                    },
                    new Vaga()
                    {
                        Coberto = false,
                        Descricao = "Vaga descoberta indisponivel",
                        Endereco = "Rua paraguassu 83 vaga 23",
                        Foto = "http://placehold.it/320x250",
                        Id = 1,
                        Disponivel = false,
                        Valor = 1.0m
                    }
                }.AsQueryable();
            }
        }
    }
}
