namespace Memorizer.DAL
{
    class MemorizerDBContext : ApiAuthorizationDbContext<ApplicationUser>
    {

        public ApplicationDbContext(
    DbContextOptions options,
    IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

    }
}
