using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Virtual.MVC.CPM.Domains
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddMediatR(typeof(GetCategoryQueryHandler).GetTypeInfo().Assembly);


            //services.AddMediatR(cf => cf.RegisterSerervicesFromAssembly(typeof(DependencyInjection).Assembly));

            return services;

        }
    }
}
