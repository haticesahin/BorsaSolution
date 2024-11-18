using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Borsa.Client
{
    public class DependencyProvider //: IDependencyProvider
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
           // services.RegisterRestServiceClient<IBorsaClient>(nameof(BorsaClientOptions), configuration);
        }

        public int Oder => 999;
    }
}
