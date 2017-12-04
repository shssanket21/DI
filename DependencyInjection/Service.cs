using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface Iservice
    {
        void Serve();
    }

    public interface Iservice2
    {
        void loadMsg(string msg);
    }

    public class Service : Iservice, Iservice2
    {
        readonly AllServices _AllService;

        public void Serve()
        {
            Console.WriteLine("Service : I will Serve you");
            Console.ReadKey();
        }

        public void loadMsg(string msg)
        {
            Console.WriteLine(msg);
        }

        public Service(AllServices serve)
        {
            _AllService = serve;
            _AllService.load("xyz");
        }
    }
}
