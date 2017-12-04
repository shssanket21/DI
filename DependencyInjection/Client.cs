using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{ 
    public class Client
    {
        private Iservice _service;

        public Client(Iservice service)
        {
            _service = service;
        }

        public void Start()
        {
            Console.WriteLine("Client Called Service");
            _service.Serve();
        }
    }
}
