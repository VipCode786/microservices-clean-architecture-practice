using Microsoft.Extensions.DependencyInjection;
using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using FluentValidation;
using eCommerce.Core.Validators;

namespace eCommerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddTransient<IUserServices, UserServices>();
            //fluent
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
            return services;
        }
    }
}
