using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dell
{
    public class Nhibernate
    {
        public static ISessionFactory sessionFactory
        {
            get
            {
                var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(DatabaseSetup.connectionString).ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMap>())
                .BuildConfiguration();

                return configuration.BuildSessionFactory();
            }
        }


    }
}