using Castle.Windsor;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<Iservice2, Iservice>().ImplementedBy<Service>());
            container.Register(Component.For<AllServices>().ImplementedBy<AllClass>());
            container.Resolve<Iservice2>().loadMsg("Hello Load Msg");
            container.Resolve<Iservice>().Serve();

            //var container = new WindsorContainer();
            //container.Register(Component.For<AllServices>().ImplementedBy<AllClass>());
            //resolve.Start();
            Console.ReadKey();
        }
    }
}
