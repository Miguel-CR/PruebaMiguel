using API.Data.Repository;

namespace API.Configuration
{
    public static class Injection
    {
        public static void AddInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
        }

    }
}
