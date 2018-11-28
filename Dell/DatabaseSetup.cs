using System;
using System.Configuration;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Dell
{
    public class DatabaseSetup
    {
        public static void CreateDatabase()
        {
            string connectionString = @"Server=RADU\SQLEXPRESS;Database=testdb01;Trusted_Connection=True;";

            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString).ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMap>())
                .BuildConfiguration();

            var exporter = new SchemaUpdate(configuration);
            exporter.Execute(true, true);
        }
    }
}