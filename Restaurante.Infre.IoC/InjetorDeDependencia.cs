using Restaurante.Aplicacao.Interfaces;
using Restaurante.Aplicacao.Servicos;
using Restaurante.Dominio.Interfaces.Repositórios;
using Restaurante.Dominio.Interfaces.Serviços;
using Restaurante.Dominio.Servicos;
using Restaurante.Infra.Data.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace Restaurante.Infra.IoC
{
    public class InjetorDeDependencia
    {
        public static void Registrar(IServiceCollection svcCollecton) {
            //Aplicação
            svcCollecton.AddScoped(typeof(IAppBase<,>), typeof(ServicoAppBase<,>));
            svcCollecton.AddScoped<IPratoApp, PratoApp>();

            //Domínio
            svcCollecton.AddScoped(typeof(IServicosBase<>), typeof(ServicoBase<>));
            svcCollecton.AddScoped<IPratoServicos, PratoServico>();

            //Repostório
            svcCollecton.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
            svcCollecton.AddScoped<IPratoRepositorio, PratoRepositorio>();
        }
    }
}
