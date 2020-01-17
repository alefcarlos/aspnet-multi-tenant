using System.Collections.Generic;

namespace MultiTenant.WebApi
{
    public static class Contexts
    {
        public static List<TenantContext> ContextList => new List<TenantContext>{
            new TenantContext{Name = "BRA", ConnectionString = "BRASIL_Connextion"},
            new TenantContext{Name = "ARG", ConnectionString = "ARG_Connextion"},
        };
    }
}