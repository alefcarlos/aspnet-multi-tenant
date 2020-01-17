namespace MultiTenant.WebApi
{
    public class TenantContext
    {
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public int AnotherProp { get; set; }
    }
}