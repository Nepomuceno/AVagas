using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVagas.Core.Model;
using System.Data.Entity.Spatial;

namespace AVagas.Core.Data.Filters
{
    public static class VagasFilter
    {
        public static IQueryable<Vaga> Disponiveis(this IQueryable<Vaga> current)
        {
            return current.Where(v => v.Disponivel);
        }
        public static IQueryable<Vaga> Coberta(this IQueryable<Vaga> current)
        {
            return current.Where(v => !v.Coberto.HasValue || v.Coberto.Value);
        }
        public static IQueryable<Vaga> MaisBaratasQue(
            this IQueryable<Vaga> current,decimal value)
        {
            return current.Where(v => v.Valor < value);
        }

        public static IQueryable<Vaga> PertoDe(
            this IQueryable<Vaga> current, string latitude,string longitude)
        {
            var location =
                DbGeography.FromText
                (string.Format("POINT({0} {1})", latitude, longitude));
            return current.Where(v => v.Localizacao.Distance(location) < 10);
        }

        public static Vaga ComOCodigo(
            this IQueryable<Vaga> current, int codVaga)
        {
            return current.FirstOrDefault(v => v.Id == codVaga);
        }
    }
}
