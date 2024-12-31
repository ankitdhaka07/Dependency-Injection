using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifetimeDI
{
    internal class SingletonService :Service, ISingletonService
    {
        public SingletonService() :base ("Singleton")
        {
        }
    }
}
