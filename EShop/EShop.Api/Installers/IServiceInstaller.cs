using Microsoft.Extensions.DependencyInjection;

namespace EShop.Api.Installers
{
    public interface IServiceInstaller
    {
        void InstallService(IServiceCollection services);
    }
}