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
                string connectionString = @"Server=RADU\SQLEXPRESS;Database=testdb01;Trusted_Connection=True;";

                var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString).ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMap>())
                .BuildConfiguration();

                return configuration.BuildSessionFactory();
            }
        }


    }
}