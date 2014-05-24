using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AVagas.Core.Data;
using AVagas.Core.Data.Filters;
using AVagas.Core.Model;

namespace AVagas.Controllers
{
    [RoutePrefix("api/Vagas")]
    public class VagasController : ApiController
    {
        private IAVagasContext _aVagasContext;
        
        public VagasController(IAVagasContext aVagasContext)
        {
            _aVagasContext = aVagasContext;
        }
        [Route("")]
        public IQueryable<Vaga> GetVagas()
        {
            return _aVagasContext.Vagas.Coberta().Disponiveis();
        }
        [Route("{codVaga}")]
        public Vaga GetVaga(int codVaga)
        {
            return _aVagasContext.Vagas.ComOCodigo(codVaga);
        }

        [Route("Perto/{latitude}/{longitude}")]
        public IQueryable<Vaga> GetVagasPerto(double longitude, double latitude)
        {
            return _aVagasContext.Vagas.PertoDe(latitude.ToString(),longitude.ToString());
        }
        [Route("Baratas")]
        public IQueryable<Vaga> GetVagasBaratas()
        {
            return _aVagasContext.Vagas.MaisBaratasQue(10);
        } 
    }
}
