using Microsoft.Extensions.DependencyInjection;
using SOLIDPrinciplesDemo.Solution.Application;
using SOLIDPrinciplesDemo.Solution.Startup;

namespace SOLIDPrinciplesDemo.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = Services.ServiceProvider.GetService<IApplication>();
            app.Run();
        }
    }
}
