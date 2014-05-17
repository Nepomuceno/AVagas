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
                        Endereco = "Rua 1",
                        Foto = "",
                        Id = 1,
                        Disponivel = true,
                        Valor = 1.0m
                    },
                    new Vaga()
                    {
                        Coberto = false,
                        Descricao = "Vaga descoberta indisponivel",
                        Endereco = "Rua 1",
                        Foto = "",
                        Id = 1,
                        Disponivel = false,
                        Valor = 1.0m
                    }
                }.AsQueryable();
            }
        }
    }
}
