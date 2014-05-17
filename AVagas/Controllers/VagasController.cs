using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AVagas.Core.Data;
using AVagas.Core.Model;

namespace AVagas.Controllers
{
    public class VagasController : ApiController
    {
        private IAVagasContext _aVagasContext;

        public VagasController()
        {
            _aVagasContext = new AVagasContext();
        }
        public IQueryable<Vaga> GetVagas()
        {
            return _aVagasContext.Vagas;
        } 
    }
}
