using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVagas.Core.Model;

namespace AVagas.Core.Data.EF.Migrations
{
    public class VagaConfiguration : EntityTypeConfiguration<Vaga>
    {
        public VagaConfiguration()
        {
            HasKey(v => v.Id);
            Property(v => v.Descricao)
                .HasMaxLength(500)
                .IsUnicode(true)
                .IsRequired();
        }
    }
}
