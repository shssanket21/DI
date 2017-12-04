using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace DependencyInjection
{
    public class AllClass : AllServices
    {
        readonly AllServices _AllService;

        //public AllClass(AllServices serve)
        //{
        //    _AllService = serve;
        //    _AllService.load("xyz");
        //}

        //public void Start()
        //{
        //    Console.WriteLine("Hello");
        //}

        public void load(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
