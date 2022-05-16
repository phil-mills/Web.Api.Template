namespace Web.Startup.DependancyGroups
{
    using Microsoft.Extensions.DependencyInjection;
    
    public interface IDependancyGroup
    {
        void RegisterDependancies(IServiceCollection services);
    }
}