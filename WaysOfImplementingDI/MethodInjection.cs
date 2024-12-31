using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDIContainer
{
    internal class MethodInjection
    {
        IMailServiceDependency _mailService;
        
        
        //[Dependency]
        public void SendPremMessage( IMailServiceDependency mailServiceDependency)
        {
            _mailService = mailServiceDependency;
            _mailService.SendPremiumMail();
        }
    }
}
