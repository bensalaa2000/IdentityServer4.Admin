using System;
using System.Reflection;
using Skoruba.IdentityServer4.Admin.EntityFramework.Configuration.Configuration;


using PostgreSQLMigrationAssembly = SkorubaIdentityServer4Admin.Admin.EntityFramework.PostgreSQL.Helpers.MigrationAssembly;

namespace SkorubaIdentityServer4Admin.Admin.Configuration.Database
{
    public static class MigrationAssemblyConfiguration
    {
        public static string GetMigrationAssemblyByProvider(DatabaseProviderConfiguration databaseProvider)
        {
            return databaseProvider.ProviderType switch
            {
                
                DatabaseProviderType.PostgreSQL => typeof(PostgreSQLMigrationAssembly).GetTypeInfo()
                    .Assembly.GetName()
                    .Name,
                
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}







