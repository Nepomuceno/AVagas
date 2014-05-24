using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVagas.Core.Model;
using AVagas.Core.Data.EF.Migrations;

namespace AVagas.Core.Data.EF
{
    public class AVagasContextEF : DbContext, IAVagasContext
    {
        public AVagasContextEF(): base("VagaContext")
        {

        }
        public IDbSet<Vaga> VagasSet { get; set; }

        public IQueryable<Vaga> Vagas
        {
            get { return this.VagasSet; }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VagaConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }

}
