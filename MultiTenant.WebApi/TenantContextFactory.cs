using System.Linq;
using Microsoft.AspNetCore.Http;

namespace MultiTenant.WebApi
{
    public class TenantContextFactory
    {
        public TenantContextFactory(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        private readonly IHttpContextAccessor contextAccessor;

        public TenantContext Create()
        {
            var tenant = contextAccessor.HttpContext.Items["tenant"] as string;
            return Contexts.ContextList.First(x => string.Equals(x.Name, tenant, System.StringComparison.InvariantCultureIgnoreCase));
        }
    }
}