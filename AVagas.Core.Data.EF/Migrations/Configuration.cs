namespace AVagas.Core.Data.EF.Migrations
{
    using AVagas.Core.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AVagas.Core.Data.EF.AVagasContextEF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }



        protected override void Seed(AVagas.Core.Data.EF.AVagasContextEF context)
        {
            context.VagasSet.AddOrUpdate(v => v.Descricao,
                new Vaga()
                {
                    Descricao = "Vaga 1",
                    Disponivel = true,
                    Coberto = true,
                    Valor = 3,
                    Endereco = "Rua paracatu 1300",
                    Localizacao = DbGeography.FromText("POINT(-122.296623 47.640405)"),
                    Foto = "http://placecage.com/200/300"
                },
                new Vaga()
                {
                    Descricao = "Vaga 2",
                    Disponivel = true,
                    Coberto = true,
                    Valor = 3,
                    Endereco = "Rua paraguassu 83",
                    Localizacao = DbGeography.FromText("POINT(-19.9189056 -43.95928)"),
                    Foto = "http://placecage.com/250/300"
                },
                new Vaga()
                {
                    Descricao = "Vaga 3",
                    Disponivel = false,
                    Coberto = true,
                    Valor = 3,
                    Endereco = "Rua paraguassu 83",
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Foto = "http://placecage.com/180/220"
                },
                new Vaga()
                {
                    Descricao = "Vaga 4",
                    Disponivel = true,
                    Coberto = false,
                    Valor = 3,
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Endereco = "Rua paraguassu 83"
                },
                new Vaga()
                {
                    Descricao = "Vaga 5",
                    Disponivel = true,
                    Coberto = true,
                    Valor = 3,
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Endereco = "Rua paraguassu 83",
                    Foto = "http://placecage.com/180/220"
                },
                new Vaga()
                {
                    Descricao = "Vaga 6",
                    Disponivel = true,
                    Coberto = false,
                    Valor = 3,
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Endereco = "Rua paraguassu 83",
                    Foto = "http://placecage.com/200/220"
                },
                new Vaga()
                {
                    Descricao = "Vaga 7",
                    Disponivel = true,
                    Coberto = true,
                    Valor = 3,
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Endereco = "Rua paraguassu 83",
                    Foto = "http://placecage.com/200/200"
                },
                new Vaga()
                {
                    Descricao = "Vaga 8",
                    Disponivel = false,
                    Coberto = false,
                    Valor = 3,
                    Localizacao = DbGeography.FromText("POINT(-19.9149056 -43.9539)"),
                    Endereco = "Rua paraguassu 83",
                    Foto = "http://placecage.com/200/210"
                }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate se-ed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
