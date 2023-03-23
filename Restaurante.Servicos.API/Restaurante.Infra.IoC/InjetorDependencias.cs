using Restaurante.Aplicacao.Interfaces;
using Restaurante.Aplicacao.Servicos;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using Restaurante.Dominio.Servicos;
using Restaurante.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace Restaurante.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection) {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollection.AddScoped<IPratoApp, PratoApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServicoBase<>), typeof(ServicoBase<>));
            svcCollection.AddScoped<IPratoServico, PratoServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollection.AddScoped<IPratoRepositorio, PratoRepositorio>();
        }
    }
}
