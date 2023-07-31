using Bloc.SDK.Interfaces;
using Bloc.SDK.Services;
using Microsoft.Extensions.DependencyInjection;


namespace Bloc.SDK.Extensions
{
    public static class BlocServiceCollectionExtensions
    {
        public static IHttpClientBuilder AddBlocService(this IServiceCollection services, Action<BlocOptions>? setupAction = null)
        {
            var optionsBuilder = services.AddOptions<BlocOptions>();
            if(setupAction != null)
            {
                optionsBuilder.Configure(setupAction);
            }
            else
            {
                optionsBuilder.BindConfiguration(BlocOptions.SettingKey);
            }
            return services.AddHttpClient<IBlocService, BlocService>();
        }
        public static IHttpClientBuilder AddOpenAIService<TServiceInterface>(this IServiceCollection services, string name, Action<BlocOptions>? setupAction = null)
        where TServiceInterface : class, IBlocService
        {
            var optionsBuilder = services.AddOptions<BlocOptions>(name);
            if (setupAction != null)
            {
                optionsBuilder.Configure(setupAction);
            }
            else
            {
                optionsBuilder.BindConfiguration($"{BlocOptions.SettingKey}:{name}");
            }

            return services.AddHttpClient<TServiceInterface>();
        }

    }
}
