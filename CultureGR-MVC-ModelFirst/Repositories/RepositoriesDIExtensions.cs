namespace CultureGR_MVC_ModelFirst.Repositories
{
    public static class RepositoriesDIExtensions    //Adding own reporitory extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();  //adding service
            return services;
        }
    }
}
