using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLifetimeDI
{
    internal class TransientService : Service,ITransientService
    {

        public TransientService(): base("Transient")
        {
        }
    }


}


