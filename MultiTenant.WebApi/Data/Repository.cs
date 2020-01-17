using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;

namespace MultiTenant.WebApi.Data
{
    public class Repository
    {
        public Repository(TenantContextFactory tenantContextFactory, ILogger<Repository> logger)
        {
            factory = tenantContextFactory;
            this.logger = logger;
        }
        private readonly TenantContextFactory factory;
        private readonly ILogger logger;

        public void Add()
        {
            var tenantContext = factory.Create();
            using (logger.BeginScope($"[tenant] {tenantContext.ConnectionString}"))
            {
                logger.LogInformation("chegou no add!!!");

                using var connection = new SqlConnection(tenantContext.ConnectionString);
                var data = connection.Query("SELECT * FROM TABLE");

                //
                //
            }
        }
    }
}